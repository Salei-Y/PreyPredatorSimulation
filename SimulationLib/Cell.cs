using SimulationLib.Interfaces;

namespace SimulationLib
{
    public class Cell
    {
        protected ICell ocean;
        private Coordinate _offset;
        public char image;

        public bool wasNotProcessed = false;



        public Coordinate OffSet
        {
            get { return _offset; }
            set { _offset = value; }
        }

        public char Image
        {
            get { return image; }
        }


        public Cell(Coordinate offset, ICell owner)
        {
            image = '-';
            _offset = offset;
            ocean = owner;
        }


        protected void AssignCellAt(Coordinate location, Cell cell)
        {
            if (location != null)
            {
                ocean.Cells[location.X, location.Y] = cell;
            }
        }

        public virtual void Process(int iteration)
        {
        }
    }
}
