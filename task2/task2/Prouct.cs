using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Product
    {
        public string Name;
        public int Price;
        public int Count;
        public int TotalIncome;

        public static int Sell(int count)
        {
            count--;
            return count;
        }
    }
}
