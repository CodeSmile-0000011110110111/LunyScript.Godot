using Godot;
using LunyScript.SmokeTests;
using System;

namespace LunyScript.Godot.SmokeTests
{
    public partial class ObjectTestController : Node
    {
        [Export] private Boolean _ObjectCreatedAndDestroyed;
        [Export] private Boolean _EmptyObjectCreated;
        [Export] private Boolean _CubeObjectCreated;
        [Export] private Boolean _SphereObjectCreated;

        private Boolean _foundToBeDestroyedNode;

        private Int32 processCount;

        private static SceneTree SceneTree => (SceneTree)Engine.GetMainLoop();

        public override void _Ready()
        {
            var node = new Node();
            node.Name = nameof(ObjectTestScript) + "RuntimeCreated";
            //var godotNode = new GodotNode(node, node.GetInstanceId());

            // this causes the corresponding LunyScript to build & run
            SceneTree.CurrentScene.CallDeferred("add_child", node);
        }

        public override void _Process(Double deltaTime)
        {
            if (!_foundToBeDestroyedNode)
            {
                var rootNodes = SceneTree.CurrentScene.GetChildren();
                foreach (var rootNode in rootNodes)
                {
                    if (rootNode.Name == ObjectTestScript.DestroyedObjectName)
                        _foundToBeDestroyedNode = true;
                }
            }

            processCount++;
            if (processCount == 2)
                AssertObjectsCreated();
        }

        private void AssertObjectsCreated()
        {
            var destroyedNameFound = false;
            var rootNodes = SceneTree.CurrentScene.GetChildren();
            foreach (var rootNode in rootNodes)
            {
                var nodeName = rootNode.Name;
                _EmptyObjectCreated = _EmptyObjectCreated || nodeName == ObjectTestScript.EmptyObjectName;
                _CubeObjectCreated = _CubeObjectCreated || nodeName == ObjectTestScript.CubeObjectName;
                _SphereObjectCreated = _SphereObjectCreated || nodeName == ObjectTestScript.SphereObjectName;
                destroyedNameFound = destroyedNameFound || nodeName == ObjectTestScript.DestroyedObjectName;
            }

            _ObjectCreatedAndDestroyed = _foundToBeDestroyedNode && destroyedNameFound == false;
        }
    }

    // stub to ensure 'partial' keyword isn't removed by "Code Cleanup" runs
    public partial class ObjectTestController {}
}
