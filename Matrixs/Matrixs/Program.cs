using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrixs
{
    class Program
    {
        static void Main(string[] args)
        {
            uint row, column;
            bool a, b;
            
            // generating first matrix while input sizes are correct and show maximum and minimum elements
            do
            {
                Console.WriteLine("Enter rows and columns of matrix");
                Console.Write("Rows=");
                a = uint.TryParse(Console.ReadLine(), out row);
                Console.Write("Columns=");
                b = uint.TryParse(Console.ReadLine(), out column);
                if (!(a && b) || row == 0 || column == 0)
                    Console.WriteLine("not correct input data");
            } while (!(a && b) || row == 0 || column == 0);
            Matrix matrix1 = new Matrix(row, column);
            Console.WriteLine("First random generated matrix");
            matrix1.RandomGenerateMatrixElements();
            matrix1.ShowMatrix();            
            Console.Write("Max element:" + matrix1.Max() + "\tMin element:" + matrix1.Min());
            //************************************************

            //generating second matrix same way
            Console.WriteLine("\n--------------------------------------");
            do
            {
                Console.WriteLine("Enter rows and columns of matrix");
                Console.Write("Rows=");
                a = uint.TryParse(Console.ReadLine(), out row);
                Console.Write("Columns=");
                b = uint.TryParse(Console.ReadLine(), out column);
                if (!(a && b) || row == 0 || column == 0)
                    Console.WriteLine("not correct input data");
            } while (!(a && b) || row == 0 || column == 0);
            Matrix matrix2 = new Matrix(row, column);
            Console.WriteLine("Second random generated matrix");
            matrix2.RandomGenerateMatrixElements();
            matrix2.ShowMatrix();
            Console.Write("Max element:" + matrix2.Max() + "\tMin element:" + matrix2.Min());
            //************************************************

            //show how to add two matrixes
            Console.WriteLine("\n**************************************");
            if (matrix1.Row == matrix2.Row && matrix1.Column == matrix2.Column)
            {
                Console.WriteLine("Addition of two matrixes is");
                matrix1.Add(matrix2).ShowMatrix();
            }
            else
                Console.WriteLine("Impossible to add this matrixes because of different sizes");
            //*************************************************

            //scalar multiply by input scalar
            Console.WriteLine("**************************************");
            Console.Write("Please input n number(double): n=");
            double n;
            a = double.TryParse(Console.ReadLine(),out n);
            if (a)
            {
                Console.WriteLine("Multiply matrix(for example first matrix) by number n is");
                matrix1.Multiply(n).ShowMatrix();
            }
            else
                Console.WriteLine("n is not a number");
            //**************************************************

            //multiply operation with two matrixes
            Console.WriteLine("**************************************");
            if (matrix1.Column == matrix2.Row)
            {
                Console.WriteLine("Multiply of first and second matrixes is");
                matrix1.Multiply(matrix2).ShowMatrix();
            }
            else
                Console.WriteLine("Impossible multiply this two matrixes because of first matrix columns must be equals to second matrix rows");
            //********************************************************

            //transpose first matrix
            Console.WriteLine("**************************************");
            Console.WriteLine("Transpose of first matrix is");
            matrix1.Transpose().ShowMatrix();
            //*********************************************************

            
        }
    }
}
