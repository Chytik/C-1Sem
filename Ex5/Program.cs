using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Подготовка_5._1
{
    class Polynom
    {
        public int[] _koef;
        public int[] Koef { get { return _koef; } }
        public int Step { get { return _koef.Length - 1; } }
        public Polynom() { _koef = new int[] { -3, 2, 1 }; }
        public Polynom(int[] arr) {  _koef = arr; }
        public void Mul(int num)
        {
            for (int i = 0; i < _koef.Length; i++) _koef[i] *= num;
        }
        public void Add(int[] koef)
        {
            int[] arr = new int[(_koef.Length <= koef.Length ? koef.Length : _koef.Length)];//создаем массив, делаем длину равной длине массива с максимальным кол-ом коэф-ов.
            for (int i = 0; i < arr.Length; i++) arr[i] = (i < koef.Length ? koef[i] : 0) + (i < _koef.Length ? _koef[i] : 0);//Проходя по длине большего массива складываем все элементы, если в каком-то массиве они заканчиваются, то вместо них прибавляется 0.
            if (_koef.Length <= koef.Length) _koef = new int[koef.Length];//если длина поля массива была меньше входного параметра, то она увеличивается до длины входного параметра.
            for (int i = 0; i < _koef.Length; i++) _koef[i] = arr[i];//Каждый элемент из вспомогательного массива переносим в массив поля.
        }
        public double Val(int x)
        {
            double result = 0;
            for (int i = 0; i < _koef.Length; i++) result += _koef[i] * Math.Pow(x, i);//каждый коэф-нт умножаем на значение х, возведенное в степень, значение которой равно i.
            return result;
        }
        public double Prod(int x)
        {
            double result = 0;
            for (int i = 1; i < _koef.Length; i++) result += _koef[i] * i * Math.Pow(x, i - 1);//каждый коэф-нт умножаем на степень, умножаем на значение х, возведенное в степень, значение которой равно i-1. Это производная.
            return result;
        }
        public void Print()
        {
            Console.Write("результат: ");
            for(int i = _koef.Length - 1; i > -1; i--)
            {
                if (_koef[i] == 0) continue;//если коэф-нт равен 0, то итерация цикла пропускается.
                else if (_koef[i] > 0 && i != _koef.Length - 1) Console.Write($"+{_koef[i]}x^{i}");
                else Console.Write($"{_koef[i]}x^{i}");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {        
            Polynom polynom = new Polynom();
            Polynom polynom1 = new Polynom(new int[] {0, -1, 0, -1});
            polynom.Mul(2);
            polynom.Add(polynom1.Koef);
            polynom.Print();
            Console.WriteLine();
            Console.WriteLine(polynom.Prod(2));
        }
    }
}
