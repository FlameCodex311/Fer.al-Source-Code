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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.DialogueTrees
{
	[Category] // 0x00000001802056E0-0x00000001802057D0
	[Color] // 0x00000001802056E0-0x00000001802057D0
	[Description] // 0x00000001802056E0-0x00000001802057D0
	[Icon] // 0x00000001802056E0-0x00000001802057D0
	[Name] // 0x00000001802056E0-0x00000001802057D0
	public class MultipleChoiceNode : DTNode, ISubTasksContainer // TypeDefIndex: 15121
	{
		// Fields
		public Statement statement; // 0x98
		[SliderField] // 0x0000000180205BF0-0x0000000180205C10
		public float availableTime; // 0xA0
		public bool saySelection; // 0xA4
		[AutoSortWithChildrenConnections] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		private List<Choice> availableChoices; // 0xA8
		public bool allowNextButton; // 0xB0
	
		// Properties
		public override int maxOutConnections { get; } // 0x00000001808B0FB0-0x00000001808B0FF0 
		public override bool requireActorSelection { get; } // 0x0000000180380B60-0x0000000180380B70 
	
		// Nested types
		[Serializable]
		public class Choice // TypeDefIndex: 15122
		{
			// Fields
			public bool isUnfolded; // 0x10
			public Statement statement; // 0x18
			public ConditionTask condition; // 0x20
	
			// Constructors
			public Choice(); // 0x00000001808A18F0-0x00000001808A1900
			public Choice(Statement statement); // 0x00000001808A18C0-0x00000001808A18F0
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 15123
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<Choice, ConditionTask> <>9__5_0; // 0x08
	
			// Constructors
			static <>c(); // 0x00000001808B7B20-0x00000001808B7B80
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal ConditionTask <GetSubTasks>b__5_0(Choice c); // 0x00000001808B7500-0x00000001808B7520
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass12_0 // TypeDefIndex: 15124
		{
			// Fields
			public MultipleChoiceNode <>4__this; // 0x10
			public int index; // 0x18
	
			// Constructors
			public <>c__DisplayClass12_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal void <OnOptionSelected>b__0(); // 0x00000001808B76D0-0x00000001808B7710
		}
	
		// Constructors
		public MultipleChoiceNode(); // 0x00000001808B0EF0-0x00000001808B0FB0
	
		// Methods
		public Task[] GetSubTasks(); // 0x00000001808B0690-0x00000001808B07B0
		protected override Status OnExecute(Component agent, IBlackboard bb); // 0x00000001808B07B0-0x00000001808B0D30
		private void OnOptionSelected(int index); // 0x00000001808B0D30-0x00000001808B0EF0
	}
}
