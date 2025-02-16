using Godot;
using Godot.Collections;
using System;

public partial class StateMachine : Node
{
	public Dictionary<State,string> states { get; set;} = new ();
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
