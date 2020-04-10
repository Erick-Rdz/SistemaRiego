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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            consultasSql consulta = new consultasSql();

            Boolean res = consulta.IniciarSesion(tbUsuario.Text, tbPassword.Text);

            if (res == false)
            {   
                Inicio i = new Inicio();
                i.Show();
                i.AutoSize = false;                
                i.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                i.MaximizeBox = false;              
                this.Hide();                
            }
            else
            {
                MessageBox.Show("ERROR AL INICIAR SESION");
            }         
            
        }
    }
}
