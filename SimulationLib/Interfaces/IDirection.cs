namespace SimulationLib.Interfaces
{
    public interface IDirection
    {
        Coordinate GetEmptyNeighborCoord(Coordinate coord);

        Coordinate GetPreyNeighborCoord(Coordinate coord);
    }
}
