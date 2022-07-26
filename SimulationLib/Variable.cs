namespace SimulationLib
{
    public class Variable
    {
        public const int numRows = 25;
        public const int numCols = 70;
        public static int size = numRows * numCols; 
        public static int numPreys = 150;
        public static int numPredators = 20;
        public static int numObstacles = 75; 
        public const int TimeToFeed = 6;
        public const int TimeToReproduce = 6;
        public const char defaultPreyImage = 'f';
        public const char defaultPredatorImage = 'S';
        public const int defaultNumIterations = 1000;
        public const int FrameChangeDelay = 1600;
        public const int TimerInterval = 170;
    }
}
