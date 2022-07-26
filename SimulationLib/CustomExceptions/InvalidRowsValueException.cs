using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationLib.CustomExceptions
{
    public class InvalidRowsValueException : Exception
    {
        public InvalidRowsValueException() : base("Invalid value for the number of rows.")
        {
        }

        public InvalidRowsValueException(string message) : base(message)
        {
        }

        public InvalidRowsValueException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
