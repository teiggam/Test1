using System;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sing along with me!");

            string repeat;

            do
            {

                Console.Write("I'm a little teapot.");
                Console.WriteLine("");
                string responseONE = Console.ReadLine();

                if (responseONE.ToLower().StartsWith("short and stout"))
                {
                    Console.WriteLine("Here is my handle, here is my spout!");
                }


                else
                {
                    Console.WriteLine("Those aren't the words!");
                }

                    Console.WriteLine("Try again?");
                    Console.WriteLine("");
                    repeat = Console.ReadLine();
           

            } 
            while (string.Equals(repeat, "yes", StringComparison.OrdinalIgnoreCase));

            }

      

        }
    }
