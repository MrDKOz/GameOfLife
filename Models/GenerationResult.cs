namespace GameOfLife.Models
{
    public class GenerationResult
    {
        public int Rows { get; set; }
        public int Columns { get; set; }
        public int Births { get; set; }
        public int Deaths { get; set; }
        public int Survivors { get; set; }
        public int Generation { get; set; }
        public int TargetGenerations { get; set; }
        public long TimeTaken { get; set; }
        public CitizenState[,] Snapshot { get; set; }
    }
}
