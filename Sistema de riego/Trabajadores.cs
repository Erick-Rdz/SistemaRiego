using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_riego
{
    public partial class Trabajadores : Form
    {
        public Trabajadores()
        {
          
            InitializeComponent();
        }

        consultasSql cli = new consultasSql();


        private void Trabajadores_Load(object sender, EventArgs e)
        {

            dgvTrabajadores.DataSource = cli.MostrarTrabajadores();
            dgvTrabajadores.Columns["id"].Visible = false;
            dgvTrabajadores.RowHeadersVisible = false;
            foreach (DataGridViewColumn c in dgvTrabajadores.Columns)
            {
                c.SortMode = DataGridViewColumnSortMode.NotSortable;
                c.Selected = false;
            }

            dgvTrabajadores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTrabajadores.ClearSelection();
            dgvTrabajadores.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            int a = dgvTrabajadores.Rows.Count;

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            cli.insertarTrabajador();
            dgvTrabajadores.DataSource = cli.MostrarTrabajadores();
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (dgvTrabajadores.CurrentRow.Cells != null)
            {
                int a = dgvTrabajadores.CurrentRow.Index;

                String id = dgvTrabajadores.CurrentRow.Cells[0].Value.ToString();
                String nombre = dgvTrabajadores.CurrentRow.Cells[1].Value.ToString();
                String apellido = dgvTrabajadores.CurrentRow.Cells[2].Value.ToString();

                MessageBox.Show("PRUEBA" + id + " "+nombre+" "+ apellido);
                dgvTrabajadores.ClearSelection();
            }
            else
            {
                MessageBox.Show("NO SELECCIONADAS");

            }
           //int i = dgvTrabajadores.CurrentRow.Index;
        }
    }
}
