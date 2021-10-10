
namespace Above_Premiere.forms
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_extension = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.btn_input_video = new System.Windows.Forms.Button();
            this.btn_extract_image_frame = new System.Windows.Forms.Button();
            this.btn_extract_audio = new System.Windows.Forms.Button();
            this.btn_change_resolution = new System.Windows.Forms.Button();
            this.btn_download_mp3 = new System.Windows.Forms.Button();
            this.btn_change_format = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(194, 157);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 20);
            this.textBox1.TabIndex = 8;
            // 
            // txt_extension
            // 
            this.txt_extension.Location = new System.Drawing.Point(34, 43);
            this.txt_extension.Name = "txt_extension";
            this.txt_extension.Size = new System.Drawing.Size(54, 20);
            this.txt_extension.TabIndex = 9;
            this.txt_extension.Text = "avi";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.richTextBox1.ForeColor = System.Drawing.Color.Snow;
            this.richTextBox1.Location = new System.Drawing.Point(34, 260);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(273, 39);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "Recuerde que cada accion y cambio que usted haga\npuede llegar a demorar un buen t" +
    "iempo";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.4F);
            this.textBox2.Location = new System.Drawing.Point(94, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(61, 19);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "1920:1080";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(33, 214);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(20, 20);
            this.textBox3.TabIndex = 12;
            this.textBox3.Text = "1";
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Image = global::Above_Premiere.Properties.Resources.question_mark;
            this.button7.Location = new System.Drawing.Point(313, 260);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(41, 39);
            this.button7.TabIndex = 7;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // btn_input_video
            // 
            this.btn_input_video.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btn_input_video.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_input_video.Image = global::Above_Premiere.Properties.Resources.insert_video;
            this.btn_input_video.Location = new System.Drawing.Point(243, 69);
            this.btn_input_video.Name = "btn_input_video";
            this.btn_input_video.Size = new System.Drawing.Size(58, 57);
            this.btn_input_video.TabIndex = 6;
            this.btn_input_video.UseVisualStyleBackColor = false;
            this.btn_input_video.Click += new System.EventHandler(this.btn_input_video_Click);
            // 
            // btn_extract_image_frame
            // 
            this.btn_extract_image_frame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btn_extract_image_frame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_extract_image_frame.Image = global::Above_Premiere.Properties.Resources.image_frame;
            this.btn_extract_image_frame.Location = new System.Drawing.Point(59, 194);
            this.btn_extract_image_frame.Name = "btn_extract_image_frame";
            this.btn_extract_image_frame.Size = new System.Drawing.Size(55, 58);
            this.btn_extract_image_frame.TabIndex = 4;
            this.btn_extract_image_frame.UseVisualStyleBackColor = false;
            this.btn_extract_image_frame.Click += new System.EventHandler(this.btn_extract_image_frame_Click);
            // 
            // btn_extract_audio
            // 
            this.btn_extract_audio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btn_extract_audio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_extract_audio.Image = global::Above_Premiere.Properties.Resources.video_mute;
            this.btn_extract_audio.Location = new System.Drawing.Point(94, 132);
            this.btn_extract_audio.Name = "btn_extract_audio";
            this.btn_extract_audio.Size = new System.Drawing.Size(55, 56);
            this.btn_extract_audio.TabIndex = 3;
            this.btn_extract_audio.UseVisualStyleBackColor = false;
            this.btn_extract_audio.Click += new System.EventHandler(this.btn_extract_audio_Click);
            // 
            // btn_change_resolution
            // 
            this.btn_change_resolution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btn_change_resolution.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_change_resolution.Image = global::Above_Premiere.Properties.Resources.change_resolution;
            this.btn_change_resolution.Location = new System.Drawing.Point(94, 69);
            this.btn_change_resolution.Name = "btn_change_resolution";
            this.btn_change_resolution.Size = new System.Drawing.Size(55, 57);
            this.btn_change_resolution.TabIndex = 2;
            this.btn_change_resolution.UseVisualStyleBackColor = false;
            this.btn_change_resolution.Click += new System.EventHandler(this.btn_change_resolution_Click);
            // 
            // btn_download_mp3
            // 
            this.btn_download_mp3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btn_download_mp3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_download_mp3.Image = global::Above_Premiere.Properties.Resources.extract_mp3;
            this.btn_download_mp3.Location = new System.Drawing.Point(34, 132);
            this.btn_download_mp3.Name = "btn_download_mp3";
            this.btn_download_mp3.Size = new System.Drawing.Size(54, 56);
            this.btn_download_mp3.TabIndex = 1;
            this.btn_download_mp3.UseVisualStyleBackColor = false;
            this.btn_download_mp3.Click += new System.EventHandler(this.btn_download_mp3_Click);
            // 
            // btn_change_format
            // 
            this.btn_change_format.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.btn_change_format.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_change_format.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_change_format.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_change_format.Image = global::Above_Premiere.Properties.Resources.change_format;
            this.btn_change_format.Location = new System.Drawing.Point(34, 69);
            this.btn_change_format.Name = "btn_change_format";
            this.btn_change_format.Size = new System.Drawing.Size(54, 57);
            this.btn_change_format.TabIndex = 0;
            this.btn_change_format.UseVisualStyleBackColor = false;
            this.btn_change_format.Click += new System.EventHandler(this.btn_change_format_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(366, 311);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txt_extension);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btn_input_video);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_extract_image_frame);
            this.Controls.Add(this.btn_extract_audio);
            this.Controls.Add(this.btn_change_resolution);
            this.Controls.Add(this.btn_download_mp3);
            this.Controls.Add(this.btn_change_format);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_change_format;
        private System.Windows.Forms.Button btn_download_mp3;
        private System.Windows.Forms.Button btn_change_resolution;
        private System.Windows.Forms.Button btn_extract_audio;
        private System.Windows.Forms.Button btn_extract_image_frame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_input_video;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox txt_extension;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}