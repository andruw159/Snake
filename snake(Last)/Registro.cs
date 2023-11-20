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
    public partial class Registro : Form
    {
        //PRUEBA ACUMULAR PUNTOS---------
        Snake snakeForm;  
        //PRUEBA MANTENER----------------
        
        //-------------------------------




        public Registro(Snake snake)
        {
            InitializeComponent();
            snakeForm = snake;
            snakeForm.PuntajeActualizado += SnakeForm_PuntajeActualizado;
            //PRUEBA MANTENER---------
           
            //------------------------

        }

        //PRUEBA DE ACULAR PUNTOS -------------------
        public void SnakeForm_PuntajeActualizado(object sender, EventArgs e)
        {
            
            // Manejador de eventos que se ejecuta cuando se actualiza el puntaje
            // Actualiza la celda en el DataGridView con el nuevo puntaje
            int n = dataGridView1.Rows.Count - 1; // Obtén el índice de la última fila
            
        }

        //PRUEBA ENTRE DATAS----------

        
        //-------------------------------------


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            
            
            //Registrar Usuario y almacenar toda la info
            int n = dataGridView1.Rows.Add();

            dataGridView1.Rows[n].Cells[0].Value = txtRegistro.Text;//Registra el user
            dataGridView1.Rows[n].Cells[1].Value = snakeForm.Puntaje.ToString();//Registra el puntaje
            dataGridView1.Rows[n].Cells[2].Value = DateTime.Now.ToString(); //Registra la fecha

            //Limpiar el TextBox
            txtRegistro.Text = " ";

            //PRUEBA ENTRE DATAS------------
            

            //------------

            PlayAgain prg = new PlayAgain();
            prg.ShowDialog();

        }

        private void txtRegistro_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
