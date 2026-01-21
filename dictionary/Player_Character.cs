using Godot;
using System;

public partial class Player_Character : Sprite2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		// (placeholder script) Godot.Sprite2D Sword = this.GetNode<Godot.Sprite2D>("Sword");
		float Amount = 5;
		if (Input.IsKeyPressed(Key.W)){
			this.Position += new Vector2(0,-Amount);
		}
		if (Input.IsKeyPressed(Key.A)){
			this.Position += new Vector2(-Amount,0);
		}
		if (Input.IsKeyPressed(Key.S)){
			this.Position += new Vector2(0,Amount);
		}
		if (Input.IsKeyPressed(Key.D)){
			this.Position += new Vector2(Amount,0);
		}
	}
}
