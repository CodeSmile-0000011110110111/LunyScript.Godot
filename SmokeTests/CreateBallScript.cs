namespace LunyScript.Godot.SmokeTests
{
	public sealed class CreateBallScript : LunyScript
	{
		public override void Build(ScriptBuildContext context) => On.Ready(Prefab.Instantiate("ball"));
	}
}
