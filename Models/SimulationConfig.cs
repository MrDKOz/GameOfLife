namespace GameOfLife.Models
{
    public class SimulationConfig
    {
        public int Rows { get; set; }
        public int Columns { get; set; }
        public int Frequency { get; set; }
        public int TotalGenerations { get; set; }
        public bool InitialProvided { get; set; }
        public CitizenState[,] Initial { get; set; }
    }
}
