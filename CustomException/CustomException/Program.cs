//Console.WriteLine("Hello, OS");

namespace CustomException
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number1, Number2, Result;
            try
            {
                Console.WriteLine("Enter First Number:");
                Number1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second Number:");
                Number2 = int.Parse(Console.ReadLine());

                if (Number2 % 2 > 0)
                {
                    //OddNumberException odd = new OddNumberException();
                    //throw odd;
                    throw new OddNumberException("Odd Number Exception");
                }
                else
                {
                    Result = Number1 / Number2;
                    Console.WriteLine($"Result = {Result}");
                }
            }
            catch (OddNumberException odd)
            {
                Console.WriteLine($"Message: {odd.Message}");
                Console.WriteLine($"Source: {odd.Source}");
                Console.WriteLine($"HelpLink: {odd.HelpLink}");
                Console.WriteLine($"StackTrace: {odd.StackTrace}");
            }
            Console.ReadKey();
        }
    }
}

