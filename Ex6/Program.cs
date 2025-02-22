using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Подготовка_6
{
    class Collection
    {
        double[] array;
        public Collection() { array = new double[] { 0, 2, 4 }; }
        public Collection(int n) { array = new double[] { 2, 0, 5 }; }
        public int Count { get { return array.Length; } }
        public double this[int i]
        {
            get { return array[i]; }
            set { array[i] = value; }
        }
        public void IndexEnd(double a)
        {
            Array.Resize(ref array, Count + 1); //ref нужен, чтобы массив сохранил изменения, которые были произведены с ним в рамках метода.
            array[Count - 1] = a;
        }
        public void IndexMass(double a, int index)//добавление элемента на определенную позицию в массиве.
        {
            if (index > Count || index < 0) throw new Exception("Ошибка");
            double[] arr = new double[Count + 1];//создание вспомогательного массива с длинной массива поля, увеличенной на 1.
            for (int i = 0; i < index; i++) arr[i] = array[i];// копирование во вспомогательный массив элементы массива поля вплоть до индекса, который является входным параметром. 
            arr[index] = a;// присваивания нового элемента(а) на соответствующую позицию(index) вспомогательного массива.
            for (int i = index; i < Count; i++) arr[i + 1] = array[i];//начиная с позиции index(для вспомогательного массива позиции index + 1) копируем все элементы из массива поля во вспомогательный массив.
            array = arr;// присваиваем массиву поля вспомогательный массив.
        }
        public void Remove(int index)//удаление элемента из определенной позиции.
        {
            if (index > Count || index < 0) throw new Exception("Ошибка");
            double[] arr = new double[Count - 1];//создание вспомогательного массива с длинной массива поля, уменьшенной на 1.
            for (int i = 0; i < index; i++) arr[i] = array[i];// копирование во вспомогательный массив элементы массива поля вплоть до индекса, который является входным параметром. 
            for (int i = index + 1; i < Count; i++) arr[i-1] = array[i];//начиная с позиции index+1(для вспомогательного массива позиции index - 1) копируем все элементы из массива поля во вспомогательный массив.
            array = arr;// присваиваем массиву поля вспомогательный массив.
        }
        public void Sum(Collection a)//сумма массивов.
        {
            if (Count < a.Count)
            {
                double[] arr = new double[a.Count];//создаем вспомогательный массив большей длины.
                for (int i = 0; i < Count; i++) arr[i] = array[i] + a.array[i];//Счетчик до значения длины меньшего массива. Сумма элементов маасивов передается во вспомогательный.
                for (int i = Count; i < a.Count; i++) arr[i] = a.array[i];//Счетчик от значения меньшей длины массива до значения большей длины массива.
                array = arr;
            }
            else if (Count > a.Count)//аналогично.
            {
                double[] arr = new double[Count];
                for (int i = 0; i < a.Count; i++) arr[i] = array[i] + a.array[i];
                for (int i = a.Count; i < Count; i++) arr[i] = array[i];
                array = arr;
            }
            else for (int i = 0; i < Count; i++) array[i] += a.array[i];//здесь длины равны.
        }
        public void Umnogenie(Collection a)//умножение.
        {
            if (Count < a.Count)
            {
                double[] arr = new double[a.Count];
                for (int i = 0; i < Count; i++) arr[i] = array[i] * a.array[i];
                for (int i = Count; i < a.Count; i++) arr[i] = 0;
                array = arr;
            }
            else if (Count > a.Count)
            {
                double[] arr = new double[Count];
                for (int i = 0; i < a.Count; i++) arr[i] = array[i] * a.array[i];
                for (int i = a.Count; i < Count; i++) arr[i] = 0;
                array = arr;
            }
            else for (int i = 0; i < Count; i++) array[i] *= a.array[i];
        }
        public void Print()
        {
            for (int i = 0; i < Count; i++) Console.Write(array[i] + "  ");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Collection collection = new Collection();
            Collection collection1 = new Collection(1);
            collection.Remove(2);
            collection.IndexEnd(6);
            collection.Umnogenie(collection1);
            collection.Print();
        }
    }
}
