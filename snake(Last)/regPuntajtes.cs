﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
            

            // Utilizar un cuadro de texto no editable (TextBox) para mostrar los registros
            StreamReader leerRegistro = new StreamReader(@"C:\Users\andre\source\repos\snake(Last)\snake(Last)\Archivo_Puntajes.txt");
            string leer;

            try
            {
                leer = leerRegistro.ReadLine();
                while (leer != null)
                {
                    // Agregar la línea al cuadro de texto
                    txtregPuntajes.AppendText(leer + "\n"+ "\n");

                    // Leer la próxima línea
                    leer = leerRegistro.ReadLine();
                }
            }
            catch
            {
                MessageBox.Show("Error al leer el archivo de puntajes.");
            }
            finally
            {
                // Asegúrate de cerrar el archivo después de leerlo
                leerRegistro.Close();
            }
        }

    

        private void btnMostrar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtregPuntaje_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            this.Close();
            this.Hide();
            mn.ShowDialog();
                
        }
    }
}
