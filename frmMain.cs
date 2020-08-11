using GameOfLife.Classes;
using GameOfLife.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class frmMain : Form
    {
        private Simulation _simulation;
        private bool _initialDefined = false;

        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Builds the simulation config, and starts processing.
        /// </summary>
        private async void btnStartSimulation_Click(object sender, EventArgs e)
        {
            var simulationConfig = new SimulationConfig
            {
                Rows = Convert.ToInt32(nudRows.Text),
                Columns = Convert.ToInt32(nudColumns.Text),
                Frequency = Convert.ToInt32(nudFrequency.Text),
                TotalGenerations = Convert.ToInt32(nudTotalGenerations.Text),
                InitialProvided = _initialDefined
            };

            if (_initialDefined)
                simulationConfig.Initial = FetchInitialGeneration(simulationConfig.Rows, simulationConfig.Columns);

            _simulation = new Simulation(simulationConfig);
            CreateGrid(simulationConfig.Rows, simulationConfig.Columns);

            var generations = new Progress<GenerationResult>(DisplayResults);

            await Task.Run(() => _simulation.Simulate(generations));
        }

        /// <summary>
        /// Creates the grid on which to display the current generation.
        /// </summary>
        /// <param name="rows">Number of Rows</param>
        /// <param name="cols">Number of Columns</param>
        private void CreateGrid(int rows, int cols)
        {
            pnlGenerationSnapshot.Controls.Clear();

            for (var row = 0; row < rows; row++)
            {
                for (var col = 0; col < cols; col++)
                {
                    var checkBox = new CheckBox()
                    {
                        Name = $"chk{row}{col}",
                        Location = new Point(15 * row, 15 * col),
                        Size = new Size(15, 15),
                        Text = "",
                        
                    };

                    pnlGenerationSnapshot.Controls.Add(checkBox);
                }
            }
        }

        /// <summary>
        /// Displays the results of the generation.
        /// </summary>
        /// <param name="generation">The generation to display.</param>
        private void DisplayResults(GenerationResult generation)
        {
            for (var row = 0; row < generation.Rows; row++)
            {
                for (var column = 0; column < generation.Columns; column++)
                {
                    var cell = generation.Snapshot[row, column];

                    if (pnlGenerationSnapshot.Controls.Find($"chk{row}{column}", false).First() is CheckBox focusButton)
                    {
                        if (cell == CitizenState.Survived)
                            focusButton.CheckState = CheckState.Indeterminate;
                        else
                            focusButton.Checked = cell == CitizenState.Living;
                    }
                }
            }

            lstLog.Items.Add($"Generation: {generation.Generation}");
            lstLog.Items.Add($"Births: {generation.Births}");
            lstLog.Items.Add($"Deaths: {generation.Deaths}");
            lstLog.Items.Add($"Survivors: {generation.Survivors}");
            lstLog.Items.Add("----------------------------------");

        }

        /// <summary>
        /// Generates an empty, editable board.
        /// </summary>
        private void btnDefineStartingGeneration_Click(object sender, EventArgs e)
        {
            _initialDefined = true;
            CreateGrid(Convert.ToInt32(nudRows.Value), Convert.ToInt32(nudColumns.Value));
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
            {
                for (var column = 0; column < columns; column++)
                {
                    if (pnlGenerationSnapshot.Controls.Find($"chk{row}{column}", false).First() is CheckBox focusButton)
                        initialGeneration[row, column] = focusButton.Checked ? CitizenState.Living : CitizenState.Dead;
                }
            }

            return initialGeneration;
        }
    }
}
