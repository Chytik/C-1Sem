using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _7_Лаба_новый_уровень
{
    internal class Massivvi
    {
        private int _n;
        private int[] arr;
        public Massivvi(int n) { this._n = n; }
        public Massivvi() { this._n = 10; }
        public int Arrlength
        {
            get { return _n; }
            set { _n = value; }
        }
        public int[] Granitca(int[] arr)
        {
            Random rnd = new Random();
            int x = Perevod.ReadNumber("Введите минимальную границу диапазона: ");
            int y = Perevod.ReadNumber("Введите максимальную границу диапазона: ");
            for (int i = 0; i < arr.Length; i++) arr[i] = rnd.Next(x, y);
            return arr;
        }
        public static int Dlina()
        {
            int _n = 0;
            bool ex = true;
            while (ex)
            {
                _n = Perevod.ReadNumber("Введите количество элементов массива: ");
                if (_n < 1)
                {
                    Console.WriteLine("Ошибка, попробуйте еще раз: ");
                    ex = true;
                }
                else if (_n > 100)
                {
                    Console.WriteLine("Ой,а давайте чуть меньше(меньше 100)");
                    ex = true;
                }
                else ex = false;
            }
            return _n;
        }
        public void f5()
        {
            Vybor();
            int Option = Perevod.ReadNumber("Введите число: ");
            if (Option == 1)
            {
                arr = new int[Dlina()];
                arr = Granitca(arr);
                Vyvod(arr, "Исходный массив:");
                Vremya(arr);
            }
            else if(Option == 2) 
            {
                arr = new int[_n];
                arr = Granitca(arr);
                Vyvod(arr, "Исходный массив:");
                Vremya(arr);
            }
            else Console.WriteLine("Введите 1 или 2!");
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

            if (sort1 > sort2) Console.WriteLine("Сортировка Пузырьком была быстрее");
            else Console.WriteLine("Сортировка Вставкой была быстрее");
        }
        private void Vyvod(int[] arr, string ind)
        {
            Console.WriteLine(ind);
            foreach (int i in arr) Console.Write($"{i} ");
            Console.WriteLine();
        }
        private static int[] Copya(int[] arr)
        {
            int[] Clon = new int[arr.Length];
            for (int i = 0; i < Clon.Length; i++) Clon[i] = arr[i];
            return Clon;
        }
        private void PuzyriokSortReal(int[] arrayClon)
        {
            string str = "Гэнг бэнг";
            Console.Write("Сортировкка пузырьком: ");
            str = string.Join(", ", PuzyriokSort(arrayClon));
            Console.WriteLine(str);
        }
        private int[] PuzyriokSort(int[] arr)
        {
            int len = arr.Length;
            for (int x = 1; x < len; x++)
            {
                for (int y = 0; y < len - x; y++)
                {
                    if (arr[y] > arr[y + 1]) Swap(ref arr[y], ref arr[y + 1]);
                }
            }
            return arr;
        }
        private void Swap(ref int x1, ref int x2)
        {
            int e = x1;
            x1 = x2;
            x2 = e;
        }
        private void VstavkaSortReal(int[] arrayClon)
        {
            string str = "Гэнг бэнг";
            Console.Write("Сортировкка вставкой: ");
            str = string.Join(", ", VstavkaSort(arrayClon));
            Console.WriteLine(str);
        }
        private int[] VstavkaSort(int[] array)
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
        private void Vybor()
        {
            Console.WriteLine("Введите спопоб заполнения массива:");
            Console.WriteLine("1 - Заполнение массива случайными числами с заданием кол-ва элементов и границ");
            Console.WriteLine("2 - использование массива с фиксированной длинной");
        }
    }
}
