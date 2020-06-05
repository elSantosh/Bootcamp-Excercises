using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace LINQ
{
    //Language Integrated Qurery
    //Offers easy data access from in-memory objects    
    //====Syntax====
    //1.Lamda(Method) syntax 
    //var longwrods = words.where(w=>w.length > 10)
    //Dim = longwords = words.Where(Function(w) w.legth > 10)
    //2.Query syntax
    //var longwords = from w in words Where w.legth > 10 ;
    //Dim longwords = from w in words Where w. length > 10;
    //=======types======
    //1. LINQ to Objects.
    //2. LINQ to XML(XLINQ)
    //3. LINQ to DataSet
    //4. LINQ to SQL(QLINQ)
    //5. LINQ to Entities.
    //====Architecture====
    //top-tier :Language 
    //middle-tier : Object/DataSets/SQL/XML/Entities
    //bottom-tier: objects, Relational data, XML pages

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        string[] words = { "hello", "FOUR","wonderful","LINQ", "beautiful", "world"};
    //        //get only short words
    //        var shortwords = from word in words where word.Length <= 5 select word;

    //        foreach (var word in shortwords){
    //            Console.WriteLine(word);
    //        }

    //        Console.ReadKey();
    //    }
    //}

    //===============LINQ Query Expressions==================
    //Expressed in the form similar to that using SELECT, WHERE, ORDERBY and FROM.
    //Usually starts with the keyword FROM.

    //class LINQQueryExpressions
    //{
    //    static void Main()
    //    {
    //        //specify the data source.
    //        int[] scores = new int[] { 97, 92, 82, 60, 89,85 };

    //        //Define the query expressions
    //        IEnumerable<int> scoreQuery = from score in scores where score > 80 select score;

    //        //execute the query
    //        foreach (int i in scoreQuery)
    //        {
    //            Console.Write(i + " ");

    //        }
    //        Console.ReadKey();

    //         //Query Exp

    //        //********regular expression methods 
    //        //extension methods 
    //        //Its used to translate query expressions into traditional methods call(object-Oriented)

    //        //SqlConnection sqlConn = new SqlConnection("connection_String");
    //        //sqlConn.Open();

    //        //System.Data.SqlClient.SqlCommand sqlComm = new SqlCommand();
    //        //sqlComm.Connection = sqlConn;

    //        //sqlComm.CommandText = "select * from Customer";
    //        //return sqlComm.EndExecuteReader (CommandBehavior.CloseConnection);

    //        //*********LINQ way
    //        //Northwind db = new Northwind(@"c:\data\Northwind.mdf");
    //        //var query = from c in db.Customer select c;

    //        //=================Advantages of LINQ========================
    //        //1. Offers syntax highlighting suring design time 
    //        //2. Offers intelliSence which means writing more occurate code more easily
    //        //3. Offers easy debuging due to integration with C# language.
    //        //4. Viewing raltion between is easy due to its heirachical feature. and this enables joing table more easier 
    //        //5. LINQ allows usage of single syntax to query many diverse data types 
    //        //6. offers joining many sources with single query & breaks complex queries into set of short queries.
    //        //7. Offesrs easy tranformation of one data type to other.
    //        //8. Wrintting code is faster.

    //    }
    //}

    // ========Query Operators
    class QueryOperators
    {
        public static void Main()
        {
            //1.Filtering Operator **
            //a) Where 
            //b) ofType 

            //2. Join Operator **
            //a) Join =================
            //var names = new List<string>
            //{
            //    "Santosh",
            //    "Orlando"
            //};
            //names.Add("Sharon");

            //var namesThatStartsWithS = names.Where(x => x.StartsWith("S")).ToList();

            //foreach (var name in namesThatStartsWithS)
            //{
            //    Console.WriteLine(name);
            //}

            //var person = new List<Person>
            //{
            //    new Person
            //    {
            //        Name = "Santosh",
            //        Age = 18
            //    },
            //    new Person
            //    {
            //        Name = "Orlando",
            //        Age = 19
            //    }
            //};

            //var thirdsPerson = new Person();
            //thirdsPerson.Name = "Thirdy";
            //thirdsPerson.Age = 20;
            //person.Add(thirdsPerson);

            //var p4 = new Person();
            //p4.Name = "Santosh 1";
            //p4.Age = 21;
            //person.Add(p4);




            //var employees = persons.OfType<Person>();

            //var employee = new List<Person>();

            //var employee1 = new Employee();
            //employee1.Name = "Santosh";
            //employee1.Age = 18;
            //employee.Add(employee1);

            //var joined = person.Join(
            //    employee, 
            //    student => student.Name, 
            //    standard => standard.Name, 
            //    (p1, p2) => new Person { Name = p1.Name, Age = p1.Age }).ToList();

            //foreach (var joinItem in joined)
            //{
            //    Console.WriteLine($"Name: {joinItem.Name}, Age: {joinItem.Age}");
            //}
            //b) GroupJoin

            //======Group Join==================
            //var person = new List<Person>
            //{
            //    new Person
            //    {
            //        Name = "Santosh",
            //        Age = 18
            //    },
            //    new Person
            //    {
            //        Name = "Orlando",
            //        Age = 19
            //    }
            //};

            //var thirdsPerson = new Person();
            //thirdsPerson.Name = "Thirdy";
            //thirdsPerson.Age = 20;
            //person.Add(thirdsPerson);

            //var p4 = new Person();
            //p4.Name = "Santosh 1";
            //p4.Age = 21;
            //person.Add(p4);


            //var employee = new List<Person>();

            //var employee1 = new Employee();
            //employee1.Name = "Santosh";
            //employee1.Age = 18;
            //employee.Add(employee1);

            //var employee2 = new Employee();
            //employee2.Name = "Orlando";
            //employee2.Age = 18;
            //employee.Add(employee2);

            //// dynamic
            //var groupJoined = person.GroupJoin(
            //    employee,
            //    p1 => p1.Age,
            //    p2 => p2.Age,
            //    (p1, groups) =>
            //    new PersonGroupedByAge { Age = p1.Age, Persons = groups.ToList() })
            //.Where(x => x.Persons.Count > 0).ToList();

            ////groupJoined = groupJoined.Where(x => x.Persons.Count > 0).ToList();

            //foreach (var groupJoinItem in groupJoined)
            //{
            //    Console.WriteLine(groupJoinItem.Age);

            //    foreach (var personItem in groupJoinItem.Persons)
            //    {
            //        Console.WriteLine($"Name: {personItem.Name}, Age: {personItem.Age}");
            //    }
            //}


            //3. Projecttion Operator **
            //a) Select 
            //var persons = new List<Person>
            //{
            //    new Person
            //    {
            //        Name = "Santosh",
            //        Age = 18
            //    },
            //    new Person
            //    {
            //        Name = "Orlando",
            //        Age = 19
            //    }
            //};

            //var thirdsPerson = new Person();
            //thirdsPerson.Name = "Thirdy";
            //thirdsPerson.Age = 20;
            //persons.Add(thirdsPerson);

            //var p4 = new Person();
            //p4.Name = "Santosh";
            //p4.Age = 21;
            //persons.Add(p4);

            //b) SelectMany

            //var names = persons.SelectMany(x => x.Name).ToList();
            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}


            //4. Sorting Operators **
            //a) OrerBy
            //b) OrderBydescending 
            //var teenagers = persons.Where(person => person.Age >= 13 && person.Age <= 19).ToList();
            //foreach (var teenager in teenagers)
            //{
            //    Console.WriteLine($"Name: {teenager.Name}, Age: {teenager.Age}");
            //}

            // Order By Name Descending, Then By Age Ascending
            //var ordered = persons.OrderByDescending(x => x.Name).ThenByDescending(x => x.Age);
            //persons.Reverse();
            //foreach (var person in persons)
            //{
            //    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            //}

            //c) ThenBy 
            //d) ThenByDescending 
            //e) Reverse

            //5. Group Operators **
            //a) GroupBy
            //b) ToLookUp
            //var persons = new List<Person>
            //{
            //    new Person
            //    {
            //        Name = "Santosh",
            //        Age = 18
            //    },
            //    new Person
            //    {
            //        Name = "Orlando",
            //        Age = 18
            //    }
            //};

            //var thirdsPerson = new Person();
            //thirdsPerson.Name = "Thirdy";
            //thirdsPerson.Age = 20;
            //persons.Add(thirdsPerson);

            //var p4 = new Person();
            //p4.Name = "Santosh";
            //p4.Age = 21;
            //persons.Add(p4);

            //var lookup = persons.ToLookup(x => x.Name);
            //foreach (var lookupItem in lookup)
            //{
            //    Console.WriteLine(lookupItem.Key);

            //    foreach (var item in lookupItem)
            //    {
            //        Console.WriteLine($"Name: {item.Name}, Age: {item.Age}");
            //    }
            //}

            //6. Conversions **
            //a) AsEnumerable 
            //b) AsQueryable 
            //c) Cast



            //// Cast
            //var employees = new List<Person>();

            //var employee1 = new Employee();
            //employee1.Name = "Santosh";
            //employee1.Age = 18;
            //employees.Add(employee1);

            //var employee2 = new Employee();
            //employee2.Name = "Orlando";
            //employee2.Age = 18;
            //employees.Add(employee2);

            //var person1 = new Person();
            //employee2.Name = "P3";
            //employee2.Age = 22;

            //var asPersonsList = employees.Cast<Employee>();
            //foreach (var item in asPersonsList)
            //{
            //    Console.WriteLine($"Name: {item.Name}, Age: {item.Age}");
            //};



            //d) OfType
            //e) ToArray
            //f) ToDictionary
            //// AsEnumerable 
            //var persons = new List<Person>
            //{
            //    new Person
            //    {
            //        Name = "Santosh",
            //        Age = 18
            //    },
            //    new Person
            //    {
            //        Name = "Orlando",
            //        Age = 18
            //    }
            //};

            //var thirdsPerson = new Person();
            //thirdsPerson.Name = "Thirdy";
            //thirdsPerson.Age = 20;
            //persons.Add(thirdsPerson);

            //var p4 = new Person();
            //p4.Name = "Santosh";
            //p4.Age = 21;
            //persons.Add(p4);

            //var asEnumerable = persons.AsEnumerable();
            //foreach (var item in asEnumerable)
            //{
            //    Console.WriteLine($"Name: {item.Name}, Age: {item.Age}");
            //}


            //// IEnumerable 
            //var persons = new List<Person>
            //{
            //    new Person
            //    {
            //        Name = "Santosh",
            //        Age = 18
            //    },
            //    new Person
            //    {
            //        Name = "Orlando",
            //        Age = 19
            //    }
            //};

            //var thirdsPerson = new Person();
            //thirdsPerson.Name = "Thirdy";
            //thirdsPerson.Age = 20;
            //persons.Add(thirdsPerson);

            //var p4 = new Person();
            //p4.Name = "Santosh";
            //p4.Age = 21;
            //persons.Add(p4);

            //var asDictionary = persons.ToDictionary(x => x.Age);
            //foreach (var item in asDictionary)
            //{
            //    Console.WriteLine(item.Key);
            //    Console.WriteLine($"Name: {item.Value.Name}, Age: {item.Value.Age}");
            //}


            //var person = new Person();

            //var employee = (Employee)person;
            //g) ToList
            //h) ToLookUp

            //7. Concatenation **
            //a) Concat

            //8. Aggreagation **
            //a) Aggreagate
            //b) Average
            //c) Count
            //d) LonCount 
            //e) Max
            //f) Min
            //g) Sum

            //9. Quantifier Operators **
            //a) All
            //b) Any
            //c) Contains 
            // Contains
            //var employees = new List<Person>();

            //var employee1 = new Employee();
            //employee1.Name = "Santosh";
            //employee1.Age = 18;
            //employees.Add(employee1);

            //var employee2 = new Employee();
            //employee2.Name = "Orlando";
            //employee2.Age = 18;
            //employees.Add(employee2);

            //var person1 = new Person();
            //employee2.Name = "P3";
            //employee2.Age = 22;

            ////var employee1Copy = employee1;
            //var employee1Copy = new Employee();
            //employee1Copy.Name = employee1.Name;
            //employee1Copy.Age = employee1.Age;

            //if (employees.Contains(employee1Copy))
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}

            //var numbers = new int[] { 1, 2, 3 };
            //var one = 1;
            //var anotherOne = 1;
            //if (numbers.Contains(anotherOne))
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}

            //10. Partition Operators **
            //a) Skip
            //b) SkipWhile 
            //c) Take 
            //d) takeWhile 

            //11. Generation Operaltors **
            //a) DeafaultEmpty 
            //b) Empty 
            //c) Range 
            //d) Repeat

            //12. Set Operators **
            //a) Distint 
            //b) Except 
            //c) Intersect 
            //d) Union

            //13. Equality Operator **
            //a) SequenceEqual

            //14. Element Operators**
            //a) ElementAt 
            //b) ElementAtOrDefault ==========================
            // ElementAtOrDefault
            //var employees = new List<Person>();

            //var employee1 = new Employee();
            //employee1.Name = "Santosh";
            //employee1.Age = 18;
            //employees.Add(employee1);

            //var employee2 = new Employee();
            //employee2.Name = "Orlando";
            //employee2.Age = 18;
            //employees.Add(employee2);

            //var person1 = new Person();
            //person1.Name = "Santosh";
            //person1.Age = 22;
            //employees.Add(person1);

            //var numbers = new int[] { 1, 2, 3 };

            //var n100 = numbers.ElementAtOrDefault(100);

            //var first = employees.ElementAtOrDefault(100);
            //Console.WriteLine($"Name: {first.Name}, Age: {first.Age}");

            //c) First 
            //d) FirstOrDefault 
            //e) Last 
            //f) LastOrDefault 
            //g) Single 
            //h) SingleOrDefault
            //i) DefaultIfEmpty

            //var employees = new List<Person>();

            //var employee1 = new Employee();
            //employee1.Name = "Santosh";
            //employee1.Age = 18;
            //employees.Add(employee1);

            //var employee2 = new Employee();
            //employee2.Name = "Orlando";
            //employee2.Age = 18;
            //employees.Add(employee2);

            //var person1 = new Person();
            //person1.Name = "Santosh";
            //person1.Age = 22;
            //employees.Add(person1);

            //var first1 = employees.First(x => x.Name == "Santosh");
            //Console.WriteLine($"Name: {first1.Name}, Age: {first1.Age}");

            //var first2 = employees.FirstOrDefault(x => x.Name == "Santosh Not Exists");
            //if (null == first2)
            //{
            //    Console.WriteLine($"Name: {first2.Name}, Age: {first2.Age}");
            //}

            var first1 = employees.SingleOrDefault(x => x.Name == "Santosh Not Exists");
            Console.WriteLine($"Name: {first1.Name}, Age: {first1.Age}");

            Console.ReadKey();





















        }

        static bool CheckPersonAge(Person person)
        {
            if (person.Age >= 19)
            {
                return true;
            }

            return false;
        }

    }
    }
    public class PersonGroupedByAge
    {
        public int Age { get; set; }

        public List<Person> Persons { get; set; }
    }

    public class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }

    public class Employee : Person
    {
        public int Address { get; set; }
    }
    class LambdaExpressions
    {
        //The name derived from 'lambda' calculus: Mathemetical notion applied for defnition fucntion 
        //Lambda expression's executable part translate login in a ay at run time so that it can pass on to data source conveniently.
        //Lambda expression are limited to find applications in LINQ only.

        //====Syntax
        //(input parameters) => expression or statement block
        //eg: y => y * y

        delegate int del(int i);
        static void Main(string[] args)
        {
            //delegate declaration to multiple integer 
            //1. Expression lambda
            //del myDelegate = y => y * y;
            //int j = myDelegate(5);

            //Console.WriteLine(j);
            //Console.ReadLine();

            //2. Async lambda 
            //Lambda expression created by incoperating asynchonous proccessing by use of async keyword
            //=====syntax 
            //Func<Task<string>> getwordAsync = async ()=> "hello";

            //3. Lamda in Standard Query Operator

            int[] fibNum = {1,2,3,5,8,13,21,34};
            double avgValue = fibNum.Where(num => num % 2 == 1).Average();
            Console.WriteLine(avgValue);
            Console.ReadKey();

            //4. Type Inference in Lambda 
            // Implicit / Explicit
            //delegate int Transformer (int i);


            //5. Variable scope in Lambda Expression 
            //variable declared not available outside lambda 


            //6. Expression tree

            //7. 




            
        }

    }

}
