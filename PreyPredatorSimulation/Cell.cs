using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreyPredatorSimulation
{
    internal class Cell
    {
        Ocean Ocean1 = new Ocean();
        private Coordinate offset;
        protected char image;

        public Coordinate Offset
        {
            get { return offset; }
            set { offset = value; }
        }
        public char Image
        {
            get { return image; }
        }

        public Cell(Coordinate offset)
        {
            image = '-';
            this.offset = offset;
        }

        public void Display() //Displays cell image
        {
            Console.Write(image);
        }

        protected Coordinate GetEmptyNeighborCoord(Coordinate position) //Returns empty neighbor coordinate 
        {
            List<Coordinate> coordinates = new List<Coordinate>();
            if (position.X + 1 < Ocean.NumRows)
                if (Ocean.Cells[position.X + 1, position.Y].image == '-')
                    coordinates.Add(Ocean.Cells[position.X + 1, position.Y].Offset);
            if (position.X - 1 >= 0)
                if (Ocean.Cells[position.X - 1, position.Y].image == '-')
                    coordinates.Add(Ocean.Cells[position.X - 1, position.Y].Offset);
            if (position.Y + 1 < Ocean.NumCols)
                if (Ocean.Cells[position.X, position.Y + 1].image == '-')
                    coordinates.Add(Ocean.Cells[position.X, position.Y + 1].Offset);
            if (position.Y - 1 >= 0)
                if (Ocean.Cells[position.X, position.Y - 1].image == '-')
                    coordinates.Add(Ocean.Cells[position.X, position.Y - 1].Offset);

            if (coordinates.Count == 0)
                return null;

            return coordinates[Ocean.random.Next(0, coordinates.Count - 1)];
        }

        protected Coordinate GetPreyNeighborCoord() //Returns prey neighbor coordinate
        {
            return null;
        }

        protected Cell GetCellAt(Coordinate position) //Returns cell by position
        {
            return Ocean.Cells[position.X, position.Y];
        }

        private Cell GetEastCell() //Returns east neighbour cell
        {
            return null;
        }

        private Cell GetWesternCell() //Returns western neighbour cell
        {
            return null;
        }

        private Cell GetSouthCell() //Returns south neighbour cell
        {
            return null;
        }

        private Cell GetNorthCell() //Returns north neighbour cell
        {
            return null;
        }

        protected void AssignCellAt(Coordinate position, Cell cell) //Changes the value of cell
        {
            if (position != null)
                Ocean.Cells[position.X, position.Y] = cell;
        }

        public virtual void Process()
        {
        }
    }
}