using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationLib.CustomExceptions
{
    public class InvalidInputIterationsException : Exception
    {
        public InvalidInputIterationsException() : base("The number of iterations cannot be negative or equal to zero. Also it cannot be exceed 1000.")
        {
        }

        public InvalidInputIterationsException(string message) : base(message)
        {
        }

        public InvalidInputIterationsException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
