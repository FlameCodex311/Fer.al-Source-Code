/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.BehaviourTrees;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.StateMachines
{
	[Description] // 0x00000001801F3D10-0x00000001801F3DB0
	[DropReferenceType] // 0x00000001801F3D10-0x00000001801F3DB0
	[Name] // 0x00000001801F3D10-0x00000001801F3DB0
	public class NestedBTState : FSMStateNested<BehaviourTree> // TypeDefIndex: 15088
	{
		// Fields
		[ExposeField] // 0x00000001801F43C0-0x00000001801F4410
		[Name] // 0x00000001801F43C0-0x00000001801F4410
		[SerializeField] // 0x00000001801F43C0-0x00000001801F4410
		private BBParameter<BehaviourTree> _nestedBT; // 0xA8
		public BTExitMode exitMode; // 0xB0
		public BTExecutionMode executionMode; // 0xB4
		[DimIfDefault] // 0x00000001801CDAD0-0x00000001801CDAE0
		public string successEvent; // 0xB8
		[DimIfDefault] // 0x00000001801CDAD0-0x00000001801CDAE0
		public string failureEvent; // 0xC0
	
		// Properties
		public override BehaviourTree subGraph { get; set; } // 0x0000000180CCBBE0-0x0000000180CCBC30 0x0000000180CCBC30-0x0000000180CCBC90
		public override BBParameter subGraphParameter { get; } // 0x0000000180431310-0x0000000180431320 
	
		// Nested types
		public enum BTExecutionMode // TypeDefIndex: 15089
		{
			Once = 0,
			Repeat = 1
		}
	
		public enum BTExitMode // TypeDefIndex: 15090
		{
			StopAndRestart = 0,
			PauseAndResume = 1
		}
	
		// Constructors
		public NestedBTState(); // 0x0000000180CCBB90-0x0000000180CCBBE0
	
		// Methods
		protected override void OnEnter(); // 0x0000000180CCB6A0-0x0000000180CCB8C0
		protected override void OnUpdate(); // 0x0000000180CCBA70-0x0000000180CCBB90
		private void OnFinish(bool success); // 0x0000000180CCB980-0x0000000180CCBA70
		protected override void OnExit(); // 0x0000000180CCB8C0-0x0000000180CCB980
	}
}
