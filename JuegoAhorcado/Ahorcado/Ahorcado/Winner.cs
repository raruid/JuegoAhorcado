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
    public partial class Winner : Form
    {
        Form1 f;
        PantallaAhorcado p;

        public Winner(Form1 f, PantallaAhorcado p)
        {
            InitializeComponent();
            this.f = f;
            this.p = p;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            p.Close();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
