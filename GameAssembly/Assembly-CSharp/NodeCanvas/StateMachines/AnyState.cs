/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.StateMachines
{
	[Color] // 0x00000001801F02A0-0x00000001801F0320
	[Description] // 0x00000001801F02A0-0x00000001801F0320
	[Name] // 0x00000001801F02A0-0x00000001801F0320
	public class AnyState : FSMNode, IUpdatable // TypeDefIndex: 15083
	{
		// Fields
		public bool dontRetriggerStates; // 0x88
	
		// Properties
		public override string name { get; } // 0x0000000180CBEE50-0x0000000180CBEE80 
		public override int maxInConnections { get; } // 0x000000018037DDC0-0x000000018037DDD0 
		public override int maxOutConnections { get; } // 0x00000001807C4280-0x00000001807C4290 
		public override bool allowAsPrime { get; } // 0x0000000180380950-0x0000000180380960 
	
		// Constructors
		public AnyState(); // 0x00000001807C41B0-0x00000001807C41C0
	
		// Methods
		public override void OnGraphStarted(); // 0x0000000180CBEAD0-0x0000000180CBED00
		public override void OnGraphStoped(); // 0x0000000180CBED00-0x0000000180CBEE50
		void IUpdatable.Update(); // 0x0000000180CBE860-0x0000000180CBEAD0
	}
}
