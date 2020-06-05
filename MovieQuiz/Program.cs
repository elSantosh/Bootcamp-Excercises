using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            string customerName = "Santosh";
            Genres favgenres = Genres.Action | Genres.Anime |Genres.Sci_Fi |Genres.Romance |Genres.Drama;

            Customer c = new Customer(customerName, favgenres);
            //// customer.setfavouritemovie(customername, favgenres);
            //console.writeline(cus.favrgenres);
            //console.readkey();

            //var c = new customer();

           // c.favrGenres = Genres.Action | Genres.Sci_Fi | Genres.Fantasy;


            if ((c.favrGenres & Genres.Anime) == Genres.Anime)
                Console.WriteLine("Customer likes Anime");

            if ((c.favrGenres & Genres.Action) == Genres.Action)
                Console.WriteLine("Customer likes Action");


            if (c.favrGenres.HasFlag(Genres.Sci_Fi))
                Console.WriteLine("Customer likes Sci_Fi");

            Console.WriteLine($"Customer's favorites = {c.favrGenres}");
            Console.WriteLine($"Value stored = { (int)c.favrGenres}");

            Console.ReadKey();

            //output
            //Customer likes Action
            //Customer's favorites = Action, Sci_Fi, Fantasy
            //Value stored = 7
        }
    }

   [Flags]
    public enum Genres :  byte
    {
      Action =1,
      Comedy =2,
      Anime=4,
      Fantasy=8,
      Sci_Fi=16,
      Romance = 32,
      Drama = 64,
      Triller = 128
       
    }
    public class Customer
    {

        public string customerName { set; get; }
        public Genres favrGenres { set; get; }

        public Customer(string Name, Genres favGenres)
        {
            customerName = Name;
            favrGenres = favGenres;

        }


        //public static void setFavouriteMovie(string custName, params byte[] genre)
        //{
        //    Customer cus = new Customer();
        //    cus.customerName = custName;
        //    Console.WriteLine(cus.customerName);
        //    for (int i = 0; i < genre.Length; i++)
        //    {
        //        cus.favrGenres = (Genres)genre[i];
        //        Console.WriteLine(cus.favrGenres);
        //    }

        //    Console.ReadKey();
        //}
    }
}


