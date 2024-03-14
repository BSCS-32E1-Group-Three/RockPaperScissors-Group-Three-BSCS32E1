namespace RockPaperScissors.Models
{
    public enum Choice
    {
        Rock,
        Paper,
        Scissors
    }

    public class GameModel
    {
        public Choice PlayerChoice { get; set; }
        public Choice ComputerChoice { get; set; }
        public string Result { get; set; } = string.Empty;
        public int PlayerScore { get; set; }
        public int ComputerScore { get; set; }
    }

}
