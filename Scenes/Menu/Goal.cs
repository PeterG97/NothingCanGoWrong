namespace GameLogic;

public partial class Goal : Node
{
    [Export]
    public Label Label { get; set; }
    [Export]
    public CheckBox CheckBox { get; set; }

    private GoalData data;
    public GoalData Data
    {
        get => data;
        set
        {
            data = value; 
            Update();
        } 
    }

    public void Complete()
        => Data.Complete = true;

    public void Add(int @int)
    {
        Data.Count++;
        if (Data.Count >= Data.Needed)
        {
            Complete();
        }
    }

    public void Update()
    {
        Label.Text = $"{Data.Description}({Data.Count}/{Data.Needed})";
        CheckBox.ButtonPressed = Data.Complete;
    }
}
