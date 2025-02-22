using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Лаба_новый_уровень
{
    internal class Igra
    {
        private int s;
        private int a;
        private string[,] x =
        {
{" "," "," "," "},
{" "," "," "," "},
{" "," "," "," "},
{" "," "," "," "},
    };
        private void Pole()
        {
            Console.WriteLine("   1      2     3      4  ");
            Console.WriteLine("       |     |     |      ");
            Console.WriteLine("1    {0} |  {1}  |  {2}  |  {3}", x[0, 0], x[0, 1], x[0, 2], x[0, 3]);
            Console.WriteLine("  _____|_____|_____|_____ ");
            Console.WriteLine("       |     |     |      ");
            Console.WriteLine("2    {0} |  {1}  |  {2}  |  {3}", x[1, 0], x[1, 1], x[1, 2], x[1, 3]);
            Console.WriteLine("  _____|_____|_____|_____ ");
            Console.WriteLine("       |     |     |      ");
            Console.WriteLine("3    {0} |  {1}  |  {2}  |  {3}", x[2, 0], x[2, 1], x[2, 2], x[2, 3]);
            Console.WriteLine("  _____|_____|_____|_____ ");
            Console.WriteLine("       |     |     |      ");
            Console.WriteLine("4    {0} |  {1}  |  {2}  |  {3}", x[3, 0], x[3, 1], x[3, 2], x[3, 3]);
            Console.WriteLine("       |     |     |      ");
        }
        private int Victoria()
        {
            if (x[0, 0] == x[0, 1] && x[0, 1] == x[0, 2] && x[0, 0] != " " && x[0, 1] != " " && x[0, 2] != " ") s = 1;
            else if (x[0, 1] == x[0, 2] && x[0, 2] == x[0, 3] && x[0, 1] != " " && x[0, 2] != " " && x[0, 3] != " ") s = 1;
            else if (x[0, 0] == x[1, 0] && x[1, 0] == x[2, 0] && x[0, 0] != " " && x[1, 0] != " " && x[2, 0] != " ") s = 1;
            else if (x[1, 0] == x[2, 0] && x[2, 0] == x[3, 0] && x[1, 0] != " " && x[2, 0] != " " && x[3, 0] != " ") s = 1;
            else if (x[1, 0] == x[1, 1] && x[1, 1] == x[1, 2] && x[1, 0] != " " && x[1, 1] != " " && x[1, 2] != " ") s = 1;
            else if (x[1, 1] == x[1, 2] && x[1, 2] == x[1, 3] && x[1, 1] != " " && x[1, 2] != " " && x[1, 3] != " ") s = 1;
            else if (x[0, 1] == x[1, 1] && x[1, 1] == x[2, 1] && x[0, 1] != " " && x[1, 1] != " " && x[2, 1] != " ") s = 1;
            else if (x[1, 1] == x[2, 1] && x[2, 1] == x[3, 1] && x[1, 1] != " " && x[2, 1] != " " && x[3, 1] != " ") s = 1;
            else if (x[2, 0] == x[2, 1] && x[2, 1] == x[2, 2] && x[2, 0] != " " && x[2, 1] != " " && x[2, 2] != " ") s = 1;
            else if (x[2, 1] == x[2, 2] && x[2, 2] == x[2, 3] && x[2, 1] != " " && x[2, 2] != " " && x[2, 3] != " ") s = 1;
            else if (x[0, 2] == x[1, 2] && x[1, 2] == x[2, 2] && x[0, 2] != " " && x[1, 2] != " " && x[2, 2] != " ") s = 1;
            else if (x[1, 2] == x[2, 2] && x[2, 2] == x[3, 2] && x[1, 2] != " " && x[2, 2] != " " && x[3, 2] != " ") s = 1;
            else if (x[0, 3] == x[1, 3] && x[1, 3] == x[2, 3] && x[0, 3] != " " && x[1, 3] != " " && x[2, 3] != " ") s = 1;
            else if (x[1, 3] == x[2, 3] && x[2, 3] == x[3, 3] && x[1, 3] != " " && x[2, 3] != " " && x[3, 3] != " ") s = 1;
            else if (x[3, 0] == x[3, 1] && x[3, 1] == x[3, 2] && x[3, 0] != " " && x[3, 1] != " " && x[3, 2] != " ") s = 1;
            else if (x[3, 1] == x[3, 2] && x[3, 2] == x[3, 3] && x[3, 1] != " " && x[3, 2] != " " && x[3, 3] != " ") s = 1;
            else if (x[0, 2] == x[1, 1] && x[1, 1] == x[2, 0] && x[0, 2] != " " && x[1, 1] != " " && x[2, 0] != " ") s = 1;
            else if (x[0, 3] == x[1, 2] && x[1, 2] == x[2, 1] && x[0, 3] != " " && x[1, 2] != " " && x[2, 1] != " ") s = 1;
            else if (x[1, 2] == x[2, 1] && x[2, 1] == x[3, 0] && x[1, 2] != " " && x[2, 1] != " " && x[3, 0] != " ") s = 1;
            else if (x[1, 3] == x[2, 2] && x[2, 2] == x[3, 1] && x[1, 3] != " " && x[2, 2] != " " && x[3, 1] != " ") s = 1;
            else if (x[0, 1] == x[1, 2] && x[1, 2] == x[2, 3] && x[0, 1] != " " && x[1, 2] != " " && x[2, 3] != " ") s = 1;
            else if (x[0, 0] == x[1, 1] && x[1, 1] == x[2, 2] && x[0, 0] != " " && x[1, 1] != " " && x[2, 2] != " ") s = 1;
            else if (x[1, 1] == x[2, 2] && x[2, 2] == x[3, 3] && x[1, 1] != " " && x[2, 2] != " " && x[3, 3] != " ") s = 1;
            else if (x[1, 0] == x[2, 1] && x[2, 1] == x[3, 2] && x[1, 0] != " " && x[2, 1] != " " && x[3, 2] != " ") s = 1;
            else if (x[0, 0] != " " && x[0, 1] != " " && x[0, 2] != " " && x[0, 3] != " " && x[1, 0] != " " && x[1, 1] != " " && x[1, 2] != " " && x[1, 3] != " " && x[2, 0] != " " && x[2, 1] != " " && x[2, 2] != " " && x[2, 3] != " " && x[3, 0] != " " && x[3, 1] != " " && x[3, 2] != " " && x[3, 3] != " ") s = 2;
            else s = 0;
            return s;
        }
        public void f6()
        {
            Console.WriteLine("Кто крестики, а кто нолики? Определитесь и нажмите любую клавишу");
            Console.ReadKey();
            Random rnd = new Random();
            int igrok = rnd.Next(1, 3);
            if (igrok == 1) Console.WriteLine("Первые ходят крестики");
            else Console.WriteLine("Первые ходят нолики");
            while (a != 1 && a != 2)
            {
                Pole();
                Console.WriteLine("Введите номер строки и столбца");
                if (igrok == 1)
                {
                    Console.WriteLine("Ход крестиков");
                    int X = Perevod.ReadNumber("Строка: ") - 1;
                    int Y = Perevod.ReadNumber("Столбец: ") - 1;
                    if (X < 0 || X > 4 || Y < 0 || Y > 4)
                    {
                        Console.WriteLine("Ошибка, попробуйте еще раз: ");
                        Console.ReadLine();
                    }
                    if (x[X, Y] != "X" && x[X, Y] != "O")
                    {
                        x[X, Y] = "X";
                        igrok = 0;
                    }
                    else if (x[X, Y] == "X" || x[X, Y] == "O")
                    {
                        Console.WriteLine("Ошибка, попробуйте еще раз");
                        igrok = 1;
                    }
                }
                else
                {
                    Console.WriteLine("Ход ноликов");
                    int Z = Perevod.ReadNumber("Строка: ") - 1;
                    int W = Perevod.ReadNumber("Столбец: ") - 1;
                    if (W < 0 || W > 4 || Z < 0 || Z > 4)
                    {
                        Console.WriteLine("Ошибка, попробуйте еще раз: ");
                        Console.ReadLine();
                    }
                    if (x[Z, W] != "X" && x[Z, W] != "O")
                    {
                        x[Z, W] = "O";
                        igrok = 1;
                    }
                    else if (x[Z, W] == "X" || x[Z, W] == "O")
                    {
                        Console.WriteLine("Ошибка, попробуйте еще раз");
                        igrok = 1;
                    }
                }
                a = Victoria();
                Console.ReadKey();
                Console.Clear();
                Pole();
                Console.Clear();
            }
            if (igrok == 0 && a == 1) Console.WriteLine("Выиграли крестики");
            else if (a == 2) Console.WriteLine("Ничья");
            else Console.WriteLine("Выиграли нолики");
            Console.ReadLine();
        }
    }
}
