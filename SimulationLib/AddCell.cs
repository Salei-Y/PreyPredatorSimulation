using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationLib
{
    public class AddCell
    {
        readonly Random random = new Random((int)DateTime.Now.Ticks);

        public void AddAllCells(Ocean ocean)
        {
            AddEmptyCells(ocean);
            AddObstacles(ocean);
            AddPredators(ocean);
            AddPrey(ocean);
        }

        private Coordinate GetEmptyCellCoord(Ocean ocean)
        {
            Coordinate location = new Coordinate();

            for (int i = 0; i < (ocean.NumCols * ocean.NumRows); i++)
            {
                int RowCoord = random.Next(0, ocean.NumRows);
                int ColCoord = random.Next(0, ocean.NumCols);

                if (ocean.cells[RowCoord, ColCoord].GetType() == typeof(Cell))
                {
                    location.X = RowCoord;
                    location.Y = ColCoord;

                    break;
                }
            }

            return location;
        }


        private void AddEmptyCells(Ocean ocean)
        {
            for (int i = 0; i < ocean.NumRows; i++)
            {
                for (int j = 0; j < ocean.NumCols; j++)
                {
                    ocean.cells[i, j] = new Cell(new Coordinate
                    {
                        X = i,
                        Y = j,
                    }, ocean);
                }
            }
        }
        private void AddObstacles(Ocean ocean)
        {
            for (int i = 0; i < ocean.NumObstacles; i++)
            {
                Coordinate location = GetEmptyCellCoord(ocean);
                ocean.cells[location.X, location.Y] = new Obstacle(location, ocean);
            }
        }

        private void AddPredators(Ocean ocean)
        {
            for (int i = 0; i < ocean.NumPredators; i++)
            {
                Coordinate location = GetEmptyCellCoord(ocean);
                ocean.cells[location.X, location.Y] = new Predator(location, ocean, Variable.TimeToReproduce, Variable.TimeToFeed);
            }
        }

        private void AddPrey(Ocean ocean)
        {
            for (int i = 0; i < ocean.NumPrey; i++)
            {
                    Coordinate location = GetEmptyCellCoord(ocean);
                    ocean.cells[location.X, location.Y] = new Prey(location, ocean, Variable.TimeToReproduce);
            }
        }
    }
}
