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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PantallaAhorcado pant = new PantallaAhorcado(this);
            this.Hide();
            pant.Show();
            pant.modoFacil();
        }


        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PantallaAhorcado pant = new PantallaAhorcado(this);
            this.Hide();
            pant.Show();
            pant.modoMedio();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PantallaAhorcado pant = new PantallaAhorcado(this);
            this.Hide();
            pant.Show();
            pant.modoDificil();
        }
    }
}
