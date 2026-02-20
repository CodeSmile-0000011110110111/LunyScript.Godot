using Godot;
using System;

namespace LunyScript.Godot.SmokeTests.InputMoveTest
{
	public partial class InputTransformShift_Node3D : Node3D
	{
		public override void _Process(double delta)
		{
			throw new NotImplementedException(nameof(InputTransformShift_Node3D));

			/*
			float horizontal = Input.GetAxis("ui_left", "ui_right");
			float vertical = Input.GetAxis("ui_up", "ui_down");
			float shiftSpeed = 4f;

			Position = new Vector3(
				Position.X + horizontal * shiftSpeed * (float)delta,
				Position.Y,
				Position.Z + -vertical * shiftSpeed * (float)delta
			);

			if (Input.IsActionPressed("ui_accept"))
			{
				Position = new Vector3(
					Position.X,
					Position.Y + shiftSpeed * (float)delta,
					Position.Z
				);
			}

			if (Input.IsKeyPressed(Key.C))
			{
				Position = new Vector3(
					Position.X,
					Position.Y + -shiftSpeed * (float)delta,
					Position.Z
				);
			}
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
	var shift_speed: float = 4.0

	position = Vector3(
		position.x + horizontal * shift_speed * delta,
		position.y,
		position.z + -vertical * shift_speed * delta
	)

	if Input.is_action_pressed("ui_accept"):
		position = Vector3(
			position.x,
			position.y + shift_speed * delta,
			position.z
		)

	if Input.is_key_pressed(KEY_C):
		position = Vector3(
			position.x,
			position.y + -shift_speed * delta,
			position.z
		)
		*/
