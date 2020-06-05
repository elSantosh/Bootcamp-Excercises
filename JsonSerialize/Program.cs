using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JsonSerialize
{
    //useed to serialize json data into class instance,data files. 
    //used to deserilaise json data
    //Deserilise 
    //Serialise 
    //Package NewtonSoft.net version 6.0.0

    public class Program
    {
        public class Employee
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public bool IsManager { get; set; }
            public DateTime JoinedDate { get; set; }
            public IList<string> Titles { get; set; }
        }

        public static void Main()
        {
            string json = @"{
                          'FirstName': 'Santosh',
                          'LastName': 'Kumar',
                          'IsManager': false,
                          'JoinedDate': '2014-02-10T00:00:00Z',
                          'Titles': [
                            'Sr. Software Engineer',
                            'Applications Developer'
                          ]
                        }";

            Employee employee = JsonConvert.DeserializeObject<Employee>(json);

            Console.WriteLine(employee.FirstName);
            Console.WriteLine(employee.LastName);
            Console.WriteLine(employee.JoinedDate);
            foreach (string title in employee.Titles)
            {
                Console.WriteLine("{0}", title); 
            }

            //serializing the object using json
            string jsonString  = JsonConvert.SerializeObject(employee, Formatting.Indented);
            Console.WriteLine(jsonString);
            Console.ReadKey();

        }
    }
}
