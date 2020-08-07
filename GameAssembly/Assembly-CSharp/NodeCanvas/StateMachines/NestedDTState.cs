/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.DialogueTrees;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.StateMachines
{
	[Description] // 0x00000001801F4D20-0x00000001801F4DC0
	[DropReferenceType] // 0x00000001801F4D20-0x00000001801F4DC0
	[Name] // 0x00000001801F4D20-0x00000001801F4DC0
	public class NestedDTState : FSMStateNested<DialogueTree> // TypeDefIndex: 15091
	{
		// Fields
		[ExposeField] // 0x00000001801F43C0-0x00000001801F4410
		[Name] // 0x00000001801F43C0-0x00000001801F4410
		[SerializeField] // 0x00000001801F43C0-0x00000001801F4410
		private BBParameter<DialogueTree> _nestedDLG; // 0xA8
		[DimIfDefault] // 0x00000001801CDAD0-0x00000001801CDAE0
		public string successEvent; // 0xB0
		[DimIfDefault] // 0x00000001801CDAD0-0x00000001801CDAE0
		public string failureEvent; // 0xB8
	
		// Properties
		public override DialogueTree subGraph { get; set; } // 0x0000000180CCBF70-0x0000000180CCBFC0 0x0000000180CCBFC0-0x0000000180CCC020
		public override BBParameter subGraphParameter { get; } // 0x0000000180431310-0x0000000180431320 
	
		// Constructors
		public NestedDTState(); // 0x0000000180CCBF30-0x0000000180CCBF70
	
		// Methods
		protected override void OnEnter(); // 0x0000000180CCBD70-0x0000000180CCBE50
		protected override void OnUpdate(); // 0x0000000180CCBEE0-0x0000000180CCBF30
		protected override void OnExit(); // 0x0000000180CCBE50-0x0000000180CCBEE0
		private void OnDialogueFinished(bool success); // 0x0000000180CCBC90-0x0000000180CCBD70
	}
}
