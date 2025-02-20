using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool goout = false;
            while(goout == false)
            {
                Console.WriteLine("1. Отгадай ответ");
                Console.WriteLine("2. Об авторе");
                Console.WriteLine("3. Выход");
                Console.WriteLine("4. Проверка деления на 0");
                int number = 0;
                bool numberNumber = false;
                Console.Write("Введите число number: ");
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
                        int A = 0;
                        bool ANumber = false;
                        Console.Write("Введите ответ: ");
                        while (ANumber == false)
                        {
                            string AStr = Console.ReadLine();
                            ANumber = int.TryParse(AStr, out A);
                            if (ANumber == false)
                            {
                                Console.Write("Ошибка, попробуйте еще раз: ");
                            }
                        }
                        const double PI = Math.PI;
                        double x = Math.Round(Math.Sin(a) + 1);
                        double y = Math.Round(Math.Pow(Math.Log(b), 5));
                        double z = Math.Round(y / x);
                        double q = Math.Round(PI * z);
                        if (A == q)
                        {
                            Console.WriteLine("Ответ правильный");
                        }
                        else
                        {
                            Console.WriteLine("Ответ неправильный");
                        }
                        Console.WriteLine($"Правильный ответ: {q}");
                        break;                       
                    case 2:
                        Console.WriteLine("Фойт Максим Вячеславович. Группа 6102-090301.");
                        break;
                    case 3:
                        Console.WriteLine("Выйти из программы? Если да, то нажмите 'д', если нет, то введите'н': ");
                        string exit = Console.ReadLine();
                        if (exit == "д")
                        {
                            goout = true;
                        }
                        else if (exit == "н")
                        {
                            goout = false;
                        }
                        else
                        {
                            Console.WriteLine("Ошибка, попробуйте еще раз");
                        }
                        break;
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
                        catch(DivideByZeroException)
                        {
                            Console.WriteLine("Деление на ноль!");
                        }
                        break;
                }
            }
        }
    }
}
