using _7_Лаба_новый_уровень;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаба_8._3_осознано
{
    public partial class Masivi : Form
    {
        Massivvi massivvi = new Massivvi();
        private int[] arr;
        private int[] arr1;
        private int[] arr2;
        private int n;
        Stopwatch timer = new Stopwatch();
        Stopwatch timebubble = new Stopwatch();
        Stopwatch timevstavka = new Stopwatch();
        public Masivi()
        {
            InitializeComponent();
            this.MinimumSize = new Size(884, 525);
            this.MaximumSize = new Size(884, 525);
            labelarr.Enabled = false;
            labelarrsort.Enabled = false;
            dataGridViewarr.Enabled = false;
            dataGridViewarrsort.Enabled = false;
            labelbubble.Visible = false;
            labelvstavka.Visible = false;
            buttonsort.Enabled = false;
            BoxVvod.Text = "10";
        }
        private void masivivyhod_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
        private void buttonvvod_Click(object sender, EventArgs e)
        {
            timebubble.Reset();
            timevstavka.Reset();
            dataGridViewarr.Columns.Clear();
            dataGridViewarr.Refresh();
            dataGridViewarrsort.Columns.Clear();
            dataGridViewarrsort.Refresh();
            if (BoxVvod.Text == "")
            {
                MessageBox.Show("Не заданная длина массива", "Ошибка");
                dataGridViewarr.Enabled = false;
                dataGridViewarrsort.Enabled = false;
                labelarr.Enabled = false;
                labelarrsort.Enabled = false;
                buttonsort.Enabled = false;
                labelbubble.Visible = false;
                labelvstavka.Visible = false;
            }
            else
            {
                arr = massivvi.Granitca(int.Parse(BoxVvod.Text));
                arr1 = massivvi.Copya(arr);
                arr2 = massivvi.Copya(arr);
                buttonsort.Enabled = true;
                labelbubble.Visible = true;
                labelvstavka.Visible = true;
                labelarr.Enabled = true;
                labelarrsort.Enabled = true;
                dataGridViewarr.Enabled = true;
                dataGridViewarrsort.Enabled = true;
                labelbubble.Text = "Время \"Пузырька\":\r\n";
                labelvstavka.Text = "Время \"Вставок\":\r\n";
                if (BoxVvod.Text == "")
                {
                    MessageBox.Show("Нечитаемая или не заданная длина массива", "Ошибка");
                    dataGridViewarr.Enabled = false;
                    dataGridViewarrsort.Enabled = false;
                    labelarr.Enabled = false;
                    labelarrsort.Enabled = false;
                    buttonsort.Enabled = false;
                    labelbubble.Visible = false;
                    labelvstavka.Visible = false;
                }
                if (int.Parse(BoxVvod.Text) > 18)
                {
                    MessageBox.Show("Массив слишком длинный, вывод отключен\r\nСортировка остаётся доступной", "Предупреждение");
                    dataGridViewarr.Enabled = false;
                    dataGridViewarrsort.Enabled = false;
                    labelarr.Enabled = false;
                    labelarrsort.Enabled = false;
                }
                else if (int.Parse(BoxVvod.Text) == 0)
                {
                    MessageBox.Show("Длина массива не может быть нулевой", "Ошибка");
                    dataGridViewarr.Enabled = false;
                    dataGridViewarrsort.Enabled = false;
                    labelarr.Enabled = false;
                    labelarrsort.Enabled = false;
                    buttonsort.Enabled = false;
                    labelbubble.Visible = false;
                    labelvstavka.Visible = false;

                }
                else if (int.Parse(BoxVvod.Text) < 19)
                {
                    dataGridViewarr.RowCount = 1;
                    dataGridViewarr.ColumnCount = arr.Length;
                    for (int i = 0; i < arr.Length; i++)
                    {
                        dataGridViewarr.Rows[0].Cells[i].Value = arr[i];
                    }
                }
                else
                {
                    MessageBox.Show("Нечитаемая длина массива", "Ошибка");
                    dataGridViewarr.Enabled = false;
                    dataGridViewarrsort.Enabled = false;
                    labelarr.Enabled = false;
                    labelarrsort.Enabled = false;
                    buttonsort.Enabled = false;
                    labelbubble.Visible = false;
                    labelvstavka.Visible = false;
                }
            }
        }
        private void BoxVvod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((!char.IsControl(e.KeyChar)) && (!char.IsDigit(e.KeyChar))) || (e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }
        private void buttonsort_Click(object sender, EventArgs e)
        {
            buttonsort.Enabled = false;
            timebubble.Start();
            massivvi.PuzyriokSort(arr1);
            timebubble.Stop();
            timevstavka.Start();
            massivvi.VstavkaSort(arr2);
            timevstavka.Stop();
            labelbubble.Text = "Время \"Пузырька\":\r\n" + timebubble.Elapsed.ToString();
            labelvstavka.Text = "Время \"Вставок\":\r\n" + timevstavka.Elapsed.ToString();
            if (arr.Length < 19)
            {
                dataGridViewarrsort.RowCount = 1;
                dataGridViewarrsort.ColumnCount = arr.Length;
                for (int i = 0; i < arr.Length; i++)
                {
                    dataGridViewarrsort.Rows[0].Cells[i].Value = arr2[i];
                }
            }
            if (timevstavka.Elapsed < timebubble.Elapsed)
            {
                MessageBox.Show("Для данного массива сортировка вставками работает быстрее", "Результат");
            }
            else
            {
                MessageBox.Show("Для данного массива сортировка пузырьком работает быстрее", "Результат");
            }
            BoxVvod.Enabled = false;
            buttonvvod.Enabled = false; 
        }
    }
}
