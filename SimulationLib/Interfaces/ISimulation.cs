namespace SimulationLib.Interfaces
{
    interface ISimulation
    {
        Coordinate GetEmptyNeighborCoord(Coordinate coord);
        Coordinate GetPreyNeighborCoord(Coordinate coord);

        Cell[,] Cells { get; }
    }
}
