using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snake_Last_
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {


            //Mostrar Form de registro del usuario
            Snake sn = new Snake();
            this.Hide();
            sn.ShowDialog();
            this.Show();
            
        }

        private void btnPuntajes_Click(object sender, EventArgs e)
        {
            //Muestra formulario donde se guardan los datos del usuario, puntaje y fecha.
            Puntajes pnt = new Puntajes();
            this.Hide();
            pnt.ShowDialog();
            this.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Snake snc = new Snake();
            Puntajes pnt = new Puntajes();
            Registro rgc = new Registro(snc);
            this.Close();
            snc.Close();
            pnt.Close();
            rgc.Close();

        }
    }
}
