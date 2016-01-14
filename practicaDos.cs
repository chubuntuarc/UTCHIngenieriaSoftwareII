using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IngenieriaSoftwareII
{
    public partial class practicaDos : Form
    {
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
            //Variables que cuentan las filas y columnas
            int filas = layout.RowCount;
            int columnas = layout.ColumnCount;
            //Se genera un número aleatorio, el cual se obtiene gracias al reloj del sistema.
            Random r = new Random(System.DateTime.Now.Millisecond);
            //Variable booleana que se usa para controlar la posicion de los elementos en el table layout.
            bool posicionado;
            //condicion que recorre las filas y columnas para "mover" los elementos.
            foreach (Control ctr in layout.Controls)
             {
                //Se establece la posicion como falsa para entrar en el siguiente ciclo
                posicionado = false;
                while (!posicionado)
             {
                    //Se general columnas y filas aleatorias.
                int posibleColumna = r.Next(columnas);
                int posibleFila = r.Next(filas);
                if (layout.GetControlFromPosition(posibleColumna, posibleFila) == null)
                  {
                        //Se posiciona un elemento en las columnas y filas generadas.
                     layout.SetCellPosition(ctr, new TableLayoutPanelCellPosition(posibleColumna, posibleFila));
                        //Se establece la posición como verdadera para mantener el elemento hasta la siguiente iteración.
                     posicionado = true;
                                     }
                     }
                 }
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
