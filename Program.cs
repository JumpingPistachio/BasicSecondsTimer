using System;
using System.Threading;

namespace SecondsTimer
{
    class Program
    {

        int y;
        int x;
        string z;
        bool loop = false;
        static void Main(string[] args)
        {
            new Program().Run();
        }


        void Run()
        {
            y = 0;
            x = 0;
            Console.WriteLine("How long would you like to set this timer for? (in seconds)");
            z = Console.ReadLine();
            try
            {

                x = int.Parse(z);
                loop = true;
                while (loop = true)
                {
                    if (x == y)
                    {
                        Console.WriteLine("Finished Counting");
                        Thread.Sleep(250);
                        Console.Clear();
                        loop = false;
                        Run();
                    }
                    y += 1;
                    Console.WriteLine(y);
                    Thread.Sleep(1000);

                }

            }
            catch (FormatException)
            {

                Console.WriteLine("That is not a valid number.");
                Thread.Sleep(600);
                Console.Clear();
                Run();

            }
        }

    }
}
