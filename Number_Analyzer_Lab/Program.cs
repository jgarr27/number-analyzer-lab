using System;

namespace Number_Analyzer_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool again = true;

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            do
            {
                Console.WriteLine(name + ", Please enter a number between 1 and 100");
                int num = int.Parse(Console.ReadLine());

                if (num % 2 != 0 && num < 60)
                {
                    Console.WriteLine(name + ", " + num + " is odd and less than 60");
                }
                else if (num % 2 == 0 && num <= 24)
                {
                    Console.WriteLine(name + ", " + num + " is even and less than 25");
                }
                else if (num % 2 == 0 && num >= 26 && num <= 68)
                {
                    Console.WriteLine(name + ", " + num + " is even and between 26 and 60 inclusive");
                }
                else if (num % 2 == 0 && num > 60)
                {
                    Console.WriteLine(name + ", " + num + " is even and greater than 60");
                }
                else if (num % 2 != 0 && num > 60)
                {
                    Console.WriteLine(name + ", " + num + " is odd and greater than 60");
                }
                Console.WriteLine(name + ", would you like to restart? yes or no");
                string answer = Console.ReadLine();

                if (answer == "no")
                {
                    break;
                }
            }
            while (again = true);
        }
    }
}