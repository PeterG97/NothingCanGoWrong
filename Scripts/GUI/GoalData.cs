namespace GameLogic;

public record GoalData
{
    //Func<> Objective { get; set; }
    public string Description { get; set; }
    public int? Count { get; set; }
    public int Needed { get; set; }

    public bool Complete { get; set; }
}
