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
    public partial class GameOver : Form
    {
        Form1 f;
        PantallaAhorcado p;

        public GameOver(Form1 f, PantallaAhorcado pant)
        {
            InitializeComponent();
            this.f = f;
            this.p = pant;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            f.Show();
            p.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.Close();
            this.Close();
            Application.Exit();
        }
    }
}
