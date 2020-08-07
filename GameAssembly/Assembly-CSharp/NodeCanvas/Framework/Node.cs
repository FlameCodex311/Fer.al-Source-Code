/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ParadoxNotion;
using ParadoxNotion.Design;
using ParadoxNotion.Serialization.FullSerializer;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Framework
{
	[Serializable]
	[fsDeserializeOverwrite] // 0x0000000180215490-0x00000001802154D0
	[fsSerializeAsReference] // 0x0000000180215490-0x00000001802154D0
	[SpoofAOT] // 0x0000000180215490-0x00000001802154D0
	public abstract class Node : IGraphElement, ISerializationCollectable // TypeDefIndex: 15708
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string _UID; // 0x10
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string _name; // 0x18
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string _tag; // 0x20
		[fsIgnoreInBuild] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		private Vector2 _position; // 0x28
		[fsIgnoreInBuild] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		private string _comment; // 0x30
		[fsIgnoreInBuild] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		private bool _isBreakpoint; // 0x38
		private Graph _graph; // 0x40
		private int _ID; // 0x48
		private List<Connection> _inConnections; // 0x50
		private List<Connection> _outConnections; // 0x58
		[NonSerialized]
		private Status _status; // 0x60
		[NonSerialized]
		private string _nameCache; // 0x68
		[NonSerialized]
		private string _descriptionCache; // 0x70
		[NonSerialized]
		private int _priorityCache; // 0x78
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float <timeStarted>k__BackingField; // 0x7C
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <isChecked>k__BackingField; // 0x80
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <breakPointReached>k__BackingField; // 0x81
	
		// Properties
		public Graph graph { get; internal set; } // 0x00000001803C7290-0x00000001803C72A0 0x00000001804CD6C0-0x00000001804CD6D0
		public int ID { get; internal set; } // 0x0000000180379ED0-0x0000000180379EE0 0x00000001804D99A0-0x00000001804D99B0
		public string UID { get; } // 0x0000000180CCD6D0-0x0000000180CCD760 
		public List<Connection> inConnections { get; protected set; } // 0x0000000180378320-0x0000000180378330 0x00000001803F7B90-0x00000001803F7BA0
		public List<Connection> outConnections { get; protected set; } // 0x00000001803A1580-0x00000001803A1590 0x00000001803A1740-0x00000001803A1750
		public Vector2 position { get; set; } // 0x0000000180CBC8E0-0x0000000180CBC900 0x00000001803FA0C0-0x00000001803FA0D0
		private string customName { get; set; } // 0x0000000180372430-0x0000000180372440 0x0000000180379F30-0x0000000180379F40
		public string tag { get; set; } // 0x0000000180374AF0-0x0000000180374B00 0x00000001803F70C0-0x00000001803F70D0
		public string comments { get; set; } // 0x00000001803745C0-0x00000001803745D0 0x00000001803FA0A0-0x00000001803FA0B0
		public bool isBreakpoint { get; set; } // 0x0000000180379B20-0x0000000180379B30 0x00000001804F1690-0x00000001804F16A0
		public virtual string name { get; set; } // 0x0000000180CCD980-0x0000000180CCDAB0 0x0000000180379F30-0x0000000180379F40
		public virtual string description { get; } // 0x0000000180CCD770-0x0000000180CCD820 
		public virtual int priority { get; } // 0x0000000180CCDAB0-0x0000000180CCDB40 
		public abstract int maxInConnections { get; }
		public abstract int maxOutConnections { get; }
		public abstract Type outConnectionType { get; }
		public abstract bool allowAsPrime { get; }
		public abstract bool canSelfConnect { get; }
		public abstract Alignment2x2 commentsAlignment { get; }
		public abstract Alignment2x2 iconAlignment { get; }
		public Status status { get; protected set; } // 0x00000001804ADA80-0x00000001804ADA90 0x0000000180CC4190-0x0000000180CC41C0
		public Component graphAgent { get; } // 0x0000000180CCD850-0x0000000180CCD8E0 
		public IBlackboard graphBlackboard { get; } // 0x0000000180CCD8E0-0x0000000180CCD970 
		public float elapsedTime { get; } // 0x0000000180CCD820-0x0000000180CCD850 
		private float timeStarted { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180780020-0x0000000180780030 0x0000000180CCDB60-0x0000000180CCDB70
		private bool isChecked { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180CCD970-0x0000000180CCD980 0x0000000180CCDB50-0x0000000180CCDB60
		private bool breakPointReached { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180CCD760-0x0000000180CCD770 0x0000000180CCDB40-0x0000000180CCDB50
	
		// Nested types
		[AttributeUsage] // 0x00000001801D0B50-0x00000001801D0B70
		protected class AutoSortWithChildrenConnections : Attribute // TypeDefIndex: 15709
		{
			// Constructors
			public AutoSortWithChildrenConnections(); // 0x00000001803F46D0-0x00000001803F46E0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <YieldBreak>d__92 : IEnumerator<object> // TypeDefIndex: 15710
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public Action resume; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <YieldBreak>d__92(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180CD2690-0x0000000180CD2730
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180CD2730-0x0000000180CD2780
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass102_0 // TypeDefIndex: 15711
		{
			// Fields
			public Node b; // 0x10
			public Node a; // 0x18
	
			// Constructors
			public <>c__DisplayClass102_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <AreNodesConnected>b__0(Connection c); // 0x0000000180373A80-0x0000000180373AA0
			internal bool <AreNodesConnected>b__1(Connection c); // 0x0000000180387F60-0x0000000180387F80
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 15712
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<Connection, Node> <>9__105_0; // 0x08
			public static Func<Connection, Node> <>9__106_0; // 0x10
	
			// Constructors
			static <>c(); // 0x0000000180CD2570-0x0000000180CD25D0
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal Node <GetParentNodes>b__105_0(Connection c); // 0x0000000180386C00-0x0000000180386C20
			internal Node <GetChildNodes>b__106_0(Connection c); // 0x000000018038CAA0-0x000000018038CAC0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass107_0 // TypeDefIndex: 15713
		{
			// Fields
			public Node parentNode; // 0x10
	
			// Constructors
			public <>c__DisplayClass107_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <IsChildOf>b__0(Connection c); // 0x0000000180786E80-0x0000000180786EA0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass108_0 // TypeDefIndex: 15714
		{
			// Fields
			public Node childNode; // 0x10
	
			// Constructors
			public <>c__DisplayClass108_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <IsParentOf>b__0(Connection c); // 0x0000000180373A80-0x0000000180373AA0
		}
	
		// Constructors
		public Node(); // 0x0000000180CCD640-0x0000000180CCD6D0
	
		// Methods
		public static Node Create(Graph targetGraph, Type nodeType, Vector2 pos); // 0x0000000180CCC440-0x0000000180CCC590
		public Node Duplicate(Graph targetGraph); // 0x0000000180CCC590-0x0000000180CCC950
		public void Validate(Graph assignedGraph); // 0x0000000180CCD550-0x0000000180CCD5E0
		public Status Execute(Component agent, IBlackboard blackboard); // 0x0000000180CCCA70-0x0000000180CCCAC0
		public void Reset(bool recursively = true /* Metadata: 0x007BB494 */); // 0x0000000180CCD1D0-0x0000000180CCD2D0
		[IteratorStateMachine] // 0x0000000180217640-0x0000000180217690
		private IEnumerator YieldBreak(Action resume); // 0x0000000180CCD5E0-0x0000000180CCD640
		public Status Error(object msg); // 0x0000000180CCC950-0x0000000180CCCA70
		public Status Fail(string msg); // 0x0000000180CCCAC0-0x0000000180CCCAD0
		public void Warn(string msg); // 0x00000001803774A0-0x00000001803774B0
		public void SetStatus(Status status); // 0x0000000180CC4190-0x0000000180CC41C0
		protected void SendEvent(string eventName); // 0x0000000180CCD2D0-0x0000000180CCD300
		protected void SendEvent<T>(string eventName, T value);
		public static bool IsNewConnectionAllowed(Node sourceNode, Node targetNode, Connection refConnection = null); // 0x0000000180CCCFC0-0x0000000180CCD120
		protected virtual bool CanConnectToTarget(Node targetNode); // 0x0000000180380B60-0x0000000180380B70
		protected virtual bool CanConnectFromSource(Node sourceNode); // 0x0000000180380B60-0x0000000180380B70
		public static bool AreNodesConnected(Node a, Node b); // 0x0000000180CCC310-0x0000000180CCC440
		public Coroutine StartCoroutine(IEnumerator routine); // 0x0000000180CCD300-0x0000000180CCD330
		public void StopCoroutine(Coroutine routine); // 0x0000000180CCD330-0x0000000180CCD360
		public IEnumerable<Node> GetParentNodes(); // 0x0000000180CCCD30-0x0000000180CCCE50
		public IEnumerable<Node> GetChildNodes(); // 0x0000000180CCCAD0-0x0000000180CCCBF0
		public bool IsChildOf(Node parentNode); // 0x0000000180CCCF10-0x0000000180CCCFC0
		public bool IsParentOf(Node childNode); // 0x0000000180CCD120-0x0000000180CCD1D0
		internal virtual string GetWarningOrError(); // 0x0000000180CCCE50-0x0000000180CCCF10
		private string GetHardError(); // 0x0000000180CCCBF0-0x0000000180CCCD30
		protected virtual Status OnExecute(Component agent, IBlackboard blackboard); // 0x00000001804ADA80-0x00000001804ADA90
		protected virtual void OnReset(); // 0x00000001803774A0-0x00000001803774B0
		public virtual void OnCreate(Graph assignedGraph); // 0x00000001803774A0-0x00000001803774B0
		public virtual void OnValidate(Graph assignedGraph); // 0x00000001803774A0-0x00000001803774B0
		public virtual void OnDestroy(); // 0x00000001803774A0-0x00000001803774B0
		public virtual void OnParentConnected(int connectionIndex); // 0x00000001803774A0-0x00000001803774B0
		public virtual void OnParentDisconnected(int connectionIndex); // 0x00000001803774A0-0x00000001803774B0
		public virtual void OnChildConnected(int connectionIndex); // 0x00000001803774A0-0x00000001803774B0
		public virtual void OnChildDisconnected(int connectionIndex); // 0x00000001803774A0-0x00000001803774B0
		public virtual void OnChildrenConnectionsSorted(int[] oldIndeces); // 0x00000001803774A0-0x00000001803774B0
		public virtual void OnGraphStarted(); // 0x00000001803774A0-0x00000001803774B0
		public virtual void OnPostGraphStarted(); // 0x00000001803774A0-0x00000001803774B0
		public virtual void OnGraphStoped(); // 0x00000001803774A0-0x00000001803774B0
		public virtual void OnPostGraphStoped(); // 0x00000001803774A0-0x00000001803774B0
		public virtual void OnGraphPaused(); // 0x00000001803774A0-0x00000001803774B0
		public virtual void OnGraphUnpaused(); // 0x00000001803774A0-0x00000001803774B0
		public override string ToString(); // 0x0000000180CCD360-0x0000000180CCD550
	}
}
