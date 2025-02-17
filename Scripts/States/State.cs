using Godot;
using System;

public abstract partial class State : Node
{
	[Signal]
	public delegate void TransistionedEventHandler();

	// [Signal]
	// public delegate void TransistionedEventHandler();

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	
	public void Enter()
	{
		
	}
	
	public void Exit()
	{
		
	}
	public abstract void Update();
		
	public void PhysicsUpdate(double delta)
	{

	}

	public override void _PhysicsProcess(double delta)
	{

	}

	public void OnChildTransition(State state)
	{

	}
}
