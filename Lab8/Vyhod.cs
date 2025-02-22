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
    public partial class Vyhod : Form
    {
        public Vyhod()
        {
            InitializeComponent();
            this.MinimumSize = new Size(507, 107);
            this.MaximumSize = new Size(507, 107);
        }

        private void TochnO_Click(object sender, EventArgs e)
        {

        }

        private void Net_Click(object sender, EventArgs e)
        {
            VyhodNet vyhodNet = new VyhodNet();
            vyhodNet.Show();
            this.Close();
        }

        private void Da_Click(object sender, EventArgs e)
        {
            VyhodDa vyhodDa = new VyhodDa();
            vyhodDa.Show();
            this.Close();
        }
    }
}
