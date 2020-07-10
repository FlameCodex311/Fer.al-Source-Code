/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.DialogueTrees
{
	[Category] // 0x00000001800BB2A0-0x00000001800BB390
	[Color] // 0x00000001800BB2A0-0x00000001800BB390
	[Description] // 0x00000001800BB2A0-0x00000001800BB390
	[Icon] // 0x00000001800BB2A0-0x00000001800BB390
	[Name] // 0x00000001800BB2A0-0x00000001800BB390
	public class MultipleChoiceNode : DTNode, ISubTasksContainer // TypeDefIndex: 14096
	{
		// Fields
		public Statement statement; // 0x88
		[SliderField] // 0x00000001800BB650-0x00000001800BB670
		public float availableTime; // 0x90
		public bool saySelection; // 0x94
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private List<Choice> availableChoices; // 0x98
		public bool allowNextButton; // 0xA0
	
		// Properties
		public override int maxOutConnections { get; } // 0x0000000181569900-0x0000000181569950 
		public override bool requireActorSelection { get; } // 0x00000001803C29F0-0x00000001803C2A00 
	
		// Nested types
		[Serializable]
		public class Choice // TypeDefIndex: 14097
		{
			// Fields
			public bool isUnfolded; // 0x10
			public Statement statement; // 0x18
			public ConditionTask condition; // 0x20
	
			// Constructors
			public Choice(); // 0x000000018075C3F0-0x000000018075C400
			public Choice(Statement statement); // 0x0000000181561F40-0x0000000181561F70
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 14098
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<Choice, ConditionTask> <>9__5_0; // 0x08
	
			// Constructors
			static <>c(); // 0x0000000181576450-0x00000001815764B0
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal ConditionTask <GetSubTasks>b__5_0(Choice c); // 0x000000018072AED0-0x000000018072AEF0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass12_0 // TypeDefIndex: 14099
		{
			// Fields
			public MultipleChoiceNode <>4__this; // 0x10
			public int index; // 0x18
	
			// Constructors
			public <>c__DisplayClass12_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal void <OnOptionSelected>b__0(); // 0x0000000181575F50-0x0000000181575F90
		}
	
		// Constructors
		public MultipleChoiceNode(); // 0x0000000181569840-0x0000000181569900
	
		// Methods
		public Task[] GetSubTasks(); // 0x0000000181569020-0x0000000181569140
		protected override Status OnExecute(Component agent, IBlackboard bb); // 0x0000000181569140-0x0000000181569650
		private void OnOptionSelected(int index); // 0x0000000181569650-0x0000000181569840
	}
}
