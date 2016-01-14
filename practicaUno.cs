using System;
using System.Windows.Forms;

namespace IngenieriaSoftwareII
{
    public partial class practicaUno : Form
    {
        public practicaUno()
        {
            InitializeComponent();
        }
        //Label que cierra la aplicación
        private void lblMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Evento load de la forma
        private void practicaUno_Load(object sender, EventArgs e)
        {
            //Orientación de la barra
            trackBar1.Orientation = Orientation.Vertical;
            //Se genera un número aleatorio
            Random r = new Random();
            int numero = r.Next(1, 12);
            //Se asigna el número aleatorio al nombre del archivo para después asignarlo al picturebox
             pbImagen.Image = System.Drawing.Image.FromFile(Application.StartupPath + "..\\practicauno\\"+ numero.ToString()+".png");
        }
        //Evento que se ejecuta cuando la forma es cerrada
        private void practicaUno_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
        }
        //Label que comienza el conteo del timer
        private void lblIniciar_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        //Método que se ejecuta con cada iteración del timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Se generra un número aleatorio
            Random r = new Random();
            int numero = r.Next(1, 12);
            //Se asigna el número aleatorio al nombre del archivo para después asignarlo al picturebox
            pbImagen.Image = System.Drawing.Image.FromFile(Application.StartupPath + "..\\practicauno\\" + numero.ToString() + ".png");
        }
        //Metodo que detiene el timer
        private void lblDetener_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
        //Método que interactua cuando se cambia el valor al trackbar
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //Se cambia el tiempo de la iteración del timer en base al valor del trackbar
            timer1.Interval = trackBar1.Value * -100 + 1300;
        }
    }
}
