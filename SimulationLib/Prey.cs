using SimulationLib.Interfaces;

namespace SimulationLib
{
    public class Prey : Cell
    {

        public const char defaultPreyImage = 'f';
        protected int _timeToReproduce = 6;
        protected int lastIterationNumber = 0;

        protected IDirection dir;


        public Prey(Coordinate offset, ICell ocean, int timeToProcreate) : base(offset, ocean)
        {
            _timeToReproduce = timeToProcreate;
            image = Variable.defaultPreyImage;

            wasNotProcessed = false;

            dir = new ParticipantsDirection(ocean);
        }


        protected virtual Prey Reproduce(Coordinate coord)
        {
            if (coord != null)
            {
                Prey newborn = new Prey(coord, ocean, 6);
                _timeToReproduce = 6;

                return newborn;
            }
            else
            {
                return this;
            }
        }

        protected virtual void Move(Coordinate oldCoord, Coordinate newCoord, int iteration)
        {
            if (iteration != lastIterationNumber)
            {
                _timeToReproduce--;
                lastIterationNumber = iteration;
            }

            if (_timeToReproduce <= 0)
            {
                AssignCellAt(oldCoord, Reproduce(oldCoord));
            }
            else
            {
                AssignCellAt(oldCoord, new Cell(oldCoord, ocean));
            }
            AssignCellAt(newCoord, new Prey(newCoord, ocean, _timeToReproduce));
        }

        public override void Process(int iteration)
        {
            if (wasNotProcessed == true)
            {
                if (dir.GetEmptyNeighborCoord(OffSet) != OffSet)
                {
                    Move(OffSet, dir.GetEmptyNeighborCoord(OffSet), iteration);
                }
            }
        }
    }
}
