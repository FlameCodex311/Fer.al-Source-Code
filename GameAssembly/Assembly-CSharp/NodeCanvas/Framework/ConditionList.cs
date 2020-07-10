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
	public class ConditionList : ConditionTask, ISubTasksContainer // TypeDefIndex: 14590
	{
		// Fields
		public ConditionsCheckMode checkMode; // 0x68
		public List<ConditionTask> conditions; // 0x70
		private List<ConditionTask> initialActiveConditions; // 0x78
	
		// Properties
		private bool allTrueRequired { get; } // 0x0000000181562AD0-0x0000000181562AE0 
		protected override string info { get; } // 0x0000000181562AE0-0x0000000181562D50 
	
		// Nested types
		public enum ConditionsCheckMode // TypeDefIndex: 14591
		{
			AllTrueRequired = 0,
			AnyTrueSuffice = 1
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 14592
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<ConditionTask, bool> <>9__10_0; // 0x08
	
			// Constructors
			static <>c(); // 0x0000000181761400-0x0000000181761460
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <OnInit>b__10_0(ConditionTask c); // 0x0000000181760D60-0x0000000181760D80
		}
	
		// Constructors
		public ConditionList(); // 0x0000000181562A70-0x0000000181562AD0
	
		// Methods
		Task[] ISubTasksContainer.GetSubTasks(); // 0x0000000181562410-0x0000000181562460
		public override Task Duplicate(ITaskSystem newOwnerSystem); // 0x00000001815621A0-0x0000000181562410
		protected override string OnInit(); // 0x0000000181562950-0x0000000181562A70
		protected override void OnEnable(); // 0x0000000181562880-0x0000000181562950
		protected override void OnDisable(); // 0x00000001815625B0-0x0000000181562660
		protected override bool OnCheck(); // 0x0000000181562460-0x00000001815625B0
		public override void OnDrawGizmos(); // 0x0000000181562770-0x0000000181562880
		public override void OnDrawGizmosSelected(); // 0x0000000181562660-0x0000000181562770
		public void AddCondition(ConditionTask condition); // 0x0000000181561F70-0x00000001815621A0
	}
}
