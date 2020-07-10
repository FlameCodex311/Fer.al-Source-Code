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
	[Category] // 0x00000001801638B0-0x0000000180163980
	[Color] // 0x00000001801638B0-0x0000000180163980
	[Description] // 0x00000001801638B0-0x0000000180163980
	[Icon] // 0x00000001801638B0-0x0000000180163980
	public class PrioritySelector : BTComposite // TypeDefIndex: 14034
	{
		// Fields
		public List<BBParameter<float>> priorities; // 0x78
		private List<Connection> orderedConnections; // 0x80
		private int current; // 0x88
	
		// Constructors
		public PrioritySelector(); // 0x0000000181570C70-0x0000000181570D00
	
		// Methods
		public override void OnChildConnected(int index); // 0x00000001815708E0-0x00000001815709F0
		public override void OnChildDisconnected(int index); // 0x00000001815709F0-0x0000000181570A50
		protected override Status OnExecute(Component agent, IBlackboard blackboard); // 0x0000000181570A50-0x0000000181570BC0
		protected override void OnReset(); // 0x0000000181570BC0-0x0000000181570BD0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private float <OnExecute>b__5_0(Connection c); // 0x0000000181570BD0-0x0000000181570C70
	}
}
