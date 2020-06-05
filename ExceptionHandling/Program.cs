using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
//    class DivNumbers
//    {
//        //    //try
//        //    //catch
//        //    //finally
//        //    //throw
//        //    //Exception Classes in C#
//        //    //1.System.IO.IOException 
//        //    //2.System.IndexOutOfTheRangeexception 
//        //    //3.System.ArrayTypeMismatchException
//        //    //4.System.NullReferenceException 
//        //    //5.System.DivideByZeroException
//        //    //6.Sytem.InvalidcastException 
//        //    //7.System.OutOfMemoryException 
//        //    //8.System.StackOverflow Exception 

//        int result;
//        DivNumbers()
//    {

//    }

//    static void Main(string[] args)
//    {
//        DivNumbers d = new DivNumbers();
//        d.division(25, 0);
//    }

//    public void division(int num1, int num2)
//    {
//        try
//        {
//            result = num1 / num2;

//        }
//        catch (DivideByZeroException e)
//        {
//            Console.WriteLine(e);
//        }
//        finally
//        {
//            Console.WriteLine("the result: {0}", result);

//        }
//        Console.ReadKey();

//    }

//}

    //Creating user defines exception
    class TestTemparature
    {
        public static void Main()
        {
            Teparature tem = new Teparature();
            try
            {
                tem.showTemp();

            }
            catch (TempIsZeroExceptionCode e)
            {
                Console.WriteLine("Exception code:{0} Exception message:{1}",e.StatusCode, e.Message );

            }
            finally
            {
                Console.ReadKey();
            }
        }
        //public class TempIsZeroException : Exception
        //{
        //    public TempIsZeroException(string Message) : base(Message)
        //    {

        //    } 
        //}

        public class TempIsZeroExceptionCode : ApplicationException
        {
            public int StatusCode { get; private set;}
           
            public TempIsZeroExceptionCode(int status,string Message) : base(Message)
            {
                StatusCode = status;
            }

        }
        public class Teparature
        {
            int temparature = 0;


            public void showTemp()
            {
                if (temparature == 0)
                {
                    //throw (new TempIsZeroException("zero temparature found"));

                    throw (new TempIsZeroExceptionCode(2000,"new exception"));
                }
                else
                {
                    Console.WriteLine("Temparature:{0} degrees", temparature);
                }
            }
        }
    }
}


