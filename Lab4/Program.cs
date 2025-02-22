using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_4ю2
{
    internal class Program
    {
        static int ReadNumber(string str)
        {
            int Chislo = 0;
            bool ChisloNumber = false;
            Console.Write(str);
            while (ChisloNumber == false)
            {
                ChisloNumber = int.TryParse(Console.ReadLine(), out Chislo);
                if (ChisloNumber == false)
                {
                    Console.Write("Ошибка, попробуйте еще раз: ");
                }
            }
            return Chislo;
        }
        static void f1()
        {
            Console.WriteLine("Чему равно значение функции: f=PI(ln(b)^5/(sin(a)+1))?");
            int b = ReadNumber("Введите число b: ");
            int a = ReadNumber("Введите число a: ");
            double q = Result1(b, a);
            Result2(q);
        }
        static double Result1(int b, int a)
        {
            const double PI = Math.PI;
            double x = Math.Round(Math.Sin(a) + 1);
            double y = Math.Round(Math.Pow(Math.Log(b), 5));
            double z = Math.Round(y / x);
            double q = Math.Round(PI * z);
            return q;
        }
        static double Result2(double q)
        {
            for (int num = 2; num > -1; --num)
            {
                int d = ReadNumber("Введите ответ");
                if (d == q)
                {
                    Console.WriteLine($"Ответ правильный, он действительно равен {q}");
                    num = -1000;
                }
                else
                {
                    if (num > 0)
                    {
                        Console.WriteLine("Ответ неправильный");
                        Console.WriteLine($"Количество оставшихся попыток: {num}");
                        Console.WriteLine("Попробуйте еще раз");
                    }
                    else
                    {
                        Console.WriteLine("Ответ неправильный, попытки кончились");
                        Console.WriteLine($"Правильный ответ был: {q}");
                    }
                }
            }
            return q;
        }
        static void f2()
        {
            Console.WriteLine("Фойт Максим Вячеславович. Группа 6102-090301.");
        }
        static bool f3(bool goout)
        {
            bool exit = true;
            while (exit)
            {
                Console.WriteLine("Вы хотите выйти из программы? Если да, то нажмите 'д', если нет, то нажмите 'н'");
                string answer = Console.ReadLine();
                if (answer == "д")
                {
                    goout = true;
                    exit = false;
                }
                else if (answer == "н")
                {
                    goout = false;
                    exit = false;
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Ошибка, попробуйте еще раз");
                }
            }
            return goout;
        }
        static void f4()
        {
            Console.WriteLine("Чему равно значение функции: f=m/n?");
            int m = ReadNumber("Введите число m: ");
            int n = ReadNumber("Введите число n: ");
            int r = Result11(m, n);
        }
        static int Result11(int m, int n)
        {
            int r = 0;
            try
            {
                r = m / n;
                Console.WriteLine($"Правильный ответ: {r}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Деление на 0!");
            }
            return r;
        }
        static void f5()
        {
            int[] mass = new int[Dlina()];
            mass = Granitca(mass);
            Vyvod(mass, "Исходный массив:");
            int[] mass1 = Copya(mass);
            PuzyriokSort(mass1);
            Vyvod(mass1, "Массив поле сортировки выбором:");
            int[] mass2 = Copya(mass);
            VstavkaSort(mass2);
            Vyvod(mass2, "Массив поле сортировки вставкой:");
            TimeCount(mass);

        }
        static int Dlina()
        {
            int p = 0;
            bool ex = true;
            while (ex)
            {
                p = ReadNumber("Введите количество элементов массива: ");
                if (p < 1)
                {
                    Console.WriteLine(" Ошибка, попробуйте еще раз: ");
                    ex = true;
                }
                else
                {
                    ex = false;
                }
            }
            return p;
        }
        static int[] Granitca(int[] array)
        {
            Random rnd = new Random();
            int x = ReadNumber("Введите минимальный границу диапазона: ");
            int y = ReadNumber("Введите максимальную границу диапазона: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(x, y);
            }
            return array;
        }
        static void Vyvod(int[] a, string ind)
        {
            Console.WriteLine(ind);
            foreach (int i in a)
                Console.Write($"{i} ");
            Console.WriteLine();
        }
        static int[] Copya(int[] arr)
        {
            int[] Clon = new int[arr.Length];
            for (int i = 0; i<Clon.Length; i++)
            {
                Clon[i] = arr[i];
            }
            return Clon;
        }
        static void PuzyriokSortReal(int[] arrayClon)
        {
            string str = "Гэнг бэнг";
            int[] array = Copya(arrayClon);
            Console.Write("Сортировкка пузырьком: ");
            str = string.Join(", ", PuzyriokSort(arrayClon));
            Console.WriteLine(str);
        }
        static void VstavkaSortReal(int[] arrayClon)
        {
            string str = "Гэнг бэнг";
            int[] array = Copya(arrayClon);
            Console.Write("Сортировкка вставкой: ");
            str = string.Join(", ", VstavkaSort(arrayClon));
            Console.WriteLine(str);
        }
        static void Swap(ref int x1, ref int x2)
        {
            int e = x1;
            x1 = x2;
            x2 = e;
        }
        static int[] PuzyriokSort(int[] array)
        {
            int len = array.Length;
            for (int x = 1; x<len; x++)
            {
                for (int y = 0; y < len - x; y++)
                {
                    if (array[y] > array[y + 1])
                    {
                        Swap(ref array[y], ref array[y + 1]);
                    }
                }
            }

            return array;
        }
        static int[] VstavkaSort(int[] array)
        {
            for (int x = 1; x<array.Length; x++)
            {
                int key = array[x];
                int y = x;
                while ((y>0) && (array[y - 1] > key))
                {
                    Swap(ref array[y - 1], ref array[y]);
                    y--;
                }

                array[y] = key;
            }

            return array;
        }
        static void TimeCount(int[] testarr)
        {
            Stopwatch SortCount = new Stopwatch();
            SortCount.Start();
            int[] arr1 = Copya(testarr);
            PuzyriokSortReal(arr1);
            SortCount.Stop();
            TimeSpan sort1 = SortCount.Elapsed;

            SortCount.Start();
            int[] arr2 = Copya(testarr);
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



        static void Main(string[] args)
        {
            bool goout = false;
            while (goout == false)
            {
                Console.WriteLine("1. Отгадай ответ");
                Console.WriteLine("2. об авторе");
                Console.WriteLine("3. Выход");
                Console.WriteLine("4. Проверка деления на 0");
                Console.WriteLine("5. Задание массива, сортировка пузырьком, сортировка вставкой, сравнение времени сортировок");
                int number = ReadNumber("Введите число от 1 до 5: ");
                switch (number)
                {
                    case 1:
                        f1();
                        break;
                    case 2:
                        f2();
                        break;
                    case 3:
                        goout = f3(goout);
                        break;
                    case 4:
                        f4();
                        break;
                    case 5:
                        f5();
                        break;

                }
            }
        }
    }
}
