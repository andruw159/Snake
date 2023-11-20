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
    public partial class regPuntajtes : Form
    {
        public regPuntajtes()
        {
            InitializeComponent();
        }
        public void AgregarRegistro(string usuario, string puntaje, string fecha)
        {
            int n = dgvRegPuntaje.Rows.Add();
            dgvRegPuntaje.Rows[n].Cells[0].Value = usuario;
            dgvRegPuntaje.Rows[n].Cells[1].Value = puntaje;
            dgvRegPuntaje.Rows[n].Cells[2].Value = fecha;
        }
        private void dgvRegPuntaje_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
