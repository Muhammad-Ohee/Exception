//Console.WriteLine("Hello, OS");

namespace TheFinallyBlock
{
    class Program
    {
        static void SomeMethod()
        {
            try
            {
                Console.WriteLine("Inside SomeMethod");
                int num1 = 10, num2 = 0;
                int result = num1 / num2; //Exception will be thrown here
                Console.WriteLine($"Result: {result}");
            }
            finally
            {
                Console.WriteLine("SomeMethod finally Block");
            }
        }

        static void Main(string[] args)
        {
            try
            {
                SomeMethod();
            }
            catch (Exception)
            {
                Console.WriteLine("Exception Caught");
            }

            Console.WriteLine();

            int Number1, Number2, Result;
            try
            {
                Console.WriteLine("Enter First Number");
                Number1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second Number");
                Number2 = int.Parse(Console.ReadLine());
                Result = Number1 / Number2;
                Console.WriteLine($"Result: {Result}");
            }
            catch (DivideByZeroException DBZE)
            {
                Console.WriteLine("Divisor Should Not Be Zero");
            }
            catch (FormatException FE)
            {
                Console.WriteLine("Enter Only Integer Numbers");
            }
            finally
            {
                Console.WriteLine("This is finally block, executed.");
            }
            //Console.ReadKey();
        }
    }
}

