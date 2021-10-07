using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Above_Premiere.forms
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            this.CenterToScreen();

        }

        private string CONSOLA = "cmd.exe";


        private void btn_change_format_Click(object sender, EventArgs e)
        {
            FormSeleccionExtension fse = new FormSeleccionExtension();
            fse.Show();
        }

        private void btn_change_resolution_Click(object sender, EventArgs e)
        {
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = @"C:\Users\HP\Desktop\Davinci\Cuatrimestre 4\Plataformas de desarrollo\ffmpeg\bin\ffmpeg.exe";
            //ps.WindowStyle = ProcessWindowStyle.Hidden;
            ps.Arguments = @"-i C:\Users\HP\Desktop\prueba.mp4 C:\Users\HP\Desktop\prueba.avi";
            Process.Start(ps);
            //Process.Start("C:\\Windows\\System32\\cmd.exe", "/c");
            /*startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = CONSOLA;
            startInfo.Arguments = "/C ffmpeg -i input.avi -vf scale = 320: 240 output.avi";
            */
        }

        private void btn_download_mp3_Click(object sender, EventArgs e)
        {
            /*
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = CONSOLA;
            startInfo.Arguments = "ffmpeg -i input.mp3 output.mp3";
            */
        }

        private void btn_extract_audio_Click(object sender, EventArgs e)
        {
            /*
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = CONSOLA;
            startInfo.Arguments = "/C copy /b Image1.jpg + Archive.rar Image2.jpg";
            */
        }

        private void btn_extract_image_frame_Click(object sender, EventArgs e)
        {
            /*
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = CONSOLA;
            startInfo.Arguments = "/C copy /b Image1.jpg + Archive.rar Image2.jpg";
            */
        }

        private void btn_input_video_Click(object sender, EventArgs e)
        {
            using (var fd = new OpenFileDialog())
            {
                if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK && !string.IsNullOrWhiteSpace(fd.FileName))
                {

                    textBox1.Text = fd.FileName;
                }
            }
        }

        public String archivo_path()
        {
            return textBox1.Text;
        }




    }




}
