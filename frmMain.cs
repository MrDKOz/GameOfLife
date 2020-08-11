using GameOfLife.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameOfLife.Simulation;

namespace GameOfLife
{
    public partial class frmMain : Form
    {
        private bool initialGridCreated;

        public frmMain()
        {
            InitializeComponent();
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
            if (simulationConfig.InitialProvided)
                simulationConfig.Initial = FetchInitialGeneration(simulationConfig.Rows, simulationConfig.Columns);
            else
                CreateGrid(simulationConfig.Rows, simulationConfig.Columns);

            // Update UI
            prgTotal.Maximum = simulationConfig.TotalGenerations;

            // Point our updates, and start the simulation
            var generations = new Progress<GenerationResult>(DisplayResults);
            var simulator = new Simulator(simulationConfig);
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

            // Write out the current generation details
            lstLog.Items.Add($"Generation: {generation.Generation}");
            lstLog.Items.Add($"Births: {generation.Births}");
            lstLog.Items.Add($"Deaths: {generation.Deaths}");
            lstLog.Items.Add($"Survivors: {generation.Survivors}");
            lstLog.Items.Add("----------------------------------");

            // Update progress
            prgTotal.PerformStep();
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
                initialGridCreated = false;
            }
            else
            {
                CreateGrid(Convert.ToInt32(nudRows.Value), Convert.ToInt32(nudColumns.Value));

                button.Text = "Remove Current Grid";
                initialGridCreated = true;
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

        private void nudRows_ValueChanged(object sender, EventArgs e)
        {
            if (pnlGenerationSnapshot.Controls.Count <= 0) return;

            pnlGenerationSnapshot.Controls.Clear();
            CreateGrid(Convert.ToInt32(nudRows.Text), Convert.ToInt32(nudColumns.Text));
        }
    }
}
