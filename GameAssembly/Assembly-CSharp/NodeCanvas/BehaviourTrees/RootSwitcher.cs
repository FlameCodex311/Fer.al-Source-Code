/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.BehaviourTrees
{
	[Category] // 0x0000000180221FA0-0x0000000180222030
	[Description] // 0x0000000180221FA0-0x0000000180222030
	[Name] // 0x0000000180221FA0-0x0000000180222030
	[Obsolete] // 0x0000000180221FA0-0x0000000180222030
	public class RootSwitcher : BTNode // TypeDefIndex: 15195
	{
		// Fields
		public string targetNodeTag; // 0x88
		private Node targetNode; // 0x90
	
		// Constructors
		public RootSwitcher(); // 0x00000001808A8120-0x00000001808A8130
	
		// Methods
		public override void OnGraphStarted(); // 0x00000001808B4090-0x00000001808B40F0
		protected override Status OnExecute(Component agent, IBlackboard blackboard); // 0x00000001808B4010-0x00000001808B4090
	}
}
