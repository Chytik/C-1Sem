using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаба_8._3_осознано
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MinimumSize = new Size(718, 432);
            this.MaximumSize = new Size(718, 432);
        }

        private void Ygadayka_Click(object sender, EventArgs e)
        {
            PrimerPr primerPr = new PrimerPr();
            primerPr.Show();
            this.Hide();
        }

        private void Vyhod_Click(object sender, EventArgs e)
        {
            Vyhod vyhod = new Vyhod();
            vyhod.Show();
            this.Hide();
        }

        private void Avtor_Click(object sender, EventArgs e)
        {
            Avtor avtor = new Avtor();
            avtor.Show();
            this.Hide();
        }


        private void buttonarrays_Click(object sender, EventArgs e)
        {
            Masivi masivi = new Masivi();
            masivi.Show();
            this.Hide();
        }

        private void buttonstrings_Click(object sender, EventArgs e)
        {
            Strings strings = new Strings();
            strings.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tictactoe Tictactoe = new tictactoe();
            Tictactoe.Show();
            this.Hide();
        }
    }
}
