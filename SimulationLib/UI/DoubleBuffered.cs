namespace SimulationLib.UI
{
    public class DoubleBuffered
    {
            public void CountParticipants(Ocean ocean)
            {
                int preys = 0;
                int predators = 0;

                for (int i = 0; i < ocean.NumRows; i++)
                {
                    for (int j = 0; j < ocean.NumCols; j++)
                    {
                        if (ocean.Cells[i, j].Image == 'f')
                        {
                            preys++;
                        }
                        else if (ocean.Cells[i, j].Image == 'S')
                        {
                            predators++;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }

                ocean.NumPrey = preys;
                ocean.NumPredators = predators;
            }

            public char[,] GetIterationImage(char[,] iterationImage, string stats, Ocean ocean, int iterationRows, int iterationCols)
            {
                for (int i = 0; i < iterationRows; i++)
                {
                    for (int j = 0; j < iterationCols; j++)
                    {
                        if (i == 0)
                        {
                            if (j < stats.Length)
                            {
                                iterationImage[i, j] = stats[j];
                            }
                            else
                            {
                                iterationImage[i, j] = ' ';
                            }
                        }
                        else if (i == 1 || i == iterationRows - 1)
                        {
                            if (j < Variable.numCols)
                            {
                                iterationImage[i, j] = '*';
                            }
                            else
                            {
                                iterationImage[i, j] = ' ';
                            }
                        }
                        else
                        {
                            if (j < Variable.numCols)
                            {
                                iterationImage[i, j] = ocean.Cells[i - 2, j].Image;
                            }
                            else
                            {
                                iterationImage[i, j] = ' ';
                            }
                        }
                    }
                }

                return iterationImage;
            }
        }
    }
