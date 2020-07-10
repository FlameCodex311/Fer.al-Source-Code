/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.BehaviourTrees
{
	[Category] // 0x0000000180161660-0x00000001801616F0
	[Description] // 0x0000000180161660-0x00000001801616F0
	[DoNotList] // 0x0000000180161660-0x00000001801616F0
	[Name] // 0x0000000180161660-0x00000001801616F0
	public class RootSwitcher : BTNode // TypeDefIndex: 14022
	{
		// Fields
		public string targetNodeTag; // 0x78
		private Node targetNode; // 0x80
	
		// Constructors
		public RootSwitcher(); // 0x000000018155E370-0x000000018155E380
	
		// Methods
		public override void OnGraphStarted(); // 0x0000000181571830-0x0000000181571880
		protected override Status OnExecute(Component agent, IBlackboard blackboard); // 0x00000001815717C0-0x0000000181571830
	}
}
