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

namespace NodeCanvas.DialogueTrees
{
	[Category] // 0x00000001800BA200-0x00000001800BA2F0
	[Color] // 0x00000001800BA200-0x00000001800BA2F0
	[Description] // 0x00000001800BA200-0x00000001800BA2F0
	[Icon] // 0x00000001800BA200-0x00000001800BA2F0
	[Name] // 0x00000001800BA200-0x00000001800BA2F0
	public class ConditionNode : DTNode, ITaskAssignable<ConditionTask> // TypeDefIndex: 14093
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private ConditionTask _condition; // 0x88
	
		// Properties
		public ConditionTask condition { get; set; } // 0x0000000180424200-0x0000000180424210 0x000000018049D700-0x000000018049D710
		public Task task { get; set; } // 0x0000000180424200-0x0000000180424210 0x0000000181562F50-0x0000000181562FE0
		public override int maxOutConnections { get; } // 0x0000000180362180-0x0000000180362190 
		public override bool requireActorSelection { get; } // 0x00000001803C29F0-0x00000001803C2A00 
	
		// Constructors
		public ConditionNode(); // 0x000000018155E380-0x000000018155E3C0
	
		// Methods
		protected override Status OnExecute(Component agent, IBlackboard bb); // 0x0000000181562D80-0x0000000181562EC0
	}
}
