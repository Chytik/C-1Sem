using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Лаба_новый_уровень
{
    public static class Primer
    {
        public static void f1()
        {
            Console.WriteLine("Чему равно значение функции: f=PI(ln(b)^5/(sin(a)+1))?");
            int b = Perevod.ReadNumber("Введите число b: ");
            int a = Perevod.ReadNumber("Введите число a: ");
            double q = Result1(b, a);
            Result2(q);
        }
        public static double Result1(int b, int a)
        {
            const double PI = Math.PI;
            double x = Math.Round(Math.Sin(a) + 1);
            double y = Math.Round(Math.Pow(Math.Log(b), 5));
            double z = Math.Round(y / x);
            double q = Math.Round(PI * z);
            return q;
        }
        public static double Result2(double q)
        {
            for (int num = 2; num > -1; --num)
            {
                int d = Perevod.ReadNumber("Введите ответ");
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
        public static void f4()
        {
            Console.WriteLine("Чему равно значение функции: f=m/n?");
            int m = Perevod.ReadNumber("Введите число m: ");
            int n = Perevod.ReadNumber("Введите число n: ");
            int r = Result11(m, n);
        }
        private static int Result11(int m, int n)
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
    }
}
