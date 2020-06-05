using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOperations
{
    class Program
    {
        //reading
        //writting 
        //appending 

        
        
        
        static void Main(string[] args)
        {
            String path = @"C:\Users\santosh.guruju\Documents\Example.txt";

            //1.File.Exist
            //if (File.Exists(path))
            //{
            //    Console.WriteLine("File exists");
            //}
            //else {
            //    Console.WriteLine("File does not exists");
            //}

            //2.ReadAllLines


            //String[] lines;
            //lines = File.ReadAllLines(path);

            //Console.WriteLine(lines[0]);
            //Console.WriteLine(lines[9]);

            ////3.ReadAllText
            //String lines;
            //lines = File.ReadAllText(path);
            //Console.WriteLine(lines);

            //4.FileCopy
            String copypath = @"C:\Users\santosh.guruju\Documents\ExampleNew1.txt";
            //File.Copy(path, copypath);

            //5.FileDelete
            File.Delete(copypath);

            Console.ReadKey();
        }
    }
 }

