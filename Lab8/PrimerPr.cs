using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _7_Лаба_новый_уровень;

namespace Лаба_8._3_осознано
{
    public partial class PrimerPr : Form
    {
        private int a;
        private int b;
        private int num = 3;
        private double q;
        private double d;
        public PrimerPr()
        {
            InitializeComponent();
            this.MinimumSize = new Size(823, 379);
            this.MaximumSize = new Size(823, 379);
            ChemyRavno.Enabled = true;
            Boxa.Enabled = true;
            Boxb.Enabled = true;
            Otvet.Enabled = false;
            BBBBB.Enabled = true;
            BoxANS.Enabled = false;
            Answer.Enabled = false;
            PrimerVyhod.Enabled = true;
            LB.Enabled = true;
            LA.Enabled = true;
        }

        private void PrimerVyhod_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void BBBBB_Click(object sender, EventArgs e)
        {
            bool qqq = int.TryParse(Boxb.Text, out b);
            bool qqq1 = int.TryParse(Boxa.Text, out a);
            if (string.IsNullOrEmpty(Boxb.Text)|| string.IsNullOrEmpty(Boxa.Text))
            {
                MessageBox.Show("Ошибка, отсутствуют значения переменных");
            }
            else if(!qqq||!qqq1)
            {
                MessageBox.Show("Ошибка, Введены нечитаемые переменнные");
            }
            else
            {
                ChemyRavno.Enabled = true;
                Boxa.Enabled = false;
                Boxb.Enabled = false;
                Otvet.Enabled = true;
                BBBBB.Enabled = false;
                BoxANS.Enabled = true;
                Answer.Enabled = true;
                PrimerVyhod.Enabled = true;
                LB.Enabled = false;
                LA.Enabled = false;
                q = Primer.Result1(a, b);
            }
        }

        private void Answer_Click(object sender, EventArgs e)
        {
            bool readUser = double.TryParse(BoxANS.Text, out d);
            if (!readUser)
            {
                MessageBox.Show("Произошла ошибка при вводе ответа");
            }
            else if (d != q && num != 1)
            {
                num--;
                MessageBox.Show("Ответ неправильный! Осталось попыток: " + num);
            }
            else if (num == 1)
            {
                MessageBox.Show("Вы проиграли! Правильный ответ: " + q);
                BoxANS.Enabled = false;
                Answer.Enabled = false;
                Otvet.Enabled = false;
            }
            else if (d == q)
            {
                BoxANS.Enabled = false;
                Answer.Enabled = false;
                Otvet.Enabled = false;
                MessageBox.Show("Ответ верный!", "Успех!");
                num = 0;
            }
        }

        private void PrimerPr_Load(object sender, EventArgs e)
        {

        }
    }
}
