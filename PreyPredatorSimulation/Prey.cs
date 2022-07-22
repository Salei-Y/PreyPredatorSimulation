using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreyPredatorSimulation
{
    internal class Prey : Cell
    {
        private const char defaultPreyImage = 'f';
        protected int timeToReproduce;

        public Prey(Coordinate offset) : base(offset)
        {
            timeToReproduce = 6;
            image = defaultPreyImage;
        }

        protected virtual void Reproduce(Coordinate position)
        {
            Ocean.Cells[position.X, position.Y] = new Prey(position);
        }

        protected virtual void MoveFrom(Coordinate oldPosition, Coordinate newPosition)
        {
            AssignCellAt(oldPosition, new Cell(oldPosition));
            AssignCellAt(newPosition, new Prey(newPosition));
        }

        public override void Process()
        {
            Coordinate newPosition = GetEmptyNeighborCoord(Offset);
            if (newPosition != Offset)
                MoveFrom(Offset, newPosition);
        }
    }
}