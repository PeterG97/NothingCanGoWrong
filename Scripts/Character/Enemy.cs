namespace GameLogic;

public partial class Enemy : NPC
{
	[Export] 
	public AnimatedSprite2D Sprite { get; set; }
	
	private Player player;

	[Export] private StateMachine stateMachine;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		player = GetTree().GetFirstNodeInGroup("Player") as Player;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

    public override void _PhysicsProcess(double delta)
    {
        MoveAndSlide();

        if (stateMachine.currentState is Chase or Idle)
        {
	        Sprite.Play("Walk");
	        Sprite.FlipH = Velocity.X < 0;
        }
        else if (stateMachine.currentState is MeleeAttack)
        {
	        Sprite.FlipH = player.Position.X - Position.X < 0;
	        Sprite.Play("Attack");
        }
        else
        {
	        Sprite.Play("Idle");
        }
        
    }
}
