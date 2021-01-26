using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UP_Laba4
{
    class Stroka
    {
        string str;
        public Stroka(string str)
        {
            this.str = str;
        }

        public string strConcat(string str1)
        {
            string strRez="";
            if (str1.Length > str.Length)
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    strRez += str1[i];
                    if (i > str.Length-1)
                    {
                        for (int j = i+1; j < str1.Length; j++)
                        {
                            strRez += str1[j];
                        }
                        break;
                    }
                    else
                    {
                        strRez += str[str.Length-i-1];
                    }
                }
            }
            else
            {
                for (int i = 0; i < str.Length; i++)
                {
                    strRez += str[i];
                    if (i > str1.Length-1)
                    {
                        for (int j = i+1; j < str.Length; j++)
                        {
                            strRez += str[j];
                        }
                        break;
                    }
                    else
                    {
                        strRez += str1[str1.Length- i-1];
                    }
                }
            }
            return strRez;
        }

        public override string ToString()
        {
            return str;
        }
    }
}
