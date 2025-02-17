public partial class Weapon : Node2D
{
    [Export]
    public int Damage { get; private set; } = 1;
    [Export]
    public int Speed { get; private set; } = 1;
    [Export]
    public int Cooldown { get; private set; } = 0;

    public WeaponState State { get; private set; } = WeaponState.Ready;

    private double cooldown;

    public override void _Process(double delta)
	{
        switch (State)
        {
            case WeaponState.Cooldown:
                cooldown -= delta;
                if (cooldown <= 0)
                {
                    State = WeaponState.Ready;
                }
                return;
            default:
                return;
        }
	}

    public void Attack()
    {
        if (State == WeaponState.Ready)
        {
            State = WeaponState.Attacking;
            cooldown = Cooldown;
        }
    }

    public enum WeaponState
    {
        Ready,
        Attacking,
        Cooldown
    }
}
