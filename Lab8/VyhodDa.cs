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
    public partial class VyhodDa : Form
    {
        public VyhodDa()
        {
            InitializeComponent();
            this.MinimumSize = new Size(454, 360);
            this.MaximumSize = new Size(454, 360);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
