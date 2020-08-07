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

namespace NodeCanvas.StateMachines
{
	[Description] // 0x00000001801F5A70-0x00000001801F5B10
	[DropReferenceType] // 0x00000001801F5A70-0x00000001801F5B10
	[Name] // 0x00000001801F5A70-0x00000001801F5B10
	public class NestedFSMState : FSMStateNested<NodeCanvas.StateMachines.FSM> // TypeDefIndex: 15092
	{
		// Fields
		[ExposeField] // 0x00000001801F7310-0x00000001801F7360
		[Name] // 0x00000001801F7310-0x00000001801F7360
		[SerializeField] // 0x00000001801F7310-0x00000001801F7360
		protected BBParameter<FSM> _nestedFSM; // 0xA8
		public FSMExitMode exitMode; // 0xB0
	
		// Properties
		public override FSM subGraph { get; set; } // 0x0000000180CCC260-0x0000000180CCC2B0 0x0000000180CCC2B0-0x0000000180CCC310
		public override BBParameter subGraphParameter { get; } // 0x0000000180431310-0x0000000180431320 
	
		// Nested types
		public enum FSMExitMode // TypeDefIndex: 15093
		{
			StopAndRestart = 0,
			PauseAndResume = 1
		}
	
		// Constructors
		public NestedFSMState(); // 0x0000000180CCC220-0x0000000180CCC260
	
		// Methods
		protected override void OnEnter(); // 0x0000000180CCC020-0x0000000180CCC110
		protected override void OnUpdate(); // 0x0000000180CCC1D0-0x0000000180CCC220
		protected override void OnExit(); // 0x0000000180CCC110-0x0000000180CCC1D0
	}
}
