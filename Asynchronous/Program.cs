using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asynchronous
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var taskOne = RequestForLaptopReplacement();
            var taskTwo = SeekClarificationWithStakeHolder();
            var taskThree = SketIdeas();
            var taskFour = IsInterruptedByCollegue();

            await taskOne;
            await taskTwo;
            await taskThree;
            await taskFour;

            Console.ReadKey();


        }

        public static async Task RequestForLaptopReplacement()
        {
            Console.WriteLine("request for laptop replacement");

            await Task.Delay(5000);

        }
        public static async Task SeekClarificationWithStakeHolder()
        {
            Console.WriteLine("seek clasrification from stakeHoder");

            await Task.Delay(5000);

        }
        public static async Task SketIdeas()
        {
            Console.WriteLine("sketch ideas");

            await Task.Delay(5000);

        }
        public static async Task IsInterruptedByCollegue()
        {
            Console.WriteLine("Interrupted by collegue");

            await Task.Delay(5000);

        }
    }
}
