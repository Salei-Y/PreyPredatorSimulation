using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationLib.CustomExceptions
{
    public class InvalidColumnsValueException : Exception
    {
        public InvalidColumnsValueException() : base("Invalid value for the number of columns.")
        {
        }

        public InvalidColumnsValueException(string message) : base(message)
        {
        }

        public InvalidColumnsValueException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
