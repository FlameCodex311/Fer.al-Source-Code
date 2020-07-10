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
	[Category] // 0x0000000180164EF0-0x0000000180164FE0
	[Color] // 0x0000000180164EF0-0x0000000180164FE0
	[Description] // 0x0000000180164EF0-0x0000000180164FE0
	[Icon] // 0x0000000180164EF0-0x0000000180164FE0
	[Name] // 0x0000000180164EF0-0x0000000180164FE0
	public class StepIterator : BTComposite // TypeDefIndex: 14038
	{
		// Fields
		private int current; // 0x78
	
		// Constructors
		public StepIterator(); // 0x000000018155E370-0x000000018155E380
	
		// Methods
		public override void OnGraphStarted(); // 0x00000001815679A0-0x00000001815679B0
		protected override Status OnExecute(Component agent, IBlackboard blackboard); // 0x0000000181572CC0-0x0000000181572D80
		protected override void OnReset(); // 0x0000000181572D80-0x0000000181572D90
	}
}
