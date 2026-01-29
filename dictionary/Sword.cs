using Godot;
using System;

public partial class Sword : Sprite2D
{
	private Vector2 OriginPosition;


	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public override void _UnhandledInput(InputEvent @event)
	{
		bool pressed = false;
		float OriginRotation = this.RotationDegrees;
		float PositionX = Position.X; //currently 84
		float PositionY = Position.Y; //currently -2

		if (@event is InputEventMouseButton mouseEvent &&
			mouseEvent.Pressed &&
			mouseEvent.ButtonIndex == MouseButton.Left)
		//player using sword with left click
		{
			pressed = true;
		}
		else
		{
			pressed = false;
		}

		if (pressed == true)
		{
			Position = new Vector2(PositionX = 100, PositionY = -20);
		}
		else
		{
			Position = OriginPosition;
		}

	}

}
