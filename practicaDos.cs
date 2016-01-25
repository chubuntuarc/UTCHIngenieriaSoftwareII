using System;
using System.Windows.Forms;
using System.Drawing;

namespace IngenieriaSoftwareII
{
    public partial class practicaDos : Form
    {
        //Variables globales para la posicion de los objetos
        int a,b = 4;
        public practicaDos()
        {
            InitializeComponent();
            // El formulario recibirá cualquier evento antes que sus controles
            this.KeyPreview = true;
            // El formulario, siempre en primer plano
            this.TopLevel = true;
        }
        //Método que funciona cuando se presiona la tecla Escape.
        private void practicaDos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
                Form1 menu = new Form1();
                menu.Show();
            }
        }
        //Método que funciona durante el timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Movimiento de la primera estación espacial.
            practicaDos dos = new practicaDos();
            if (pbUno.Location.X <= 0 ) a = a * -1;
            if (pbUno.Location.Y <= 0 ) b = b * -1;
            pbUno.Location = new Point(pbUno.Location.X + a, pbUno.Location.Y + b);

        }

        private void practicaDos_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        //Método que funciona al hacer click sobre el panel
        private void layout_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 menu = new Form1();
            menu.Show();
        }
    }
}
