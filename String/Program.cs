using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string *a = "Hello";
            string b = "Hello";

            int aAdd = &a;

            Console.WriteLine("{0}", &a);
            Console.WriteLine("{0}", &b);

        }
    }
}
