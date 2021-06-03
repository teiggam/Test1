using System;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sing along with me!");

            bool goOn = true;
            while (goOn == true)
            {



                Console.Write("I'm a little teapot.");
                Console.WriteLine("");
                string responseONE = Console.ReadLine();

                if (responseONE.ToLower().StartsWith("short and stout"))
                {
                    Console.WriteLine("Here is my handle, here is my spout!");
                    goOn = false;
                }
                else
                {
                    GetContinue();
                }

            }


        }
        public static bool GetContinue()
        {
            Console.WriteLine();
            Console.WriteLine("Those aren't the words!  Try again?");
            string answer = Console.ReadLine();

            if (answer.ToLower() == "y")
            {
                return true;
            }
            else if (answer.ToLower() == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("I didn't understand your response, please try again...");
            }
            return GetContinue();

        }


    }
}
