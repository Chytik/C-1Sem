using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Лаба_новый_уровень
{
    internal class SlovaDva
    {
        private readonly string stroka1;
        private readonly string stroka2;
        private string str5 = "Быть может, вся природа - мозаика цветов?";
        private string str6 = "Быть может, вся природа - различность голосов?";
        public SlovaDva()
        {
            this.stroka1 = str5;
            this.stroka2 = str6;
        }
        public SlovaDva(string str3, string str4)
        {
            this.stroka1 = str3;
            this.stroka2 = str4;
        }
        public void f71()
        {
            Console.WriteLine("Сравним строки.");
            int i0 = 0;
            i0 = Sravnenie1(stroka1, stroka2);
            Console.WriteLine($"Количество первых совпадающих символов {i0}");
        }
        public static string proverka1(int p, string stroka1)
        {
            p = Perevod.ReadNumber("Выберете способ. 1. Ввод пользователя. 2. Тестовый ввод: ");
            if (p == 1)
            {
                Console.WriteLine("Введите строку1: ");
                stroka1 = Console.ReadLine();
            }
            if (p == 2)
            {
                stroka1 = "Быть может, вся природа - мозаика цветов?";
                Console.WriteLine(stroka1);
            }
            return stroka1;
        }
        public static string proverka2(int p, string stroka2)
        {
            p = Perevod.ReadNumber("Выберете способ. 1. Ввод пользователя. 2. Тестовый ввод: ");
            if (p == 1)
            {
                Console.WriteLine("Введите строку2: ");
                stroka2 = Console.ReadLine();
            }
            if (p == 2)
            {
                stroka2 = "Быть может, вся природа - различность голосов?";
                Console.WriteLine(stroka2);
            }
            return stroka2;
        }
        private int Sravnenie1(string stroka1, string stroka2)
        {
            int p = 0;
            stroka1 = proverka1(p, str5);
            stroka2 = proverka2(p, str6);
            int res = 0;
            for (int i = 0; i < stroka1.Length && i < stroka2.Length; i++)
            {
                if (stroka1[i] == stroka2[i]) res++;
                if (stroka1[i] != stroka2[i]) break;
            }
            return res;
        }
    }
}
