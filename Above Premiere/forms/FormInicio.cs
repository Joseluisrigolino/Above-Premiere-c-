using Above_Premiere.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            this.CenterToScreen(); //Centra el form en la pantalla
        }

        private void button3_Click(object sender, EventArgs e) //Boton para ingresar 
        {
            String user = this.txt_user.Text;
            String password = this.txt_pass.Text;
            String key = this.txt_key.Text;
            if (user != "root") //Chequea si el usuario ahora mismo hardcodeado es "root" si no manda error
            {
                MessageBox.Show("Usuario incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (password != "") //Chequea si el password ahora mismo hardcodeado es "" si no manda error
            {
                MessageBox.Show("Constraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (leerArchivos().Contains(key)) //Verifica si la key ingresada en el form existe dentro del txt keys
                {
                    FormPrincipal fp = new FormPrincipal();
                    fp.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Key inexistente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private String[] leerArchivos() //Devuelve un array con todos las llaves del "keys.txt"
        {
            string fileToRead = @"C:\Users\HP\source\repos\Above Premiere\Above Premiere\models\keys.txt";
            string[] lines = File.ReadAllLines(fileToRead);
            return lines;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*-------------------------------------------------------------------------
              Este boton te enviara a la pagina wb donde podras comprar la key
            ---------------------------------------------------------------------------*/
        }

        private void button2_Click(object sender, EventArgs e)
        {

            FormAyudaInicio fai = new FormAyudaInicio();
            fai.Show();
            /*----------------------------------------------------------------------------------
              Este boton mostrara una imagen donde vera que sirve cada boton y espacio del form
            ------------------------------------------------------------------------------------*/
        }
    }
}
