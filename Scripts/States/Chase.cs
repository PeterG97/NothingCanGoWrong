public partial class Chase : State
{
    [Export] private Enemy enemyNode;
    [Export] private int moveSpeed = 40;
    private Player player;
    public override void Enter()
    {
        player = GetTree().GetFirstNodeInGroup("Player") as Player;
    }

    public override void PhysicsUpdate(double delta)
    {
        var direction = player.GlobalPosition - enemyNode.GlobalPosition;

        if (direction.Length() > 50)
        {
            enemyNode.Velocity = direction.Normalized() * moveSpeed;
        }
        else if (direction.Length() > 200)
        {
            EmitSignal(SignalName.Changed, this, "Idle");
        }
        else
        {
            enemyNode.Velocity = new Vector2(0, 0);
            EmitSignal(SignalName.Changed, this, "Attack");
        }
    }
}