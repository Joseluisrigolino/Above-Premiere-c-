using Above_Premiere.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Above_Premiere
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String user = this.txt_user.Text;
            String password = this.txt_pass.Text;
            String key = this.txt_key.Text;
            if (user != "root")
            {
                MessageBox.Show("Usuario incorrecto");

            }
            else if (password != "")
            {
                MessageBox.Show("Contraseña incorrecta");
            }
            else
            {
                FormPrincipal fp = new FormPrincipal();
                fp.Show();
                this.Hide();
            }


        }
    }
}
