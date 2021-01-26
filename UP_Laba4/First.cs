using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UP_Laba4
{
    class First
    {
        int num1;
        int num2;
        Random random = new Random();

        public First(int num1,int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public First(int pred)
        {
            this.num1 = random.Next(1,pred);
            this.num2 = random.Next(1, pred);
        }

        public First(string fileName)
        {
            using (StreamReader sr = new StreamReader($"{fileName}.txt"))
            {
                while (!sr.EndOfStream)
                {
                    num1=int.Parse(sr.ReadLine());
                    if (num1>0)
                    {
                        num2 = int.Parse(sr.ReadLine());
                    }
                }
            }
        }

        public int Slojenie()
        {
            return num1 + num2;
        }

        public override string ToString()
        {
            return $"Число 1:{num1}, число 2:{num2}";
        }
    }
}
