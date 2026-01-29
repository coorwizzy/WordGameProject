using Godot;
using System;

public partial class Main : Node2D
{
	
	PackedScene EnemyScene;
	bool alive = true;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		EnemyScene = (PackedScene)GD.Load("res://Enemy.tscn");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		
	}
	
	public override void _UnhandledInput(InputEvent @event)
	{
		if (@event is InputEventMouseButton mouseEvent &&
		mouseEvent.Pressed &&
		mouseEvent.ButtonIndex == MouseButton.Middle)
		// create instance of enemy scene (for now)
		{
			Sprite2D sprite = EnemyScene.Instantiate<Sprite2D>();
			sprite.Position = mouseEvent.Position;
			AddChild(sprite);
		}
		//this code spawns in the scene "enemy" at where the mouse clicks on the loaded scene
	}
}
