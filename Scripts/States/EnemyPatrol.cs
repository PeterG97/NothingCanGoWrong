using Godot;
using System;

public partial class EnemyPatrol : State
{
	public static Vector2 MoveDirection {get; set;}
    public static double WanderTime {get; set;}
    private static Random random = new();

    public static void RandomizeWander()
    {
        MoveDirection = new Vector2(random.Next(-1,1),random.Next(-1,1));
        WanderTime = random.Next(1,3);
    }

    public override void Enter()
    {
        RandomizeWander();
    }

    public override void Update(double delta)
    {
        if (WanderTime > 0)
        {
            WanderTime--;
        }
        else
        {
            RandomizeWander();
        }
    }
}