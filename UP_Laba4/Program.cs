using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UP_Laba4
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex1();
            Ex2();
            Ex3();
            Ex4();
            Ex5();
            Ex6();
            Console.ReadLine();
        }

        private static void Ex1()
        {
            First first = new First(11);
            Console.WriteLine(first);
            Console.WriteLine("Сумма:" + first.Slojenie());
        }

        private static void Ex2()
        {
            Second second = new Second(100);
            Console.WriteLine(second);
            Console.WriteLine(second.KolvoNuley());
        }

        private static void Ex3()
        {
            Vector v1 = new Vector(3, 1);
            Vector v2 = new Vector("vector", 2);
            Vector v3 = v1.SlojenieVectorov(v2);
            v3.num1 = 3;
            Console.WriteLine(v1);
            Console.WriteLine(v2);
            Console.WriteLine(v3);
        }

        private static void Ex4()
        {
            Random random = new Random();
            Matrix matrix1 = new Matrix(5,5, random);
            Matrix matrix2 = new Matrix(5,5, random);
            Console.WriteLine("Perv matr:");
            Console.WriteLine(matrix1);
            Console.WriteLine("Vtoraya matr:");
            Console.WriteLine(matrix2);
            Console.WriteLine("Sravnenie:");
            if(matrix1 >= matrix2)
            {
                Console.WriteLine("Матрица 1 больше.");
            }
            else
            {
                Console.WriteLine("Матрица 2 больше.");
            }
            if (matrix2 <= matrix1)
            {
                Console.WriteLine("Матрица 2 меньше");
            }
            else
            {
              Console.WriteLine("Матрица 1 меньше");
            }
        }

        private static void Ex5()
        {
            Stroka stroka = new Stroka("ABCD");

            Console.WriteLine("C1:");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(stroka);
            Console.ResetColor();

            Console.WriteLine("C2:");
            string str = "EFGHJK";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(str);
            Console.ResetColor();

            Console.WriteLine("Moy otvet:");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(stroka.strConcat(str));
            Console.ResetColor();

            Console.WriteLine("Otvet v zadanii:");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("EDFCGBHAJK");
            Console.ResetColor();
        }

        public static void Ex6()
        {
            Console.WriteLine("Tochka:");
            if (Krug.LejitLiTochka(5,5,1,10))
            {
                Console.WriteLine("Лежит");
            }
            else
            {
                Console.WriteLine("Не лежит");
            }
            
        }
    }
}
