using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Подготовка_2
{
    abstract public class Shape//абстрактный класс.
    {
        public abstract double Square();
    }
    public class Circle : Shape//класс Circle наследуется от класса Shape.
    {
        int _radius;
        public Circle() { _radius = 4; }
        public Circle(int radius) { _radius = radius;}
        public int Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }
        public override double Square() { return Math.PI * Math.Pow(_radius, 2); } //Переопределяем метод Square.
    }
    public class Rectangle : Shape//класс Rectangle наследуется от класса Shape.
    {
        int _height;
        int _width;
        public Rectangle() { _height = 2; _width = 2;}
        public Rectangle(int height, int width)
        {
            _height = height;
            _width = width;
        }
        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }
        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }
        public override double Square() { return _height * _width; } //Переопределяем метод Square.
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] shape = new Shape[5];
            Random rnd = new Random();
            for (int i = 0; i < shape.Length; i++)
            {
                int x = rnd.Next(1, 11); // диапазон значений от 0 до 10.
                if (x < 6) shape[i] = new Circle(x);
                else shape[i] = new Rectangle(x, x / 2);
            }
            double[] SQ = new double[shape.Length]; //вспомогательный массив типа  double для корректного получения площади.
            for (int i = 0; i < SQ.Length; i++) SQ[i] = shape[i].Square(); // по факту double = double. Если бы написали shape[i] = shape[i].Square();,то было бы Shape=double, что не правильно.
            for (int j = 0; j< SQ.Length; j++)  //сортировка пузырьком в обратном порядке.
            {
                for(int i = 0; i< SQ.Length - j - 1; i++)
                {
                    if (SQ[i] < SQ[i+1])
                    {
                        double a = SQ[i];
                        SQ[i] = SQ[i + 1];
                        SQ[i + 1] = a;
                    }
                }
            }
            for (int i = 0; i < SQ.Length; i++) Console.WriteLine(SQ[i]);
        }
    }
}
