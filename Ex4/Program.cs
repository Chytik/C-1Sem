using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Подготовка_4._1
{
    class Money
    {
        ulong _rub;
        byte _cop;
        public Money(ulong rub, byte cop)
        {
            _rub = rub;
            if (cop > 99) Console.WriteLine("Ошибка");
            else _cop = cop;
        }
        public ulong Rub { get { return _rub; } }
        public byte Cop { get { return _cop; } }
        public override string ToString()//override, потому что метод не создается, а переопределяется, т.е. он уже существует, мы переделываем его под себя.
        {
            string a;
            if (_cop / 10 != 0) a = Rub + "," + _cop;
            else a = _rub + ",0" + _cop;
            return a;
        }
        public static Money operator +(Money m1, Money m2)//методы с операторами всегда статические
        {
            ulong rubles = m1._rub + m2._rub;
            byte kopeks = (byte)(m1._cop + m2._cop);
            if (kopeks >= 100)
            {
                rubles++;
                kopeks -= 100;
            }
            return new Money(rubles, kopeks);
        }
        public static Money operator -(Money m1, Money m2)
        {
            if (m1._rub < m2._rub || (m1._rub == m2._rub && m1._cop < m2._cop)) Console.WriteLine("Ошибка!");
            ulong rubles = m1._rub - m2._rub;
            byte kopeks = (byte)(m1._cop - m2._cop);
            if (kopeks < 0)
            {
                rubles--;
                kopeks += 100;
            }
            return new Money(rubles, kopeks);
        }
        public static Money operator *(Money m1, double number)
        {
            if (number < 0) throw new Exception("Ошибка");

                ulong rubles = (ulong)(m1._rub * number);
                byte kopeks = (byte)(m1._cop * number);
                if (kopeks >= 100)
                {
                    rubles += (ulong)kopeks / 100;// целая часть от деления копеек на 100 добавляется к рублям.
                    kopeks %= 100;//копейки равны остатку деления на 100.
                }
            return new Money(rubles, kopeks);
        }
        public static Money operator /(Money m1, double number)
        {
            if (number <= 0) throw new Exception("Ошибка");
            ulong rubles = (ulong)(m1._rub / number);
            byte kopeks = (byte)(m1._cop / number);
            return new Money(rubles, kopeks);
        }
        public static bool operator ==(Money m1, Money m2) { return m1._rub == m2._rub && m1._cop == m2._cop; }
        public static bool operator !=(Money m1, Money m2) { return !(m1 == m2); }
        public static bool operator <(Money m1, Money m2) { return m1._rub < m2._rub || (m1._rub == m2._rub && m1._cop < m2._cop);}
        public static bool operator >(Money m1, Money m2) { return m1._rub > m2._rub || (m1._rub == m2._rub && m1._cop > m2._cop); }
        public static bool operator <=(Money m1, Money m2) { return !(m1 > m2); }
        public static bool operator >=(Money m1, Money m2) { return m1 > m2 || m1 == m2; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Money money1 = new Money(5, 45);
            Money money2 = new Money(7, 62);
            Money moneyresult = (money1 * 2 + money2) / 2;
            Console.WriteLine($"({money1}*2+{money2})/2 = {moneyresult}");//метод ToString вызывается автоматически.
        }
    }
    
}
