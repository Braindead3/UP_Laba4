using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UP_Laba4
{
    static class Krug
    {
        static public bool LejitLiTochka(int x,int y,int r1,int r2)
        {
            if (x<0 && y>0 && x<r1 || x>0 && y<0 && Math.Sqrt(Math.Pow(x,2)-Math.Pow(y,2))<r2 && Math.Sqrt(Math.Pow(x, 2) - Math.Pow(y, 2)) > r1)
            {
                return true;
            }
            return false;
        }
    }
}
