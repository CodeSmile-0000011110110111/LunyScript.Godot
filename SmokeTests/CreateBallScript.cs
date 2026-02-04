namespace LunyScript.Godot.SmokeTests
{
	public sealed class CreateBallScript : LunyScript
	{
		public override void Build() => When.Self.Ready(Prefab.Instantiate("ball"));
	}
}
