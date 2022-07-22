using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreyPredatorSimulation
{
    internal class Predator : Prey
    {
        private int timeToFeed;
        private const char defaultPredatorImage = 'S';

        public Predator(Coordinate offset) : base(offset)
        {
            timeToFeed = 6;
            timeToReproduce = 6;
            image = defaultPredatorImage;
        }

        protected override void Reproduce(Coordinate anOffset)
        {
            base.Reproduce(anOffset);
        }

        protected override void MoveFrom(Coordinate oldPosition, Coordinate newPosition)
        {
            AssignCellAt(oldPosition, new Cell(oldPosition));
            AssignCellAt(newPosition, new Predator(newPosition));
        }

        public override void Process()
        {
            Coordinate newPosition = GetEmptyNeighborCoord(Offset);
            if (newPosition != Offset)
                MoveFrom(Offset, newPosition);
        }
    }
}
