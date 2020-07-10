/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ParadoxNotion.Design;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Framework
{
	[DoNotList] // 0x00000001800B36B0-0x00000001800B36C0
	public class ActionList : ActionTask, ISubTasksContainer // TypeDefIndex: 14584
	{
		// Fields
		public ActionsExecutionMode executionMode; // 0x68
		public List<ActionTask> actions; // 0x70
		private List<ActionTask> initialActiveActions; // 0x78
		private int currentActionIndex; // 0x80
		private readonly List<int> finishedIndeces; // 0x88
	
		// Properties
		protected override string info { get; } // 0x000000018155DEA0-0x000000018155E0A0 
	
		// Nested types
		public enum ActionsExecutionMode // TypeDefIndex: 14585
		{
			ActionsRunInSequence = 0,
			ActionsRunInParallel = 1
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 14586
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<ActionTask, bool> <>9__10_0; // 0x08
	
			// Constructors
			static <>c(); // 0x0000000181576390-0x00000001815763F0
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <OnInit>b__10_0(ActionTask a); // 0x0000000181575F20-0x0000000181575F50
		}
	
		// Constructors
		public ActionList(); // 0x000000018155DE10-0x000000018155DEA0
	
		// Methods
		Task[] ISubTasksContainer.GetSubTasks(); // 0x000000018155D4A0-0x000000018155D4F0
		public override Task Duplicate(ITaskSystem newOwnerSystem); // 0x000000018155D230-0x000000018155D4A0
		protected override string OnInit(); // 0x000000018155D770-0x000000018155D890
		protected override void OnExecute(); // 0x000000018155D710-0x000000018155D770
		protected override void OnUpdate(); // 0x000000018155DAA0-0x000000018155DE10
		protected override void OnStop(); // 0x000000018155D990-0x000000018155DAA0
		protected override void OnPause(); // 0x000000018155D890-0x000000018155D990
		public override void OnDrawGizmos(); // 0x000000018155D600-0x000000018155D710
		public override void OnDrawGizmosSelected(); // 0x000000018155D4F0-0x000000018155D600
		public void AddAction(ActionTask action); // 0x000000018155D000-0x000000018155D230
	}
}
