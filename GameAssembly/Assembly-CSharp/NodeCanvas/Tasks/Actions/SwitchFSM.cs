/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using NodeCanvas.StateMachines;
using ParadoxNotion.Design;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x000000018010CAB0-0x000000018010CB10
	[Description] // 0x000000018010CAB0-0x000000018010CB10
	public class SwitchFSM : ActionTask<FSMOwner> // TypeDefIndex: 14345
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<FSM> fsm; // 0x68
	
		// Properties
		protected override string info { get; } // 0x00000001812654C0-0x0000000181265500 
	
		// Constructors
		public SwitchFSM(); // 0x0000000181265480-0x00000001812654C0
	
		// Methods
		protected override void OnExecute(); // 0x00000001812653F0-0x0000000181265480
	}
}
