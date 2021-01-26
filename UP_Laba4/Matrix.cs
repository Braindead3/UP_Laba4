using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UP_Laba4
{
    class Matrix
    {
        public int[,] matrix;
        Random random;

        public Matrix(int[,] matrix)
        {
            this.matrix = matrix;
        }

        public Matrix(string fileName)
        {
            int counter = 0;
            List<int> nums = new List<int>();
            using (StreamReader sr = new StreamReader($"{fileName}.txt"))
            {
                while (!sr.EndOfStream)
                {
                     nums.Add(int.Parse(sr.ReadLine()));
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j]=nums[counter];
                    counter++;
                }
            }
        }

        public Matrix(int row,int col,Random random)
        {
            this.random = random;
            matrix = new int[row, col];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(1,16);
                }
            }
        }
        
        public static bool operator <=(Matrix matrix1,Matrix matrix2)
        {
            if (matrix1.CountPerevert(matrix1)  <= matrix2.CountPerevert(matrix2))
            {
                return true;
            }
            return false;
        }

        public static bool operator >=(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.CountPerevert(matrix1) >= matrix2.CountPerevert(matrix2))
            {
                return true;
            }
            return false;
        }

        public int CountPerevert(Matrix matrix1)
        {
            int[,] matrix = matrix1.matrix;
            int counter = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        string numObr;
                        int num = matrix[i, j];
                        numObr = Convert.ToString(num % 10);
                        num = num / 10;
                        if (matrix[i, j] == int.Parse(numObr))
                        {
                            counter++;
                        }
                    }
                }
            }
            return counter;
        }

        public override string ToString()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j]+"\t");
                }
                Console.WriteLine();
            }
            return "";
        }
    }
}
