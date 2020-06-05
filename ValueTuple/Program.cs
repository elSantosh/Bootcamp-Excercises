using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTuple1
{
    //Value tuple are from .NET 4.7 higher 
    //Tuple is refeerence type.
    //Value tuples are improved versions of tuple 
    //Value Tuples are value type tuples 
    //It alows to store data set which contains multiple values that may or may not related to each other 
    //store values from 0 to 8
    //also can store duplicated elements
    //can store elemets of different types
    //vlaue tuple provide strong naming conventions
    //tuples not allowed to create with zero (0) components. But values tuples are allowed 
    //better performance cuz it returns better performance from existing methods
    //valuTuple provide more flexibitility in accessing elements using "_"deconstruction algorithm
    //In ValueTuple the elements aer fields but in tuple they are properties 
    //Value-Tuple fields are mutable but in tuple they are read-only

    class Program
    {
        static void Main()
        {
           
            //create tuple with one element 
            //Tuple<int> valTpl1 = new Tuple<int>(114414);
            //cretae value tuple with three elements 
            var data = (10, "bird", 1.5);
            Console.WriteLine(data);
            Console.ReadKey();

        }


    }
}
