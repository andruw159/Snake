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
    public partial class Snake : Form
    {
        List<PictureBox> lista = new List<PictureBox>();
        int sizePiezaPrincipal = 15;
        int tiempo = 10;
        PictureBox comida = new PictureBox();//La comida
        String direccion = "Right"; //Dirección de la serpiente
        

        //PRUEBA PARA ACUMULAR PUNTAJE---------------------------

        public delegate void PuntajeActualizadoEventHandler(object sender, EventArgs e);

        // Evento que se dispara cuando el puntaje se actualiza
        public event PuntajeActualizadoEventHandler PuntajeActualizado;

        // Propiedad pública para acceder al puntaje desde el formulario principal
        public int Puntaje { get; private set; }
        //Se llama al Form Registro
        Registro registroForm;


        public Snake()
        {
            InitializeComponent();
            iniciarJuego();
           //Se le asigna a una variable el form Registro
            registroForm = new Registro(this);
          


        }
        //variable para llevar estado del metodo
        
        public void ReiniciarJuego()
        {
                // Eliminar todas las PictureBox de la serpiente
                foreach (PictureBox Serpiente in lista)
                {
                    
                    this.Controls.Remove(Serpiente);
                    timer1.Stop();
                    
                    lblPuntos.Text = (0).ToString(); //Pone el marcador en 0
                }
                //Muestra el form para guardar el puntaje obtenido
                registroForm.ShowDialog();

                //Cerrar el juego
                this.Hide();
                this.Close();
                // Eliminar la comida
                this.Controls.Remove(comida);

                //Prueba acumular puntaje----
                PuntajeActualizado?.Invoke(this, EventArgs.Empty);
            

        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            

            int nx = lista[0].Location.X;
            int ny = lista[0].Location.Y;
            lista[0].Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("Head" + direccion);//Cabeza de la serpiente

            for (int i = lista.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    //Dependiendo de la dirección se mueve la cabeza
                    if (direccion == "Right") nx = nx + sizePiezaPrincipal;
                    else if (direccion == "Left") nx = nx - sizePiezaPrincipal;
                    else if (direccion == "Up") ny = ny - sizePiezaPrincipal;
                    else if (direccion == "Down") ny = ny + sizePiezaPrincipal;
                    lista[0].Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("Head" + direccion);//Cabeza de la serpiente
                    lista[0].Location = new Point(nx, ny);
                }

                else
                {
                    //Intercambio de seguimiento

                    lista[i].Location = new Point((lista[i - 1].Location.X), (lista[i].Location.Y));
                    lista[i].Location = new Point((lista[i].Location.X), (lista[i - 1].Location.Y));

                }

            }
            for (int contarPiezas = 1; contarPiezas < lista.Count; contarPiezas++)
            {
                if (lista[contarPiezas].Bounds.IntersectsWith(comida.Bounds))
                {
                    this.Controls.Remove(comida); //remueve la comida
                    tiempo = Convert.ToInt32(timer1.Interval);//aumenta el tiempo
                    if (tiempo > 10) { timer1.Interval = tiempo - 10; }
                    lblPuntos.Text = (Convert.ToInt32(lblPuntos.Text) + 1).ToString(); //Puntos del usuario

                   //Acumulador de puntaje
                    Puntaje++;
                    PuntajeActualizado?.Invoke(this, EventArgs.Empty);
                    


                    crearComida();//crea nueva comida
                    crearSnake(lista, this, lista[lista.Count - 1].Location.X * sizePiezaPrincipal, 0);// Nueva parte de la snake

                }
            }
            //detectar colision con paredes
            if ((lista[0].Location.X >= this.Width - 15) || (lista[0].Location.Y >= this.Height - 50) || (lista[0].Location.Y < -10) || (lista[0].Location.X < -30))
            {
                ReiniciarJuego();
            }

            //colision con el cuerpo
            for (int contarPiezas = 1; contarPiezas < lista.Count; contarPiezas++)
            {
                if (lista[0].Bounds.IntersectsWith(lista[contarPiezas].Bounds))
                {
                     
                }
            }
        }
        //Metodo para poder mover la Snake con la fechas
        private void MoverPieza(object sender, KeyEventArgs e)
        {
            direccion = ((e.KeyCode & Keys.Up) == Keys.Up) ? "Up" : direccion;
            direccion = ((e.KeyCode & Keys.Down) == Keys.Down) ? "Down" : direccion;
            direccion = ((e.KeyCode & Keys.Left) == Keys.Left) ? "Left" : direccion;
            direccion = ((e.KeyCode & Keys.Right) == Keys.Right) ? "Right" : direccion;

        }
        //Metodo que crea el cuerpo de la Snake
        public void crearSnake(List<PictureBox> listaPelota, Form formulario, int posicionx, int posiciony)
        {
            PictureBox pb = new PictureBox();
            pb.Location = new Point(posicionx, posiciony);
            pb.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("body");//Se le asigna la imagen al cuerpo
            pb.BackColor = Color.Transparent;
            pb.SizeMode = PictureBoxSizeMode.AutoSize;
            listaPelota.Add(pb);
            formulario.Controls.Add(pb);
        }
        //Crea la comida aleatoriamente
        private void crearComida()
        {
            Random rnd = new Random();
            int entx = rnd.Next(1, this.Width - sizePiezaPrincipal - 10);
            int enty = rnd.Next(1, this.Height - sizePiezaPrincipal - 40);

            PictureBox pb = new PictureBox();
            pb.Location = new Point(entx, enty);
            pb.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("manzanaa");//Se le asigna la imagen a la comida
            pb.BackColor = Color.Transparent;
            pb.SizeMode = PictureBoxSizeMode.AutoSize;
            comida = pb;
            this.Controls.Add(pb);

        }
        //Meotodo que inicia el Juego
        public void iniciarJuego()
        {
            tiempo = 10;
            direccion = "Right";
            timer1.Interval = 200;
            lista = new List<PictureBox>();

            //Piezas iniciales
            for (int i = 2; 0 <= i; i--)
            {
                crearSnake(lista, this, (i * sizePiezaPrincipal) + 70, 80);
            }
            crearComida();
        }
    }
}
