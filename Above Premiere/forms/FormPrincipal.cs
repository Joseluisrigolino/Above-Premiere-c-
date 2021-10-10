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


        private void btn_change_format_Click(object sender, EventArgs e) //Boton para cambiar el formato del video
        {

            String path = textBox1.Text; //Url local del video
            String extension = txt_extension.Text; //Extension a la que se le va a cambiar

            Console.WriteLine(extension + " extension");
            if (!string.IsNullOrEmpty(extension)) //Verifica si no esta vacio ni es nulo el valor de extension
            {
                if (!string.IsNullOrEmpty(path)) //Verifica si no esta vacion ni es nulo la url local del video
                {
                    try
                    {

                        String folderPath = getFolderPath(); //Obtiene la url local de la carpeta donde se va a guardar el arhivo nuevo
                        ProcessStartInfo ps = new ProcessStartInfo();
                        ps.FileName = FFMPEG;
                        ps.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                        ps.Arguments = @"-i " + path + " " + folderPath + "\\output." + extension; //Comando donde se cambia la extension del archivo
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

        private void btn_change_resolution_Click(object sender, EventArgs e) //Boton para cambiar la resolucion del video
        {
            String path = textBox1.Text; //Url local del video
            String resolution = textBox2.Text; //Resolucion a la que se le va a cambiar
            if (!string.IsNullOrEmpty(resolution))
            {
                if (!string.IsNullOrEmpty(path)) //Verifica si no esta vacion ni es nulo la url local del video
                {
                    try
                    {

                        String folderPath = getFolderPath(); //Obtiene la url local de la carpeta donde se va a guardar el arhivo nuevo
                        ProcessStartInfo ps = new ProcessStartInfo();
                        ps.FileName = FFMPEG;
                        ps.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                        ps.Arguments = "-i " + path + " -vf scale=" + resolution + " " + folderPath + @"\archivo_modificado.mp4"; //Comando donde se cambia la resolucion del archivo
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

            String path = textBox1.Text; //Url local del video

            if (!string.IsNullOrEmpty(path)) //Verifica si no esta vacion ni es nulo la url local del video
            {
                try
                {

                    String forderPath = getFolderPath(); //Obtiene la url local de la carpeta donde se va a guardar el arhivo nuevo
                    Console.WriteLine(forderPath);
                    ProcessStartInfo ps = new ProcessStartInfo();
                    ps.FileName = FFMPEG;
                    ps.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    ps.Arguments = @"-i " + path + " " + forderPath + "\\output.mp3"; //Comando donde se cambia a mp3 el archivo
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
            String path = textBox1.Text; //Url local del video

            if (!string.IsNullOrEmpty(path)) //Verifica si no esta vacio ni es nulo la url local del video
            {
                try
                {
                    String forderPath = getFolderPath(); //Obtiene la url local de la carpeta donde se va a guardar el arhivo nuevo
                    Console.WriteLine(forderPath);
                    ProcessStartInfo ps = new ProcessStartInfo();
                    ps.FileName = FFMPEG;
                    ps.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    ps.Arguments = "-i " + path + " -an -vcodec copy " + forderPath + @"\output.mp4"; //Comando donde se mutea el archivo
                    Process.Start(ps); //Empieza el ingreso de comandos en la consola
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
            String path = textBox1.Text; //Url local del video
            String seconds = textBox3.Text; //Segundos donde se toma cada frame del archivo

            if (!string.IsNullOrEmpty(seconds)) //Verifica si no esta vacio ni es nulo los segundos dentro del form
            {
                if (!string.IsNullOrEmpty(path)) //Verifica si no esta vacio ni es nulo la url local del video
                {
                    try
                    {
                        MessageBox.Show("Seleccionar una carpeta en donde las imagenes se crearan, o cree una y seleccionela",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        String folderPath = getFolderPath();
                        ProcessStartInfo ps = new ProcessStartInfo();
                        ps.FileName = FFMPEG;
                        ps.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                        ps.Arguments = "-i " + path + " -vf fps=fps=" + seconds + " " + folderPath + @"\captura-%d.png"; //Comando donde se extraen las imagenes por cada X frames
                        Process.Start(ps); //Empieza el ingreso de comandos en la consola

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

        }

        private void btn_input_video_Click(object sender, EventArgs e) //Ingreso del video a formatear
        {
            using (var fd = new OpenFileDialog()) //Funcion para abrir archivos y seleccionar video
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


        private String getFolderPath() //Funcion para seleccionar donde guardar los archivos nuevos
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

        private void button7_Click(object sender, EventArgs e)
        {
            FormAyudaPrincipal fap = new FormAyudaPrincipal();
            fap.Show();
        }
    }




}
