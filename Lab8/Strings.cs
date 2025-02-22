using _7_Лаба_новый_уровень;
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
    public partial class Strings : Form
    {
        public Strings()
        {
            InitializeComponent();
            this.MinimumSize = new Size(1147, 480);
            this.MaximumSize = new Size(1147, 480);
            labelStr1.Enabled = false;
            BoxStr1.Enabled = false;
            BoxStr1.Clear();
            labelStr2.Enabled = false;
            BoxStr2.Enabled = false;
            BoxStr2.Clear();
            ButtonTask1.Checked = true;
        }       
        private void buttonVyhod_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
        private void ButtonTask1_CheckedChanged(object sender, EventArgs e)
        {
            labelStr1.Enabled = false;
            BoxStr1.Enabled = false;
            BoxStr1.Clear();
            labelStr2.Enabled = false;
            BoxStr2.Enabled = false;
            BoxStr2.Clear();
            labelStr.Enabled = true;
            BoxStr.Enabled = true; 
            BoxStr.Text = "Варкалось. Хливкие шорьки. Пырялись по наве, И хрюкотали зелюки, Как мюмзики в мове.О бойся Бармаглота, сын! Он так свирлеп и дик, А в глуще рымит исполин - Злопастный Брандашмыг";
        }
        private void ButtonTask2_CheckedChanged(object sender, EventArgs e)
        {
            labelStr2.Enabled = false;
            BoxStr2.Enabled = false;
            BoxStr2.Clear();
            labelStr1.Enabled = false;
            BoxStr1.Enabled = false;
            BoxStr1.Clear();
            labelStr.Enabled = true;
            BoxStr.Enabled = true;
            BoxStr.Text = "Варкалось. Хливкие шорьки. Пырялись по наве, И хрюкотали зелюки, Как мюмзики в мове.О бойся Бармаглота, сын! Он так свирлеп и дик, А в глуще рымит исполин - Злопастный Брандашмыг";
        }

        private void ButtonTask3_CheckedChanged(object sender, EventArgs e)
        {
            labelStr1.Enabled = false;
            BoxStr1.Enabled = false;
            BoxStr1.Clear();
            labelStr2.Enabled = false;
            BoxStr2.Enabled = false;
            BoxStr2.Clear();
            labelStr.Enabled = true;
            BoxStr.Enabled = true;
            BoxStr.Text = "Варкалось. Хливкие шорьки. Пырялись по наве, И хрюкотали зелюки, Как мюмзики в мове.О бойся Бармаглота, сын! Он так свирлеп и дик, А в глуще рымит исполин - Злопастный Брандашмыг";
        }
        private void ButtonTask4_CheckedChanged(object sender, EventArgs e)
        {
            labelStr.Enabled = false;
            BoxStr.Enabled = false;
            BoxStr.Clear();
            labelStr1.Enabled = true;
            BoxStr1.Enabled = true;
            BoxStr1.Text = "Быть может, вся Природа – мозаика цветов?";
            labelStr2.Enabled = true;
            BoxStr2.Enabled = true;
            BoxStr2.Text = "Быть может, вся Природа – различность голосов?";
            BoxResult.Clear();
        }

        private void buttonSolve_Click(object sender, EventArgs e)
        {
            if ((BoxStr.Enabled) && (BoxStr.Text == ""))
            {
                MessageBox.Show("Поле строки пустое", "Ошибка!");
            }
            else if ((!BoxStr.Enabled) && ((BoxStr1.Text == "") || (BoxStr2.Text == "")))
            {
                MessageBox.Show("Поле одной или двух строк пустое", "Ошибка!");
            }
            else
            {
                if (ButtonTask1.Checked)
                {
                    Glasnye1(BoxStr.Text);
                }
                else if (ButtonTask2.Checked)
                {
                    Soglasnye1(BoxStr.Text);
                }
                else if (ButtonTask3.Checked)
                {
                    Znaki1(BoxStr.Text);
                }
                else if (ButtonTask4.Checked)
                {
                    Sravnenie1(BoxStr1.Text, BoxStr2.Text);
                }
            }
        }

        private void Glasnye1(string str1)
        {
            List<char> Gl = new List<char> { 'У', 'у', 'Е', 'е', 'Ё', 'ё', 'Ы', 'ы', 'А', 'а', 'О', 'о', 'Э', 'э', 'Я', 'я', 'И', 'и', 'Ю', 'ю' };
            List<char> Gls = new List<char>();
            int Glc = 0;
            foreach (char ch in str1)
            {
                if (Gl.Contains(ch))
                {
                    Glc++;
                }
            }
            BoxResult.Text = "Количество гласных в строке: " + Glc;
        }
        private void Soglasnye1(string str1)
        {
            List<char> soGl = new List<char> { 'Й', 'й', 'Ц', 'ц', 'К', 'к', 'Н', 'н', 'Г', 'г', 'Ш', 'ш', 'Щ', 'щ', 'З', 'з', 'Х', 'х', 'ъ', 'Ф', 'ф', 'В', 'в', 'П', 'п', 'Р', 'р', 'Л', 'л', 'Д', 'д', 'Ж', 'ж', 'Ч', 'ч', 'С', 'с', 'М', 'м', 'Т', 'т', 'ь', 'Б', 'б' };
            List<char> soGls = new List<char>();
            int soGlc = 0;
            foreach (char ch in str1)
            {
                if (soGl.Contains(ch))
                {
                    soGlc++;
                }
            }
            BoxResult.Text = "Количество согласных в строке: " + soGlc;
        }
        private void Znaki1(string str1)
        {
            List<char> Gl = new List<char> { '.', ',', '?', '!', '-', ';', ':', '"', '(', ')' };
            List<char> Gls = new List<char>();
            int Glc = 0;
            foreach (char ch in str1)
            {
                if (Gl.Contains(ch))
                {
                    Glc++;
                }
            }
            BoxResult.Text = "Количество знаков в строке: " + Glc;
        }
        private void Sravnenie1(string stroka1, string stroka2)
        {
            int res = 0;
            for (int i = 0; i < stroka1.Length && i < stroka2.Length; i++)
            {
                if (stroka1[i] == stroka2[i])
                {
                    res++;
                }
                if (stroka1[i] != stroka2[i])
                {
                    break;
                }
            }
            BoxResult.Text = "Количество Совпадающих первых символов: " + res;
        }

        private void labelStr2_Click(object sender, EventArgs e)
        {

        }
    }
}
