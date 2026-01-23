using Godot;
using Luny;
using LunyScript.SmokeTests;
using System;

namespace LunyScript.Godot.Tests
{
	public partial class TestController : Node
	{
		[Export] public Boolean Assert_Runs_WhenCreated_Passed;
		[Export] public Boolean Assert_Runs_WhenDestroyed_Passed;
		[Export] public Boolean Assert_Runs_WhenEnabled_Passed;
		[Export] public Boolean Assert_Runs_WhenDisabled_Passed;
		[Export] public Boolean Assert_Runs_WhenReady_Passed;
		[Export] public Boolean Assert_Runs_EveryFixedStep_Passed;
		[Export] public Boolean Assert_Runs_EveryFrame_Passed;
		[Export] public Boolean Assert_Runs_EveryFrameEnds_Passed;

		public TestController()
		{
			LunyLogger.LogInfo($"{nameof(TestController)}() ctor", this);
			LunyScriptEngine.Instance.GlobalVariables.OnVariableChanged += OnVariableChanged;
		}

		public override void _Ready() => LunyLogger.LogInfo($"{nameof(TestController)}() _Ready", this);

		private void OnVariableChanged(Object sender, LunyScriptVariableChangedArgs changedVar)
		{
			LunyLogger.LogInfo($"{changedVar}", this);

			var pass = changedVar.Variable.Boolean();
			if (changedVar.Name == nameof(Assert_Runs_WhenCreated))
				Assert_Runs_WhenCreated_Passed = pass;
			else if (changedVar.Name == nameof(Assert_Runs_WhenDestroyed))
				Assert_Runs_WhenDestroyed_Passed = pass;
			else if (changedVar.Name == nameof(Assert_Runs_WhenEnabled))
				Assert_Runs_WhenEnabled_Passed = pass;
			else if (changedVar.Name == nameof(Assert_Runs_WhenDisabled))
				Assert_Runs_WhenDisabled_Passed = pass;
			else if (changedVar.Name == nameof(Assert_Runs_WhenReady))
				Assert_Runs_WhenReady_Passed = pass;
			else if (changedVar.Name == nameof(Assert_Runs_EveryFixedStep))
				Assert_Runs_EveryFixedStep_Passed = pass;
			else if (changedVar.Name == nameof(Assert_Runs_EveryFrame))
				Assert_Runs_EveryFrame_Passed = pass;
			else if (changedVar.Name == nameof(Assert_Runs_EveryFrameEnds))
				Assert_Runs_EveryFrameEnds_Passed = pass;
			else
				throw new ArgumentOutOfRangeException(nameof(changedVar.Name));
		}
	}
}
