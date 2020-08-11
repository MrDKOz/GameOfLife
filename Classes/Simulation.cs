using GameOfLife.Models;
using System;
using System.Threading;

namespace GameOfLife.Classes
{
    public enum SimulationState
    {
        Simulating,
        Complete,
        Cancelled
    }

    public class Simulation
    {
        private readonly SimulationConfig _simulationConfig;

        public Simulation(SimulationConfig simulationConfig)
        {
            _simulationConfig = simulationConfig;
        }

        /// <summary>
        /// Runs the simulation to completion.
        /// </summary>
        /// <param name="simProgress">The sim progress.</param>
        public void Simulate(IProgress<GenerationResult> simProgress)
        {
            var generationDetails = new GenerationResult
            {
                Rows = _simulationConfig.Rows,
                Columns = _simulationConfig.Columns
            };

            var currentGeneration = 1;

            // Generate initial seed if needed, otherwise use the provided one
            generationDetails.Snapshot = _simulationConfig.InitialProvided
                ? _simulationConfig.Initial
                : GenerateInitial();

            // Simulation new generations until we either have no changes,
            // or we hit our total generation count
            while (currentGeneration <= _simulationConfig.TotalGenerations)
            {
                generationDetails = GenerateNext(generationDetails);

                generationDetails.Generation = currentGeneration++;

                simProgress.Report(generationDetails);

                Thread.Sleep(_simulationConfig.Frequency);
            }
        }

        /// <summary>
        /// Generates the initial generation.
        /// </summary>
        /// <returns>The seed generation</returns>
        private CitizenState[,] GenerateInitial()
        {
            var state = new CitizenState[_simulationConfig.Rows, _simulationConfig.Columns];
            var random = new Random();

            for (var row = 0; row < _simulationConfig.Rows; row++)
                for (var col = 0; col < _simulationConfig.Columns; col++)
                    state[row, col] = (CitizenState)random.Next(0, 2);

            return state;
        }

        /// <summary>
        /// Generates the next generation, based on the previous one.
        /// </summary>
        /// <param name="seed">The previous generation.</param>
        /// <returns>The new generation</returns>
        private GenerationResult GenerateNext(GenerationResult seed)
        {
            var newGeneration = seed;
            var newState = new CitizenState[_simulationConfig.Rows, _simulationConfig.Columns];

            var deaths = 0;
            var births = 0;
            var survivors = 0;

            for (var row = 0; row < _simulationConfig.Rows; row++)
                for (var col = 0; col < _simulationConfig.Columns; col++)
                {
                    CitizenState newCitizenState;
                    var currentCitizenState = newGeneration.Snapshot[row, col];
                    var livingNeighbours = SimulationHelpers.LivingNeighbourCount(seed.Snapshot, row, col);

                    switch (currentCitizenState)
                    {
                        case CitizenState.Living when livingNeighbours < 2:
                        case CitizenState.Living when livingNeighbours > 3:
                            newCitizenState = CitizenState.Dead;
                            deaths++;
                            break;
                        case CitizenState.Survived when livingNeighbours < 2:
                        case CitizenState.Survived when livingNeighbours > 3:
                            newCitizenState = CitizenState.Dead;
                            deaths++;
                            break;
                        case CitizenState.Dead when livingNeighbours == 3:
                            newCitizenState = CitizenState.Living;
                            births++;
                            break;
                        default:
                            newCitizenState = currentCitizenState;
                            if (newCitizenState == CitizenState.Living || newCitizenState == CitizenState.Survived)
                            {
                                newCitizenState = CitizenState.Survived;
                                survivors++;
                            }

                            break;
                    }

                    newState[row, col] = newCitizenState;
                }

            // Update the generation in the result
            newGeneration.Snapshot = newState;
            newGeneration.Births = births;
            newGeneration.Deaths = deaths;
            newGeneration.Survivors = survivors;

            return newGeneration;
        }
    }
}
