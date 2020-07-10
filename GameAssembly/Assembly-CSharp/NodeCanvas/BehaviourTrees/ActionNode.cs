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
	[Description] // 0x000000018016FE10-0x000000018016FEB0
	[Icon] // 0x000000018016FE10-0x000000018016FEB0
	[Name] // 0x000000018016FE10-0x000000018016FEB0
	public class ActionNode : BTNode, ITaskAssignable<ActionTask> // TypeDefIndex: 14065
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private ActionTask _action; // 0x78
	
		// Properties
		public Task task { get; set; } // 0x0000000180369C70-0x0000000180369C80 0x000000018155E480-0x000000018155E510
		public ActionTask action { get; set; } // 0x0000000180369C70-0x0000000180369C80 0x00000001803D8EF0-0x00000001803D8F00
		public override string name { get; } // 0x000000018155E3C0-0x000000018155E3F0 
	
		// Constructors
		public ActionNode(); // 0x000000018155E370-0x000000018155E380
	
		// Methods
		protected override Status OnExecute(Component agent, IBlackboard blackboard); // 0x000000018155E100-0x000000018155E130
		protected override void OnReset(); // 0x000000018155E2C0-0x000000018155E2E0
		public override void OnGraphPaused(); // 0x000000018155E270-0x000000018155E2C0
	}
}
