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
    public partial class Avtor : Form
    {
        public Avtor()
        {
            InitializeComponent();
            this.MinimumSize = new Size(1471, 157);
            this.MaximumSize = new Size(1471, 157);
        }

        private void Nasmotrelsa_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
