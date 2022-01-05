using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main start");

            Thread th1 = new Thread(Thread1);
            Thread th2 = new Thread(Thread2);

            th1.Start();
            th2.Start();

            if (th1.Join(1000))
            {
                Console.WriteLine("Done");
            }
            else
            {
                Console.WriteLine("Not done");
            }

            th2.Join();
            Console.WriteLine("Join 2");

            if (th1.IsAlive)
            {
                Console.WriteLine("1 live");
            }
            else
            {
                Console.WriteLine("1 dead");
            }

            Console.WriteLine("Main end");
        }

        public static void Thread1()
        {
            Console.WriteLine("1 start");
            Thread.Sleep(3000);
            Console.WriteLine("1 end");
        }

        public static void Thread2()
        {
            Console.WriteLine("2 start");
        }
    }
}
