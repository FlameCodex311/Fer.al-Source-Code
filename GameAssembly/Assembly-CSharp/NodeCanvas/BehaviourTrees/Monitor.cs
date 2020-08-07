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
	[Category] // 0x000000018021AA60-0x000000018021AB10
	[Description] // 0x000000018021AA60-0x000000018021AB10
	[Icon] // 0x000000018021AA60-0x000000018021AB10
	public class Monitor : BTDecorator, ITaskAssignable<ActionTask> // TypeDefIndex: 15172
	{
		// Fields
		[Name] // 0x000000018021AF00-0x000000018021AF30
		public MonitorMode monitorMode; // 0x88
		[Name] // 0x000000018021B1B0-0x000000018021B1E0
		public ReturnStatusMode returnMode; // 0x8C
		private Status decoratorActionStatus; // 0x90
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ActionTask _action; // 0x98
	
		// Properties
		public ActionTask action { get; set; } // 0x0000000180418990-0x00000001804189A0 0x0000000180419170-0x0000000180419180
		public Task task { get; set; } // 0x0000000180418990-0x00000001804189A0 0x00000001808B0600-0x00000001808B0690
	
		// Nested types
		public enum MonitorMode // TypeDefIndex: 15173
		{
			Failure = 0,
			Success = 1,
			AnyStatus = 10
		}
	
		public enum ReturnStatusMode // TypeDefIndex: 15174
		{
			OriginalDecoratedChildStatus = 0,
			NewDecoratorActionStatus = 1
		}
	
		// Constructors
		public Monitor(); // 0x00000001808A8120-0x00000001808A8130
	
		// Methods
		protected override Status OnExecute(Component agent, IBlackboard blackboard); // 0x00000001808B0490-0x00000001808B05C0
		protected override void OnReset(); // 0x00000001808B05C0-0x00000001808B0600
	}
}
