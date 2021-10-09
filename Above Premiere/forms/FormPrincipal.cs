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

        private string FFMPEG = @"C:\Users\HP\Desktop\Davinci\Cuatrimestre 4\Plataformas de desarrollo\ffmpeg\bin\ffmpeg.exe";


        private void btn_change_format_Click(object sender, EventArgs e)
        {


            String path = textBox1.Text;
            String output = txt_extension.Text;
            Console.WriteLine(output + " extension");
            if (!string.IsNullOrEmpty(output))
            {
                if (!string.IsNullOrEmpty(path))
                {
                    try
                    {

                        String folderPath = getFolderPath();
                        Console.WriteLine(output + " extension");
                        ProcessStartInfo ps = new ProcessStartInfo();
                        ps.FileName = FFMPEG;
                        ps.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                        ps.Arguments = @"-i " + path + " " + folderPath + "\\output." + output;
                        Process.Start(ps);

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Debes elegir un archivo al que convertir", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe escribir la extension con la que quiere cambiar el video entre 'mpeg','mp4','flv','avi'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_change_resolution_Click(object sender, EventArgs e)
        {
            String path = textBox1.Text;
            String output = textBox2.Text;
            if (!string.IsNullOrEmpty(output))
            {
                if (!string.IsNullOrEmpty(path))
                {
                    try
                    {

                        String folderPath = getFolderPath();
                        Console.WriteLine(output + " escala");
                        ProcessStartInfo ps = new ProcessStartInfo();
                        ps.FileName = FFMPEG;
                        ps.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                        ps.Arguments = "-i " + path + " -vf scale=" + output + " " + folderPath + @"\archivo_modificado.mp4";
                        Process.Start(ps);

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Debes elegir un archivo al que cambiar resolucion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe escribir aqui arriba a que resolucion quiere cambiarlo ej: 1920:1080, 1366:768", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_download_mp3_Click(object sender, EventArgs e)
        {

            String path = textBox1.Text;

            if (!string.IsNullOrEmpty(path))
            {
                try
                {

                    String forderPath = getFolderPath();
                    Console.WriteLine(forderPath);
                    ProcessStartInfo ps = new ProcessStartInfo();
                    ps.FileName = FFMPEG;
                    ps.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    ps.Arguments = @"-i " + path + " " + forderPath + "\\output.mp3";
                    Process.Start(ps);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debes elegir un archivo al que convertir", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btn_extract_audio_Click(object sender, EventArgs e)
        {
            String path = textBox1.Text;

            if (!string.IsNullOrEmpty(path))
            {
                try
                {
                    String forderPath = getFolderPath();
                    Console.WriteLine(forderPath);
                    ProcessStartInfo ps = new ProcessStartInfo();
                    ps.FileName = FFMPEG;
                    ps.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    ps.Arguments = "-i " + path + " -an -vcodec copy " + forderPath + @"\output.mp4";
                    Process.Start(ps);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debes elegir un archivo al que mutear", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_extract_image_frame_Click(object sender, EventArgs e)
        {
            String path = textBox1.Text;
            String seconds = textBox3.Text;
            if (!string.IsNullOrEmpty(seconds))
            {
                if (!string.IsNullOrEmpty(path))
                {
                    try
                    {
                        MessageBox.Show("Seleccionar una carpeta en donde las imagenes se crearan, o cree una y seleccionela",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        String folderPath = getFolderPath();
                        ProcessStartInfo ps = new ProcessStartInfo();
                        ps.FileName = FFMPEG;
                        ps.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                        ps.Arguments = "-i " + path + " -vf fps=fps=" + seconds + " " + folderPath + @"\captura-%d.png";
                        Process.Start(ps);

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Debes elegir un archivo al que cambiar resolucion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe escribir aqui a la izquierda cada cuanto segundos elegir un frame", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            //ffmpeg -i mivideo.webm -vf fps=fps=1 captura-%d.png
        }

        private void btn_input_video_Click(object sender, EventArgs e)
        {
            using (var fd = new OpenFileDialog())
            {
                if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK && !string.IsNullOrWhiteSpace(fd.FileName))
                {

                    textBox1.Text = fd.FileName;

                }
                else
                {
                    MessageBox.Show("Debe seleccionar algun archivo de video al que modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public String archivo_path()
        {
            return textBox1.Text;
        }

        private String getFolderPath()
        {
            String pathFolderName = "";
            FolderBrowserDialog ofd = new FolderBrowserDialog();
            DialogResult result = ofd.ShowDialog();

            if (result == DialogResult.OK)
            {
                pathFolderName = ofd.SelectedPath;

            }
            return pathFolderName;
        }

        private void btn_extension_Click(object sender, EventArgs e)
        {
            FormSeleccionExtension fse = new FormSeleccionExtension();
            fse.Show();
            String extension = fse.getExtension();
            this.txt_extension.Text = extension;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
    }




}
