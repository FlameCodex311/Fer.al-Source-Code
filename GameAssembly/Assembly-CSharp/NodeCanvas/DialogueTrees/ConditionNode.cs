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

namespace NodeCanvas.DialogueTrees
{
	[Category] // 0x0000000180202A80-0x0000000180202B70
	[Color] // 0x0000000180202A80-0x0000000180202B70
	[Description] // 0x0000000180202A80-0x0000000180202B70
	[Icon] // 0x0000000180202A80-0x0000000180202B70
	[Name] // 0x0000000180202A80-0x0000000180202B70
	public class ConditionNode : DTNode, ITaskAssignable<ConditionTask> // TypeDefIndex: 15118
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ConditionTask _condition; // 0x98
	
		// Properties
		public ConditionTask condition { get; set; } // 0x0000000180418990-0x00000001804189A0 0x0000000180419170-0x0000000180419180
		public Task task { get; set; } // 0x0000000180418990-0x00000001804189A0 0x00000001808A2650-0x00000001808A26E0
		public override int maxOutConnections { get; } // 0x0000000180411150-0x0000000180411160 
		public override bool requireActorSelection { get; } // 0x0000000180380B60-0x0000000180380B70 
	
		// Constructors
		public ConditionNode(); // 0x000000018089EA60-0x000000018089EAB0
	
		// Methods
		protected override Status OnExecute(Component agent, IBlackboard bb); // 0x00000001808A2510-0x00000001808A2650
	}
}
