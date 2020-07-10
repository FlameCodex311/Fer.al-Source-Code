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
	[Category] // 0x000000018016F5E0-0x000000018016F680
	[Description] // 0x000000018016F5E0-0x000000018016F680
	[Icon] // 0x000000018016F5E0-0x000000018016F680
	public class WaitUntil : BTDecorator, ITaskAssignable<ConditionTask> // TypeDefIndex: 14064
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private ConditionTask _condition; // 0x78
		private bool accessed; // 0x80
	
		// Properties
		public Task task { get; set; } // 0x0000000180369C70-0x0000000180369C80 0x0000000181576AC0-0x000000018157AE30
		private ConditionTask condition { get; set; } // 0x0000000180369C70-0x0000000180369C80 0x00000001803D8EF0-0x00000001803D8F00
	
		// Constructors
		public WaitUntil(); // 0x000000018155E370-0x000000018155E380
	
		// Methods
		protected override Status OnExecute(Component agent, IBlackboard blackboard); // 0x0000000181576960-0x0000000181576AC0
		protected override void OnReset(); // 0x0000000180DFA880-0x0000000180DFA890
	}
}
