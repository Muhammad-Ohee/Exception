using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    public class OddNumberException : Exception
    {
        //Creating our own Exception Class by inheriting Exception class
        public OddNumberException() : base()
        {
        }

        public OddNumberException(string message) : base(message)
        {
        }

        public OddNumberException(string message, Exception innerException) : base(message, innerException)
        {
        }

        //Overriding the Message property
        /*
        public override string Message
        {
            get
            {
                return "Divisor can't be odd number";
            }
        }
        */



        //Overriding the HelpLink Property
        public override string HelpLink
        {
            get
            {
                return "Get More Information from here: https://learn.microsoft.com/en-us/dotnet/csharp/";
            }
        }
    }
}
