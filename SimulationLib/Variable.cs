namespace SimulationLib
{
    public class Variable
    {
        public static int numRows = 25;
        public static int numCols = 70;
        public static int size = numRows * numCols; 
        public static int numPrey = 150;
        public static int numPredators = 20;
        public static int numObstacles = 75; 
        public const int TimeToFeed = 6;
        public const int TimeToReproduce = 6;
        public const char defaultPreyImage = 'f';
        public const char defaultPredatorImage = 'S';
    }
}
