using System.Threading.Channels;

namespace IterationStatements
{
    public class Program
    {
        
        public static void PrintNumbers1000()
        {
           
            {
                for (int i = 1000; i >= -1000; i--)
                {
                    Console.WriteLine(i);
                }
            }
            
        }

        public static void UpbyThrees()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        public static void TwoNumbersSame(int numOne, int numTwo)
        {
            if (numOne == numTwo)
            {
                Console.WriteLine("{numOne} and {numTwo} are the same!");
            }
            else
            {
                Console.WriteLine($"{numOne} and {numTwo} are not the same!");
            }
            
        }

        public static void EvenOrOdd(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"Even");
            }
            else
            {
                Console.WriteLine($"Odd");
            }
        }

        public static void IsPositive(int number)
        {
            if (number > 0)
            {
                Console.WriteLine("Positive");
            }
            else if (number == 0)
            {
                Console.WriteLine("Zero");
            }
            else
            {
                Console.WriteLine("Negative");
            }
        }

        public static void CanVote()
        {
            Console.WriteLine("Please enter your age:");
            var canParse= int.TryParse(Console.ReadLine(), out int userAge);

            while (canParse == false)
            {
                Console.WriteLine("Please enter a valid age:");
                canParse = int.TryParse(Console.ReadLine(), out userAge);
            }

            if (userAge >= 18)
            {
                Console.WriteLine($"Congrats, {userAge} is old enough to vote!");
            }
            else
            {
                Console.WriteLine($"Sorry, {userAge} is not old enough to vote!");
            }
        }

        public static void TenRange()
        {
            Console.WriteLine("Please give me a number:");
            var canParse = int.TryParse(Console.ReadLine(), out int userNumber);

            while (!canParse)
            {
                Console.WriteLine("Please enter a valid number:");
                canParse = int.TryParse(Console.ReadLine(), out userNumber);
            }

            if (userNumber <= 10 && userNumber >= -10)
            {
                Console.WriteLine($"{userNumber} is in the ten range!");
            }
            else
            {
                Console.WriteLine($"{userNumber} is not in the ten range!");
            }
        }

        public static void MupltiplyThoughTwelve(int number)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} x  {number} = {i * number}");
            }
        }

        static void Main(string[] args)
        {
            //PrintNumbers1000();
            //UpbyThrees();
            //TwoNumbersSame(1, 2);
            //EvenOrOdd(2);
            //IsPositive(2);
            //CanVote();
            //TenRange();
            //MupltiplyThoughTwelve(10);
        }
    }
}

