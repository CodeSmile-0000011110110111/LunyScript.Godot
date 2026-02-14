namespace LunyScript.Godot.SmokeTests
{
	public sealed class CreateBallScript : Script
	{
		public override void Build(ScriptContext context) => On.Ready(Prefab.Instantiate("ball"));
	}
}
