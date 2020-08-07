/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using NodeCanvas.StateMachines;
using ParadoxNotion.Design;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.BehaviourTrees
{
	[Description] // 0x000000018021EEF0-0x000000018021EFE0
	[DropReferenceType] // 0x000000018021EEF0-0x000000018021EFE0
	[Icon] // 0x000000018021EEF0-0x000000018021EFE0
	[Name] // 0x000000018021EEF0-0x000000018021EFE0
	public class NestedFSM : BTNodeNested<FSM> // TypeDefIndex: 15187
	{
		// Fields
		[ExposeField] // 0x00000001801F7310-0x00000001801F7360
		[Name] // 0x00000001801F7310-0x00000001801F7360
		[SerializeField] // 0x00000001801F7310-0x00000001801F7360
		private BBParameter<FSM> _nestedFSM; // 0xA0
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public string successState; // 0xA8
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public string failureState; // 0xB0
	
		// Properties
		public override FSM subGraph { get; set; } // 0x00000001808B1A00-0x00000001808B1A50 0x00000001808B1A50-0x00000001808B1AB0
		public override BBParameter subGraphParameter { get; } // 0x00000001803D6D90-0x00000001803D6DA0 
	
		// Constructors
		public NestedFSM(); // 0x00000001808B19C0-0x00000001808B1A00
	
		// Methods
		protected override Status OnExecute(Component agent, IBlackboard blackboard); // 0x00000001808B16F0-0x00000001808B1930
		private void OnFSMFinish(bool success); // 0x00000001808B1410-0x00000001808B1430
		protected override void OnReset(); // 0x00000001808B1930-0x00000001808B19C0
	}
}
