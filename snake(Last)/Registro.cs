using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snake_Last_
{
    public partial class Registro : Form
    {
        //Se llama al Form Snake
        Snake snakeForm;  
        

        public Registro(Snake snake)
        {
            InitializeComponent();
            snakeForm = snake;
            snakeForm.PuntajeActualizado += SnakeForm_PuntajeActualizado;
        }

     
        public void SnakeForm_PuntajeActualizado(object sender, EventArgs e)
        {
            // Actualiza la celda en el DataGridView con el nuevo puntaje
            int n = dataGridView1.Rows.Count - 1; // Obtén el índice de la última fila
            
        }

        


        public void btnRegistrar_Click(object sender, EventArgs e)
        {
            
            
            //Registrar Usuario y almacenar toda la info
            int n = dataGridView1.Rows.Add();

            dataGridView1.Rows[n].Cells[0].Value = txtRegistro.Text;//Registra el user
            dataGridView1.Rows[n].Cells[1].Value = snakeForm.Puntaje.ToString();//Registra el puntaje
            dataGridView1.Rows[n].Cells[2].Value = DateTime.Now.ToString(); //Registra la fecha

            //Limpiar el TextBox
            txtRegistro.Text = " ";
            //Se guarda la informacion en un archivo txt
            StreamWriter registrar = new StreamWriter(@"C:\Users\andre\source\repos\snake(Last)\snake(Last)\Archivo_Puntajes.txt", true);

            try
            {
                registrar.WriteLine("\n NickName:  "+ dataGridView1.Rows[n].Cells[0].Value);
                registrar.WriteLine("\n Puntaje: " + dataGridView1.Rows[n].Cells[1].Value);
                registrar.WriteLine("\n Fecha: " + DateTime.Now.ToString());
            }
            catch
            {
                MessageBox.Show("Error");
            }
            registrar.Close();



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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            this.Close();
            menu.ShowDialog();
            
        }
    }
}
