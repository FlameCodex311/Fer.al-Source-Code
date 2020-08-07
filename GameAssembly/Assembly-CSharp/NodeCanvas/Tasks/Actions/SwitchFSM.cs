/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using NodeCanvas.StateMachines;
using ParadoxNotion.Design;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x0000000180278CE0-0x0000000180278D40
	[Description] // 0x0000000180278CE0-0x0000000180278D40
	public class SwitchFSM : ActionTask<FSMOwner> // TypeDefIndex: 15448
	{
		// Fields
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<FSM> fsm; // 0x68
	
		// Properties
		protected override string info { get; } // 0x00000001807A9B60-0x00000001807A9BA0 
	
		// Constructors
		public SwitchFSM(); // 0x00000001807A9B20-0x00000001807A9B60
	
		// Methods
		protected override void OnExecute(); // 0x00000001807A9A90-0x00000001807A9B20
	}
}
