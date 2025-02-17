using Godot;
using System;

public abstract partial class State : Node
{
	[Signal]
	public delegate void ChangedEventHandler(State state, string newStateName);
	public virtual void Enter(){}
	public virtual void Exit(){}
	public virtual void Update(double delta){}
	public virtual void PhysicsUpdate(double delta){}
	public override void _PhysicsProcess(double delta){}
}
