//Console.WriteLine("Hello, OS");

using System.Text;

namespace InnerException
{
    class Program
    {
        static void Main(string[] args)
        {
            // Outer Try
            try
            {
                int FirstNumber, SecondNumber, Result;

                // Inner Try
                try
                {
                    //Make sure to Cause Exception in the Try Block
                    Console.WriteLine("Enter First Number:");
                    FirstNumber = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Second Number:");
                    SecondNumber = Convert.ToInt32(Console.ReadLine());

                    Result = FirstNumber / SecondNumber;
                    Console.WriteLine($"Result = {Result}");
                }

                // Inner Catch
                catch (Exception ex)
                {
                    string FilePath = @"D:\Test\log.txt";
                    if (File.Exists(FilePath))
                    {
                        StringBuilder stringBuilder = new StringBuilder();
                        stringBuilder.AppendLine($"Message: {ex.Message} \n");
                        stringBuilder.AppendLine($"Source: {ex.Source} \n");
                        stringBuilder.AppendLine($"Help Link: {ex.HelpLink} \n");
                        stringBuilder.AppendLine($"Stack Trace: {ex.StackTrace} \n");
                        stringBuilder.AppendLine($"Get type(): {ex.GetType()} \n");
                        stringBuilder.AppendLine($"Get type().Name: {ex.GetType().Name} \n");

                        StreamWriter streamWriter = new StreamWriter(FilePath);
                        streamWriter.WriteLine(stringBuilder.ToString());
                        streamWriter.Close();

                        Console.WriteLine("There is a Problem! Please Try Later");
                        //throw;
                    }
                    else
                    {
                        //To retain the Original Exception pass, this exception as a parameter
                        //to the constructor of the current exception

                        string errorMessage = FilePath + " does not exist";
                        throw new FileNotFoundException(errorMessage, ex);
                    }
                }
            }

            // Outer Catch
            catch (Exception exception)
            {
                //exception.Message will give the current exception message
                //i.e. Message about File Not Found Exception
                Console.WriteLine("\nCurrent Exception Details: ");
                Console.WriteLine($"Current Exception Message: {exception.Message}");
                Console.WriteLine($"Current Exception Source: {exception.Source}");
                Console.WriteLine($"Current Exception StackTrace: {exception.StackTrace}");

                if (exception.InnerException != null)
                {
                    Console.WriteLine("\nInner Exception Details: ");
                    Console.WriteLine($"Inner Exception Message: {exception.InnerException.Message}");
                    Console.WriteLine($"Inner Exception Source: {exception.InnerException.Source}");
                    Console.WriteLine($"Inner Exception StackTrace: {exception.InnerException.StackTrace}");
                }
            }
        }
    }
}

