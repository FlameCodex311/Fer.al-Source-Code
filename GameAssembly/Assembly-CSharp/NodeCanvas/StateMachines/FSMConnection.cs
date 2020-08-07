/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.StateMachines
{
	public class FSMConnection : Connection, ITaskAssignable<ConditionTask> // TypeDefIndex: 15073
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private FSM.TransitionCallMode _transitionCallMode; // 0x30
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ConditionTask _condition; // 0x38
	
		// Properties
		public ConditionTask condition { get; set; } // 0x00000001803743D0-0x00000001803743E0 0x00000001803FEB60-0x00000001803FEB70
		public Task task { get; set; } // 0x00000001803743D0-0x00000001803743E0 0x0000000180CC3230-0x0000000180CC32C0
		public FSM.TransitionCallMode transitionCallMode { get; private set; } // 0x00000001804AA650-0x00000001804AA660 0x000000018041A3B0-0x000000018041A400
	
		// Constructors
		public FSMConnection(); // 0x00000001807C4290-0x00000001807C42A0
	
		// Methods
		public void EnableCondition(Component agent, IBlackboard blackboard); // 0x0000000180CC30C0-0x0000000180CC30E0
		public void DisableCondition(); // 0x0000000180CC30A0-0x0000000180CC30C0
		public void PerformTransition(); // 0x0000000180CC30E0-0x0000000180CC3230
	}
}
