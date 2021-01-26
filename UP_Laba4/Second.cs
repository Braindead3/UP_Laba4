using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UP_Laba4
{
    class Second
    {
        int num;
        Random random = new Random();

        public Second(int num)
        {
            this.num = num;
        }

        public Second()
        {
            this.num = random.Next(1,1001);
        }

        public Second(string fileName)
        {
            using (StreamReader sr = new StreamReader($"{fileName}.txt"))
            {
                while (!sr.EndOfStream)
                {
                    num = int.Parse(sr.ReadLine());
                }
            }
        }

        public int KolvoNuley()
        {
            int counter = 0;
            int numDlaScheta = num;
            while(numDlaScheta>0)
            {
                if (numDlaScheta%10==0)
                {
                    counter++;
                }
                numDlaScheta = numDlaScheta / 10;
            }
            return counter;
        }

        public override string ToString()
        {
            return $"{num}";
        }
    }
}
