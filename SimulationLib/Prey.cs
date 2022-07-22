namespace SimulationLib
{
    public class Prey : Cell
    {

        public const char defaultPreyImage = 'f';
        protected int timeToReproduce = 6;
        protected int lastIterationNumber = 0;

        public Prey(Coordinate offset, Ocean ocean, int timeToProcreate) : base(offset, ocean)
        {
            timeToReproduce = timeToProcreate;
            image = defaultPreyImage;
            wasNotProcessed = false;
        }

        public virtual Prey Reproduce(Coordinate location)
        {
            if (location != null)
            {
                Prey newborn = new Prey(location, Ocean1, Variable.TimeToReproduce);
                timeToReproduce = Variable.TimeToReproduce;

                return newborn;
            }
            else
            {
                return this;
            }
        }

        protected virtual void Move(Coordinate oldLocation, Coordinate newLocation, int iteration)
        {
            if (iteration != lastIterationNumber)
            {
                timeToReproduce--;
                lastIterationNumber = iteration;
            }

            if (timeToReproduce <= 0)
            {
                Ocean1.AssignCellAt(oldLocation, Reproduce(oldLocation));
            }
            else
            {
                Ocean1.AssignCellAt(oldLocation, new Cell(oldLocation, Ocean1));
            }
            Ocean1.AssignCellAt(newLocation, new Prey(newLocation, Ocean1, timeToReproduce));
        }

        public override void Process (int iteration)
        {
            if (wasNotProcessed == true)
            {
                if (Ocean1.GetEmptyNeighborCoord(Offset) != Offset)
                {
                    Move(Offset, Ocean1.GetEmptyNeighborCoord(Offset), iteration);
                }
            }
        }
    }
}
