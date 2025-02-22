namespace GameLogic;

public class GoalData
{
    //Func<> Objective { get; set; }
    public string Description { get; set; }
    public int Count { get; set; }
    public int Needed { get; set; }
    public GoalDifficulty Difficulty { get; set; }

    public bool Complete { get; set; }

    public enum GoalDifficulty
    {
        None,
        Easy,
        Medium,
        Hard
    }
}
