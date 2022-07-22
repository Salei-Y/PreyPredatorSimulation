using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreyPredatorSimulation
{
    internal class Obstacle : Cell
    {
        private const char defaultObstacleImage = '#';

        public Obstacle(Coordinate offset) : base(offset)
        {
            image = defaultObstacleImage;
        }
    }
}
