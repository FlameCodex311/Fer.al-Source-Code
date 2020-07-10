/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using NodeCanvas.StateMachines;
using ParadoxNotion.Design;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.BehaviourTrees
{
	[Category] // 0x0000000180170C60-0x0000000180170D20
	[Description] // 0x0000000180170C60-0x0000000180170D20
	[Icon] // 0x0000000180170C60-0x0000000180170D20
	[Name] // 0x0000000180170C60-0x0000000180170D20
	public class NestedFSM : BTNode, IGraphAssignable // TypeDefIndex: 14067
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private BBParameter<FSM> _nestedFSM; // 0x78
		private Dictionary<FSM, FSM> instances; // 0x80
		private FSM currentInstance; // 0x88
		public string successState; // 0x90
		public string failureState; // 0x98
	
		// Properties
		public override string name { get; } // 0x000000018155E3C0-0x000000018155E3F0 
		public FSM nestedFSM { get; set; } // 0x000000018156A0A0-0x000000018156A0F0 0x000000018156A6D0-0x000000018156A730
		Graph IGraphAssignable.nestedGraph { get; set; } // 0x000000018156A0A0-0x000000018156A0F0 0x000000018156A0F0-0x000000018156A1C0
	
		// Constructors
		public NestedFSM(); // 0x000000018156A660-0x000000018156A6D0
	
		// Methods
		Graph[] IGraphAssignable.GetInstances(); // 0x000000018156A040-0x000000018156A0A0
		protected override Status OnExecute(Component agent, IBlackboard blackboard); // 0x000000018156A1C0-0x000000018156A490
		private void OnFSMFinish(bool success); // 0x000000018156A490-0x000000018156A4B0
		protected override void OnReset(); // 0x000000018156A5D0-0x000000018156A660
		public override void OnGraphPaused(); // 0x000000018156A4B0-0x000000018156A540
		public override void OnGraphStoped(); // 0x000000018156A540-0x000000018156A5D0
		private FSM CheckInstance(); // 0x0000000181569DE0-0x000000018156A040
	}
}
