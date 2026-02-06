namespace LunyScript.Godot.SmokeTests
{
	public sealed class CreateBallScript : LunyScript
	{
		public override void Build() => On.Ready(Prefab.Instantiate("ball"));
	}
}
