using Godot;
using System;

namespace LunyScript.Godot.SmokeTests.InputMoveTest
{
	public partial class InputTransformMove_Node3D : Node3D
	{
		public override void _Process(Double delta)
		{
#if GODOT
			var horizontal = Input.GetAxis("ui_left", "ui_right");
			var vertical = Input.GetAxis("ui_up", "ui_down");
			var moveSpeed = 4f;

			Position += -Transform.Basis.Z * vertical * moveSpeed * (Single)delta;
			Position += Transform.Basis.X * horizontal * moveSpeed * (Single)delta;

			if (Input.IsActionPressed("ui_accept"))
				Position += Transform.Basis.Y * moveSpeed * (Single)delta;

			if (Input.IsKeyPressed(Key.C))
				Position += -Transform.Basis.Y * moveSpeed * (Single)delta;
#endif
		}
	}
}
