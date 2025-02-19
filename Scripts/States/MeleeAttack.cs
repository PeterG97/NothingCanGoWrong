namespace GameLogic;

public partial class MeleeAttack : State
{
    [Export] private Enemy enemyNode;
    private Player player;
    public override void Enter()
    {
        player = GetTree().GetFirstNodeInGroup("Player") as Player;
        enemyNode.Sprite.AnimationLooped += AttackComplete; 
    }
    private void AttackComplete()
    {
        var direction = player.GlobalPosition - enemyNode.GlobalPosition;
        
        if (direction.Length() < 50) return;
        
        EmitSignal(SignalName.Changed, this, "Chase");
        enemyNode.Sprite.AnimationLooped -= AttackComplete;
    }
}