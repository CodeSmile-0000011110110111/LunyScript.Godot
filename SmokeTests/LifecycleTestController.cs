using Godot;
using Luny;
using LunyScript.SmokeTests.Lifecycle;
using System;

namespace LunyScript.Godot.SmokeTests
{
#if GODOT
	public partial class LifecycleTestController : Node
#else
	public class LifecycleTestController : Node
#endif
	{
		[Export] public Boolean Assert_Runs_OnCreated_Passed;
		[Export] public Boolean Assert_Runs_OnDestroyed_Passed;
		[Export] public Boolean Assert_Runs_OnEnabled_Passed;
		[Export] public Boolean Assert_Runs_OnDisabled_Passed;
		[Export] public Boolean Assert_Runs_OnReady_Passed;
		[Export] public Boolean Assert_Runs_OnHeartbeat_Passed;
		[Export] public Boolean Assert_Runs_OnFrameUpdate_Passed;
		[Export] public Boolean Assert_Runs_OnFrameLateUpdate_Passed;

		public LifecycleTestController()
		{
			LunyLogger.LogInfo($"{nameof(LifecycleTestController)}() ctor", this);
			ScriptEngine.Instance.GlobalVariables.OnVariableChanged += OnVariableChanged;
		}

		public override void _Ready() => LunyLogger.LogInfo($"{nameof(LifecycleTestController)}() _Ready", this);

		private void OnVariableChanged(Object sender, VariableChangedArgs changedVar)
		{
			if (changedVar.Name.StartsWith("Time."))
				return;

			LunyLogger.LogInfo($"{changedVar}", this);

			var pass = changedVar.Current.AsBoolean();
			if (changedVar.Name == nameof(Assert_Runs_OnCreated))
				Assert_Runs_OnCreated_Passed = pass;
			else if (changedVar.Name == nameof(Assert_Runs_OnDestroyed))
				Assert_Runs_OnDestroyed_Passed = pass;
			else if (changedVar.Name == nameof(Assert_Runs_OnEnabled))
				Assert_Runs_OnEnabled_Passed = pass;
			else if (changedVar.Name == nameof(Assert_Runs_OnDisabled))
				Assert_Runs_OnDisabled_Passed = pass;
			else if (changedVar.Name == nameof(Assert_Runs_OnReady))
				Assert_Runs_OnReady_Passed = pass;
			else if (changedVar.Name == nameof(Assert_Runs_OnHeartbeat))
				Assert_Runs_OnHeartbeat_Passed = pass;
			else if (changedVar.Name == nameof(Assert_Runs_OnFrameUpdate))
				Assert_Runs_OnFrameUpdate_Passed = pass;
			else if (changedVar.Name == nameof(Assert_Runs_OnFrameLateUpdate))
				Assert_Runs_OnFrameLateUpdate_Passed = pass;
			else
				LunyLogger.LogWarning($"unhandled {changedVar}", this);
		}
	}
}
