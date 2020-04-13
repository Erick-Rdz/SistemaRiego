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
    public partial class Inventario : Form
    {
        consultasSql cli = new consultasSql();
        conexion cn = new conexion();
        public Inventario()
        {
            InitializeComponent();
            //Inventario_Load();
        }

        public void limpiar()
        {
            Fert_txt.Text = "";
            Pest_txt.Text = "";
            Mat_txt.Text = "";
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            dgvInventario.DataSource = cli.MostrarInventario();

            foreach (DataGridViewColumn c in dgvInventario.Columns)
            {
                c.SortMode = DataGridViewColumnSortMode.NotSortable;
                c.Selected = false;
            }
            dgvInventario.SelectionMode = DataGridViewSelectionMode.FullRowSelect; 
            dgvInventario.ClearSelection();
            //dgvInventario.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            // int a = dgvInventario.Rows.Count;

        }
        private void dgvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e) 
        {
            try
            {
                Fert_txt.Text = dgvInventario.CurrentRow.Cells[1].Value.ToString();
                Pest_txt.Text = dgvInventario.CurrentRow.Cells[2].Value.ToString();
                Mat_txt.Text = dgvInventario.CurrentRow.Cells[3].Value.ToString();
            }
            catch
            {

            }
        }
        private void update_btn_Click(object sender, EventArgs e)  
        {

            SqlCommand cmd = new SqlCommand("UPDATE INVENTARIO SET Fertilizante = @Fertilizante, Pesticida = @Pesticida, Material = @Material", cn.LeerCadena());
            cmd.Parameters.AddWithValue("@Fertilizante", Fert_txt.Text);
            cmd.Parameters.AddWithValue("@Pesticida", Pest_txt.Text);
            cmd.Parameters.AddWithValue("@Material", Mat_txt.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            dgvInventario.DataSource = cli.MostrarHectareas();
            limpiar();
            MessageBox.Show("Registro actualizado");
        }
        private void buscar_txt_KeyUp(object sender, KeyEventArgs e)
        {
            SqlCommand cmd = cn.LeerCadena().CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM inventario WHERE Fertiliante LIKE ('" + buscar_txt.Text + "%')";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            dgvInventario.DataSource = dt;
        }


        private void Insert_btn_Click_1(object sender, EventArgs e)
        {
            if (cli.InsertarRegistroInventario(Fert_txt.Text, Pest_txt.Text, Mat_txt.Text))
            {
                dgvInventario.DataSource = cli.MostrarInventario();
                limpiar();
                MessageBox.Show("Registro insertado correctamente");
            }
            else
            {
                MessageBox.Show("Error al insertar registro");
            }
        }

        private void Delete_btn_Click_1(object sender, EventArgs e)
        {
            if (dgvInventario.CurrentRow.Cells != null)
            {
                if (MessageBox.Show("¿Desea Eliminar el registro?", "Confirmar Accion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    String id = dgvInventario.CurrentRow.Cells[0].Value.ToString();

                    MessageBox.Show("REGISTRO ELIMINADO");

                    cli.eliminarRegistroInventario(id);
                    dgvInventario.DataSource = cli.MostrarInventario();
                    limpiar();

                }
            }
        }

        private void Update_btn_Click_1(object sender, EventArgs e)
        {
            dgvInventario.DataSource = cli.MostrarInventario();
        }
    }

}
