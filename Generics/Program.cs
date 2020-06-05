using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    //Genericas allow you to write a class or methods that can work with any data type 
    //Feature:
    //1. It helps to maximise code safety,code reuse and  performence 
    //2.you can create your own generic classes, interfaces , methods, delegates and events 
    //3.

    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            //declaring an array 
            MyGenericArray<int> intArray = new MyGenericArray<int>(5);

            //setting value 
            for (int c=0;c<5;c++)
            {
                intArray.setItem(c, c*5);
            }

            //retrieving values 
            for (int c=0; c < 5;c++)
            {
                Console.WriteLine(intArray.getItem(c) + " ");
            }
            Console.WriteLine();

            //Declaring a charecter array
            MyGenericArray<char> charArray = new MyGenericArray<char>(5);

            //setting value to char array
            for(int c = 0; c<5;c++)
            {
                charArray.setItem(c, (char)(c + 97));
            }

            //getting values from char array
            for (int c = 0; c<5; c++)
            {
                Console.WriteLine(charArray.getItem(c) + " ");
            }

            Console.WriteLine();
            //========================

            int a, b;
            char x, y;
            a = 10;
            b = 20;
            x = 'I';
            y = 'V';

            //dissplay values before SWAP
            Console.WriteLine("Int values before calling SWAP:");
            Console.WriteLine("a={0},b={1}", a, b);
            Console.WriteLine("char values before clling SWAP:");
            Console.WriteLine("x={0},y={1}", x, y);

            //call SWAP
            Swap<int>(ref a, ref b);
            Swap<char>(ref x, ref y);

            //dissplay values after SWAP
            Console.WriteLine("Int values after calling SWAP:");
            Console.WriteLine("a={0},b={1}", a, b);
            Console.WriteLine("char values after clling SWAP:");
            Console.WriteLine("x={0},y={1}", x, y);

            Console.ReadKey();


        }

        //Declaring a generic method
        static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;

        }

    }
    //Example: declaring generic class
    public class MyGenericArray<T>
    {
        private T[] array;

        public MyGenericArray(int size)
        {
            array = new T[size + 1];

        }
        public T getItem(int index)
        {
            return array[index];
         }
        public void setItem(int index, T value)
        {
            array[index] = value;

        }
    }
    
}
