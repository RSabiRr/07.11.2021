using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extention
{
   static class pow
    {
        public static int pow1(this int pow,int a)
        {
            int a2;
            for (int i = 0; i < pow; i++)
            {
              Console.WriteLine(Math.Sqrt(Math.Sqrt(a)));
            }
            return a;
        }

    }
}
