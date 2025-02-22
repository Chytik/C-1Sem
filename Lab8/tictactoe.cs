using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаба_8._3_осознано
{
    public partial class tictactoe : Form
    {
        private string t = "";
        Random rnd = new Random();
        private int[] array= new int[16];
        Button[] btn = new Button[16];
        public tictactoe()
        {
            InitializeComponent();
            this.MinimumSize = new Size(888, 463);
            this.MaximumSize = new Size(888, 463);
            if (rnd.Next(1,10)<=5)
            {
                t = "Крестики";
                hod1.Text = "Ходят X";
            }
            else
            {
                t = "fjujfukf";
                hod1.Text = "Ходят 0";
            }
            btn[0] = button1;
            btn[1] = button2;
            btn[2] = button3;
            btn[3] = button4;
            btn[4] = button5;
            btn[5] = button6;
            btn[6] = button7;
            btn[7] = button8;
            btn[8] = button9;
            btn[9] = button10;
            btn[10] = button11;
            btn[11] = button12;
            btn[12] = button13;
            btn[13] = button14;
            btn[14] = button15;
            btn[15] = button16;
        }

        private void buttonSdacha_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (t=="Крестики")
            {
                for (int i=0; i<btn.Length; i++)
                {
                    if (sender == btn[i])
                    {
                        btn[i].Text = "X";
                        hod1.Text = "Ходят нолики";
                        t = "fjujfukf";
                        btn[i].Enabled = false;
                        array[i] = 1;
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < btn.Length; i++)
                {
                    if (sender == btn[i])
                    {
                        btn[i].Text = "0";
                        hod1.Text = "Ходят крестики";
                        t = "Крестики";
                        btn[i].Enabled = false;
                        array[i] = 2;
                        break;
                    }
                }
            }
            if (array[0] == 1 && array[1] == 1 && array[2] == 1)
            {
                btn[0].BackColor = System.Drawing.Color.Green;
                btn[1].BackColor = System.Drawing.Color.Green;
                btn[2].BackColor = System.Drawing.Color.Green;
                for (int i=0; i<btn.Length; i++)
                {
                    btn[i].Enabled = false;                   
                }
                hod1.Text = "Выиграли крестики";
            }
            else if (array[1] == 1 && array[2] == 1 && array[3] == 1)
            {
                btn[1].BackColor = System.Drawing.Color.Green;
                btn[2].BackColor = System.Drawing.Color.Green;
                btn[3].BackColor = System.Drawing.Color.Green;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                hod1.Text = "Выиграли крестики";
            }
            else if (array[4] == 1 && array[5] == 1 && array[6] == 1)
            {
                btn[4].BackColor = System.Drawing.Color.Green;
                btn[5].BackColor = System.Drawing.Color.Green;
                btn[6].BackColor = System.Drawing.Color.Green;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                hod1.Text = "Выиграли крестики";
            }
            else if (array[5] == 1 && array[6] == 1 && array[7] == 1)
            {
                btn[5].BackColor = System.Drawing.Color.Green;
                btn[6].BackColor = System.Drawing.Color.Green;
                btn[7].BackColor = System.Drawing.Color.Green;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                hod1.Text = "Выиграли крестики";
            }
            else if (array[8] == 1 && array[9] == 1 && array[10] == 1)
            {
                btn[8].BackColor = System.Drawing.Color.Green;
                btn[9].BackColor = System.Drawing.Color.Green;
                btn[10].BackColor = System.Drawing.Color.Green;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                hod1.Text = "Выиграли крестики";
            }
            else if (array[9] == 1 && array[10] == 1 && array[11] == 1)
            {
                btn[9].BackColor = System.Drawing.Color.Green;
                btn[10].BackColor = System.Drawing.Color.Green;
                btn[11].BackColor = System.Drawing.Color.Green;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                hod1.Text = "Выиграли крестики";
            }
            else if (array[12] == 1 && array[13] == 1 && array[14] == 1)
            {
                btn[12].BackColor = System.Drawing.Color.Green;
                btn[13].BackColor = System.Drawing.Color.Green;
                btn[14].BackColor = System.Drawing.Color.Green;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                hod1.Text = "Выиграли крестики";
            }
            else if (array[13] == 1 && array[14] == 1 && array[15] == 1)
            {
                btn[13].BackColor = System.Drawing.Color.Green;
                btn[14].BackColor = System.Drawing.Color.Green;
                btn[15].BackColor = System.Drawing.Color.Green;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                hod1.Text = "Выиграли крестики";
            }
            else if (array[0] == 1 && array[4] == 1 && array[8] == 1)
            {
                btn[0].BackColor = System.Drawing.Color.Green;
                btn[4].BackColor = System.Drawing.Color.Green;
                btn[8].BackColor = System.Drawing.Color.Green;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                hod1.Text = "Выиграли крестики";
            }
            else if (array[4] == 1 && array[8] == 1 && array[12] == 1)
            {
                btn[4].BackColor = System.Drawing.Color.Green;
                btn[8].BackColor = System.Drawing.Color.Green;
                btn[12].BackColor = System.Drawing.Color.Green;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                hod1.Text = "Выиграли крестики";
            }
            else if (array[1] == 1 && array[5] == 1 && array[9] == 1)
            {
                btn[1].BackColor = System.Drawing.Color.Green;
                btn[5].BackColor = System.Drawing.Color.Green;
                btn[9].BackColor = System.Drawing.Color.Green;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                hod1.Text = "Выиграли крестики";
            }
            else if (array[5] == 1 && array[9] == 1 && array[13] == 1)
            {
                btn[5].BackColor = System.Drawing.Color.Green;
                btn[9].BackColor = System.Drawing.Color.Green;
                btn[13].BackColor = System.Drawing.Color.Green;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                hod1.Text = "Выиграли крестики";
            }
            else if (array[2] == 1 && array[6] == 1 && array[10] == 1)
            {
                btn[2].BackColor = System.Drawing.Color.Green;
                btn[6].BackColor = System.Drawing.Color.Green;
                btn[10].BackColor = System.Drawing.Color.Green;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                hod1.Text = "Выиграли крестики";
            }
            else if (array[6] == 1 && array[10] == 1 && array[14] == 1)
            {
                btn[6].BackColor = System.Drawing.Color.Green;
                btn[10].BackColor = System.Drawing.Color.Green;
                btn[14].BackColor = System.Drawing.Color.Green;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                hod1.Text = "Выиграли крестики";
            }
            else if (array[3] == 1 && array[7] == 1 && array[11] == 1)
            {
                btn[3].BackColor = System.Drawing.Color.Green;
                btn[7].BackColor = System.Drawing.Color.Green;
                btn[11].BackColor = System.Drawing.Color.Green;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                hod1.Text = "Выиграли крестики";
            }
            else if (array[7] == 1 && array[11] == 1 && array[15] == 1)
            {
                btn[7].BackColor = System.Drawing.Color.Green;
                btn[11].BackColor = System.Drawing.Color.Green;
                btn[15].BackColor = System.Drawing.Color.Green;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                hod1.Text = "Выиграли крестики";
            }
            else if (array[1] == 1 && array[6] == 1 && array[11] == 1)
            {
                btn[1].BackColor = System.Drawing.Color.Green;
                btn[6].BackColor = System.Drawing.Color.Green;
                btn[11].BackColor = System.Drawing.Color.Green;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                hod1.Text = "Выиграли крестики";
            }
            else if (array[0] == 1 && array[5] == 1 && array[10] == 1)
            {
                btn[0].BackColor = System.Drawing.Color.Green;
                btn[5].BackColor = System.Drawing.Color.Green;
                btn[10].BackColor = System.Drawing.Color.Green;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                hod1.Text = "Выиграли крестики";
            }
            else if (array[5] == 1 && array[10] == 1 && array[15] == 1)
            {
                btn[5].BackColor = System.Drawing.Color.Green;
                btn[10].BackColor = System.Drawing.Color.Green;
                btn[15].BackColor = System.Drawing.Color.Green;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                hod1.Text = "Выиграли крестики";
            }
            else if (array[4] == 1 && array[9] == 1 && array[14] == 1)
            {
                btn[4].BackColor = System.Drawing.Color.Green;
                btn[9].BackColor = System.Drawing.Color.Green;
                btn[14].BackColor = System.Drawing.Color.Green;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                hod1.Text = "Выиграли крестики";
            }
            else if (array[4] == 1 && array[9] == 1 && array[14] == 1)
            {
                btn[4].BackColor = System.Drawing.Color.Green;
                btn[9].BackColor = System.Drawing.Color.Green;
                btn[14].BackColor = System.Drawing.Color.Green;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                hod1.Text = "Выиграли крестики";
            }
            else if (array[8] == 1 && array[5] == 1 && array[2] == 1)
            {
                btn[8].BackColor = System.Drawing.Color.Green;
                btn[5].BackColor = System.Drawing.Color.Green;
                btn[2].BackColor = System.Drawing.Color.Green;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                hod1.Text = "Выиграли крестики";
            }
            else if (array[8] == 1 && array[5] == 1 && array[2] == 1)
            {
                btn[8].BackColor = System.Drawing.Color.Green;
                btn[5].BackColor = System.Drawing.Color.Green;
                btn[2].BackColor = System.Drawing.Color.Green;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                hod1.Text = "Выиграли крестики";
            }
            else if (array[12] == 1 && array[9] == 1 && array[6] == 1)
            {
                btn[12].BackColor = System.Drawing.Color.Green;
                btn[9].BackColor = System.Drawing.Color.Green;
                btn[6].BackColor = System.Drawing.Color.Green;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                hod1.Text = "Выиграли крестики";
            }
            else if (array[9] == 1 && array[6] == 1 && array[3] == 1)
            {
                btn[9].BackColor = System.Drawing.Color.Green;
                btn[6].BackColor = System.Drawing.Color.Green;
                btn[3].BackColor = System.Drawing.Color.Green;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                hod1.Text = "Выиграли крестики";
            }
            else if (array[13] == 1 && array[10] == 1 && array[7] == 1)
            {
                btn[13].BackColor = System.Drawing.Color.Green;
                btn[10].BackColor = System.Drawing.Color.Green;
                btn[7].BackColor = System.Drawing.Color.Green;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                hod1.Text = "Выиграли крестики";
            }
            if (array[0] == 2 && array[1] == 2 && array[2] == 2)
            {
                btn[0].BackColor = System.Drawing.Color.Green;
                btn[1].BackColor = System.Drawing.Color.Green;
                btn[2].BackColor = System.Drawing.Color.Green;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                hod1.Text = "Выиграли нолики";
            }
            else if (array[1] == 2 && array[2] == 2 && array[3] == 2)
            {
                btn[1].BackColor = System.Drawing.Color.Green;
                btn[2].BackColor = System.Drawing.Color.Green;
                btn[3].BackColor = System.Drawing.Color.Green;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                hod1.Text = "Выиграли нолики";
            }
            else if (array[4] == 2 && array[5] == 2 && array[6] == 2)
            {
                btn[4].BackColor = System.Drawing.Color.Green;
                btn[5].BackColor = System.Drawing.Color.Green;
                btn[6].BackColor = System.Drawing.Color.Green;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                hod1.Text = "Выиграли нолики";
            }
            else if (array[5] == 2 && array[6] == 2 && array[7] == 2)
            {
                btn[5].BackColor = System.Drawing.Color.Green;
                btn[6].BackColor = System.Drawing.Color.Green;
                btn[7].BackColor = System.Drawing.Color.Green;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                hod1.Text = "Выиграли нолики";
            }
            else if (array[8] == 2 && array[9] == 2 && array[10] == 2)
            {
                btn[8].BackColor = System.Drawing.Color.Green;
                btn[9].BackColor = System.Drawing.Color.Green;
                btn[10].BackColor = System.Drawing.Color.Green;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                hod1.Text = "Выиграли нолики";
            }
            else if (array[9] == 2 && array[10] == 2 && array[11] == 2)
            {
                btn[9].BackColor = System.Drawing.Color.Green;
                btn[10].BackColor = System.Drawing.Color.Green;
                btn[11].BackColor = System.Drawing.Color.Green;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                hod1.Text = "Выиграли нолики";
            }
            else if (array[12] == 2 && array[13] == 2 && array[14] == 2)
            {
                btn[12].BackColor = System.Drawing.Color.Green;
                btn[13].BackColor = System.Drawing.Color.Green;
                btn[14].BackColor = System.Drawing.Color.Green;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                hod1.Text = "Выиграли нолики";
            }
            else if (array[13] == 2 && array[14] == 2 && array[15] == 2)
            {
                btn[13].BackColor = System.Drawing.Color.Green;
                btn[14].BackColor = System.Drawing.Color.Green;
                btn[15].BackColor = System.Drawing.Color.Green;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                hod1.Text = "Выиграли нолики";
            }
            else if (array[0] == 2 && array[4] == 2 && array[8] == 2)
            {
                btn[0].BackColor = System.Drawing.Color.Green;
                btn[4].BackColor = System.Drawing.Color.Green;
                btn[8].BackColor = System.Drawing.Color.Green;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                hod1.Text = "Выиграли нолики";
            }
            else if (   array[4] == 2 && array[8] == 2 && array[12] == 2)
            {
                btn[4].BackColor = System.Drawing.Color.Green;
                btn[8].BackColor = System.Drawing.Color.Green;
                btn[12].BackColor = System.Drawing.Color.Green;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                hod1.Text = "Выиграли нолики";
            }
            else if (array[1] == 2 && array[5] == 2 && array[9] == 2)
            {
                btn[1].BackColor = System.Drawing.Color.Green;
                btn[5].BackColor = System.Drawing.Color.Green;
                btn[9].BackColor = System.Drawing.Color.Green;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                hod1.Text = "Выиграли нолики";
            }
            else if (array[5] == 2 && array[9] == 2 && array[13] == 2)
            {
                btn[5].BackColor = System.Drawing.Color.Green;
                btn[9].BackColor = System.Drawing.Color.Green;
                btn[13].BackColor = System.Drawing.Color.Green;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                hod1.Text = "Выиграли нолики";
            }
            else if (array[2] == 2 && array[6] == 2 && array[10] == 2)
            {
                btn[2].BackColor = System.Drawing.Color.Green;
                btn[6].BackColor = System.Drawing.Color.Green;
                btn[10].BackColor = System.Drawing.Color.Green;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                hod1.Text = "Выиграли нолики";
            }
            else if (array[6] == 2 && array[10] == 2 && array[14] == 2)
            {
                btn[6].BackColor = System.Drawing.Color.Green;
                btn[10].BackColor = System.Drawing.Color.Green;
                btn[14].BackColor = System.Drawing.Color.Green;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                hod1.Text = "Выиграли нолики";
            }
            else if (array[3] == 2 && array[7] == 2 && array[11] == 2)
            {
                btn[3].BackColor = System.Drawing.Color.Green;
                btn[7].BackColor = System.Drawing.Color.Green;
                btn[11].BackColor = System.Drawing.Color.Green;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                hod1.Text = "Выиграли нолики";
            }
            else if (array[7] == 2 && array[11] == 2 && array[15] == 2)
            {
                btn[7].BackColor = System.Drawing.Color.Green;
                btn[11].BackColor = System.Drawing.Color.Green;
                btn[15].BackColor = System.Drawing.Color.Green;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                hod1.Text = "Выиграли нолики";
            }
            else if (array[1] == 2 && array[6] == 2 && array[11] == 2)
            {
                btn[1].BackColor = System.Drawing.Color.Green;
                btn[6].BackColor = System.Drawing.Color.Green;
                btn[11].BackColor = System.Drawing.Color.Green;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                hod1.Text = "Выиграли нолики";
            }
            else if (array[0] == 2 && array[5] == 2 && array[10] == 2)
            {
                btn[0].BackColor = System.Drawing.Color.Green;
                btn[5].BackColor = System.Drawing.Color.Green;
                btn[10].BackColor = System.Drawing.Color.Green;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                hod1.Text = "Выиграли нолики";
            }
            else if (array[5] == 2 && array[10] == 2 && array[15] == 2)
            {
                btn[5].BackColor = System.Drawing.Color.Green;
                btn[10].BackColor = System.Drawing.Color.Green;
                btn[15].BackColor = System.Drawing.Color.Green;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                hod1.Text = "Выиграли нолики";
            }
            else if (array[4] == 2 && array[9] == 2 && array[14] == 2)
            {
                btn[4].BackColor = System.Drawing.Color.Green;
                btn[9].BackColor = System.Drawing.Color.Green;
                btn[14].BackColor = System.Drawing.Color.Green;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                hod1.Text = "Выиграли нолики";
            }
            else if (array[4] == 2 && array[9] == 2 && array[14] == 2)
            {
                btn[4].BackColor = System.Drawing.Color.Green;
                btn[9].BackColor = System.Drawing.Color.Green;
                btn[14].BackColor = System.Drawing.Color.Green;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                hod1.Text = "Выиграли нолики";
            }
            else if (array[8] == 2 && array[5] == 2 && array[2] == 2)
            {
                btn[8].BackColor = System.Drawing.Color.Green;
                btn[5].BackColor = System.Drawing.Color.Green;
                btn[2].BackColor = System.Drawing.Color.Green;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                hod1.Text = "Выиграли нолики";
            }
            else if (array[8] == 2 && array[5] == 2 && array[2] == 2)
            {
                btn[8].BackColor = System.Drawing.Color.Green;
                btn[5].BackColor = System.Drawing.Color.Green;
                btn[2].BackColor = System.Drawing.Color.Green;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                hod1.Text = "Выиграли нолики";
            }
            else if (array[12] == 2 && array[9] == 2 && array[6] == 2)
            {
                btn[12].BackColor = System.Drawing.Color.Green;
                btn[9].BackColor = System.Drawing.Color.Green;
                btn[6].BackColor = System.Drawing.Color.Green;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                hod1.Text = "Выиграли нолики";
            }
            else if (array[9] == 2 && array[6] == 2 && array[3] == 2)
            {
                btn[9].BackColor = System.Drawing.Color.Green;
                btn[6].BackColor = System.Drawing.Color.Green;
                btn[3].BackColor = System.Drawing.Color.Green;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                hod1.Text = "Выиграли нолики";
            }
            else if (array[13] == 2 && array[10] == 2 && array[7] == 2)
            {
                btn[13].BackColor = System.Drawing.Color.Green;
                btn[10].BackColor = System.Drawing.Color.Green;
                btn[7].BackColor = System.Drawing.Color.Green;
                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].Enabled = false;
                }
                hod1.Text = "Выиграли нолики";
            }
            else if ((array[0] == 1 || array[0] == 2) && (array[1] == 1 || array[1] == 2) && (array[2] == 1 || array[2] == 2) && (array[3] == 1 || array[3] == 2) && (array[4] == 1 || array[4] == 2) && (array[5] == 1 || array[5] == 2) && (array[6] == 1 || array[6] == 2) && (array[7] == 1 || array[7] == 2) && (array[8] == 1 || array[8] == 2) && (array[9] == 1 || array[9] == 2) && (array[10] == 1 || array[10] == 2) && (array[11] == 1 || array[11] == 2) && (array[12] == 1 || array[12] == 2) && (array[13] == 1 || array[13] == 2) && (array[14] == 1 || array[14] == 2) && (array[15] == 1 || array[15] == 2))
            {
                btn[0].BackColor = System.Drawing.Color.Green;
                btn[1].BackColor = System.Drawing.Color.Green;
                btn[2].BackColor = System.Drawing.Color.Green;
                btn[3].BackColor = System.Drawing.Color.Green;
                btn[4].BackColor = System.Drawing.Color.Green;
                btn[5].BackColor = System.Drawing.Color.Green;
                btn[6].BackColor = System.Drawing.Color.Green;
                btn[7].BackColor = System.Drawing.Color.Green;
                btn[8].BackColor = System.Drawing.Color.Green;
                btn[9].BackColor = System.Drawing.Color.Green;
                btn[10].BackColor = System.Drawing.Color.Green;
                btn[11].BackColor = System.Drawing.Color.Green;
                btn[12].BackColor = System.Drawing.Color.Green;
                btn[13].BackColor = System.Drawing.Color.Green;
                btn[14].BackColor = System.Drawing.Color.Green;
                btn[15].BackColor = System.Drawing.Color.Green;
                hod1.Text = "Ничья";
            }
        }
    }
}
