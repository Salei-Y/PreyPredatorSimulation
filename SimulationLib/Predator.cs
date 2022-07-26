using SimulationLib.Interfaces;

namespace SimulationLib
{
        public class Predator : Prey
        {
            #region [Variables]

            protected int timeToFeed;

            #endregion

            #region [Constructor]

            public Predator(Coordinate offset, ICell ocean, int timeToProcreate, int timeToEat) : base(offset, ocean, timeToProcreate)
            {
                _timeToReproduce = timeToProcreate;
                timeToFeed = timeToEat;
                image = Variable.defaultPredatorImage;

                wasNotProcessed = false;

                dir = new ParticipantsDirection(ocean);
            }

            #endregion

            #region [Methods]

            protected override Prey Reproduce(Coordinate coord)
            {
                if (coord != null)
                {
                    Predator newborn = new Predator(coord, ocean, Variable.TimeToReproduce, Variable.TimeToFeed);
                    _timeToReproduce = Variable.TimeToReproduce;

                    return newborn;
                }
                else
                {
                    return this;
                }
            }

            protected override void Move(Coordinate oldCoord, Coordinate newCoord, int iteration)
            {
                Coordinate preyCoord = dir.GetPreyNeighborCoord(OffSet);

                if (iteration != lastIterationNumber)
                {
                    _timeToReproduce--;
                    timeToFeed--;
                    lastIterationNumber = iteration;
                }

                if (timeToFeed <= 0)
                {
                    AssignCellAt(oldCoord, new Cell(oldCoord, ocean));
                }
                else if (preyCoord != null)
                {
                    AssignCellAt(oldCoord, new Cell(oldCoord, ocean));
                    AssignCellAt(preyCoord, new Predator(preyCoord, ocean, _timeToReproduce, Variable.TimeToFeed));
                }
                else if (_timeToReproduce <= 0)
                {
                    if (preyCoord != null)
                    {
                        AssignCellAt(oldCoord, Reproduce(oldCoord));
                        AssignCellAt(preyCoord, new Predator(preyCoord, ocean, _timeToReproduce, Variable.TimeToFeed));
                    }
                    else
                    {
                        AssignCellAt(oldCoord, Reproduce(oldCoord));
                        AssignCellAt(newCoord, new Predator(newCoord, ocean, _timeToReproduce, timeToFeed));
                    }
                }
                else
                {
                    AssignCellAt(oldCoord, new Cell(oldCoord, ocean));
                    AssignCellAt(newCoord, new Predator(newCoord, ocean, _timeToReproduce, timeToFeed));
                }
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

            #endregion
        }
    }
