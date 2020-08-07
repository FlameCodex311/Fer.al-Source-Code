/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.StateMachines
{
	public abstract class FSMNode : Node // TypeDefIndex: 15074
	{
		// Properties
		public override bool allowAsPrime { get; } // 0x0000000180380950-0x0000000180380960 
		public override bool canSelfConnect { get; } // 0x0000000180380950-0x0000000180380960 
		public override int maxInConnections { get; } // 0x00000001807C4280-0x00000001807C4290 
		public override int maxOutConnections { get; } // 0x00000001807C4280-0x00000001807C4290 
		public sealed override Type outConnectionType { get; } // 0x0000000180CC3350-0x0000000180CC33B0 
		public sealed override Alignment2x2 commentsAlignment { get; } // 0x00000001806C4390-0x00000001806C43A0 
		public sealed override Alignment2x2 iconAlignment { get; } // 0x000000018037DDC0-0x000000018037DDD0 
		public FSM FSM { get; } // 0x0000000180CC32C0-0x0000000180CC3350 
	
		// Constructors
		protected FSMNode(); // 0x00000001807C41B0-0x00000001807C41C0
	}
}
