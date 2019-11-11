using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahorcado
{
    public partial class PantallaAhorcado : Form
    {
        Form1 f;
        string palabraBase = "";
        string palabraAdivinar = "";
        Char[] palabra = new char[1];
        string palabraString = "";
        string palabrasFallos = "";
        string auxiliar = "";
        bool encontrada = false;
        bool terminado = true;


        public PantallaAhorcado(Form1 f)
        {
            InitializeComponent();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            contadorVidas.Text = "4";
            this.f = f;
        }

        public void modoFacil()
        {
            string[] arrayPalabrasFacil = new string[5];
            arrayPalabrasFacil[0] = "pelota";
            arrayPalabrasFacil[1] = "cepillo";
            arrayPalabrasFacil[2] = "botella";
            arrayPalabrasFacil[3] = "canasta";
            arrayPalabrasFacil[4] = "manibela";

            Random random = new Random();
            int start2 = random.Next(0, arrayPalabrasFacil.Length);
            palabraBase = arrayPalabrasFacil[start2];

            for (int i = 0; i < palabraBase.Length; i++)
            {
                palabraAdivinar = palabraAdivinar + "_";
            }            

            Random ran = new Random();
            int index = ran.Next(0, palabraAdivinar.Length);
            
            palabraAdivinar = palabraAdivinar.Remove(index, 1);
            palabraAdivinar = palabraAdivinar.Insert(index, palabraAdivinar[index].ToString());


            Random rand = new Random();
            int index2 = rand.Next(0, palabraAdivinar.Length);

            palabraAdivinar = palabraAdivinar.Remove(index2, 1);
            palabraAdivinar = palabraAdivinar.Insert(index2, palabraAdivinar[index2].ToString());

            palabraParaAdivinar.Text = palabraAdivinar;

        }

        public void modoMedio()
        {
            string[] arrayPalabrasMedio = new string[5];
            arrayPalabrasMedio[0] = "conector";
            arrayPalabrasMedio[1] = "franela";
            arrayPalabrasMedio[2] = "asociacion";
            arrayPalabrasMedio[3] = "mampara";
            arrayPalabrasMedio[4] = "alcachofa";

            Random random = new Random();
            int start2 = random.Next(0, arrayPalabrasMedio.Length);
            palabraBase = arrayPalabrasMedio[start2];

            for (int i = 0; i < palabraBase.Length-1; i++)
            {
                palabraAdivinar = palabraAdivinar + "_ ";
            }



            Random ra = new Random();
            int index3 = ra.Next(0, palabraAdivinar.Length);

            palabraAdivinar = palabraAdivinar.Remove(index3, 1);
            auxiliar = palabraAdivinar[index3].ToString();
            palabraAdivinar = palabraAdivinar.Insert(index3, auxiliar);

            palabraParaAdivinar.Text = palabraAdivinar;

        }

        public void modoDificil()
        {
            string[] arrayPalabrasDificil = new string[5];
            arrayPalabrasDificil[0] = "azabache";
            arrayPalabrasDificil[1] = "efimero";
            arrayPalabrasDificil[2] = "penumbra";
            arrayPalabrasDificil[3] = "ribonucleico";
            arrayPalabrasDificil[4] = "hipoglucidos";

            Random random = new Random();
            int start2 = random.Next(0, arrayPalabrasDificil.Length);
            palabraBase = arrayPalabrasDificil[start2];

            for (int i = 0; i < palabraBase.Length; i++)
            {
                palabraAdivinar = palabraAdivinar + "_";
            }

            //palabraNormal.Text = palabraBase;
            palabraParaAdivinar.Text = palabraAdivinar;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void comprobarSiTerminado(string palabra)
        {
            for(int i = 0; i < palabra.Length && terminado == true; i++)
            {
                if(palabra[i] == '_')
                {
                    terminado = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            palabraString = palabraIntroducida.Text;

            for(int i = 0; i < palabraString.Length; i++)
            {
                palabra[0] = palabraString[i];
            }

            encontrada = false;
            for(int i = 0; i < palabraBase.Length; i++)
            {
                if(palabra[0] == palabraBase[i])
                {
                    auxiliar = palabra[0].ToString();
                    palabraAdivinar = palabraAdivinar.Remove(i, 1);
                    palabraAdivinar = palabraAdivinar.Insert(i, auxiliar);
                    palabraParaAdivinar.Text = palabraAdivinar;
                    encontrada = true;
                }
            }

            if (encontrada == false)
            {
                palabrasFallos = palabrasFallos + palabra[0].ToString() + " ";
                palabrasFalladas.Text = palabrasFallos;
                if (pictureBox4.Visible == true)
                {
                    pictureBox3.Visible = true;
                    contadorVidas.Text = "0";
                    palabraParaAdivinar.Text = palabraBase;
                    GameOver game = new GameOver(f, this);
                    game.Show();
                }
                else if (pictureBox2.Visible == true)
                {
                    pictureBox4.Visible = true;
                    contadorVidas.Text = "1";
                }
                else if (pictureBox1.Visible == true)
                {
                    pictureBox2.Visible = true;
                    contadorVidas.Text = "2";
                }
                else
                {
                    pictureBox1.Visible = true;
                    contadorVidas.Text = "3";
                }
            }
            else
            {
                terminado = true;
                comprobarSiTerminado(palabraAdivinar);

                if (terminado == true)
                {
                    Winner ganador = new Winner(f, this);
                    ganador.Show();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
