namespace IngenieriaSoftwareII
{
    partial class practicaDos
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbDos = new System.Windows.Forms.PictureBox();
            this.pbUno = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbDos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUno)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbDos
            // 
            this.pbDos.Image = global::IngenieriaSoftwareII.Properties.Resources._9;
            this.pbDos.Location = new System.Drawing.Point(213, 44);
            this.pbDos.Name = "pbDos";
            this.pbDos.Size = new System.Drawing.Size(128, 128);
            this.pbDos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbDos.TabIndex = 1;
            this.pbDos.TabStop = false;
            // 
            // pbUno
            // 
            this.pbUno.Image = global::IngenieriaSoftwareII.Properties.Resources._3;
            this.pbUno.Location = new System.Drawing.Point(46, 44);
            this.pbUno.Name = "pbUno";
            this.pbUno.Size = new System.Drawing.Size(128, 128);
            this.pbUno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbUno.TabIndex = 0;
            this.pbUno.TabStop = false;
            // 
            // practicaDos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(577, 419);
            this.Controls.Add(this.pbDos);
            this.Controls.Add(this.pbUno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "practicaDos";
            this.Opacity = 0.9D;
            this.Text = "practicaDos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.practicaDos_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.practicaDos_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pbDos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbDos;
        private System.Windows.Forms.PictureBox pbUno;
    }
}