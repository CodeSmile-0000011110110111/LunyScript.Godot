using Godot;
using System;

namespace LunyScript.Godot.SmokeTests.InputMoveTest
{
	public partial class InputTransformMove_Node3D : Node3D
	{
		public override void _Process(double delta)
		{
			throw new NotImplementedException(nameof(InputTransformMove_Node3D));

			/*
			float horizontal = Input.GetAxis("ui_left", "ui_right");
			float vertical = Input.GetAxis("ui_up", "ui_down");
			float moveSpeed = 4f;

			Position = Position + -Transform.Basis.Z * vertical * moveSpeed * (float)delta;
			Position = Position + Transform.Basis.X * horizontal * moveSpeed * (float)delta;

			if (Input.IsActionPressed("ui_accept"))
				Position = Position + Transform.Basis.Y * moveSpeed * (float)delta;

			if (Input.IsKeyPressed(Key.C))
				Position = Position + -Transform.Basis.Y * moveSpeed * (float)delta;
		*/
		}
	}
}

// GDScript version
/*
extends Node3D

func _process(delta: float) -> void:
	var horizontal = Input.get_axis("ui_left", "ui_right")
	var vertical = Input.get_axis("ui_up", "ui_down")
	var move_speed: float = 4.0

	position = position + -transform.basis.z * vertical * move_speed * delta
	position = position + transform.basis.x * horizontal * move_speed * delta

	if Input.is_action_pressed("ui_accept"):
		position = position + transform.basis.y * move_speed * delta

	if Input.is_key_pressed(KEY_C):
		position = position + -transform.basis.y * move_speed * delta
	*/
