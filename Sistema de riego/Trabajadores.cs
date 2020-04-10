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
            int a = dgvTrabajadores.Rows.Count;

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
