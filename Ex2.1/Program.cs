using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Подготовка_2_ПМНСХ //Дисклеймер: это вариант для людей, которые ОТЛИЧНО ПОНИМАЮТ, что и зачем они делают. 
{
    public abstract class Shape
    {
        public abstract double Square();
    }
    public class Circle : Shape
    {
        public double Radius { get; set; } //get и set пустые, т.к. с помощью них в задаче мы ничего не получаем и не устанавливаем.
        public Circle(double radius){Radius = radius;}
        public override double Square() { return Math.PI * Math.Pow(Radius, 2); }
    }
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public override double Square() { return Height * Width; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[]
            {
                new Circle(5),
                new Rectangle(3,4),
                new Rectangle(4,5),
                new Circle(2)
            };
            var sortedShapes = shapes.OrderByDescending(shape => shape.Square());
            foreach(var shape in sortedShapes) Console.WriteLine(shape.Square());
        }
    }
}
