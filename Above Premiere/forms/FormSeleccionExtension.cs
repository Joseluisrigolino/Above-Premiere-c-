using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Above_Premiere.forms
{
    public partial class FormSeleccionExtension : Form
    {
        public FormSeleccionExtension()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public string getExtension()
        {
            return this.extension_text.Text;
        }

        private void extension_mp4_Click(object sender, EventArgs e)
        {

        }

        public void close()
        {
            this.Hide();
        }

        private void extension_mpeg_Click(object sender, EventArgs e)
        {
            this.extension_text.Text = ".mpeg";

        }

        private void extension_mp4_Click_1(object sender, EventArgs e)
        {
            this.extension_text.Text = ".mp4";
        }

        private void extension_flv_Click(object sender, EventArgs e)
        {
            this.extension_text.Text = ".flv";
        }

        private void extension_avi_Click(object sender, EventArgs e)
        {
            this.extension_text.Text = ".avi";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String format = getExtension();
            /*
             Logica para cambiar de formato
             */

            this.close();
        }
    }
}
