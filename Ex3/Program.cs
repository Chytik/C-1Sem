using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Подготовка_3._1
{
    class Matrix
    {
        double[,] _matrix;
        int row;
        int col;
        public int Row { get { return row; } }
        public int Col { get { return col; } }
        public double[,] _Matrix
        {
            get
            {
                //row = _matrix.GetLength(0);  Эти строчки необязательны!
                //col = _matrix.GetLength(1);
                return _matrix;
            }
        }
        public Matrix(double[,] matrix)
        {
            row = matrix.GetLength(0); //А вот эти строчки обязательны, т.к. необходимо задать кол-во строк и столбцов матрицы.
            col = matrix.GetLength(1);  
            _matrix = matrix;
        }
        public double[,] Umnogenie(double a)
        {
            for(int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++) _matrix[i, j] *= a;
            }
            return _matrix;
        }
        public double[,] Slogenie(Matrix matrix)
        {
            if (_matrix.GetLength(0) != matrix.Row || _matrix.GetLength(1) != matrix.Col) Console.WriteLine("Операция невыполнима!");
            else
            {
                for(int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++) _matrix[i, j] += matrix._Matrix[i, j];
                }
            }
            return _matrix;
        }
        public void Vyvod()
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++) Console.Write(_matrix[i, j] + "   ");
                Console.WriteLine();
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix(new double[,] { { 1, 1 }, { 2, 3 } });
            Matrix matrix1 = new Matrix(new double[,] { { 2, 3 }, { 6, 7 } });
            matrix.Umnogenie(-2);
            matrix.Slogenie(matrix1);
            matrix.Vyvod();
        }
    }
}
