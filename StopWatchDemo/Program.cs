using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatchDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press enter to start the timer.");
            Console.ReadLine();
            Stopwatch watch = new Stopwatch();
            watch.Start();

            Console.WriteLine("Press enter to stop the timer.");
            Console.ReadLine();
            watch.Stop();

            Console.ReadLine();
        }
    }
}
