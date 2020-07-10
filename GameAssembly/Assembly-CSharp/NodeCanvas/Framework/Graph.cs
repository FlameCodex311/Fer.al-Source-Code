/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework.Internal;
using ParadoxNotion;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Framework
{
	[Serializable]
	public abstract class Graph : ScriptableObject, ITaskSystem, ISerializationCallbackReceiver // TypeDefIndex: 14559
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private string _serializedGraph; // 0x18
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private List<UnityEngine.Object> _objectReferences; // 0x20
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool _deserializationFailed; // 0x28
		[NonSerialized]
		private bool hasDeserialized; // 0x29
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static Action<Graph> onGraphSerialized; // 0x00
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static Action<Graph> onGraphDeserialized; // 0x08
		private string _category; // 0x30
		private string _comments; // 0x38
		private Vector2 _translation; // 0x40
		private float _zoomFactor; // 0x48
		private List<Node> _nodes; // 0x50
		private List<CanvasGroup> _canvasGroups; // 0x58
		private BlackboardSource _localBlackboard; // 0x60
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Action<bool> onFinish; // 0x68
		[NonSerialized]
		private Component _agent; // 0x70
		[NonSerialized]
		private IBlackboard _blackboard; // 0x78
		[NonSerialized]
		private static List<Graph> runningGraphs; // 0x10
		[NonSerialized]
		private float timeStarted; // 0x80
		[NonSerialized]
		private bool initialReferencesUpdated; // 0x84
		[NonSerialized]
		private bool _isAutoUpdated; // 0x85
		[NonSerialized]
		private bool _isRunning; // 0x86
		[NonSerialized]
		private bool _isPaused; // 0x87
	
		// Properties
		public abstract Type baseNodeType { get; }
		public abstract bool requiresAgent { get; }
		public abstract bool requiresPrimeNode { get; }
		public abstract bool isTree { get; }
		public abstract bool useLocalBlackboard { get; }
		public abstract bool canAcceptVariableDrops { get; }
		public new string name { get; set; } // 0x000000018123D3C0-0x000000018123D3D0 0x0000000181759C40-0x0000000181759C50
		public string category { get; set; } // 0x0000000180397720-0x0000000180397730 0x00000001803A2800-0x00000001803A2810
		public string comments { get; set; } // 0x0000000180369BB0-0x0000000180369BC0 0x00000001803A2820-0x00000001803A2830
		public float elapsedTime { get; } // 0x0000000181759790-0x00000001817597D0 
		public bool isRunning { get; private set; } // 0x00000001817597F0-0x0000000181759800 0x0000000181759C30-0x0000000181759C40
		public bool isPaused { get; private set; } // 0x00000001817597E0-0x00000001817597F0 0x0000000181759C20-0x0000000181759C30
		public bool isAutoUpdated { get; private set; } // 0x00000001817597D0-0x00000001817597E0 0x0000000180478860-0x0000000180478870
		public List<Node> allNodes { get; private set; } // 0x00000001803A27A0-0x00000001803A27B0 0x00000001803A2850-0x00000001803A2860
		public Node primeNode { get; set; } // 0x0000000181759880-0x0000000181759940 0x0000000181759C50-0x0000000181759D80
		public List<CanvasGroup> canvasGroups { get; set; } // 0x0000000180357120-0x0000000180357130 0x0000000180485C70-0x0000000180485C80
		public Vector2 translation { get; set; } // 0x0000000180EF85B0-0x0000000180EF85D0 0x00000001803A2810-0x00000001803A2820
		public float zoomFactor { get; set; } // 0x0000000180487CC0-0x0000000180487CD0 0x0000000180DD2D70-0x0000000180DD2D80
		public Component agent { get; private set; } // 0x0000000180369B50-0x0000000180369B60 0x00000001803C87F0-0x00000001803C8800
		public IBlackboard blackboard { get; private set; } // 0x0000000181759750-0x0000000181759790 0x0000000181759BD0-0x0000000181759C20
		public BlackboardSource localBlackboard { get; } // 0x0000000181759800-0x0000000181759880 
		UnityEngine.Object ITaskSystem.contextObject { get; } // 0x0000000180362190-0x00000001803621A0 
	
		// Events
		public static event Action<Graph> onGraphSerialized {
			add; // 0x0000000181759660-0x0000000181759750
			remove; // 0x0000000181759AE0-0x0000000181759BD0
		}
		public static event Action<Graph> onGraphDeserialized {
			add; // 0x0000000181759560-0x0000000181759660
			remove; // 0x00000001817599E0-0x0000000181759AE0
		}
		public event Action<bool> onFinish {
			add; // 0x00000001817594C0-0x0000000181759560
			remove; // 0x0000000181759940-0x00000001817599E0
		}
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass107_0 // TypeDefIndex: 14560
		{
			// Fields
			public Graph targetGraph; // 0x10
	
			// Constructors
			public <>c__DisplayClass107_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <CloneNodes>b__0(Node n); // 0x0000000181760E00-0x0000000181760E80
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 14561
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<Node, bool> <>9__112_0; // 0x08
			public static Func<Node, int> <>9__112_1; // 0x10
			public static Func<Node, bool> <>9__130_0; // 0x18
			public static Func<Node, bool> <>9__131_0; // 0x20
			public static Func<BBParameter, bool> <>9__146_0; // 0x28
	
			// Constructors
			static <>c(); // 0x00000001817614C0-0x0000000181761520
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <UpdateNodeIDs>b__112_0(Node n); // 0x0000000181760D80-0x0000000181760DD0
			internal int <UpdateNodeIDs>b__112_1(Node n); // 0x0000000181760DD0-0x0000000181760E00
			internal bool <GetRootNodes>b__130_0(Node n); // 0x0000000181760CB0-0x0000000181760D00
			internal bool <GetLeafNodes>b__131_0(Node n); // 0x0000000181760C60-0x0000000181760CB0
			internal bool <GetDefinedParameters>b__146_0(BBParameter p); // 0x0000000181760C40-0x0000000181760C60
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass125_0 // TypeDefIndex: 14562
		{
			// Fields
			public int searchID; // 0x10
	
			// Constructors
			public <>c__DisplayClass125_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <GetNodeWithID>b__0(Node n); // 0x0000000181760E80-0x0000000181760EA0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass152_0 // TypeDefIndex: 14563
		{
			// Fields
			public Node node; // 0x10
	
			// Constructors
			public <>c__DisplayClass152_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <RemoveNode>b__0(Node n); // 0x0000000181760EA0-0x0000000181760F40
		}
	
		// Constructors
		protected Graph(); // 0x0000000181759430-0x00000001817594C0
		static Graph(); // 0x00000001817593D0-0x0000000181759430
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x00000001817589E0-0x00000001817589F0
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x00000001817589D0-0x00000001817589E0
		protected void OnEnable(); // 0x0000000181757040-0x0000000181757050
		protected void OnDisable(); // 0x00000001803581E0-0x00000001803581F0
		protected void OnDestroy(); // 0x00000001803581E0-0x00000001803581F0
		protected void OnValidate(); // 0x00000001803581E0-0x00000001803581F0
		protected void Reset(); // 0x0000000181757970-0x0000000181757980
		public void Serialize(); // 0x0000000181757E90-0x0000000181757F90
		public void Deserialize(); // 0x00000001817552E0-0x0000000181755490
		public string Serialize(bool pretyJson, List<UnityEngine.Object> objectReferences); // 0x0000000181757F90-0x00000001817580D0
		public GraphSerializationData Deserialize(string serializedGraph, bool validate, List<UnityEngine.Object> objectReferences); // 0x0000000181755490-0x00000001817556E0
		private bool LoadGraphData(GraphSerializationData data, bool validate); // 0x0000000181756EC0-0x0000000181757040
		public virtual object OnDerivedDataSerialization(); // 0x000000018035FCC0-0x000000018035FCD0
		public virtual void OnDerivedDataDeserialization(object data); // 0x00000001803581E0-0x00000001803581F0
		public void GetSerializationData(out string json, out List<UnityEngine.Object> references); // 0x0000000181756860-0x00000001817568F0
		public void SetSerializationObjectReferences(List<UnityEngine.Object> references); // 0x000000018036AC90-0x000000018036ACA0
		public string SerializeLocalBlackboard(); // 0x0000000181757DE0-0x0000000181757E90
		public bool DeserializeLocalBlackboard(string json); // 0x00000001817551F0-0x00000001817552E0
		public static T Clone<T>(T graph)
			where T : Graph;
		public void CopySerialized(Graph target); // 0x0000000181755090-0x00000001817551F0
		public void Validate(); // 0x0000000181759180-0x00000001817593D0
		protected virtual void OnGraphValidate(); // 0x00000001803581E0-0x00000001803581F0
		public static List<Node> CloneNodes(List<Node> originalNodes, Graph targetGraph = null, Vector2 originPosition = default); // 0x0000000181754570-0x0000000181754FF0
		public void UpdateReferencesFromOwner(GraphOwner owner); // 0x0000000181758E20-0x0000000181758ED0
		public void UpdateReferences(Component newAgent, IBlackboard newBlackboard); // 0x0000000181758ED0-0x0000000181759180
		private void UpdateNodeBBFields(); // 0x0000000181758A10-0x0000000181758B50
		public void SendTaskOwnerDefaults(); // 0x0000000181757CB0-0x0000000181757DE0
		public void UpdateNodeIDs(bool alsoReorderList); // 0x0000000181758B50-0x0000000181758E20
		private int AssignNodeID(Node node, int lastID, ref Node[] parsed); // 0x0000000181754320-0x00000001817544A0
		public void StartGraph(Component newAgent, IBlackboard newBlackboard, bool autoUpdate, Action<bool> callback = null); // 0x00000001817580D0-0x00000001817586E0
		public void Stop(bool success = true /* Metadata: 0x007845F7 */); // 0x00000001817586E0-0x00000001817589D0
		public void Pause(); // 0x0000000181757050-0x00000001817571F0
		public void UpdateGraph(); // 0x00000001817589F0-0x0000000181758A10
		protected virtual void OnGraphStarted(); // 0x00000001803581E0-0x00000001803581F0
		protected virtual void OnGraphUpdate(); // 0x00000001803581E0-0x00000001803581F0
		protected virtual void OnGraphStoped(); // 0x00000001803581E0-0x00000001803581F0
		protected virtual void OnGraphPaused(); // 0x00000001803581E0-0x00000001803581F0
		protected virtual void OnGraphUnpaused(); // 0x00000001803581E0-0x00000001803581F0
		public void SendEvent(EventData eventData, object sender); // 0x0000000181757980-0x0000000181757AD0
		public static void SendGlobalEvent(EventData eventData, object sender); // 0x0000000181757AD0-0x0000000181757CB0
		public Node GetNodeWithID(int searchID); // 0x0000000181756570-0x0000000181756650
		public List<T> GetAllNodesOfType<T>()
			where T : Node;
		public T GetNodeWithTag<T>(string tagName)
			where T : Node;
		public List<T> GetNodesWithTag<T>(string tagName)
			where T : Node;
		public List<T> GetAllTagedNodes<T>()
			where T : Node;
		public List<Node> GetRootNodes(); // 0x0000000181756760-0x0000000181756860
		public List<Node> GetLeafNodes(); // 0x00000001817562F0-0x00000001817563F0
		public List<T> GetAllNestedGraphs<T>(bool recursive)
			where T : Graph;
		public List<Graph> GetAllInstancedNestedGraphs(); // 0x00000001817556E0-0x00000001817559E0
		public static Graph GetElementGraph(object obj); // 0x0000000181755B10-0x0000000181755F30
		public List<T> GetAllTasksOfType<T>()
			where T : Task;
		private void GetObjectTasks<T>(object obj, ref List<T> tasks)
			where T : Task;
		public HierarchyTree.Element GetFlatGraphHierarchy(); // 0x0000000181755F30-0x0000000181756150
		public HierarchyTree.Element GetFullGraphHierarchy(); // 0x0000000181756150-0x00000001817562F0
		public HierarchyTree.Element GetNestedGraphHierarchy(); // 0x00000001817563F0-0x0000000181756570
		private HierarchyTree.Element GetTreeNodeElement(Node node, bool recurse, ref int lastID); // 0x0000000181756CF0-0x0000000181756EC0
		public static HierarchyTree.Element GetTaskAndParametersStructureInTarget(object obj); // 0x00000001817568F0-0x0000000181756BE0
		public IGraphElement GetTaskParentElement(Task targetTask); // 0x0000000181756BE0-0x0000000181756C60
		public IGraphElement GetParameterParentElement(BBParameter targetParameter); // 0x0000000181756650-0x00000001817566D0
		public static Task[] GetTasksInElement(IGraphElement target); // 0x0000000181756C60-0x0000000181756CF0
		public static BBParameter[] GetParametersInElement(IGraphElement target); // 0x00000001817566D0-0x0000000181756760
		public BBParameter[] GetDefinedParameters(); // 0x00000001817559E0-0x0000000181755B10
		public void PromoteDefinedParametersToVariables(IBlackboard bb); // 0x00000001817571F0-0x0000000181757380
		public T AddNode<T>()
			where T : Node;
		public T AddNode<T>(Vector2 pos)
			where T : Node;
		public Node AddNode(Type nodeType); // 0x0000000181753EC0-0x0000000181753F30
		public Node AddNode(Type nodeType, Vector2 pos); // 0x0000000181753F30-0x0000000181754320
		public void RemoveNode(Node node, bool recordUndo = true /* Metadata: 0x007845F8 */, bool force = false /* Metadata: 0x007845F9 */); // 0x0000000181757550-0x0000000181757970
		public Connection ConnectNodes(Node sourceNode, Node targetNode, int sourceIndex = -1 /* Metadata: 0x007845FA */, int targetIndex = -1 /* Metadata: 0x007845FE */); // 0x0000000181754FF0-0x0000000181755090
		public void RemoveConnection(Connection connection, bool recordUndo = true /* Metadata: 0x00784602 */); // 0x0000000181757380-0x0000000181757550
		public void RecordUndo(string name); // 0x00000001803581E0-0x00000001803581F0
		public void ClearGraph(); // 0x00000001817544A0-0x0000000181754570
	}
}
