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
	[Category] // 0x00000001801611A0-0x0000000180161230
	[Description] // 0x00000001801611A0-0x0000000180161230
	[DoNotList] // 0x00000001801611A0-0x0000000180161230
	[Name] // 0x00000001801611A0-0x0000000180161230
	public class NodeToggler : BTNode // TypeDefIndex: 14020
	{
		// Fields
		public ToggleMode toggleMode; // 0x78
		public string targetNodeTag; // 0x80
		private List<Node> targetNodes; // 0x88
	
		// Nested types
		public enum ToggleMode // TypeDefIndex: 14021
		{
			Enable = 0,
			Disable = 1,
			Toggle = 2
		}
	
		// Constructors
		public NodeToggler(); // 0x0000000181570000-0x0000000181570010
	
		// Methods
		public override void OnGraphStarted(); // 0x000000018156FFA0-0x0000000181570000
		protected override Status OnExecute(Component agent, IBlackboard blackboard); // 0x000000018156FB20-0x000000018156FFA0
	}
}
