using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UP_Laba4
{
    class Vector
    {
        List<int> points;
        Random random = new Random();
        public int num1;

        public Vector(int x, int y, int z,int num)
        {
            this.num1 = num;
            points = new List<int> { x, y, z };
        }

        public Vector(int raz, int num)
        {
            this.num1 = num;
            points = new List<int>();
            for (int i = 0; i < raz; i++)
            {
                points.Add(random.Next(1, 11));
            }
        }

        public Vector(string fileName, int num1)
        {
            this.num1 = num1;
            points = new List<int>();
            using (StreamReader sr = new StreamReader($"{fileName}.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string str = sr.ReadLine();
                    string[] vector = str.Split();
                    foreach (var num in vector)
                    {
                        points.Add(int.Parse(num));
                    }
                }
            }
        }

        public Vector()
        {
        }

        public Vector SlojenieVectorov(Vector v2)
        {
            if (points.Count==v2.points.Count)
            {
                Vector vectorRez= new Vector();
                vectorRez.points = new List<int>();
                for (int i = 0; i < points.Count; i++)
                {
                    vectorRez.points.Add(points[i]+v2.points[i]);
                }
                return vectorRez;
            }
            else
            {
                Console.WriteLine("Векторы не одинаковой длинны");
                return null;
            }
        }

        public override string ToString()
        {
            Console.Write($"Vector {num1}:");
            foreach (var point in points)
            {
                Console.Write($"{point} ");
            }
            return "";
        }
        
        

    }
}
