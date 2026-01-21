using Godot;
using System;

public partial class Enemy : Sprite2D
{
	private RandomNumberGenerator rng = new RandomNumberGenerator();
	private float speed = 5f;

	public override void _Ready()
	{
		rng.Randomize();
	}

	public override void _Process(double delta)
	{
		int randomNumber = rng.RandiRange(0, 3);

		switch (randomNumber)
		{
			case 0:
				Position += new Vector2(0, -speed);
				break;
			case 1:
				Position += new Vector2(0, speed);
				break;
			case 2:
				Position += new Vector2(-speed, 0);
				break;
			case 3:
				Position += new Vector2(speed, 0);
				break;
		}
	}
}
