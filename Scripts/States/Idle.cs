using Godot;
using System;


public partial class Idle : State
{
    [Export] 
    public Enemy Enemy { get; set; }
    
    [Export] 
    public int MoveSpeed {get; set;} = 10;
	private Vector2 MoveDirection {get; set;}
    private double WanderTime {get; set;}

    private Random random = new Random();

    private void RandomizeWander()
    {
        MoveDirection = new Vector2(random.Next(-1,1),random.Next(-1,1));
        WanderTime = random.Next(1,8);
    }

    public override void Enter()
    {
        RandomizeWander();
    }

    public override void _Ready()
    {
        Console.WriteLine(this.Enemy);
    }

    public override void Update(double delta)
    {
        if (WanderTime > 0)
        {
            WanderTime -= delta;
        }
        else
        {
            RandomizeWander();
        }
    }
    public override void PhysicsUpdate(double delta)
    {
        if (Enemy is not null)
        {
            Enemy.Velocity = MoveDirection * MoveSpeed;
        }
    }
}