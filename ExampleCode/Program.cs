using System;
using System.Collections.Generic;
using System.Linq;

namespace ExampleCode
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> products = new List<Product>
          {
              new Product{Id=1,ProductName="Apple",Price=10000,Ram=128},
              new Product{Id=1,ProductName="Lenova",Price=3000,Ram=64},
              new Product{Id=1,ProductName="Hp",Price=1000,Ram=64},
              new Product{Id=1,ProductName="Hp",Price=1000,Ram=64},
              new Product{Id=1,ProductName="Dell",Price=4000,Ram=64},
              new Product{Id=1,ProductName="Acer",Price=5000,Ram=32},
              new Product{Id=1,ProductName="Asus",Price=6000,Ram=32},
              new Product{Id=1,ProductName="Msi",Price=7000,Ram=16},
              new Product{Id=1,ProductName="Monster",Price=8000,Ram=16},
              new Product{Id=1,ProductName="Casper",Price=9000,Ram=8},
              new Product{Id=1,ProductName="Samsung",Price=9000,Ram=8},

          };
            Console.WriteLine("-------------Any---------------");

            var result = products.Where(P => P.ProductName == "Apple").Any();

            Console.WriteLine(result);


            Console.WriteLine("-------------WHERE---------------");

            var result1 = products.Where(P => P.Price > 5000);
            foreach (var r1 in result1)
            {
                Console.WriteLine(r1.ProductName);

            }

            Console.WriteLine("-------------SingleOrDefault---------------");

            var result2 = products.SingleOrDefault(P => P.Price==6000);

            Console.WriteLine(result2.Ram);

            Console.WriteLine("-------------FindALL---------------");

            var result3 = products.FindAll(P => P.Ram==32);

            foreach (var r3 in result3)
            {
                Console.WriteLine(r3.ProductName);
            }

            Console.WriteLine("-------------Find---------------");

            var result4 = products.Find(P => P.Ram == 64);
            Console.WriteLine(result4.ProductName);


            Console.WriteLine("-------------First---------------");

            var result5 = products.First(P => P.Ram==16);
            Console.WriteLine(result5.ProductName);


            Console.WriteLine("-------------FirstOrDefault---------------");

            var result6 = products.FirstOrDefault(P => P.Id==1);
            Console.WriteLine(result6.Ram);


            Console.WriteLine("-------------MAX---------------");

            var result7 = products.Max(P => P.Price>5000);
            Console.WriteLine(result7);

            Console.WriteLine("-------------MİN---------------");

            var result8 = products.Min(P => P.Id==1);
            Console.WriteLine(result8);

           

            Console.WriteLine("-------------    EXİTS---------------");

            var result10 = products.Exists(P => P.Ram<8);
            Console.WriteLine(result10);

            Console.WriteLine("-------------OrderBy--------------");

            var result9 = products.OrderBy(P => P.Id==1);
            foreach (var r9 in result9)
            {
                Console.WriteLine(r9.Ram);
            }

            //Console.WriteLine("-------------TOLİST---------");


            //List<Product> result10 = products.ToList();
            //Console.WriteLine(result10);



            //var result11 = products.Contains();
           
            //    Console.WriteLine(result11);

            













        }


    }

    class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public int Ram { get; set; }




    }
}
