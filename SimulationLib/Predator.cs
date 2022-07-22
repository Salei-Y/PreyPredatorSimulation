namespace SimulationLib
{
    public class Predator : Prey
    {
        private int timeToFeed;
        private const char defaultPredatorImage = 'S';

        public Predator(Coordinate offset, Ocean ocean, int timeToProcreate, int timeToEat) : base(offset, ocean, timeToProcreate)
        {
             timeToReproduce = timeToProcreate;
            timeToFeed = timeToEat;
            image = defaultPredatorImage;
            wasNotProcessed = false;
        }

        public override Prey Reproduce(Coordinate location)
        {
            if (location != null)
            {
                Predator newborn = new Predator(location, Ocean1, Variable.TimeToReproduce, Variable.TimeToFeed);
                timeToReproduce = Variable.TimeToReproduce;
                return newborn;
            }
            else
            {
                return this;
            }
        }

        protected override void Move(Coordinate oldLocation, Coordinate newLocation, int iteration)
        {
            Coordinate preyLocation = Ocean1.GetPreyNeighborCoord(Offset);

            if (iteration != lastIterationNumber)
            {
                timeToReproduce--;
                timeToFeed--;
                lastIterationNumber = iteration;
            }

            if (timeToFeed <= 0)
            {
                Ocean1.AssignCellAt(oldLocation, new Cell(oldLocation, Ocean1));
            }

            else if (preyLocation != null)
            {
                Ocean1.AssignCellAt(oldLocation, new Cell(oldLocation, Ocean1));
                Ocean1.AssignCellAt(preyLocation, new Predator(preyLocation, Ocean1, timeToReproduce, Variable.TimeToFeed));
            }

            else if (timeToReproduce <= 0)
            {
                Ocean1.AssignCellAt(oldLocation, Reproduce(oldLocation));
                Ocean1.AssignCellAt(newLocation, new Predator(newLocation, Ocean1, timeToReproduce, timeToFeed));
            }

            else
            {
                Ocean1.AssignCellAt(oldLocation, new Cell(oldLocation, Ocean1));
                Ocean1.AssignCellAt(newLocation, new Predator(newLocation, Ocean1, timeToReproduce, timeToFeed));
            }


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
