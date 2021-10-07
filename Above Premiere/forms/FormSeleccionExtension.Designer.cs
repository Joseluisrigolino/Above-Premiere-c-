
namespace Above_Premiere.forms
{
    partial class FormSeleccionExtension
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
            this.label1 = new System.Windows.Forms.Label();
            this.extension_text = new System.Windows.Forms.TextBox();
            this.extension_mp4 = new System.Windows.Forms.Button();
            this.extension_flv = new System.Windows.Forms.Button();
            this.extension_avi = new System.Windows.Forms.Button();
            this.extension_mpeg = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bebas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Que formato desea elegir?, debe ser uno de estos 4\r\n\r\n\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // extension_text
            // 
            this.extension_text.Location = new System.Drawing.Point(13, 135);
            this.extension_text.Name = "extension_text";
            this.extension_text.Size = new System.Drawing.Size(60, 20);
            this.extension_text.TabIndex = 1;
            // 
            // extension_mp4
            // 
            this.extension_mp4.Image = global::Above_Premiere.Properties.Resources.extensions_mp4;
            this.extension_mp4.Location = new System.Drawing.Point(95, 54);
            this.extension_mp4.Name = "extension_mp4";
            this.extension_mp4.Size = new System.Drawing.Size(57, 61);
            this.extension_mp4.TabIndex = 3;
            this.extension_mp4.UseVisualStyleBackColor = true;
            this.extension_mp4.Click += new System.EventHandler(this.extension_mp4_Click_1);
            // 
            // extension_flv
            // 
            this.extension_flv.Image = global::Above_Premiere.Properties.Resources.extensions_flv;
            this.extension_flv.Location = new System.Drawing.Point(170, 54);
            this.extension_flv.Name = "extension_flv";
            this.extension_flv.Size = new System.Drawing.Size(57, 61);
            this.extension_flv.TabIndex = 4;
            this.extension_flv.UseVisualStyleBackColor = true;
            this.extension_flv.Click += new System.EventHandler(this.extension_flv_Click);
            // 
            // extension_avi
            // 
            this.extension_avi.Image = global::Above_Premiere.Properties.Resources.extensions_avi;
            this.extension_avi.Location = new System.Drawing.Point(243, 55);
            this.extension_avi.Name = "extension_avi";
            this.extension_avi.Size = new System.Drawing.Size(57, 61);
            this.extension_avi.TabIndex = 5;
            this.extension_avi.UseVisualStyleBackColor = true;
            this.extension_avi.Click += new System.EventHandler(this.extension_avi_Click);
            // 
            // extension_mpeg
            // 
            this.extension_mpeg.Image = global::Above_Premiere.Properties.Resources.extensions_mpeg;
            this.extension_mpeg.Location = new System.Drawing.Point(13, 54);
            this.extension_mpeg.Name = "extension_mpeg";
            this.extension_mpeg.Size = new System.Drawing.Size(60, 62);
            this.extension_mpeg.TabIndex = 2;
            this.extension_mpeg.UseVisualStyleBackColor = true;
            this.extension_mpeg.Click += new System.EventHandler(this.extension_mpeg_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(95, 132);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Ejecutar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // FormSeleccionExtension
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(312, 177);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.extension_avi);
            this.Controls.Add(this.extension_flv);
            this.Controls.Add(this.extension_mp4);
            this.Controls.Add(this.extension_mpeg);
            this.Controls.Add(this.extension_text);
            this.Controls.Add(this.label1);
            this.Name = "FormSeleccionExtension";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox extension_text;
        private System.Windows.Forms.Button extension_mpeg;
        private System.Windows.Forms.Button extension_mp4;
        private System.Windows.Forms.Button extension_flv;
        private System.Windows.Forms.Button extension_avi;
        private System.Windows.Forms.Button button5;
    }
}