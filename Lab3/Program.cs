using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool goout = false;
            while (goout == false)
            {
                Console.WriteLine("1. Отгадай ответ");
                Console.WriteLine("2. об авторе");
                Console.WriteLine("3. Выход");
                Console.WriteLine("4. Проверка деления на 0");
                int number = 0;
                bool numberNumber = false;
                Console.Write("Введите число от 1 до 4: ");
                while (numberNumber == false)
                {
                    string numberStr = Console.ReadLine();
                    numberNumber = int.TryParse(numberStr, out number);
                    if (numberNumber == false)
                    {
                        Console.Write("Ошибка, попробуйте еще раз: ");
                    }
                }
                switch (number)
                {
                    case 1:
                        Console.WriteLine("Чему равно значение функции: f=PI(ln(b)^5/(sin(a)+1))?");
                        int b = 0;
                        bool bNumber = false;
                        Console.Write("Введите число b: ");
                        while (bNumber == false)
                        {
                            string bStr = Console.ReadLine();
                            bNumber = int.TryParse(bStr, out b);
                            if (bNumber == false)
                            {
                                Console.Write("Ошибка, попробуйте еще раз: ");
                            }
                        }
                        int a = 0;
                        bool aNumber = false;
                        Console.Write("Введите число a: ");
                        while (aNumber == false)
                        {
                            string aStr = Console.ReadLine();
                            aNumber = int.TryParse(aStr, out a);
                            if (aNumber == false)
                            {
                                Console.Write("Ошибка, попробуйте еще раз: ");
                            }
                        }
                        const double PI = Math.PI;
                        double x = Math.Round(Math.Sin(a) + 1);
                        double y = Math.Round(Math.Pow(Math.Log(b), 5));
                        double z = Math.Round(y / x);
                        double q = Math.Round(PI * z);
                        for (int num = 2; num > -1; --num)
                        {
                            Console.Write("Введите ответ: ");
                            int d = 0;
                            bool dNumber = false;
                            while (dNumber == false)
                            {
                                string dStr = Console.ReadLine();
                                dNumber = int.TryParse(dStr, out d);
                                if (dNumber == false)
                                {
                                    Console.Write("Ошибка, попробуйте еще раз: ");
                                }
                            }
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
                        break;
                    case 2:
                        Console.WriteLine("Фойт Максим Вячеславович. Группа 6102-090301.");
                        break;
                    case 3:
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
                        
                        break;
                    case 4:
                        Console.WriteLine("Чему равно значение функции: f=m/n?");
                        int m = 0;
                        bool mNumber = false;
                        Console.Write("Введите число m: ");
                        while (mNumber == false)
                        {
                            string mStr = Console.ReadLine();
                            mNumber = int.TryParse(mStr, out m);
                            if (mNumber == false)
                            {
                                Console.Write("Ошибка, попробуйте еще раз: ");
                            }
                        }
                        int n = 0;
                        bool nNumber = false;
                        Console.Write("Введите число n: ");
                        while (nNumber == false)
                        {
                            string nStr = Console.ReadLine();
                            nNumber = int.TryParse(nStr, out n);
                            if (nNumber == false)
                            {
                                Console.Write("Ошибка, попробуйте еще раз: ");
                            }
                        }
                        try
                        {
                            int r = m / n;
                            Console.WriteLine($"Правильный ответ: {r}");
                        }
                        catch (DivideByZeroException)
                        {
                            Console.WriteLine("Деление на 0!");
                        }
                        break;
                }
            }
        }
    }         
   } 
