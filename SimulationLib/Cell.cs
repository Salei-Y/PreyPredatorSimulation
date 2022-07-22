namespace SimulationLib
{
    public class Cell
    {
        protected Ocean Ocean1 = new Ocean();
        public Coordinate offset;
        public char image;
        public bool wasNotProcessed = false;

        public Coordinate Offset
        {
            get { return offset; }
            set { offset = value; }
        }

        public char Image
        {
            get { return image; }
        }

        public Cell(Coordinate offset, Ocean ocean)
        {
            image = '-';
            this.offset = offset;
            Ocean1 = ocean;
        }

        public virtual void Process(int iteration)
        {
        }
    }
}
