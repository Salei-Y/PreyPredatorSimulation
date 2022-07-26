using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationLib
{
    public class Randomize
    {
        readonly Random rnd = new Random((int)DateTime.Now.Ticks);

        public int randomNumber;

        public int RandomNumber(int maxValue)
        {
            randomNumber = rnd.Next(0, maxValue);

            return randomNumber;
        }
    }
}
