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
	[Category] // 0x000000018016A7C0-0x000000018016A880
	[Description] // 0x000000018016A7C0-0x000000018016A880
	[Icon] // 0x000000018016A7C0-0x000000018016A880
	[Name] // 0x000000018016A7C0-0x000000018016A880
	public class Interruptor : BTDecorator, ITaskAssignable<ConditionTask> // TypeDefIndex: 14049
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private ConditionTask _condition; // 0x78
	
		// Properties
		public ConditionTask condition { get; set; } // 0x0000000180369C70-0x0000000180369C80 0x00000001803D8EF0-0x00000001803D8F00
		public Task task { get; set; } // 0x0000000180369C70-0x0000000180369C80 0x0000000181568570-0x0000000181568600
	
		// Constructors
		public Interruptor(); // 0x000000018155E370-0x000000018155E380
	
		// Methods
		protected override Status OnExecute(Component agent, IBlackboard blackboard); // 0x0000000181568440-0x0000000181568570
	}
}
