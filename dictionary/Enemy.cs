using Godot;
using System;

public partial class Enemy : Sprite2D
{
	private RandomNumberGenerator rng = new RandomNumberGenerator();

	// Fixed displacement per move (pixels)
	private const float StepDistance = 16f;

	// Time range between moves (seconds)
	private const float MinMoveTime = 0.5f;
	private const float MaxMoveTime = 2.5f;

	private Timer moveTimer;

	public override void _Ready()
	{
		rng.Randomize();

		moveTimer = GetNode<Timer>("MoveTimer");
		moveTimer.Timeout += OnMoveTimeout;

		ScheduleNextMove();
	}

	private void OnMoveTimeout()
	{
		// Choose random direction
		Vector2 direction = rng.RandiRange(0, 3) switch
		{
			0 => Vector2.Up,
			1 => Vector2.Down,
			2 => Vector2.Left,
			_ => Vector2.Right
		};

		// Apply fixed displacement
		Position += direction * StepDistance;

		// Schedule next move at a random time
		ScheduleNextMove();
	}

	private void ScheduleNextMove()
	{
		moveTimer.WaitTime = rng.RandfRange(MinMoveTime, MaxMoveTime);
		moveTimer.Start();
	}
}
