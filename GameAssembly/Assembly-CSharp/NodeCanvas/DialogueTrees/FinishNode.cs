/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.DialogueTrees
{
	[Category] // 0x00000001802032F0-0x00000001802033E0
	[Color] // 0x00000001802032F0-0x00000001802033E0
	[Description] // 0x00000001802032F0-0x00000001802033E0
	[Icon] // 0x00000001802032F0-0x00000001802033E0
	[Name] // 0x00000001802032F0-0x00000001802033E0
	public class FinishNode : DTNode // TypeDefIndex: 15119
	{
		// Fields
		public CompactStatus finishState; // 0x98
	
		// Properties
		public override int maxOutConnections { get; } // 0x000000018037DDC0-0x000000018037DDD0 
		public override bool requireActorSelection { get; } // 0x0000000180380950-0x0000000180380960 
	
		// Constructors
		public FinishNode(); // 0x00000001808A7EE0-0x00000001808A7F30
	
		// Methods
		protected override Status OnExecute(Component agent, IBlackboard bb); // 0x00000001808A7E80-0x00000001808A7EE0
	}
}
