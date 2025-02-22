using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Подготовка_1
{
    class Student
    {
        string _name;
        int _age;
        int _averageMark;
        public string Name
        {
            get { return _name; }
            set{_name = value;}
        }
        public int Age
        {
            get{ return _age; }
            set { _age = value;}
        }
        public int AverageMark
        {
            get{ return _averageMark;}
            set{ _averageMark = value;}
        }
        public Student()
        {
            _name = "Олег";
            _age = 33;
            _averageMark = 5;
        }
        public Student(string name, int age, int averageMark)
        {
            _name = name;
            _age = age;
            _averageMark = averageMark;
        }
        public void StudentInfo() {Console.WriteLine($"Имя: {_name}; Возраст: {_age}; Средняя оценка: {_averageMark}");}
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] student = new Student[4]; // 1 способ создания массива объектов.
            student[0] = new Student();
            student[1] = new Student("Гена", 42, 2);
            student[2] = new Student("Игорь", 22, 3);
            student[3] = new Student("Макс", 24, 4);
            //Student[] student = new Student[]   // 2 способ создания массива объектов.
            //{
            //    new Student(),
            //    new Student("Гена", 42, 2)
            //};
            for (int i = 0; i< student.Length; i++) student[i].StudentInfo(); //вывод всех студентов.
            double mark = AverageMark(student);
            for(int i = 0; i<student.Length; i++)
            {
                if (student[i].AverageMark>mark) student[i].StudentInfo(); //Вывод студентов с успеваемостью выше среднего балла в группе.
            }
        }
        
        static double AverageMark(Student[] student)  //метод статический, чтобы для вызова не создавать объект класса.
        {
            double mark = 0;
            for(int i = 0; i< student.Length; i++) mark += student[i].AverageMark; 
            mark /= student.Length; 
            return mark;
        }
    }
}
