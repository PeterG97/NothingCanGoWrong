namespace NothingCanGoWrong.Scripts.Items;

public partial class Key : Node2D
{
    [Export] 
    private Player player;

	
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        player = GetTree().GetFirstNodeInGroup("Player") as Player;
    }
    
}