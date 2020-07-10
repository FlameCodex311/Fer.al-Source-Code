/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.BehaviourTrees
{
	[Category] // 0x00000001801711E0-0x00000001801712A0
	[Description] // 0x00000001801711E0-0x00000001801712A0
	[Icon] // 0x00000001801711E0-0x00000001801712A0
	[Name] // 0x00000001801711E0-0x00000001801712A0
	public class SubTree : BTNode, IGraphAssignable // TypeDefIndex: 14068
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private BBParameter<BehaviourTree> _subTree; // 0x78
		private Dictionary<BehaviourTree, BehaviourTree> instances; // 0x80
		private BehaviourTree currentInstance; // 0x88
	
		// Properties
		public override string name { get; } // 0x000000018155E3C0-0x000000018155E3F0 
		public BehaviourTree subTree { get; set; } // 0x0000000181573FC0-0x0000000181574010 0x00000001815744D0-0x0000000181574530
		Graph IGraphAssignable.nestedGraph { get; set; } // 0x0000000181573FC0-0x0000000181574010 0x0000000181574010-0x00000001815740E0
	
		// Constructors
		public SubTree(); // 0x0000000181574460-0x00000001815744D0
	
		// Methods
		Graph[] IGraphAssignable.GetInstances(); // 0x0000000181573F60-0x0000000181573FC0
		protected override Status OnExecute(Component agent, IBlackboard blackboard); // 0x00000001815740E0-0x00000001815742B0
		protected override void OnReset(); // 0x00000001815743D0-0x0000000181574460
		public override void OnGraphPaused(); // 0x00000001815742B0-0x0000000181574340
		public override void OnGraphStoped(); // 0x0000000181574340-0x00000001815743D0
		private BehaviourTree CheckInstance(); // 0x0000000181573D00-0x0000000181573F60
	}
}
