namespace _02.EnglishNameOfTheLastDigit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int numberLastDigit = Math.Abs(number % 10);

            if (numberLastDigit == 1)
            {
                Console.WriteLine("one");
            }
            else if (numberLastDigit == 2)
            {
                Console.WriteLine("two");
            }
            else if (numberLastDigit == 3)
            {
                Console.WriteLine("three");
            }
            else if (numberLastDigit == 4)
            {
                Console.WriteLine("four");
            }
            else if (numberLastDigit == 5)
            {
                Console.WriteLine("five");
            }
            else if (numberLastDigit == 6)
            {
                Console.WriteLine("six");
            }
            else if (numberLastDigit == 7)
            {
                Console.WriteLine("seven");
            }
            else if (numberLastDigit == 8)
            {
                Console.WriteLine("eight");
            }
            else if (numberLastDigit == 9)
            {
                Console.WriteLine("nine");
            }
            else if (numberLastDigit == 0)
            {
                Console.WriteLine("zero");
            }



        }
    }
}