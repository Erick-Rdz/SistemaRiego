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
    public partial class Riegos : Form
    {
        consultasSql cli = new consultasSql();
        conexion cn = new conexion();
        public Riegos()
        {
            InitializeComponent();
        }
        public void limpiar()
        {
            Fecha_txt.Text = "";
            Hora_txt.Text = "";
            EmpCargo_txt.Text = "";
            Fert_txt.Text = "";
            NumHect_txt.Text = "";
        }

        private void Riegos_Load(object sender, EventArgs e)
        {
            dgvRiegos.DataSource = cli.MostrarRiegos();
            dgvRiegos.Columns["id"].Visible = false;   
            dgvRiegos.RowHeadersVisible = false;

            foreach (DataGridViewColumn c in dgvRiegos.Columns)
            {
                c.SortMode = DataGridViewColumnSortMode.NotSortable;
                c.Selected = false;
            }
            dgvRiegos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRiegos.ClearSelection();
        }
        private void dgvRiegos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Fecha_txt.Text = dgvRiegos.CurrentRow.Cells[1].Value.ToString();
                Hora_txt.Text = dgvRiegos.CurrentRow.Cells[2].Value.ToString();
                EmpCargo_txt.Text = dgvRiegos.CurrentRow.Cells[3].Value.ToString();
                Fert_txt.Text = dgvRiegos.CurrentRow.Cells[4].Value.ToString();
                NumHect_txt.Text = dgvRiegos.CurrentRow.Cells[5].Value.ToString();
            }
            catch
            {

            }
        }
        private void update_btn_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand(
                "UPDATE RIEGOS SET Fecha = @Fecha, Hora = @Hora, Empl_cargo = @Emplcargo, Fertilizante = @Fertilizante, Num_Hect = @NumeroHectareas ", cn.LeerCadena());
            cmd.Parameters.AddWithValue("@Fecha", Fecha_txt.Text);
            cmd.Parameters.AddWithValue("@Hora", Hora_txt.Text);
            cmd.Parameters.AddWithValue("@Emplcargo", EmpCargo_txt.Text);
            cmd.Parameters.AddWithValue("@Fertilizante", Fert_txt.Text);
            cmd.Parameters.AddWithValue("@NumerHctareas", NumHect_txt.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            dgvRiegos.DataSource = cli.MostrarHectareas();
            limpiar();
            MessageBox.Show("Registro actualizado");
        }
        private void buscar_txt_KeyUp(object sender, KeyEventArgs e)
        {
            SqlCommand cmd = cn.LeerCadena().CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Riego WHERE Hora LIKE ('" + buscar_txt.Text + "%')";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            dgvRiegos.DataSource = dt;
        }
        private void Delete_btn_Click(object sender, EventArgs e)  
        {

            if (dgvRiegos.CurrentRow.Cells != null)
            {
                if (MessageBox.Show("¿Desea Eliminar el registro?", "Confirmar Accion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    String id = dgvRiegos.CurrentRow.Cells[0].Value.ToString();  

                    MessageBox.Show("REGISTRO ELIMINADO");

                    cli.eliminarRegistroHectarea(id); 
                    dgvRiegos.DataSource = cli.MostrarHectareas(); 


                }
            }

        }

    }
}
