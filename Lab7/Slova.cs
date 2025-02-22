using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Лаба_новый_уровень
{
    internal class Slova
    {
        private string str1;
        private const string stroka = "Варкалось. Хливкие шорьки.Пырялись по наве, И хрюкотали зелюки, Как мюмзики в мове.О бойся Бармаглота, сын!Он так свирлеп и дик, А в глуще рымит исполин - Злопастный Брандашмыг";
        public Slova(string str2) { this.str1 = str2; }
        public Slova() { this.str1 = stroka; }
        public void f7()
        {
            int a0 = 0;
            a0 = Glasnye1();
            Console.WriteLine($"Количество гласных: {a0}");
            int b0 = 0;
            b0 = Soglasnye1();
            Console.WriteLine($"Количество согласных: {b0}");
            int c0 = 0;
            c0 = Znaki1();
            Console.WriteLine($"Количество знаков препинапинания: {c0}");
            int d0 = 0;
            d0 = Slova1();
        }
        public static string proverka(int p, string str1)
        {
            p = Perevod.ReadNumber("Выберете способ. 1. Ввод пользователя. 2. Тестовый ввод: ");
            if (p == 1)
            {
                Console.WriteLine("Введите строку: ");
                str1 = Console.ReadLine();
            }
            if (p == 2)
            {
                str1= "Варалось, хлипкие шорьки Пырялись по наве, И хрюали зелюки, Как мюмзии в мове. О бойся Бармаглота, сын! Он так свиреп и дик, А в глуще римит исполин - Злопастный Брандашмыг.";
                Console.WriteLine(str1);
            }
            return str1;
        }
        private int Glasnye1()
        {
            int p = 0;
            string stroka = proverka(p, str1);
            List<char> Gl = new List<char> { 'У', 'у', 'Е', 'е', 'Ё', 'ё', 'Ы', 'ы', 'А', 'а', 'О', 'о', 'Э', 'э', 'Я', 'я', 'И', 'и', 'Ю', 'ю' };
            List<char> Gls = new List<char>();
            int Glc = 0;
            foreach (char ch in stroka)
            {
                if (Gl.Contains(ch)) Glc++;
            }
            return Glc;
        }
        private int Soglasnye1()
        {
            int p = 0;
            string stroka = proverka(p, str1);
            List<char> soGl = new List<char> { 'Й', 'й', 'Ц', 'ц', 'К', 'к', 'Н', 'н', 'Г', 'г', 'Ш', 'ш', 'Щ', 'щ', 'З', 'з', 'Х', 'х', 'ъ', 'Ф', 'ф', 'В', 'в', 'П', 'п', 'Р', 'р', 'Л', 'л', 'Д', 'д', 'Ж', 'ж', 'Ч', 'ч', 'С', 'с', 'М', 'м', 'Т', 'т', 'ь', 'Б', 'б' };
            List<char> soGls = new List<char>();
            int soGlc = 0;
            foreach (char ch in stroka)
            {
                if (soGl.Contains(ch)) soGlc++;
            }
            return soGlc;
        }
        private int Znaki1()
        {
            int p = 0;
            string stroka = proverka(p, str1);
            List<char> Gl = new List<char> { '.', ',', '?', '!', '-', ';', ':', '"', '(', ')' };
            List<char> Gls = new List<char>();
            int Glc = 0;
            foreach (char ch in stroka)
            {
                if (Gl.Contains(ch)) Glc++;
            }
            return Glc;
        }
        private int Slova1()
        {
            int p = 0;
            string stroka = proverka(p, str1);
            string[] text;
            text = stroka.Split(' ');
            int counter = 0;
            counter = text.Length;
            return counter;
        }
    }
}
