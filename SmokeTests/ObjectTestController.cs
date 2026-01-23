using Godot;
using LunyScript.Unity.SmokeTests;
using System;

namespace LunyScript.Godot.Tests
{
	public partial class ObjectTestController : Node
	{
		[Export] private Boolean _ObjectCreatedAndDestroyed;
		[Export] private Boolean _EmptyObjectCreated;
		[Export] private Boolean _CubeObjectCreated;
		[Export] private Boolean _SphereObjectCreated;

		private Boolean _foundToBeDestroyedObject;

		public override void _Ready()
		{
			var node = new Node();
			node.Name = nameof(ObjectTestLunyScript);

			// this causes the corresponding LunyScript to build & run
			var sceneTree = (SceneTree)Engine.GetMainLoop();
			sceneTree.CurrentScene.CallDeferred("add_child", node);
		}
	}
}
