/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.DialogueTrees
{
	[Obsolete] // 0x0000000180208300-0x0000000180208330
	public class GoToNode : DTNode // TypeDefIndex: 15130
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private DTNode _targetNode; // 0x98
	
		// Properties
		public override int maxOutConnections { get; } // 0x000000018037DDC0-0x000000018037DDD0 
		public override bool requireActorSelection { get; } // 0x0000000180380950-0x0000000180380960 
	
		// Constructors
		public GoToNode(); // 0x000000018089EA60-0x000000018089EAB0
	
		// Methods
		protected override Status OnExecute(Component agent, IBlackboard bb); // 0x00000001808A88A0-0x00000001808A8980
	}
}
