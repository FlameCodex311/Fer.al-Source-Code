/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.StateMachines
{
	[Category] // 0x000000018015F460-0x000000018015F4E0
	[Description] // 0x000000018015F460-0x000000018015F4E0
	[Name] // 0x000000018015F460-0x000000018015F4E0
	public class NestedFSMState : FSMState, IGraphAssignable // TypeDefIndex: 14018
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected BBParameter<FSM> _nestedFSM; // 0x88
		private Dictionary<FSM, FSM> instances; // 0x90
		private FSM currentInstance; // 0x98
	
		// Properties
		public FSM nestedFSM { get; set; } // 0x000000018175AC30-0x000000018175AC80 0x000000018175B0A0-0x000000018175B100
		Graph IGraphAssignable.nestedGraph { get; set; } // 0x000000018175AC30-0x000000018175AC80 0x000000018175AC80-0x000000018175AD50
	
		// Constructors
		public NestedFSMState(); // 0x000000018175B030-0x000000018175B0A0
	
		// Methods
		Graph[] IGraphAssignable.GetInstances(); // 0x000000018175ABD0-0x000000018175AC30
		protected override void OnEnter(); // 0x000000018175AD50-0x000000018175AEB0
		protected override void OnUpdate(); // 0x000000018175AFF0-0x000000018175B030
		protected override void OnExit(); // 0x000000018175AEB0-0x000000018175AF60
		protected override void OnPause(); // 0x000000018175AF60-0x000000018175AFF0
		private FSM CheckInstance(); // 0x000000018175A960-0x000000018175ABD0
	}
}
