/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.BehaviourTrees;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.StateMachines
{
	[Category] // 0x000000018015EE20-0x000000018015EEA0
	[Description] // 0x000000018015EE20-0x000000018015EEA0
	[Name] // 0x000000018015EE20-0x000000018015EEA0
	public class NestedBTState : FSMState, IGraphAssignable // TypeDefIndex: 14015
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private BBParameter<BehaviourTree> _nestedBT; // 0x88
		public BTExecutionMode executionMode; // 0x90
		public BTExitMode exitMode; // 0x94
		public string successEvent; // 0x98
		public string failureEvent; // 0xA0
		private Dictionary<BehaviourTree, BehaviourTree> instances; // 0xA8
		private BehaviourTree currentInstance; // 0xB0
	
		// Properties
		public BehaviourTree nestedBT { get; set; } // 0x000000018175A260-0x000000018175A2B0 0x000000018175A900-0x000000018175A960
		Graph IGraphAssignable.nestedGraph { get; set; } // 0x000000018175A260-0x000000018175A2B0 0x000000018175A2B0-0x000000018175A380
	
		// Nested types
		public enum BTExecutionMode // TypeDefIndex: 14016
		{
			Once = 0,
			Repeat = 1
		}
	
		public enum BTExitMode // TypeDefIndex: 14017
		{
			StopAndRestart = 0,
			PauseAndResume = 1
		}
	
		// Constructors
		public NestedBTState(); // 0x000000018175A890-0x000000018175A900
	
		// Methods
		Graph[] IGraphAssignable.GetInstances(); // 0x000000018175A200-0x000000018175A260
		protected override void OnEnter(); // 0x000000018175A380-0x000000018175A530
		protected override void OnUpdate(); // 0x000000018175A7C0-0x000000018175A890
		private void OnFinish(bool success); // 0x000000018175A5F0-0x000000018175A720
		protected override void OnExit(); // 0x000000018175A530-0x000000018175A5F0
		protected override void OnPause(); // 0x000000018175A720-0x000000018175A7C0
		private BehaviourTree CheckInstance(); // 0x0000000181759F90-0x000000018175A200
	}
}
