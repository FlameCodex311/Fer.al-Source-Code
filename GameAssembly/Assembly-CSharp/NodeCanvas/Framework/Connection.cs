/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ParadoxNotion.Design;
using ParadoxNotion.Serialization.FullSerializer;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Framework
{
	[Serializable]
	[fsDeserializeOverwrite] // 0x00000001801CDDD0-0x00000001801CDE00
	[SpoofAOT] // 0x00000001801CDDD0-0x00000001801CDE00
	public abstract class Connection : IGraphElement, ISerializationCollectable // TypeDefIndex: 15671
	{
		// Fields
		[fsSerializeAsReference] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		private Node _sourceNode; // 0x10
		[fsSerializeAsReference] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		private Node _targetNode; // 0x18
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string _UID; // 0x20
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool _isDisabled; // 0x28
		[NonSerialized]
		private Status _status; // 0x2C
	
		// Properties
		public string UID { get; } // 0x00000001808A3490-0x00000001808A3520 
		public Node sourceNode { get; protected set; } // 0x0000000180372440-0x0000000180372450 0x0000000180379F20-0x0000000180379F30
		public Node targetNode { get; protected set; } // 0x0000000180372430-0x0000000180372440 0x0000000180379F30-0x0000000180379F40
		string IGraphElement.name { get; } // 0x00000001808A2FC0-0x00000001808A2FF0 
		public bool isActive { get; set; } // 0x00000001808A3530-0x00000001808A3540 0x00000001808A3540-0x00000001808A35A0
		public Status status { get; set; } // 0x000000018043C670-0x000000018043C680 0x000000018041A370-0x000000018041A380
		public Graph graph { get; } // 0x00000001808A3520-0x00000001808A3530 
	
		// Constructors
		public Connection(); // 0x00000001808A3480-0x00000001808A3490
	
		// Methods
		public static Connection Create(Node source, Node target, int sourceIndex = -1 /* Metadata: 0x007BB444 */, int targetIndex = -1 /* Metadata: 0x007BB448 */); // 0x00000001808A2A30-0x00000001808A2B90
		public Connection Duplicate(Node newSource, Node newTarget); // 0x00000001808A2B90-0x00000001808A2F80
		public int SetSourceNode(Node newSource, int index = -1 /* Metadata: 0x007BB44C */); // 0x00000001808A3030-0x00000001808A3220
		public int SetTargetNode(Node newTarget, int index = -1 /* Metadata: 0x007BB450 */); // 0x00000001808A3220-0x00000001808A3410
		public Status Execute(Component agent, IBlackboard blackboard); // 0x00000001808A2F80-0x00000001808A2FC0
		public void Reset(bool recursively = true /* Metadata: 0x007BB454 */); // 0x00000001808A2FF0-0x00000001808A3030
		public virtual void OnCreate(int sourceIndex, int targetIndex); // 0x00000001803774A0-0x00000001803774B0
		public virtual void OnValidate(int sourceIndex, int targetIndex); // 0x00000001803774A0-0x00000001803774B0
		public virtual void OnDestroy(); // 0x00000001803774A0-0x00000001803774B0
		public override string ToString(); // 0x00000001808A3410-0x00000001808A3480
	}
}
