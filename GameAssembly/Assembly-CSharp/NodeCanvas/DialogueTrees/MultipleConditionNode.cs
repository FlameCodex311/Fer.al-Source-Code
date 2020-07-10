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
	[Category] // 0x00000001800BCD90-0x00000001800BCE80
	[Color] // 0x00000001800BCD90-0x00000001800BCE80
	[Description] // 0x00000001800BCD90-0x00000001800BCE80
	[Icon] // 0x00000001800BCD90-0x00000001800BCE80
	[Name] // 0x00000001800BCD90-0x00000001800BCE80
	public class MultipleConditionNode : DTNode, ISubTasksContainer // TypeDefIndex: 14100
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private List<ConditionTask> conditions; // 0x88
	
		// Properties
		public override int maxOutConnections { get; } // 0x00000001805F5E50-0x00000001805F5E60 
	
		// Constructors
		public MultipleConditionNode(); // 0x0000000181569D50-0x0000000181569DE0
	
		// Methods
		public Task[] GetSubTasks(); // 0x0000000181569A30-0x0000000181569A80
		public override void OnChildConnected(int index); // 0x0000000181569A80-0x0000000181569AE0
		public override void OnChildDisconnected(int index); // 0x0000000181569AE0-0x0000000181569B40
		protected override Status OnExecute(Component agent, IBlackboard bb); // 0x0000000181569B40-0x0000000181569D50
	}
}
