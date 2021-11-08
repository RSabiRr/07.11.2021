using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extention
{
   static class pow
    {
        public static int pow1(this int a)
        {
            int c = 0;
            c=(int)Math.Cbrt(a);

            return c;
        }

    }
}
