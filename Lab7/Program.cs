using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Лаба_новый_уровень
{
    internal class Program
    {
        public static void f2() { Console.WriteLine("Фойт Максим Вячеславович. Группа 6102-090301."); }
        public static bool f3()
        {
            bool goout = false;
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
                else Console.WriteLine("Ошибка, попробуйте еще раз");
            }
            return goout;
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
                Console.WriteLine("6. Крестики нолики 4х4");
                Console.WriteLine("7. Посчитаем гласные и согласные в строке");
                int number = Perevod.ReadNumber("Введите число от 1 до 7: ");
                switch (number)
                {
                    case 1:
                        Primer.f1();
                        break;
                    case 2:
                        f2();
                            break;
                    case 3:
                        goout = f3();
                            break;
                    case 4:
                        Primer.f4();
                        break;
                    case 5:
                        Massivvi massivvi = new Massivvi();
                        massivvi.f5();
                            break;
                    case 6:
                        Igra igra = new Igra();
                        igra.f6();
                        break;
                    case 7:
                        Slova slovo1 = new Slova();
                        slovo1.f7();
                        SlovaDva slovo2 = new SlovaDva();
                        slovo2.f71();
                        break;
                }
            }

        }
    }
}
