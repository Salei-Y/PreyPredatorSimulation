using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimulationLib.Interfaces;

namespace SimulationLib
{
    public class ParticipantsDirection : IDirection
    {

        private ICell _ocean;

        Randomize random = new Randomize();

        private int _x;
        private int _y;

        public ParticipantsDirection(ICell ocean)
        {
            _ocean = ocean;
        }


        public Coordinate GetEmptyNeighborCoord(Coordinate coord)
        {
            List<Coordinate> coordinates = new List<Coordinate>();

            int choice;

            if (coord.X + 1 < _ocean.NumRows)
            {
                (_x, _y) = GetSouth(coord);

                if (_ocean.Cells[_x, _y].GetType() == typeof(Cell))
                {
                    coordinates.Add(_ocean.Cells[_x, _y].OffSet);
                }
            }

            if (coord.X - 1 >= 0)
            {
                (_x, _y) = GetNorth(coord);

                if (_ocean.Cells[_x, _y].GetType() == typeof(Cell))
                {
                    coordinates.Add(_ocean.Cells[_x, _y].OffSet);
                }
            }

            if (coord.Y + 1 < _ocean.NumCols)
            {
                (_x, _y) = GetEast(coord);

                if (_ocean.Cells[_x, _y].GetType() == typeof(Cell))
                {
                    coordinates.Add(_ocean.Cells[_x, _y].OffSet);
                }
            }

            if (coord.Y - 1 >= 0)
            {
                (_x, _y) = GetWest(coord);

                if (_ocean.Cells[_x, _y].GetType() == typeof(Cell))
                {
                    coordinates.Add(_ocean.Cells[_x, _y].OffSet);
                }
            }

            if (coord.X + 1 < _ocean.NumRows && coord.Y + 1 < _ocean.NumCols)
            {
                (_x, _y) = GetSouthEast(coord);

                if (_ocean.Cells[_x, _y].GetType() == typeof(Cell))
                {
                    coordinates.Add(_ocean.Cells[_x, _y].OffSet);
                }
            }

            if (coord.X + 1 < _ocean.NumRows && coord.Y - 1 >= 0)
            {
                (_x, _y) = GetSouthWest(coord);

                if (_ocean.Cells[_x, _y].GetType() == typeof(Cell))
                {
                    coordinates.Add(_ocean.Cells[_x, _y].OffSet);
                }
            }

            if (coord.X - 1 >= 0 && coord.Y - 1 >= 0)
            {
                (_x, _y) = GetNorthWest(coord);

                if (_ocean.Cells[_x, _y].GetType() == typeof(Cell))
                {
                    coordinates.Add(_ocean.Cells[_x, _y].OffSet);
                }
            }

            if (coord.X - 1 >= 0 && coord.Y + 1 < _ocean.NumCols)
            {
                (_x, _y) = GetNorthEast(coord);

                if (_ocean.Cells[_x, _y].GetType() == typeof(Cell))
                {
                    coordinates.Add(_ocean.Cells[_x, _y].OffSet);
                }
            }

            if (coordinates.Count == 0)
                return null;

            choice = random.RandomNumber(coordinates.Count - 1);

            return coordinates[choice];
        }

        public Coordinate GetPreyNeighborCoord(Coordinate coord)
        {
            List<Coordinate> coordinates = new List<Coordinate>();

            int choice;

            if (coord.X + 1 < _ocean.NumRows)
            {
                (_x, _y) = GetSouth(coord);

                if (_ocean.Cells[_x, _y].GetType() == typeof(Prey))
                {
                    coordinates.Add(_ocean.Cells[_x, _y].OffSet);
                }
            }

            if (coord.X - 1 >= 0)
            {
                (_x, _y) = GetNorth(coord);

                if (_ocean.Cells[_x, _y].GetType() == typeof(Prey))
                {
                    coordinates.Add(_ocean.Cells[_x, _y].OffSet);
                }
            }

            if (coord.Y + 1 < _ocean.NumCols)
            {
                (_x, _y) = GetEast(coord);

                if (_ocean.Cells[_x, _y].GetType() == typeof(Prey))
                {
                    coordinates.Add(_ocean.Cells[_x, _y].OffSet);
                }
            }

            if (coord.Y - 1 >= 0)
            {
                (_x, _y) = GetWest(coord);

                if (_ocean.Cells[_x, _y].GetType() == typeof(Prey))
                {
                    coordinates.Add(_ocean.Cells[_x, _y].OffSet);
                }
            }

            if (coord.X + 1 < _ocean.NumRows && coord.Y + 1 < _ocean.NumCols)
            {
                (_x, _y) = GetSouthEast(coord);

                if (_ocean.Cells[_x, _y].GetType() == typeof(Prey) )
                {
                    coordinates.Add(_ocean.Cells[_x, _y].OffSet);
                }
            }

            if (coord.X + 1 < _ocean.NumRows && coord.Y - 1 >= 0)
            {
                (_x, _y) = GetSouthWest(coord);

                if (_ocean.Cells[_x, _y].GetType() == typeof(Prey))
                {
                    coordinates.Add(_ocean.Cells[_x, _y].OffSet);
                }
            }

            if (coord.X - 1 >= 0 && coord.Y - 1 >= 0)
            {
                (_x, _y) = GetNorthWest(coord);

                if (_ocean.Cells[_x, _y].GetType() == typeof(Prey))
                {
                    coordinates.Add(_ocean.Cells[_x, _y].OffSet);
                }
            }

            if (coord.X - 1 >= 0 && coord.Y + 1 < _ocean.NumCols)
            {
                (_x, _y) = GetNorthEast(coord);

                if (_ocean.Cells[_x, _y].GetType() == typeof(Prey))
                {
                    coordinates.Add(_ocean.Cells[_x, _y].OffSet);
                }
            }

            if (coordinates.Count == 0)
                return null;

            choice = random.RandomNumber(coordinates.Count - 1);

            return coordinates[choice];
        }

        
        private (int, int) GetNorth(Coordinate coord)
        {
            return (coord.X - 1, coord.Y);
        }

        private (int, int) GetNorthEast(Coordinate coord)
        {
            return (coord.X - 1, coord.Y + 1);
        }

        private (int, int) GetEast(Coordinate coord)
        {
            return (coord.X, coord.Y + 1);
        }

        private (int, int) GetSouthEast(Coordinate coord)
        {
            return (coord.X + 1, coord.Y + 1);
        }

        private (int, int) GetSouth(Coordinate coord)
        {
            return (coord.X + 1, coord.Y);
        }

        private (int, int) GetSouthWest(Coordinate coord)
        {
            return (coord.X + 1, coord.Y - 1);
        }

        private (int, int) GetWest(Coordinate coord)
        {
            return (coord.X, coord.Y - 1);
        }

        private (int, int) GetNorthWest(Coordinate coord)
        {
            return (coord.X - 1, coord.Y - 1);
        }
    }
}
