using System;
namespace dec5lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double givenCandies=Candies(7);
            
            //Console.WriteLine(givenCandies);

            //checking if HowLong works to see how long a string is
            //Console.WriteLine("Please enter a string.");
            //string? userInput = Console.ReadLine();
            //Console.WriteLine(HowLong(userInput));

            Console.WriteLine("enter money");
            string? input = Console.ReadLine();
            double userMoney = Convert.ToDouble(input);
            Moola(userMoney);

                    
        } //end of main method

        public static double Candies(double haveCandies)
        {
            return haveCandies*45;
            
        }

        public static int HowLong(string toCheck)
        {
            int thisLong=0;
            char[] arrayToCheck=toCheck.ToCharArray();
            thisLong=arrayToCheck.Length;
            return thisLong;
        }

        public static void Moola(double userMoney)
        {
            if (userMoney>=500)
            {
                Console.WriteLine("You're rich boii");
            }
            else
            {
                Console.WriteLine("You're poor lol");
            }

        }

    }
}