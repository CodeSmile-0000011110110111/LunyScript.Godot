using Godot;
using System;

namespace LunyScript.Godot.SmokeTests.InputMoveTest
{
	public partial class InputTransformShift_Node3D : Node3D
	{
		public override void _Process(Double delta)
		{
#if GODOT
			var horizontal = Input.GetAxis("ui_left", "ui_right");
			var vertical = Input.GetAxis("ui_up", "ui_down");
			var shiftSpeed = 4f;

			Position = new Vector3(
				Position.X + horizontal * shiftSpeed * (Single)delta,
				Position.Y,
				Position.Z + -vertical * shiftSpeed * (Single)delta
			);

			if (Input.IsActionPressed("ui_accept"))
			{
				Position = new Vector3(
					Position.X,
					Position.Y + shiftSpeed * (Single)delta,
					Position.Z
				);
			}

			if (Input.IsKeyPressed(Key.C))
			{
				Position = new Vector3(
					Position.X,
					Position.Y + -shiftSpeed * (Single)delta,
					Position.Z
				);
			}
#endif
		}
	}
}
