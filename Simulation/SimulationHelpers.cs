using GameOfLife.Models;

namespace GameOfLife.Simulation
{
    public static class SimulationHelpers
    {
        /// <summary>
        /// Returns the living neighbour count
        /// </summary>
        /// <param name="state">The current Citizen state.</param>
        /// <param name="row">The index of the row to check.</param>
        /// <param name="col">The index of the column to check.</param>
        /// <returns>The number of living neighbours.</returns>
        public static int LivingNeighbourCount(CitizenState[,] state, int row, int col)
        {
            var livingNeighbors = 0;

            for (var x = -1; x <= 1; x++)
            {
                for (var y = -1; y <= 1; y++)
                {
                    var rowRef = row + x;
                    var colRef = col + y;

                    if (rowRef >= state.GetLowerBound(0) && rowRef <= state.GetUpperBound(0) &&
                        colRef >= state.GetLowerBound(1) && colRef <= state.GetUpperBound(1) &&
                        state[rowRef, colRef] != CitizenState.Dead)
                        livingNeighbors++;
                }
            }

            if (state[row, col] == CitizenState.Living || state[row, col] == CitizenState.Survived) livingNeighbors -= 1;

            return livingNeighbors;
        }
    }
}
