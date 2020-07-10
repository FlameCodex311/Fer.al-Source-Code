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
	[Category] // 0x000000018016C2D0-0x000000018016C380
	[Description] // 0x000000018016C2D0-0x000000018016C380
	[Icon] // 0x000000018016C2D0-0x000000018016C380
	public class Monitor : BTDecorator, ITaskAssignable<ActionTask> // TypeDefIndex: 14053
	{
		// Fields
		[Name] // 0x000000018016C6A0-0x000000018016C6D0
		public MonitorMode monitorMode; // 0x78
		[Name] // 0x000000018016C7F0-0x000000018016C820
		public ReturnStatusMode returnMode; // 0x7C
		private Status decoratorActionStatus; // 0x80
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private ActionTask _action; // 0x88
	
		// Properties
		public ActionTask action { get; set; } // 0x0000000180424200-0x0000000180424210 0x000000018049D700-0x000000018049D710
		public Task task { get; set; } // 0x0000000180424200-0x0000000180424210 0x0000000181568F90-0x0000000181569020
	
		// Nested types
		public enum MonitorMode // TypeDefIndex: 14054
		{
			Failure = 0,
			Success = 1,
			AnyStatus = 10
		}
	
		public enum ReturnStatusMode // TypeDefIndex: 14055
		{
			OriginalDecoratedChildStatus = 0,
			NewDecoratorActionStatus = 1
		}
	
		// Constructors
		public Monitor(); // 0x000000018155E370-0x000000018155E380
	
		// Methods
		protected override Status OnExecute(Component agent, IBlackboard blackboard); // 0x0000000181568E00-0x0000000181568F50
		protected override void OnReset(); // 0x0000000181568F50-0x0000000181568F90
	}
}
