using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_riego
{
    public partial class Hectareas : Form
    {
        consultasSql cli = new consultasSql();
        conexion cn = new conexion();

        public Hectareas()
        {
            InitializeComponent();
        }

        private void Hectareas_Load(object sender, EventArgs e)
        {
            dgvHectareas.DataSource = cli.MostrarHectareas();  //LLENAMOS DE DATOS EL DATA SOURCE
            dgvHectareas.Columns["Num_Hect"].Visible = false;   //OCULTAMOS LA COLUMNA ID PORQUE NO DEBEMOS MOSTRARLA
            dgvHectareas.RowHeadersVisible = false;             //OCULTAMOS EL INDICE DEL DATA SOURCE

            foreach (DataGridViewColumn c in dgvHectareas.Columns) //CICLO PARA NO PERMITIR QUE SE ORDENEN LAS COLUMNAS YA QUE LUEGO FALLA
            {
                c.SortMode = DataGridViewColumnSortMode.NotSortable;
                c.Selected = false;
            }

            dgvHectareas.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //METODO QUE HACE QUE SE SELECCIONE TODA LA FILA
            dgvHectareas.ClearSelection();                      //QUITAMOS LA SELECCION DE ALGUN REGISTRO

            //int a = dgvHectareas.Rows.Count;   //METODO PARA CONTAR LAS FILAS ACTUALES EN EL DATASOURCE
        }

        private void dgvHectareas_CellContentClick(object sender, DataGridViewCellEventArgs e) //METODO PARA CARGAR LOS DATOS EN LA PARTE IZQUIERDA
        {
            try
            {
                numhect_txt.Text = dgvHectareas.CurrentRow.Cells[0].Value.ToString();
                tipocult_txt.Text = dgvHectareas.CurrentRow.Cells[1].Value.ToString();
                cantarbo_txt.Text = dgvHectareas.CurrentRow.Cells[2].Value.ToString();
                cantcos_txt.Text = dgvHectareas.CurrentRow.Cells[3].Value.ToString();
                numhect_txt.Enabled = false;
            }
            catch
            {

            }
  

        }

        private void update_btn_Click(object sender, EventArgs e)  //METODO PARA ACTUALIZAR EN LA BASE DE DATOS LOS REGISTROS
        {

            SqlCommand cmd = new SqlCommand("UPDATE HECTAREAS SET Tipo_Cultivo = @tipocultivo, Cant_Arboles = @cantarboles, cant_Cosecha = @cantcosecha WHERE Num_Hect = @numhect", cn.LeerCadena());
            cmd.Parameters.AddWithValue("@tipocultivo", tipocult_txt.Text);
            cmd.Parameters.AddWithValue("@cantarboles", cantarbo_txt.Text);
            cmd.Parameters.AddWithValue("@cantcosecha", cantcos_txt.Text);
            cmd.Parameters.AddWithValue("@numhect", numhect_txt.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            dgvHectareas.DataSource = cli.MostrarHectareas();
            MessageBox.Show("Registro actualizado");
        }

        //METODO PARA FILTRAR ALGUN CULTIVO DESDE LA CAJA DE TEXTO "Buscar cultivo"
        private void buscar_txt_KeyUp(object sender, KeyEventArgs e)
        {
            SqlCommand cmd = cn.LeerCadena().CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Hectareas WHERE Tipo_cultivo LIKE ('" + buscar_txt.Text + "%')";//CONSULTAMOS LA BASE DE DATOS ESPECIFICAMENTE EL CAMPO "Tipo_cultivo" CON LA SIGUIENTE ESTRUCTURA
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            dgvHectareas.DataSource = dt;
        }

        private void Delete_btn_Click(object sender, EventArgs e)  //METODO PARA ELIMINAR REGISTRO
        {

            if (dgvHectareas.CurrentRow.Cells != null)
            {
                if (MessageBox.Show("¿Desea Eliminar el registro?", "Confirmar Accion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    String id = dgvHectareas.CurrentRow.Cells[0].Value.ToString(); //OBTENEMOS EL ID DE LA FILA SELECCIONADA 

                    MessageBox.Show("REGISTRO ELIMINADO");

                    cli.eliminarRegistroHectarea(id);  //CONSULTA QUE ELIMINA EL REGISTRO
                    dgvHectareas.DataSource = cli.MostrarHectareas(); //ACTUALIZO EL DATAGRIDVIEW


                }              
            }
               
        }
    }
}
