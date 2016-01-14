using System;
using System.Windows.Forms;

namespace IngenieriaSoftwareII
{
    public partial class Form1 : Form
    {
        //Se construye las formas.
        practicaUno uno = new practicaUno();
        practicaDos dos = new practicaDos();
        public Form1()
        {
            InitializeComponent();
        }
        //Label que ejecuta la salida de la aplicación.
        private void lblSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Label que en base a su visibilidad muestra la forma de la práctica uno.
        private void label3_Click(object sender, EventArgs e)
        {
            uno.Show();
            this.Hide();
        }
        //Label que en base a su visibilidad muestra la forma de la práctica uno.
        private void label4_Click(object sender, EventArgs e)
        {
            dos.Show();
            this.Hide();
        }
        //Método que esconde y muestra elementos.
        public void houdini()
        {
            //Se esconden los label que contienen mi nombre y el del grupo.
            lblJesus.Visible = false;
            lblGrupo.Visible = false;
            //Se hacen visibles los label de nombre y descripción de la práctica.
            lblNombrePractica.Visible = true;
            lblDescripcion.Visible = true;
            //Se hace visible el panel que contiene el label de ejecución.
            pnlEjecutar.Visible = true;
        }
        //Método que funciona en base a la práctica uno.
        private void lblPractica1_Click(object sender, EventArgs e)
        {
            houdini();
            //Se asigna un fondo al picturebox principal en base a la práctica seleccionada.
            pbPractica.Image = System.Drawing.Image.FromFile(Application.StartupPath + "..\\img\\1.png");
            //Se asigna una descripción y un nombre a la práctica.
            lblDescripcion.Text = "Esta práctica consiste en generar\n de manera aleatoria doce imagenes,\n y mediante un \"TrackBar\"se controla\n la velocidad con que cambian.";
            lblNombrePractica.Text = "Práctica Uno";
            //Se hace visible la etiqueta que hará la función de mostrar la forma de la práctica uno.
            label3.Visible = true;
            label4.Visible = false;
        }
        //Método que funciona en base a la práctica dos.
        private void lblPractica2_Click(object sender, EventArgs e)
        {
            houdini();
            //Se asigna un fondo al picturebox principal en base a la práctica seleccionada.
            pbPractica.Image = System.Drawing.Image.FromFile(Application.StartupPath + "..\\img\\2.png");
            //Se asigna una descripción y un nombre a la práctica.
            lblDescripcion.Text = "Esta práctica consiste en generar\n un protector de pantalla,\n utilizando dos o más imagenes\n y haciendolas rotar..";
            lblNombrePractica.Text = "Práctica Dos";
            //Se hace visible la etiqueta que hará la función de mostrar la forma de la práctica dos.
            label4.Visible = true;
            label3.Visible = false;
        }
        //Evento load de la forma principal
        private void Form1_Load(object sender, EventArgs e)
        {
            //Se crean tooltips de apoyo para el usuario
            ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.label1, "Selecciona una de las opciones que se muestran debajo");
            ToolTip ToolTip2 = new System.Windows.Forms.ToolTip();
            ToolTip2.SetToolTip(this.lblSalir, "Salir de la aplicación");
            //Se crea la transparencia para el texto del menú principal en base a
            //la imagen principal.
            lblNombrePractica.Parent = pbPractica;
            lblJesus.Parent = pbPractica;
            lblGrupo.Parent = pbPractica;
            lblDescripcion.Parent = pbPractica;
        }
        //Método que cierra la aplicación cuando la forma es cerrada.
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
