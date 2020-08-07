/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework.Internal;
using ParadoxNotion;
using ParadoxNotion.Serialization.FullSerializer;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Framework
{
	[Serializable]
	public abstract class Graph : ScriptableObject, ITaskSystem, ISerializationCallbackReceiver // TypeDefIndex: 15674
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string _serializedGraph; // 0x18
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private List<UnityEngine.Object> _objectReferences; // 0x20
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private GraphSource _graphSource; // 0x28
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool _haltSerialization; // 0x30
		[NonSerialized]
		private bool haltForUndo; // 0x31
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static Action<Graph> onGraphSerialized; // 0x00
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static Action<Graph> onGraphDeserialized; // 0x08
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Action<bool> onFinish; // 0x38
		private static List<Graph> _runningGraphs; // 0x10
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <hasInitialized>k__BackingField; // 0x40
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private HierarchyTree.Element <flatMetaGraph>k__BackingField; // 0x48
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private HierarchyTree.Element <fullMetaGraph>k__BackingField; // 0x50
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private HierarchyTree.Element <nestedMetaGraph>k__BackingField; // 0x58
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Graph <parentGraph>k__BackingField; // 0x60
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float <elapsedTime>k__BackingField; // 0x68
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float <deltaTime>k__BackingField; // 0x6C
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int <lastUpdateFrame>k__BackingField; // 0x70
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <isRunning>k__BackingField; // 0x74
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <isPaused>k__BackingField; // 0x75
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private UpdateMode <updateMode>k__BackingField; // 0x78
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Component <agent>k__BackingField; // 0x80
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private IBlackboard <parentBlackboard>k__BackingField; // 0x88
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Action delayedInitCalls; // 0x90
	
		// Properties
		private bool hasInitialized { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180455BA0-0x0000000180455BB0 0x0000000180455C20-0x0000000180455C30
		private HierarchyTree.Element flatMetaGraph { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803743E0-0x00000001803743F0 0x00000001804ADAE0-0x00000001804ADAF0
		private HierarchyTree.Element fullMetaGraph { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180378320-0x0000000180378330 0x00000001803F7B90-0x00000001803F7BA0
		private HierarchyTree.Element nestedMetaGraph { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803A1580-0x00000001803A1590 0x00000001803A1740-0x00000001803A1750
		public abstract Type baseNodeType { get; }
		public abstract bool requiresAgent { get; }
		public abstract bool requiresPrimeNode { get; }
		public abstract bool isTree { get; }
		public abstract bool allowBlackboardOverrides { get; }
		public abstract bool canAcceptVariableDrops { get; }
		private GraphSource graphSource { get; set; } // 0x00000001803745B0-0x00000001803745C0 0x00000001803FA0C0-0x00000001803FA0D0
		public string category { get; set; } // 0x00000001808AE700-0x00000001808AE720 0x00000001808AEC90-0x00000001808AECB0
		public string comments { get; set; } // 0x00000001808AE720-0x00000001808AE740 0x00000001808AECB0-0x00000001808AECD0
		public Vector2 translation { get; set; } // 0x00000001808AE960-0x00000001808AE990 0x00000001808AEE70-0x00000001808AEEB0
		public float zoomFactor { get; set; } // 0x00000001808AE990-0x00000001808AE9B0 0x00000001808AEEB0-0x00000001808AEED0
		public List<Node> allNodes { get; set; } // 0x00000001808AE680-0x00000001808AE6A0 0x00000001808AEC50-0x00000001808AEC70
		public List<CanvasGroup> canvasGroups { get; set; } // 0x00000001808AE6E0-0x00000001808AE700 0x00000001808AEC70-0x00000001808AEC90
		private BlackboardSource localBlackboard { get; set; } // 0x00000001808AE6C0-0x00000001808AE6E0 0x00000001808AECF0-0x00000001808AED10
		private List<Task> allTasks { get; } // 0x00000001808AE6A0-0x00000001808AE6C0 
		private List<BBParameter> allParameters { get; } // 0x00000001808AA100-0x00000001808AA120 
		private List<Connection> allConnections { get; } // 0x00000001808A9DE0-0x00000001808A9E00 
		public Graph rootGraph { get; } // 0x00000001808AE880-0x00000001808AE920 
		public bool serializationHalted { get; } // 0x0000000180455B90-0x0000000180455BA0 
		public static IEnumerable<Graph> runningGraphs { get; } // 0x00000001808AE920-0x00000001808AE960 
		public Graph parentGraph { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180418970-0x0000000180418980 0x00000001804AF510-0x00000001804AF520
		public float elapsedTime { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001804C5F40-0x00000001804C5F50 0x00000001804C6190-0x00000001804C61A0
		public float deltaTime { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001804C5F30-0x00000001804C5F40 0x00000001804C6180-0x00000001804C6190
		public int lastUpdateFrame { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001804B4700-0x00000001804B4710 0x00000001804B47E0-0x00000001804B47F0
		public bool didUpdateLastFrame { get; } // 0x00000001808AE740-0x00000001808AE760 
		public bool isRunning { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001808AE770-0x00000001808AE780 0x00000001808AECE0-0x00000001808AECF0
		public bool isPaused { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001808AE760-0x00000001808AE770 0x00000001808AECD0-0x00000001808AECE0
		public UpdateMode updateMode { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803959E0-0x00000001803959F0 0x00000001804793B0-0x00000001804793C0
		public Node primeNode { get; set; } // 0x00000001808AE780-0x00000001808AE880 0x00000001808AED10-0x00000001808AEE70
		public Component agent { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x000000018040ED60-0x000000018040ED70 0x00000001804793A0-0x00000001804793B0
		public IBlackboard blackboard { get; } // 0x00000001808AE6C0-0x00000001808AE6E0 
		public IBlackboard parentBlackboard { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180476CE0-0x0000000180476CF0 0x00000001804794C0-0x00000001804794D0
		UnityEngine.Object ITaskSystem.contextObject { get; } // 0x0000000180411160-0x0000000180411170 
	
		// Events
		public static event Action<Graph> onGraphSerialized {
			add; // 0x00000001808AE5D0-0x00000001808AE680
			remove; // 0x00000001808AEBA0-0x00000001808AEC50
		}
		public static event Action<Graph> onGraphDeserialized {
			add; // 0x00000001808AE520-0x00000001808AE5D0
			remove; // 0x00000001808AEAF0-0x00000001808AEBA0
		}
		public event Action<bool> onFinish {
			add; // 0x00000001808AE480-0x00000001808AE520
			remove; // 0x00000001808AEA50-0x00000001808AEAF0
		}
		private event Action delayedInitCalls {
			add; // 0x00000001808AE3E0-0x00000001808AE480
			remove; // 0x00000001808AE9B0-0x00000001808AEA50
		}
	
		// Nested types
		public enum UpdateMode // TypeDefIndex: 15675
		{
			NormalUpdate = 0,
			LateUpdate = 1,
			FixedUpdate = 2,
			Manual = 3
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 15676
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<Node, int> <>9__149_0; // 0x08
			public static Func<Node, bool> <>9__190_0; // 0x10
			public static Func<Node, bool> <>9__191_0; // 0x18
			public static Func<BBParameter, bool> <>9__194_0; // 0x20
	
			// Constructors
			static <>c(); // 0x0000000180CD25D0-0x0000000180CD2630
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal int <UpdateNodeIDs>b__149_0(Node n); // 0x0000000180CD1D90-0x0000000180CD1E00
			internal bool <GetRootNodes>b__190_0(Node n); // 0x0000000180CD1C50-0x0000000180CD1CA0
			internal bool <GetLeafNodes>b__191_0(Node n); // 0x0000000180CD1C00-0x0000000180CD1C50
			internal bool <GetDefinedParameters>b__194_0(BBParameter p); // 0x0000000180CD1BE0-0x0000000180CD1C00
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass155_0 // TypeDefIndex: 15677
		{
			// Fields
			public Graph <>4__this; // 0x10
			public GraphLoadData data; // 0x18
	
			// Constructors
			public <>c__DisplayClass155_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal void <LoadOverwriteAsync>b__0(); // 0x0000000180CD1E00-0x0000000180CD1E50
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <LoadOverwriteAsync>d__155 : IAsyncStateMachine // TypeDefIndex: 15678
		{
			// Fields
			public int <>1__state; // 0x00
			public AsyncVoidMethodBuilder <>t__builder; // 0x08
			public Graph <>4__this; // 0x28
			public GraphLoadData data; // 0x30
			public Action callback; // 0x60
			private TaskAwaiter <>u__1; // 0x68
	
			// Methods
			private void MoveNext(); // 0x000000018006C170-0x000000018006CC10
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass156_0 // TypeDefIndex: 15679
		{
			// Fields
			public Graph <>4__this; // 0x10
			public GraphLoadData data; // 0x18
	
			// Constructors
			public <>c__DisplayClass156_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal void <LoadOverwrite>b__0(); // 0x0000000180CD1E50-0x0000000180CD1E90
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass185_0 // TypeDefIndex: 15680
		{
			// Fields
			public int searchID; // 0x10
	
			// Constructors
			public <>c__DisplayClass185_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <GetNodeWithID>b__0(Node n); // 0x0000000180CD1E90-0x0000000180CD1EB0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass187_0<T> // TypeDefIndex: 15681
			where T : Node
		{
			// Fields
			public string tagName;
	
			// Constructors
			public <>c__DisplayClass187_0();
	
			// Methods
			internal bool <GetNodeWithTag>b__0(T n);
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass188_0<T> // TypeDefIndex: 15682
			where T : Node
		{
			// Fields
			public string tagName;
	
			// Constructors
			public <>c__DisplayClass188_0();
	
			// Methods
			internal bool <GetNodesWithTag>b__0(T n);
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass202_0 // TypeDefIndex: 15683
		{
			// Fields
			public Stack<HierarchyTree.Element> stack; // 0x10
			public HierarchyTree.Element parentElement; // 0x18
	
			// Constructors
			public <>c__DisplayClass202_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal void <CollectSubElements>b__0(object o); // 0x0000000180CD1F30-0x0000000180CD2010
			internal void <CollectSubElements>b__1(object o, fsData d); // 0x0000000180CD2010-0x0000000180CD2080
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass205_0 // TypeDefIndex: 15684
		{
			// Fields
			public List<Task> result; // 0x10
	
			// Constructors
			public <>c__DisplayClass205_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal void <GetTasksInElement>b__0(object o, fsData d); // 0x0000000180CD2080-0x0000000180CD2170
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass206_0 // TypeDefIndex: 15685
		{
			// Fields
			public List<BBParameter> result; // 0x10
	
			// Constructors
			public <>c__DisplayClass206_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal void <GetParametersInElement>b__0(object o, fsData d); // 0x0000000180CD2170-0x0000000180CD2260
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass211_0 // TypeDefIndex: 15686
		{
			// Fields
			public Node node; // 0x10
	
			// Constructors
			public <>c__DisplayClass211_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <RemoveNode>b__0(Node n); // 0x0000000180CD2260-0x0000000180CD2300
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass214_0 // TypeDefIndex: 15687
		{
			// Fields
			public Graph targetGraph; // 0x10
	
			// Constructors
			public <>c__DisplayClass214_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <CloneNodes>b__0(Node n); // 0x0000000180CD2300-0x0000000180CD2380
		}
	
		// Constructors
		protected Graph(); // 0x00000001808AE380-0x00000001808AE3E0
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x00000001808AD7E0-0x00000001808AD7F0
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x00000001808AD770-0x00000001808AD7E0
		protected void OnEnable(); // 0x00000001808AB770-0x00000001808AB7A0
		protected void OnDisable(); // 0x00000001808AB750-0x00000001808AB770
		protected void OnDestroy(); // 0x00000001808AB730-0x00000001808AB750
		protected void OnValidate(); // 0x00000001803774A0-0x00000001803774B0
		protected void Reset(); // 0x00000001808AC590-0x00000001808AC5B0
		public bool SelfSerialize(); // 0x00000001808AC890-0x00000001808ACA90
		public bool SelfDeserialize(); // 0x00000001808AC810-0x00000001808AC890
		public string Serialize(List<UnityEngine.Object> references); // 0x00000001808ACE70-0x00000001808ACF70
		public bool Deserialize(string serializedGraph, List<UnityEngine.Object> references, bool validate); // 0x00000001808A9AB0-0x00000001808A9C40
		public GraphSource GetGraphSource(); // 0x00000001803745B0-0x00000001803745C0
		public string GetSerializedJsonData(); // 0x0000000180372430-0x0000000180372440
		internal List<UnityEngine.Object> GetSerializedReferencesData(); // 0x00000001808AB030-0x00000001808AB080
		internal GraphSource GetGraphSourceMetaDataCopy(); // 0x00000001808AAAC0-0x00000001808AAB30
		internal void SetGraphSourceMetaData(GraphSource source); // 0x00000001808ACF70-0x00000001808ACF90
		public string SerializeLocalBlackboard(ref List<UnityEngine.Object> references); // 0x00000001808ACD90-0x00000001808ACE70
		public bool DeserializeLocalBlackboard(string json, List<UnityEngine.Object> references); // 0x00000001808A9A00-0x00000001808A9AB0
		public static T Clone<T>(T graph, Graph parentGraph)
			where T : Graph;
		public void Validate(); // 0x00000001808AE0F0-0x00000001808AE380
		public void UpdateReferencesFromOwner(GraphOwner owner, bool force = false /* Metadata: 0x007BB455 */); // 0x00000001808ADD60-0x00000001808ADE20
		public void UpdateReferences(Component newAgent, IBlackboard newParentBlackboard, bool force = false /* Metadata: 0x007BB456 */); // 0x00000001808ADE20-0x00000001808AE0F0
		private void UpdateNodeBBFields(); // 0x00000001808AD890-0x00000001808ADA10
		void ITaskSystem.UpdateTasksOwner(); // 0x00000001808AB660-0x00000001808AB730
		public void UpdateNodeIDs(bool alsoReorderList); // 0x00000001808ADA10-0x00000001808ADD60
		private int AssignNodeID(Node node, int lastID, ref Node[] parsed); // 0x00000001808A8C00-0x00000001808A8D70
		protected void ThreadSafeInitCall(Action call); // 0x00000001808AD660-0x00000001808AD770
		[AsyncStateMachine] // 0x000000018020A520-0x000000018020A570
		public void LoadOverwriteAsync(GraphLoadData data, Action callback); // 0x00000001808AB410-0x00000001808AB500
		public void LoadOverwrite(GraphLoadData data); // 0x00000001808AB500-0x00000001808AB660
		public void Initialize(Component newAgent, IBlackboard newParentBlackboard, bool preInitializeSubGraphs); // 0x00000001808AB390-0x00000001808AB410
		private void PreInitializeSubGraphs(); // 0x00000001808AB950-0x00000001808ABB40
		public void StartGraph(Component newAgent, IBlackboard newParentBlackboard, UpdateMode newUpdateMode, Action<bool> callback = null); // 0x00000001808ACF90-0x00000001808AD370
		public void Stop(bool success = true /* Metadata: 0x007BB457 */); // 0x00000001808AD3A0-0x00000001808AD660
		public void Pause(); // 0x00000001808AB7A0-0x00000001808AB950
		public void Resume(); // 0x00000001808AC610-0x00000001808AC810
		public void Restart(); // 0x00000001808AC5B0-0x00000001808AC610
		public void UpdateGraph(); // 0x00000001808AD7F0-0x00000001808AD840
		public void UpdateGraph(float deltaTime); // 0x00000001808AD840-0x00000001808AD890
		public virtual object OnDerivedDataSerialization(); // 0x000000018037DDC0-0x000000018037DDD0
		public virtual void OnDerivedDataDeserialization(object data); // 0x00000001803774A0-0x00000001803774B0
		protected virtual void OnGraphInitialize(); // 0x00000001803774A0-0x00000001803774B0
		protected virtual void OnGraphStarted(); // 0x00000001803774A0-0x00000001803774B0
		protected virtual void OnGraphUpdate(); // 0x00000001803774A0-0x00000001803774B0
		protected virtual void OnGraphStoped(); // 0x00000001803774A0-0x00000001803774B0
		protected virtual void OnGraphPaused(); // 0x00000001803774A0-0x00000001803774B0
		protected virtual void OnGraphUnpaused(); // 0x00000001803774A0-0x00000001803774B0
		protected virtual void OnGraphObjectEnable(); // 0x00000001803774A0-0x00000001803774B0
		protected virtual void OnGraphObjectDisable(); // 0x00000001803774A0-0x00000001803774B0
		protected virtual void OnGraphObjectDestroy(); // 0x00000001803774A0-0x00000001803774B0
		protected virtual void OnGraphValidate(); // 0x00000001803774A0-0x00000001803774B0
		public void SendEvent(string name, object value, object sender); // 0x00000001808ACA90-0x00000001808ACBA0
		public void SendEvent<T>(string name, T value, object sender);
		public static void SendGlobalEvent(string name, object value, object sender); // 0x00000001808ACBA0-0x00000001808ACD90
		public static void SendGlobalEvent<T>(string name, T value, object sender);
		public IEnumerable<BBParameter> GetAllParameters(); // 0x00000001808AA100-0x00000001808AA120
		public IEnumerable<Connection> GetAllConnections(); // 0x00000001808A9DE0-0x00000001808A9E00
		public IEnumerable<T> GetAllTasksOfType<T>()
			where T : Task;
		public Node GetNodeWithID(int searchID); // 0x00000001808AACA0-0x00000001808AADA0
		public IEnumerable<T> GetAllNodesOfType<T>()
			where T : Node;
		public T GetNodeWithTag<T>(string tagName)
			where T : Node;
		public IEnumerable<T> GetNodesWithTag<T>(string tagName)
			where T : Node;
		public List<T> GetAllTagedNodes<T>()
			where T : Node;
		public IEnumerable<Node> GetRootNodes(); // 0x00000001808AAF30-0x00000001808AB030
		public IEnumerable<Node> GetLeafNodes(); // 0x00000001808AAB30-0x00000001808AAC30
		public IEnumerable<T> GetAllNestedGraphs<T>(bool recursive)
			where T : Graph;
		public IEnumerable<Graph> GetAllInstancedNestedGraphs(); // 0x00000001808A9E00-0x00000001808AA100
		public IEnumerable<BBParameter> GetDefinedParameters(); // 0x00000001808AA120-0x00000001808AA220
		public void PromoteMissingParametersToVariables(IBlackboard bb); // 0x00000001808ABB40-0x00000001808ABDE0
		public static Graph GetElementGraph(object obj); // 0x00000001808AA220-0x00000001808AA6F0
		public HierarchyTree.Element GetFlatMetaGraph(); // 0x00000001808AA6F0-0x00000001808AA910
		public HierarchyTree.Element GetFullMetaGraph(); // 0x00000001808AA910-0x00000001808AAAC0
		public HierarchyTree.Element GetNestedMetaGraph(); // 0x00000001808AAC30-0x00000001808AACA0
		private static void DigNestedGraphs(Graph currentGraph, HierarchyTree.Element currentElement); // 0x00000001808A9C40-0x00000001808A9DE0
		private static HierarchyTree.Element GetTreeNodeElement(Node node, bool recurse, ref int lastID); // 0x00000001808AB210-0x00000001808AB390
		private static HierarchyTree.Element CollectSubElements(IGraphElement obj); // 0x00000001808A9720-0x00000001808A9870
		public IGraphElement GetTaskParentElement(Task targetTask); // 0x00000001808AB080-0x00000001808AB100
		public IGraphElement GetParameterParentElement(BBParameter targetParameter); // 0x00000001808AADA0-0x00000001808AAE20
		public static IEnumerable<Task> GetTasksInElement(IGraphElement target); // 0x00000001808AB100-0x00000001808AB210
		public static IEnumerable<BBParameter> GetParametersInElement(IGraphElement target); // 0x00000001808AAE20-0x00000001808AAF30
		public T AddNode<T>()
			where T : Node;
		public T AddNode<T>(Vector2 pos)
			where T : Node;
		public Node AddNode(Type nodeType); // 0x00000001808A8980-0x00000001808A8A00
		public Node AddNode(Type nodeType, Vector2 pos); // 0x00000001808A8A00-0x00000001808A8C00
		public void RemoveNode(Node node, bool recordUndo = true /* Metadata: 0x007BB458 */, bool force = false /* Metadata: 0x007BB459 */); // 0x00000001808ABFA0-0x00000001808AC590
		public Connection ConnectNodes(Node sourceNode, Node targetNode, int sourceIndex = -1 /* Metadata: 0x007BB45A */, int targetIndex = -1 /* Metadata: 0x007BB45E */); // 0x00000001808A9870-0x00000001808A9A00
		public void RemoveConnection(Connection connection, bool recordUndo = true /* Metadata: 0x007BB462 */); // 0x00000001808ABDE0-0x00000001808ABFA0
		public static List<Node> CloneNodes(List<Node> originalNodes, Graph targetGraph = null, Vector2 originPosition = default); // 0x00000001808A8E50-0x00000001808A9720
		public void ClearGraph(); // 0x00000001808A8D70-0x00000001808A8E50
		[Obsolete] // 0x000000018020A7E0-0x000000018020A810
		public void StartGraph(Component newAgent, IBlackboard newBlackboard, bool autoUpdate, Action<bool> callback = null); // 0x00000001808AD370-0x00000001808AD3A0
	}
}
