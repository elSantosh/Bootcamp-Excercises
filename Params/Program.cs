using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params
{
    //param are use to declare methods that does not know number of parameters
    //note:parametes are two types 1, actual parameter(arguments)used in caller method eg:sum(a,b). formal arguments, used in called mathod eg:public int add(int x,int y)
    //useful write clean code 
    //instead of passing overloading methods, you create an array pass it as an argument or comma separated list of arguments
    //
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("param with three parameter:");
            int total3 = Students.TotalMarks(2, 3, 4,5,6,8);
            Console.WriteLine(total3);
            Console.ReadKey();

            Console.WriteLine("params with array of strings");
            string[] subjects = { "english", "maths", "science" };
            Console.WriteLine(Students.Allsubjects(subjects));
            Console.ReadKey();
        }
    }
    public class Students
    {
        public static int TotalMarks (params int[] list)
        {
            int total = 0;
            for(int i=0;i<list.Length; i++)
            {
                total += list[i];

            }
            return total;
        }
        public static string Allsubjects(params string[] subjects)
        {
            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            for(int i=0;i<subjects.Length;i++)
            {
                builder.Append(subjects[i]);
                builder.Append(" ");
           }
            return builder.ToString();
        } 
    }
}
