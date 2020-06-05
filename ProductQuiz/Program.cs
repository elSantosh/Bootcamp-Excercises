using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductQuiz
{

    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Product();
            Console.WriteLine($"Product 1 Id = {Product.Id}");
            var p2 = new Product();
            Console.WriteLine($"Product 2 Id = {p2.Id}");
            var p3 = new Product();
            Console.WriteLine($"Product 3 Id = {p3.Id}");

            Console.ReadKey();
        }

    }
    class Product
    {
        public static int Id;

        public Product()
        {
            Id = ++Id;
        }

    }
}

