using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreTestRevision
{

    // Stack & Heap
    // Value and Reference Types
    // Data Types
    // Enum
    // Type Convertion
    // Constants
    // Readonly keyword
    // Variable Operators
    // Conditional Statements
    // Loops
    // Scoping
    // Class 
    // Object
    // Methods
    // - Constructors
    // - Destructors
    // - Virtual Methods
    // Property
    // Generics
    // OOP
    // - Inheritance
    // - Polymorphism
    // - Abstraction
    // - Encapsulation

    // Naming Convension
    // Capital Case with underscore after each new word
    // - Constants
    // Pascal Case
    // - Classes
    // - Methods
    // - Property
    // - Interface (starts with an I)
    // Camel Case
    // - Variables
    // - Parmeters
    // Starts and underscore and is camel case
    // - Private fields
    // Must end with Exception, Attribute
    // - Custom exception 
    // - Custom attribute

    // Generics example - repository pattern
    // Interface
    // Static
    // Async Programming
    // Unit Testing

    // Shortcuts:
    // ctor - constructor
    // prop - property

    // Ctrl + . - suggestion

    class Program
    {
        static async Task Main(string[] args)
        {
            //DoALongProcess();

            //var customer = new Customer();
            //customer.DoALongProcessOfLoadingAllTheProductOfThisCustomer();

            //var file = new BestFile("C://");
            //file.ClearFolder();

            //var c1 = new Customer();
            //Customer.StaticCount++;
            //c1.InstanceCount++;
            //Console.WriteLine($"Static: { Customer.StaticCount }");
            //Console.WriteLine($"Instance: {c1.InstanceCount}");

            //var c2 = new Customer();
            //Customer.StaticCount++;
            //c2.InstanceCount++;
            //Console.WriteLine($"Static: { Customer.StaticCount }");
            //Console.WriteLine($"Instance: {c2.InstanceCount}");

            //var c3 = new Customer();
            //Customer.StaticCount++;
            //c3.InstanceCount++;
            //Console.WriteLine($"Static: { Customer.StaticCount }");
            //Console.WriteLine($"Instance: {c3.InstanceCount}");

            //var doALongProcessTask = DoALongProcess();
            //var fourSecondsOnly = FourSecondsOnly();

            /*var doALongProcessTask = */
            DoALongProcess();
            /*var fourSecondsOnly = */
            FourSecondsOnly();


            Console.WriteLine(Customer.LastInitializeDate.Value);
            AnotherLongPreocess();

            //await fourSecondsOnly;
            //await doALongProcessTask;

            Console.WriteLine(Customer.LastProcessedDate.Value);

            Console.ReadKey();
        }

        static void DoALongProcess()
        {
            /*await*/
            LoadFromFile();

            Customer.LastProcessedDate = DateTime.Now;
        }

        static void LoadFromFile()
        {
            //await Task.Delay(5000);
            System.Threading.Thread.Sleep(5000);
        }

        static void FourSecondsOnly()
        {
            //await Task.Delay(4000);
            System.Threading.Thread.Sleep(4000);
        }

        //static async Task DoALongProcess()
        //{
        //    await LoadFromFile();

        //    Customer.LastProcessedDate = DateTime.Now;
        //}

        //static async Task LoadFromFile()
        //{
        //    await Task.Delay(5000);
        //}

        //static async Task FourSecondsOnly()
        //{
        //    await Task.Delay(4000);
        //}

        static void AnotherLongPreocess()
        {
        }
    }

    public class Customer
    {
        public static int StaticCount { get; set; }

        public static DateTime? LastProcessedDate { get; set; }

        public static DateTime? LastInitializeDate { get; set; } = DateTime.Now;

        public int InstanceCount { get; set; }

        static Customer()
        {
            // Will run only once.
            StaticCount = 1000;

            LongProcessToInitializeSomethingsOnlyOnce();
        }

        private static void LongProcessToInitializeSomethingsOnlyOnce()
        {
        }

        public Customer()
        {
            InstanceCount = 200;
        }

        public void DoALongProcessOfLoadingAllTheProductOfThisCustomer()
        {
            // Long long long process.
            // ...
            // ...  
        }
    }

    public class FileUtilities
    {
        public static bool ClearFolder()
        {
            // Delete all files it path.
            // But not the folder itself.

            return true;
        }
    }

    public class BestFile
    {
        public string Path { get; set; }

        public BestFile(string path)
        {
            Path = path;
        }

        public bool ClearFolder()
        {
            // Delete all files it path.
            // But not the folder itself.

            return true;
        }
    }


    public class ZooKeeper
    {
        public void GiveFood(IEatingAnimal eatingAnimal)
        {
            eatingAnimal.Eat();
        }

        public void LetFlyInsideTheBigCage(List<IFlyingAnimal> flyingAnimals)
        {
            foreach (var flyingAnimal in flyingAnimals)
            {
                flyingAnimal.Fly();
                Console.WriteLine($"{flyingAnimal.Name} flies");
            }
        }
    }

    public interface IAnimal
    {
        void Walk();
    }

    public interface IFlyingAnimal
    {
        string Name { get; }

        void Fly();
    }

    public interface IEatingAnimal
    {
        void Eat();
    }

    public class Animal
    {
        public string Name { get; set; }

        public void Walk()
        {
            Console.WriteLine("Animal walks");
        }
    }

    public class FlyingAnimal : Animal, IFlyingAnimal
    {
        public FlyingAnimal(string name)
        {
            Name = name;
        }

        public void Fly()
        {
            Console.WriteLine("Animal flies");
        }
    }

    public class Bird : FlyingAnimal, IEatingAnimal
    {
        public Bird(string name) : base(name)
        {
        }

        public void Eat()
        {
            Console.WriteLine("The bird eats.");
        }

        //public void Fly()
        //{
        //    Console.WriteLine("Bird flies");
        //}
    }

    public class Dog : Animal, IEatingAnimal
    {
        public void Eat()
        {
            Console.WriteLine("The dog eats.");
        }
    }


    public class BetterSoftFileData<T> : IRepository<T>
    {
        private List<T> _items;

        public void Add(T item)
        {
            // Add to _items
        }

        public IEnumerable<T> Get()
        {
            // Get from _items
            return _items;
        }

        public void Load()
        {
            // Read contents of file.
        }

        public void Remove(T item)
        {
            // Remove from _items
        }

        public void Update(T item)
        {
            // Save the contents to the file.
        }
    }

    public class PersonController
    {
        private IRepository<Person> _personRepository = new BetterSoftFileData<Person>();
        private IRepository<Address> _addressRepository = new BetterSoftFileData<Address>();

        public PersonController()
        {
        }

        //[HttpGet]
        public IEnumerable<Person> Get()
        {
            return _personRepository.Get();
        }

        // [HttpPost]
        public void Post(Person person)
        {
            _personRepository.Add(person);
        }

        //[HttpGet("Address")]
        public IEnumerable<Address> GetAddresses()
        {
            return _addressRepository.Get();
        }
    }

    public interface IRepository<T>
    {
        void Load();

        IEnumerable<T> Get();

        void Add(T item);

        void Remove(T item);

        void Update(T item);
    }

    public class Repository<T> : IRepository<T>
    {
        public List<T> _items;

        public Repository()
        {
            Load();
        }

        public void Load()
        {
            // Load persons from the database, files or other datasource.
            var data = new List<T> { };

            _items = data;
        }

        public IEnumerable<T> Get()
        {
            return _items;
        }

        public void Add(T item)
        {
            _items.Add(item);
            // Call commit changes.
        }

        public void Remove(T item)
        {
            _items.Remove(item);
            // Call commit changes.
        }

        public void Update(T item)
        {
            // Do update.
        }

        public void DoSomeAction()
        {
        }
    }

    public class PersonRepository
    {
        //public List<Person> Persons { get; protected set; }

        public List<Person> _persons;

        public void Load()
        {
            // Load persons from the database, files or other datasource.
            var data = new List<Person> {
                new Person
                {
                    Name = "Albert",
                    Age = 20
                },
                new Person
                {
                    Name = "Grace",
                    Age = 20
                }
            };

            _persons = data;
        }

        public void Add(Person person)
        {
            _persons.Add(person);
            // Call commit changes.
        }

        public void Remove(Person person)
        {
            _persons.Remove(person);
            // Call commit changes.
        }
    }

    public class AddressRepository
    {
        public List<Address> _addresses;

        public void Load()
        {
            // Load persons from the database, files or other datasource.
            var data = new List<Address> { };

            _addresses = data;
        }

        public void Add(Address address)
        {
            _addresses.Add(address);
            // Call commit changes.
        }

        public void Remove(Address address)
        {
            _addresses.Remove(address);
            // Call commit changes.
        }
    }

    public class Address
    {
        public long AddressID { get; set; }

        public long PersonID { get; set; }

        public string Line1 { get; set; }

        public string Line2 { get; set; }

        public string State { get; set; }

        public string PostalCode { get; set; }
    }

    public class Person
    {
        // Constants
        #region "Constants"
        private const string DEFAULT_NAME = "Unknown";

        private const int CONSTANT_DEFAULT_AGE = 13;
        #endregion "Constants"

        // Fields


        // Properties
        #region "Properties"
        public long PersonID { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }
        #endregion "Properties"


        // Constructors
        public Person() : base()
        {
            Name = DEFAULT_NAME;
            Age = 13;
        }

        public Person(string name) : base()
        {
            Name = name;
            ++Age;
        }

        public Person(string name, int age) : this()
        {
            Name = name;
            Age = age;
        }

        // Methods
        #region "Methods"

        #region "File Operations"

        #endregion "File Operations"

        #endregion "Methods"
    }


    public class MyGenericList<T>
    {
        private List<T> _internal;

        public MyGenericList()
        {
            _internal = new List<T>();
        }

        public void Add(T value)
        {
            _internal.Add(value);
        }

        private void Remove(T value)
        {
            _internal.Remove(value);
        }
    }

    public class MyIntegerList
    {
        private List<int> _internal;

        public MyIntegerList()
        {
            _internal = new List<int>();
        }

        public void Add(int value)
        {
            _internal.Add(value);
        }

        private void Remove(int value)
        {
            _internal.Remove(value);
        }
    }

    public class MyDoubleList
    {
        private List<double> _internal;

        public MyDoubleList()
        {
            _internal = new List<double>();
        }

        public void Add(double value)
        {
            _internal.Add(value);
        }

        private void Remove(double value)
        {
            _internal.Remove(value);
        }
    }



    public class Club
    {
        public bool IsOfLegalAge(int age)
        {
            if (age >= AgeRegulationConstants.LEGAL_AGE)
            {
                return true;
            }

            return false;
        }
    }

    public class AgeRegulationConstants
    {
        public const int LEGAL_AGE = 18;
    }

    public class AgeRegulation
    {
        public int LegalAge { get; } = AgeRegulationConstants.LEGAL_AGE;

        public AgeRegulation()
        {
        }

        public AgeRegulation(int legalAge)
        {
            LegalAge = legalAge;
        }
    }

    public class InvalidTransaction : ApplicationException
    {
        public int StatusCode { get; }

        public InvalidTransaction(int statusCode, string message) : base(message)
        {
            StatusCode = statusCode;
        }
    }

    public enum Month
    {
        Jan = 1,
        Feb,
        Mar,
        Apr,
        Jun = 6,
        Jul,
        Aug
    }

    [Flags]
    public enum Options
    {
        HasSpecialOrder = 1,

        HasAdditionalRequest = 2
    }
}
