using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable
{
    //to which you can assign narmal values as well as null values 
    //Nullable<Int32>
    //syntax: <data_type>? <variable name> = value/null;

    class Program
    {
        static void Main(string[] args)
        {
            int? num1 = null;
            int? num2 = 42;

            double? num3 = new double();
            double? num4 = 0.99897;

            bool? boolVal = new Boolean();


            Console.WriteLine("Nullable at Show: {0},{1} ,{2},{3}", num1, num2, num3, num4);
            Console.WriteLine("the nullable value:{0}", boolVal);

            Console.WriteLine("the nullable coalescing operator:");
            Program newFunc = new Program();
            newFunc.NullableAtShow();
            Console.ReadKey();
        }
        //Coalising operator example 
        public void NullableAtShow()
        {
            double? num1 = null;
            double? num2 = 3.904914;
            double num3;

            num3 = num1 ?? 0;
            Console.WriteLine("value of num3:{0}", num3);

            num3 = num2 ?? 5.34;
            Console.WriteLine("the value of num3:{0}", num3);




        }
    }

}
