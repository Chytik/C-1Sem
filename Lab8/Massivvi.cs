using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _7_Лаба_новый_уровень
{
    /// <summary>
    /// Класс для выполнения Лабораторной работы 4.
    /// </summary>
    public class Massivvi
    {
        private int _n;
        private int[] arr;
        /// <summary>
        /// Конструктор с параметрами.
        /// </summary>
        /// <param name="n">Длина массива.</param>
        public Massivvi(int n)
        {
            this._n = n;
        }
        /// <summary>
        /// Конструктор без параметров.
        /// </summary>
        public Massivvi()
        {
            this._n = 10;
        }
        public int Arrlength
        {
            get
            {
                return _n;
            }
            set
            {
                _n = value;
            }
        }
        /// <summary>
        /// Заполнение массива случайными элементами.
        /// </summary>
        /// <param name="n">Длина массива.</param>
        /// <param name="arr">Массив.</param>
        /// <returns></returns>
        public int[] Granitca(int _n)
        {
            int[] arr = new int[_n];
            Random rnd = new Random();
            //int x = Perevod.ReadNumber("Введите минимальную границу диапазона: ");
            //int y = Perevod.ReadNumber("Введите максимальную границу диапазона: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-10,10);
            }
            return arr;
        }
        /// <summary>
        /// Запуск алгоритма выполнения лабораторной работы 4.
        /// </summary>
        /// <param name="arr">Массив.</param>
        /// <param name="arr1">Жалкая копия номер 1.</param>
        /// <param name="arr2">Жалкая копия номер 2.</param>
        public void f5()
        {
            int[] arr = Granitca(_n);
            Vyvod(arr, "Исходный массив:");
            Vremya(arr);
        }
        private void Vremya(int[] arr)
        {
            Stopwatch SortCount = new Stopwatch();
            SortCount.Start();
            int[] arr1 = Copya(arr);
            PuzyriokSortReal(arr1);
            SortCount.Stop();
            TimeSpan sort1 = SortCount.Elapsed;
            SortCount.Start();
            int[] arr2 = Copya(arr);
            VstavkaSortReal(arr2);
            SortCount.Stop();
            TimeSpan sort2 = SortCount.Elapsed;

            if (sort1 > sort2)
            {
                Console.WriteLine("Сортировка Пузырьком была быстрее");
            }
            else
            {
                Console.WriteLine("Сортировка Вставкой была быстрее");
            }
        }
        /// <summary>
        /// Вывод элементов массива.
        /// </summary>
        /// <param name="a">Массив.</param>
        /// <param name="ind">Элемент массива.</param>
        private static void Vyvod(int[] arr, string ind)
        {
            Console.WriteLine(ind);
            foreach (int i in arr)
                Console.Write($"{i} ");
            Console.WriteLine();
        }
        /// <summary>
        /// Копирование массива.
        /// </summary>
        /// <param name="arr">Массив.</param>
        /// <returns></returns>
        public int[] Copya(int[] arr)
        {
            int[] Clon = new int[arr.Length];
            for (int i = 0; i < Clon.Length; i++)
            {
                Clon[i] = arr[i];
            }
            return Clon;
        }
        /// <summary>
        /// Сортировка "пузырьком" - реализация.
        /// </summary>
        /// <param name="arrayClon">Массив.</param>
        private void PuzyriokSortReal(int[] arrayClon)
        {
            string str = "Гэнг бэнг";
            Console.Write("Сортировкка пузырьком: ");
            str = string.Join(", ", PuzyriokSort(arrayClon));
            Console.WriteLine(str);
        }
        /// <summary>
        /// Сортировка "пузырьком" - код.
        /// </summary>
        /// <param name="array">Массив.</param>
        public int[] PuzyriokSort(int[] arr)
        {
            for (int x = 1; x < arr.Length; x++)
            {
                for (int y = 0; y < arr.Length - x; y++)
                {
                    if (arr[y] > arr[y + 1])
                    {
                        Swap(ref arr[y], ref arr[y + 1]);
                    }
                }
            }
            return arr;
        }
        /// <summary>
        /// Техника смены элементов массива.
        /// </summary>
        /// <param name="x1">Переменная 1.</param>
        /// <param name="x2">Переменная 2.</param>
        private void Swap(ref int x1, ref int x2)
        {
            int e = x1;
            x1 = x2;
            x2 = e;
        }
        /// <summary>
        /// Сортировка "вставками" - реализация.
        /// </summary>
        /// <param name="arrayClon">Массив.</param>
        private void VstavkaSortReal(int[] arrayClon)
        {
            string str = "Гэнг бэнг";
            Console.Write("Сортировкка вставкой: ");
            str = string.Join(", ", VstavkaSort(arrayClon));
            Console.WriteLine(str);
        }
        /// <summary>
        /// Сортировка "вставками" - код.
        /// </summary>
        /// <param name="array">Массив.</param>
        public int[] VstavkaSort(int[] array)
        {
            for (int x = 1; x < array.Length; x++)
            {
                int key = array[x];
                int y = x;
                while ((y > 0) && (array[y - 1] > key))
                {
                    Swap(ref array[y - 1], ref array[y]);
                    y--;
                }

                array[y] = key;
            }
            return array;
        }
    }
}
