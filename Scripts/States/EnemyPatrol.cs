using Godot;
using System;

public partial class EnemyPatrol : State
{
	public static Vector2 MoveDirection {get; set;}
    public static double WanderTime {get; set;}

    public static void RandomizeWander()
    {
        MoveDirection = new Vector2(1,2);
        WanderTime = 7;
    }

    public static void Enter()
    {
        RandomizeWander();
    }

    public override void Update()
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