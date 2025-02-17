using Godot;
using System;
using System.Linq;

public partial class Enemy : NPC
{
	[Export] AnimatedSprite2D sprite;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Console.WriteLine("huh");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

    public override void _PhysicsProcess(double delta)
    {
        MoveAndSlide();
        sprite.Play(Velocity.Length() > 0 ? "Walk" : "Idle");
        sprite.FlipH = Velocity.X < 0;
    }
}
