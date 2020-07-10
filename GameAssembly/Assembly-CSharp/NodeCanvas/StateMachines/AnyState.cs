/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.StateMachines
{
	[Color] // 0x000000018015E2B0-0x000000018015E330
	[Description] // 0x000000018015E2B0-0x000000018015E330
	[Name] // 0x000000018015E2B0-0x000000018015E330
	public class AnyState : FSMState, IUpdatable // TypeDefIndex: 14013
	{
		// Fields
		public bool dontRetriggerStates; // 0x88
	
		// Properties
		public override string name { get; } // 0x0000000181749430-0x0000000181749460 
		public override int maxInConnections { get; } // 0x000000018035FCC0-0x000000018035FCD0 
		public override int maxOutConnections { get; } // 0x00000001805F5E50-0x00000001805F5E60 
		public override bool allowAsPrime { get; } // 0x00000001803C28F0-0x00000001803C2900 
	
		// Constructors
		public AnyState(); // 0x000000018155E370-0x000000018155E380
	
		// Methods
		public new void Update(); // 0x00000001817491D0-0x0000000181749430
	}
}
