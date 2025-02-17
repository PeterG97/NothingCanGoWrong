using Godot;
using Godot.Collections;
using System;

public partial class StateMachine : Node
{
	[Export] 
	public State IntialState { get; set; }

	private Dictionary<string,State> states = new ();
	private State currentState;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		foreach (var child in GetChildren())
		{
			if (child is not State state) continue;
			states[child.Name.ToString().ToLower()] = state;

			//potential memory leak but fuck it we ball
			state.Changed += OnChildTransition;
		}

		if (IntialState is null) return;
		IntialState.Enter();
		currentState = IntialState;
	}
	

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		currentState?.Update(delta);
	}

	public override void _PhysicsProcess(double delta)
	{
		currentState?.PhysicsUpdate(delta);
	}

	private void OnChildTransition(State state, string newStateName)
	{
		if (state != currentState)
		{
			return;
		}
		
		State newState = states[newStateName.ToLower()];
		if (newState is null)
		{
			return;
		}

		currentState?.Exit();

		newState.Enter();
		currentState = newState;
	}



}
