using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Лаба_новый_уровень
{
    public static class Perevod
    {
        public static int ReadNumber(string str)
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
    }
}
