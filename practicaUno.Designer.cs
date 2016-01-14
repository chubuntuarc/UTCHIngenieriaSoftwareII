namespace IngenieriaSoftwareII
{
    partial class practicaUno
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblIniciar = new System.Windows.Forms.Label();
            this.lblDetener = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblMenu);
            this.panel2.Controls.Add(this.lblIniciar);
            this.panel2.Controls.Add(this.lblDetener);
            this.panel2.Location = new System.Drawing.Point(-3, 359);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 74);
            this.panel2.TabIndex = 3;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMenu.Location = new System.Drawing.Point(15, 24);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(73, 29);
            this.lblMenu.TabIndex = 3;
            this.lblMenu.Text = "Menú";
            this.lblMenu.Click += new System.EventHandler(this.lblMenu_Click);
            // 
            // lblIniciar
            // 
            this.lblIniciar.AutoSize = true;
            this.lblIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIniciar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblIniciar.Location = new System.Drawing.Point(94, 24);
            this.lblIniciar.Name = "lblIniciar";
            this.lblIniciar.Size = new System.Drawing.Size(77, 29);
            this.lblIniciar.TabIndex = 2;
            this.lblIniciar.Text = "Iniciar";
            this.lblIniciar.Click += new System.EventHandler(this.lblIniciar_Click);
            // 
            // lblDetener
            // 
            this.lblDetener.AutoSize = true;
            this.lblDetener.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDetener.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetener.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDetener.Location = new System.Drawing.Point(177, 24);
            this.lblDetener.Name = "lblDetener";
            this.lblDetener.Size = new System.Drawing.Size(99, 29);
            this.lblDetener.TabIndex = 1;
            this.lblDetener.Text = "Detener";
            this.lblDetener.Click += new System.EventHandler(this.lblDetener_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(594, 32);
            this.trackBar1.Maximum = 12;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(405, 45);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(269, 113);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(231, 175);
            this.pbImagen.TabIndex = 5;
            this.pbImagen.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 800;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // practicaUno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(671, 488);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "practicaUno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Práctica Uno";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.practicaUno_FormClosed);
            this.Load += new System.EventHandler(this.practicaUno_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDetener;
        private System.Windows.Forms.Label lblIniciar;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Timer timer1;
    }
}