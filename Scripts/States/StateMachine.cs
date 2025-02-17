using Godot;
using Godot.Collections;
using System;

public partial class StateMachine : Node
{
    //[Export]
    //public State? IntialState {get; set;}

    //public Dictionary<string,State> states { get; set;} = new ();
    //private State? currentState;

    //// Called when the node enters the scene tree for the first time.
    //public override void _Ready()
    //{
    //	foreach (var child in GetChildren())
    //	{
    //		if (child is State state)
    //		{
    //			states[child.Name.ToString().ToLower()] = state;

    //			//potential mememory leak but fuck it we ball
    //			state.Transistioned += () => OnChildTransition(state, state.Name);

    //		}
    //	}
    //	if (IntialState is not null)
    //	{
    //		IntialState.Enter();
    //		currentState = IntialState;
    //	}
    //}

    //// Called every frame. 'delta' is the elapsed time since the previous frame.
    //public override void _Process(double delta)
    //{
    //	if (currentState is not null)
    //	{
    //		currentState.Update();
    //	}
    //}

    //public override void _PhysicsProcess(double delta)
    //{
    //	if (currentState is not null)
    //	{
    //		currentState.PhysicsUpdate(delta);
    //	}
    //}

    //public void OnChildTransition(State state, string newStateName)
    //{
    //	if (state != currentState)
    //	{
    //		return;
    //	}

    //	var newState = states[newStateName.ToLower()];
    //	if (newState is null)
    //	{
    //		return;
    //	}

    //	if (currentState is not null)
    //	{
    //		currentState.Exit();
    //	}

    //	newState.Enter();
    //	currentState = newState;
    //}



}
