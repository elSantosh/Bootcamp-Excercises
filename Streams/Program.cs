using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streams
{
    //Streams are normally used while dealing with large files, using stream those files are broken down into smaller chunks and sent streams.

    class Program
    {
        static void Main(string[] args)
        {
            String path = @"C:\Users\santosh.guruju\Documents\Example.txt";

            //1.Stream reader 
            //using (StreamReader sr = File.OpenText(path))
            //{
            //    String s = "";

            //    while ((s = sr.ReadLine()) != null)
            //    {
            //        Console.WriteLine(s);
            //    }
            //}

            //2. Stream writer 
            using (StreamWriter sr = File.AppendText(path))
            {
                sr.WriteLine("bbbbbbbbbbbbbb \n bdabdabfbbfbfbfbfbbf");
                sr.Close();

                Console.WriteLine(File.ReadAllText(path));
            }
            Console.ReadKey();
        }
    }
}
