namespace SimulationLib
{
    public class Obstacle : Cell
    {
        private const char defaultObstacleImage = '#';

        public Obstacle(Coordinate offset, Ocean ocean) : base(offset, ocean)
        {
            image = defaultObstacleImage;
        }
    }
}
