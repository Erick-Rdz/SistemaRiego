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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();

 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbl_ventas_Click(object sender, EventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {
            //this.Hide();

            Trabajadores tr = new Trabajadores();
            tr.Show();
            tr.AutoSize = false;
            tr.AutoSizeMode = AutoSizeMode.GrowAndShrink;

        }

        private void Label6_Click(object sender, EventArgs e)
        {
            Riegos r = new Riegos();
            r.Show();

        }

        private void Label7_Click(object sender, EventArgs e)
        {
            Hectareas h = new Hectareas();
            h.Show();
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            Inventario i = new Inventario();
            i.Show();
        }
    }
}
