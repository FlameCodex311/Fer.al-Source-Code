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
	[Category] // 0x0000000180165E50-0x0000000180165F10
	[Description] // 0x0000000180165E50-0x0000000180165F10
	[Icon] // 0x0000000180165E50-0x0000000180165F10
	[Name] // 0x0000000180165E50-0x0000000180165F10
	public class ConditionalEvaluator : BTDecorator, ITaskAssignable<ConditionTask> // TypeDefIndex: 14042
	{
		// Fields
		public bool isDynamic; // 0x78
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private ConditionTask _condition; // 0x80
		private bool accessed; // 0x88
	
		// Properties
		public Task task { get; set; } // 0x000000018035FCB0-0x000000018035FCC0 0x0000000181563170-0x0000000181563200
		private ConditionTask condition { get; set; } // 0x000000018035FCB0-0x000000018035FCC0 0x00000001803D8ED0-0x00000001803D8EE0
	
		// Constructors
		public ConditionalEvaluator(); // 0x000000018155E370-0x000000018155E380
	
		// Methods
		protected override Status OnExecute(Component agent, IBlackboard blackboard); // 0x0000000181562FE0-0x0000000181563160
		protected override void OnReset(); // 0x0000000181563160-0x0000000181563170
	}
}
