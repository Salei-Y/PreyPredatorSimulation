using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationLib.CustomExceptions
{
    public class InvalidValueForObjectsException : Exception
    {
        public InvalidValueForObjectsException() : base("The amount of participants cannot be negative or equal to zero.")
        {
        }

        public InvalidValueForObjectsException(string message) : base(message)
        {
        }

        public InvalidValueForObjectsException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
