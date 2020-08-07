/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.BehaviourTrees
{
	[Category] // 0x0000000180214BC0-0x0000000180214C80
	[Description] // 0x0000000180214BC0-0x0000000180214C80
	[Icon] // 0x0000000180214BC0-0x0000000180214C80
	[Name] // 0x0000000180214BC0-0x0000000180214C80
	public class ConditionalEvaluator : BTDecorator, ITaskAssignable<ConditionTask> // TypeDefIndex: 15160
	{
		// Fields
		[Name] // 0x00000001802150A0-0x00000001802150D0
		public bool isDynamic; // 0x88
		[Tooltip] // 0x0000000180215200-0x0000000180215230
		public CompactStatus conditionFailReturn; // 0x8C
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ConditionTask _condition; // 0x90
		private bool accessed; // 0x98
	
		// Properties
		public Task task { get; set; } // 0x00000001803D6D80-0x00000001803D6D90 0x00000001807C5C10-0x00000001807C5CA0
		private ConditionTask condition { get; set; } // 0x00000001803D6D80-0x00000001803D6D90 0x000000018072D660-0x000000018072D670
	
		// Constructors
		public ConditionalEvaluator(); // 0x00000001807C41B0-0x00000001807C41C0
	
		// Methods
		protected override Status OnExecute(Component agent, IBlackboard blackboard); // 0x00000001807C5A30-0x00000001807C5BE0
		protected override void OnReset(); // 0x00000001807C5BE0-0x00000001807C5C10
	}
}
