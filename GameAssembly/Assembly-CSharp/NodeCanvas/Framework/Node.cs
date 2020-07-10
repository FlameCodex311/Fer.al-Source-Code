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
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Framework
{
	[Serializable]
	[SpoofAOT] // 0x00000001800B36B0-0x00000001800B36C0
	public abstract class Node : IGraphElement // TypeDefIndex: 14577
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Vector2 _position; // 0x10
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private string _UID; // 0x18
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private string _name; // 0x20
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private string _tag; // 0x28
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private string _comment; // 0x30
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool _isBreakpoint; // 0x38
		private Graph _graph; // 0x40
		private List<Connection> _inConnections; // 0x48
		private List<Connection> _outConnections; // 0x50
		private int _ID; // 0x58
		[NonSerialized]
		private Status _status; // 0x5C
		[NonSerialized]
		private string _nameCache; // 0x60
		[NonSerialized]
		private string _descriptionCache; // 0x68
		[NonSerialized]
		private int _priorityCache; // 0x70
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <isChecked>k__BackingField; // 0x74
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <breakPointReached>k__BackingField; // 0x75
	
		// Properties
		public Graph graph { get; set; } // 0x0000000180369B30-0x0000000180369B40 0x00000001803A2810-0x00000001803A2820
		public int ID { get; set; } // 0x000000018049CAA0-0x000000018049CAB0 0x000000018049CAB0-0x000000018049CAC0
		public List<Connection> inConnections { get; protected set; } // 0x0000000180369C40-0x0000000180369C50 0x00000001803A27F0-0x00000001803A2800
		public List<Connection> outConnections { get; protected set; } // 0x00000001803A27A0-0x00000001803A27B0 0x00000001803A2850-0x00000001803A2860
		public Vector2 position { get; set; } // 0x0000000180D3D790-0x0000000180D3D970 0x000000018036B1E0-0x000000018036B1F0
		public string UID { get; } // 0x000000018175CD10-0x000000018175CDA0 
		private string customName { get; set; } // 0x000000018036AC70-0x000000018036AC80 0x000000018036AC90-0x000000018036ACA0
		public string tag { get; set; } // 0x0000000180369B60-0x0000000180369B70 0x0000000180422D30-0x0000000180422D40
		public string comments { get; set; } // 0x0000000180397720-0x0000000180397730 0x00000001803A2800-0x00000001803A2810
		public bool isBreakpoint { get; set; } // 0x00000001804AEAD0-0x00000001804AEAE0 0x000000018044E330-0x000000018044E340
		public virtual string name { get; set; } // 0x000000018175CFA0-0x000000018175D0D0 0x000000018036AC90-0x000000018036ACA0
		public virtual string description { get; } // 0x000000018175CDA0-0x000000018175CE50 
		public virtual int priority { get; } // 0x000000018175D0D0-0x000000018175D160 
		public abstract int maxInConnections { get; }
		public abstract int maxOutConnections { get; }
		public abstract Type outConnectionType { get; }
		public abstract bool allowAsPrime { get; }
		public abstract Alignment2x2 commentsAlignment { get; }
		public abstract Alignment2x2 iconAlignment { get; }
		public Status status { get; protected set; } // 0x00000001804A3740-0x00000001804A3750 0x00000001804A3750-0x00000001804A3760
		public Component graphAgent { get; } // 0x000000018175CE50-0x000000018175CEE0 
		public IBlackboard graphBlackboard { get; } // 0x000000018175CEE0-0x000000018175CFA0 
		private bool isChecked { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180545D50-0x0000000180545D60 0x0000000180DE6720-0x0000000180DE6730
		private bool breakPointReached { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180545D90-0x0000000180545DA0 0x0000000180545DE0-0x0000000180545DF0
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <YieldBreak>d__85 : IEnumerator<object> // TypeDefIndex: 14578
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public Action resume; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <YieldBreak>d__85(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001817615E0-0x0000000181761680
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181761680-0x00000001817616D0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass100_0 // TypeDefIndex: 14579
		{
			// Fields
			public Node b; // 0x10
			public Node a; // 0x18
	
			// Constructors
			public <>c__DisplayClass100_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <AreNodesConnected>b__0(Connection c); // 0x0000000180E3E940-0x0000000180E3E970
			internal bool <AreNodesConnected>b__1(Connection c); // 0x0000000180E3EA40-0x0000000180E3EA70
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 14580
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<Connection, Node> <>9__103_0; // 0x08
			public static Func<Connection, Node> <>9__104_0; // 0x10
	
			// Constructors
			static <>c(); // 0x0000000181761340-0x00000001817613A0
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal Node <GetParentNodes>b__103_0(Connection c); // 0x000000018059C9F0-0x000000018059CA10
			internal Node <GetChildNodes>b__104_0(Connection c); // 0x0000000180897C80-0x0000000180897CA0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass105_0 // TypeDefIndex: 14581
		{
			// Fields
			public Node parentNode; // 0x10
	
			// Constructors
			public <>c__DisplayClass105_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <IsChildOf>b__0(Connection c); // 0x0000000181281C10-0x0000000181281C40
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass106_0 // TypeDefIndex: 14582
		{
			// Fields
			public Node childNode; // 0x10
	
			// Constructors
			public <>c__DisplayClass106_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <IsParentOf>b__0(Connection c); // 0x0000000180E3E940-0x0000000180E3E970
		}
	
		// Constructors
		public Node(); // 0x000000018175CC80-0x000000018175CD10
	
		// Methods
		public static Node Create(Graph targetGraph, Type nodeType, Vector2 pos); // 0x000000018175B240-0x000000018175B4A0
		public Node Duplicate(Graph targetGraph); // 0x000000018175B4A0-0x000000018175B810
		public virtual void OnCreate(Graph assignedGraph); // 0x00000001803581E0-0x00000001803581F0
		public virtual void OnValidate(Graph assignedGraph); // 0x00000001803581E0-0x00000001803581F0
		public virtual void OnDestroy(); // 0x00000001803581E0-0x00000001803581F0
		public Status Execute(Component agent, IBlackboard blackboard); // 0x000000018175B960-0x000000018175B990
		public void Reset(bool recursively = true /* Metadata: 0x00784618 */); // 0x000000018175C4E0-0x000000018175C600
		[IteratorStateMachine] // 0x000000018015DA80-0x000000018015DAD0
		private IEnumerator YieldBreak(Action resume); // 0x000000018175CC20-0x000000018175CC80
		public Status Error(object msg); // 0x000000018175B810-0x000000018175B960
		public Status Fail(string msg); // 0x000000018175B990-0x000000018175BA10
		public void Warn(string msg); // 0x000000018175CBB0-0x000000018175CC20
		public void SetStatus(Status status); // 0x00000001804A3750-0x00000001804A3760
		protected void SendEvent(EventData eventData); // 0x000000018175C600-0x000000018175C630
		public void RegisterEvents(params /* 0x00000001800B36B0-0x00000001800B36C0 */ string[] eventNames); // 0x000000018175C370-0x000000018175C4E0
		public void RegisterEvents(Component targetAgent, params /* 0x00000001800B36B0-0x00000001800B36C0 */ string[] eventNames); // 0x000000018175C200-0x000000018175C370
		public void UnRegisterEvents(params /* 0x00000001800B36B0-0x00000001800B36C0 */ string[] eventNames); // 0x000000018175C910-0x000000018175CA00
		public void UnRegisterEvents(Component targetAgent, params /* 0x00000001800B36B0-0x00000001800B36C0 */ string[] eventNames); // 0x000000018175C830-0x000000018175C910
		public void UnregisterAllEvents(); // 0x000000018175CAD0-0x000000018175CBB0
		public void UnregisterAllEvents(Component targetAgent); // 0x000000018175CA00-0x000000018175CAD0
		public static bool IsNewConnectionAllowed(Node sourceNode, Node targetNode, Connection refConnection = null); // 0x000000018175BD20-0x000000018175BF70
		protected virtual bool CanConnectToTarget(Node targetNode); // 0x00000001803C29F0-0x00000001803C2A00
		protected virtual bool CanConnectFromSource(Node sourceNode); // 0x00000001803C29F0-0x00000001803C2A00
		public static bool AreNodesConnected(Node a, Node b); // 0x000000018175B100-0x000000018175B240
		protected Coroutine StartCoroutine(IEnumerator routine); // 0x000000018175C630-0x000000018175C660
		protected void StopCoroutine(Coroutine routine); // 0x000000018175C660-0x000000018175C690
		public Node[] GetParentNodes(); // 0x000000018175BB40-0x000000018175BC70
		public Node[] GetChildNodes(); // 0x000000018175BA10-0x000000018175BB40
		public bool IsChildOf(Node parentNode); // 0x000000018175BC70-0x000000018175BD20
		public bool IsParentOf(Node childNode); // 0x000000018175BF70-0x000000018175C020
		protected virtual Status OnExecute(Component agent, IBlackboard blackboard); // 0x00000001804A3740-0x00000001804A3750
		protected virtual void OnReset(); // 0x00000001803581E0-0x00000001803581F0
		public virtual void OnParentConnected(int connectionIndex); // 0x00000001803581E0-0x00000001803581F0
		public virtual void OnParentDisconnected(int connectionIndex); // 0x00000001803581E0-0x00000001803581F0
		public virtual void OnChildConnected(int connectionIndex); // 0x00000001803581E0-0x00000001803581F0
		public virtual void OnChildDisconnected(int connectionIndex); // 0x00000001803581E0-0x00000001803581F0
		public virtual void OnGraphStarted(); // 0x00000001803581E0-0x00000001803581F0
		public virtual void OnGraphStoped(); // 0x00000001803581E0-0x00000001803581F0
		public virtual void OnGraphPaused(); // 0x00000001803581E0-0x00000001803581F0
		public virtual void OnGraphUnpaused(); // 0x00000001803581E0-0x00000001803581F0
		public override string ToString(); // 0x000000018175C690-0x000000018175C830
		public virtual void OnDrawGizmos(); // 0x000000018175C110-0x000000018175C200
		public virtual void OnDrawGizmosSelected(); // 0x000000018175C020-0x000000018175C110
	}
}
