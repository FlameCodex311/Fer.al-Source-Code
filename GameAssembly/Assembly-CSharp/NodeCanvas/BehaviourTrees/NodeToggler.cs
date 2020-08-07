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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.BehaviourTrees
{
	[Category] // 0x0000000180221B90-0x0000000180221C20
	[Description] // 0x0000000180221B90-0x0000000180221C20
	[Name] // 0x0000000180221B90-0x0000000180221C20
	[Obsolete] // 0x0000000180221B90-0x0000000180221C20
	public class NodeToggler : BTNode // TypeDefIndex: 15193
	{
		// Fields
		public ToggleMode toggleMode; // 0x88
		public string targetNodeTag; // 0x90
		private List<Node> targetNodes; // 0x98
	
		// Nested types
		public enum ToggleMode // TypeDefIndex: 15194
		{
			Enable = 0,
			Disable = 1,
			Toggle = 2
		}
	
		// Constructors
		public NodeToggler(); // 0x00000001808B1FE0-0x00000001808B2000
	
		// Methods
		public override void OnGraphStarted(); // 0x00000001808B1F70-0x00000001808B1FE0
		protected override Status OnExecute(Component agent, IBlackboard blackboard); // 0x00000001808B1AB0-0x00000001808B1F70
	}
}
