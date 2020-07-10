/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ParadoxNotion.Design;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Framework
{
	[SpoofAOT] // 0x00000001800B36B0-0x00000001800B36C0
	public abstract class Connection : IGraphElement // TypeDefIndex: 14558
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Node _sourceNode; // 0x10
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Node _targetNode; // 0x18
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool _isDisabled; // 0x20
		[NonSerialized]
		private Status _status; // 0x24
	
		// Properties
		public Node sourceNode { get; protected set; } // 0x000000018036AC80-0x000000018036AC90 0x000000018036B1E0-0x000000018036B1F0
		public Node targetNode { get; protected set; } // 0x000000018038B150-0x000000018038B160 0x000000018038B160-0x000000018038B170
		public bool isActive { get; set; } // 0x000000018174C620-0x000000018174C630 0x000000018174C630-0x000000018174C690
		public Status status { get; set; } // 0x00000001803C26F0-0x00000001803C2700 0x00000001804D0B90-0x00000001804D0BA0
		public Graph graph { get; } // 0x000000018174C610-0x000000018174C620 
	
		// Constructors
		public Connection(); // 0x000000018174C600-0x000000018174C610
	
		// Methods
		public static Connection Create(Node source, Node target, int sourceIndex = -1 /* Metadata: 0x007845E6 */, int targetIndex = -1 /* Metadata: 0x007845EA */); // 0x000000018174BC30-0x000000018174BEB0
		public Connection Duplicate(Node newSource, Node newTarget); // 0x000000018174BEB0-0x000000018174C0D0
		public virtual void OnCreate(int sourceIndex, int targetIndex); // 0x00000001803581E0-0x00000001803581F0
		public virtual void OnValidate(int sourceIndex, int targetIndex); // 0x00000001803581E0-0x00000001803581F0
		public virtual void OnDestroy(); // 0x00000001803581E0-0x00000001803581F0
		public int SetSourceNode(Node newSource, int index = -1 /* Metadata: 0x007845EE */); // 0x000000018174C170-0x000000018174C380
		public int SetTargetNode(Node newTarget, int index = -1 /* Metadata: 0x007845F2 */); // 0x000000018174C380-0x000000018174C590
		public sealed override string ToString(); // 0x000000018174C590-0x000000018174C600
		public Status Execute(Component agent, IBlackboard blackboard); // 0x000000018174C0D0-0x000000018174C130
		public void Reset(bool recursively = true /* Metadata: 0x007845F6 */); // 0x000000018174C130-0x000000018174C170
	}
}
