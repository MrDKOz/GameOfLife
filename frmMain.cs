using GameOfLife.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameOfLife.Simulation;

namespace GameOfLife
{
    public partial class frmMain : Form
    {
        public enum SimulationState
        {
            Waiting,
            Starting,
            Simulating,
            Finished
        }

        private SimulationState _currentSimulationState;

        public SimulationState CurrentSimulationState
        {
            get => _currentSimulationState;
            set
            {
                _currentSimulationState = value;
                ManageUI();
            }
        }

        public frmMain()
        {
            InitializeComponent();

            CurrentSimulationState = SimulationState.Waiting;
        }

        /// <summary>
        /// Builds the simulation config, and starts processing.
        /// </summary>
        private async void btnStartSimulation_Click(object sender, EventArgs e)
        {
            // Build up our config, ready to send
            var simulationConfig = new SimulationConfig
            {
                Rows = Convert.ToInt32(nudRows.Text),
                Columns = Convert.ToInt32(nudColumns.Text),
                Frequency = Convert.ToInt32(nudFrequency.Text),
                TotalGenerations = Convert.ToInt32(nudTotalGenerations.Text),
                InitialProvided = pnlGenerationSnapshot.Controls.Count > 0
            };

            // Create a new board, or just continue with the pre-defined
            CurrentSimulationState = SimulationState.Starting;

            if (simulationConfig.InitialProvided)
                simulationConfig.Initial = FetchInitialGeneration(simulationConfig.Rows, simulationConfig.Columns);
            else
                CreateGrid(simulationConfig.Rows, simulationConfig.Columns);

            // Update UI
            prgTotal.Value = 0;
            prgTotal.Maximum = simulationConfig.TotalGenerations;

            // Point our updates, and start the simulation
            var generations = new Progress<GenerationResult>(DisplayResults);
            var simulator = new Simulator(simulationConfig);

            CurrentSimulationState = SimulationState.Simulating;
            await Task.Run(() => simulator.Simulate(generations));
        }

        /// <summary>
        /// Creates a new grid on which to display the current generation.
        /// </summary>
        /// <param name="rows">Number of Rows</param>
        /// <param name="cols">Number of Columns</param>
        private void CreateGrid(int rows, int cols)
        {
            pnlGenerationSnapshot.Controls.Clear();

            for (var row = 0; row < rows; row++)
                for (var col = 0; col < cols; col++)
                {
                    var checkBox = new CheckBox
                    {
                        Name = $"chk{row}{col}",
                        Location = new Point(15 * row, 15 * col),
                        Size = new Size(15, 15),
                    };

                    pnlGenerationSnapshot.Controls.Add(checkBox);
                }
        }

        /// <summary>
        /// Displays the results of the generation.
        /// </summary>
        /// <param name="generation">The generation to display.</param>
        private void DisplayResults(GenerationResult generation)
        {
            // Display the current generation
            for (var row = 0; row < generation.Rows; row++)
                for (var column = 0; column < generation.Columns; column++)
                {
                    var cell = generation.Snapshot[row, column];

                    if (!(pnlGenerationSnapshot.Controls.Find($"chk{row}{column}", false).First() is CheckBox focusButton)) continue;

                    if (cell == CitizenState.Survived)
                        focusButton.CheckState = CheckState.Indeterminate;
                    else
                        focusButton.Checked = cell == CitizenState.Living;
                }

            // Update progress
            OutputGenerationStatistics(generation);
            prgTotal.PerformStep();

            // Change state when simulation is complete
            if (generation.Generation == generation.TargetGenerations)
                CurrentSimulationState = SimulationState.Finished;
        }

        /// <summary>
        /// Outputs the generation statistics to the log within the UI.
        /// </summary>
        /// <param name="generation">The generation to output the statistics for.</param>
        private void OutputGenerationStatistics(GenerationResult generation)
        {
            var output = new StringBuilder();

            output.Append($"[Generation {generation.Generation}] ✔ {generation.Births} | ❌ {generation.Deaths} | = {generation.Survivors} | ⏲ {generation.TimeTaken}");

            lstLog.Items.Add(output);
        }

        /// <summary>
        /// Controls which controls can be interacted with
        /// depending on the current simulation state.
        /// </summary>
        private void ManageUI()
        {
            switch (CurrentSimulationState)
            {
                case SimulationState.Waiting:
                    prgTotal.Value = 0;
                    grpSeedAndSimulationControls.Enabled = true;
                    btnDefineStartingGeneration.Enabled = true;
                    btnStart.Text = "Start";
                    btnStart.Enabled = true;
                    btnReset.Enabled = false;
                    lstLog.Items.Clear();
                    pnlGenerationSnapshot.Controls.Clear();
                    break;
                case SimulationState.Starting:
                    prgTotal.Value = 0;

                    grpSeedAndSimulationControls.Enabled = false;
                    btnDefineStartingGeneration.Enabled = false;
                    btnStart.Enabled = false;
                    btnReset.Enabled = false;
                    break;
                case SimulationState.Simulating:
                    grpSeedAndSimulationControls.Enabled = false;
                    btnDefineStartingGeneration.Enabled = false;
                    btnStart.Enabled = false;
                    btnReset.Enabled = false;
                    break;
                case SimulationState.Finished:
                    grpSeedAndSimulationControls.Enabled = false;
                    btnDefineStartingGeneration.Enabled = false;
                    btnStart.Text = "Step";
                    btnStart.Enabled = true;
                    btnReset.Enabled = true;
                    break;
            }

            Text = $"Conway's Game of Life Simulator [{CurrentSimulationState}]";
        }

        /// <summary>
        /// Generates an empty, editable board.
        /// </summary>
        private void btnDefineStartingGeneration_Click(object sender, EventArgs e)
        {
            var button = (Button) sender;

            if (button.Text.Contains("Remove"))
            {
                pnlGenerationSnapshot.Controls.Clear();

                button.Text = "Define Starting Generation";
            }
            else
            {
                CreateGrid(Convert.ToInt32(nudRows.Value), Convert.ToInt32(nudColumns.Value));

                button.Text = "Remove Current Grid";
            }
        }

        /// <summary>
        /// Fetches the initial generation from the given board.
        /// </summary>
        /// <param name="rows">The number of rows.</param>
        /// <param name="columns">The number of columns.</param>
        /// <returns>The initial generation</returns>
        private CitizenState[,] FetchInitialGeneration(int rows, int columns)
        {
            var initialGeneration = new CitizenState[rows, columns];

            for (var row = 0; row < rows; row++)
                for (var column = 0; column < columns; column++)
                    if (pnlGenerationSnapshot.Controls.Find($"chk{row}{column}", false).First() is CheckBox focusButton)
                        initialGeneration[row, column] = focusButton.Checked ? CitizenState.Living : CitizenState.Dead;

            return initialGeneration;
        }

        /// <summary>
        /// Allows live changing of the rows and columns when setting a seed.
        /// If the user has chosen to set the initial seed, this will also
        /// update the current board.
        /// </summary>
        private void nudRows_ValueChanged(object sender, EventArgs e)
        {
            if (pnlGenerationSnapshot.Controls.Count <= 0) return;

            pnlGenerationSnapshot.Controls.Clear();
            CreateGrid(Convert.ToInt32(nudRows.Text), Convert.ToInt32(nudColumns.Text));
        }

        /// <summary>
        /// Resets the simulation entirely, allowing a fresh start.
        /// </summary>
        private void btnReset_Click(object sender, EventArgs e)
        {
            CurrentSimulationState = SimulationState.Waiting;
        }
    }
}
