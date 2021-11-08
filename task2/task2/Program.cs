using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product()
            {
                Name = "Cay",
                Price = 5,
                Count = 3,
                TotalIncome = 15,
            };


            //Product product1 = new Product()
            //{
            //    Name = "Qend",
            //    Price = 2,
            //    Count = 4,
            //    TotalIncome = 8,
            //};
            //Product product2 = new Product()
            //{
            //    Name = "Milk",
            //    Price = 4,
            //    Count = 4,
            //    TotalIncome = 16
            //};
            Console.WriteLine(Product.Sell(product.Count));

            int a = Convert.ToInt32(Console.ReadLine());

            Milk milks = new Milk()
            {
                Volume = Convert.ToInt32(Console.ReadLine()),
                FatRate = Convert.ToInt32(Console.ReadLine())

              };

        }

    }
}


