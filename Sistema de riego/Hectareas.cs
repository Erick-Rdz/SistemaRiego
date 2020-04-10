using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_riego
{
    public partial class Hectareas : Form
    {
        consultasSql cli = new consultasSql();

        public Hectareas()
        {
            InitializeComponent();
        }

        private void Hectareas_Load(object sender, EventArgs e)
        {
            dgvHectareas.DataSource = cli.MostrarHectareas();
        }
    }
}
