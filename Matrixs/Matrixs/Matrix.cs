using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrixs
{
    class Matrix
    {
        public double[,] Mat { get; set; }
        public readonly uint Row;
        public readonly uint Column;
        public Matrix(uint row, uint column)
        {
            this.Mat =new double[row , column];
            this.Row = row;
            this.Column = column;
        }
        public Matrix() { }

        public void RandomGenerateMatrixElements()
        {
            Random rd = new Random();
            for(int i=0; i<this.Row; i++)
            {
                for (int j = 0; j < this.Column; j++)
                    this.Mat[i, j] = rd.Next(-30, 31); // ... +rd.NextDouble();
            }
        }
        public void ShowMatrix()
        {
                for (int i = 0; i < this.Row; i++)
                {
                    for (int j = 0; j < this.Column; j++)
                        Console.Write(this.Mat[i, j] + "\t");
                    Console.WriteLine();
                }            
        }
        public double Max()
        {
            double max = this.Mat[0, 0];
            for (int i = 0; i < this.Row; i++)            
                for (int j = 0; j < this.Column; j++)
                    if(max < this.Mat[i, j])
                        max = this.Mat[i, j];
            return max;
        }
        public double Min()
        {
            double min = this.Mat[0, 0];
            for (int i = 0; i < this.Row; i++)
                for (int j = 0; j < this.Column; j++)
                    if (min > this.Mat[i, j])
                        min = this.Mat[i, j];
            return min;
        }
        public Matrix Add(Matrix second)
        {
            if (this.Row == second.Row && this.Column == second.Column)
            {
                Matrix result = new Matrix(this.Row, this.Column);
                for (int i = 0; i < this.Row; i++)
                {
                    for (int j = 0; j < this.Column; j++)
                        result.Mat[i, j] = this.Mat[i, j] + second.Mat[i, j];
                }
                return result;
            }
            else
            {                
                return null;
            }
        }
        public Matrix Multiply(double n)
        {
            Matrix result = new Matrix(this.Row, this.Column);
            for (int i = 0; i < this.Row; i++)
            {
                for (int j = 0; j < this.Column; j++)
                    result.Mat[i, j] = n * this.Mat[i, j];
            }
            return result;
        }
        public Matrix Multiply(Matrix second)
        {
            if (this.Column == second.Row)
            {
                Matrix result = new Matrix(this.Row, second.Column);
                for (int i = 0; i < this.Row; i++)
                {
                    for (int j = 0; j < second.Column; j++)
                    {
                        for (int k = 0; k < this.Column; k++)
                            result.Mat[i, j] += this.Mat[i, k] * second.Mat[k, j];
                    }
                }
                return result;
            }
            else
            {
                return null;
            }
        }
        public Matrix Inverse()
        {
            Matrix result = new Matrix(this.Row, this.Column);
            for (int i = 0; i < this.Row; i++)
            {
                for (int j = 0; j < this.Column; j++)
                {
                    
                        result.Mat[i, j] = this.Mat[i, j];
                }
            }
            return result;
        }
        public Matrix Transpose()
        {
            Matrix result = new Matrix(this.Column, this.Row);
            for (int i = 0; i < this.Row; i++)
            {
                for (int j = 0; j < this.Column; j++)
                    result.Mat[j, i] = this.Mat[i, j];
            }
            return result;
        }
        public bool isOrtogonal()
        {
            bool b = true;
            for (int i = 0; i < this.Row; i++)
            {
                for (int j = 0; j < this.Column; j++)
                {
                    if(this.Inverse().Mat[i, j] != this.Transpose().Mat[i,j])
                    {
                        b = false;
                        break;
                    }
                    if (!b)
                        break;
                }
            }
            return b;
        }        
    }
}
