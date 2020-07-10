/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.StateMachines
{
	[Description] // 0x0000000180160C70-0x0000000180160CA0
	public class SuperActionState : FSMState, ISubTasksContainer // TypeDefIndex: 14019
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private ActionList _onEnterList; // 0x88
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private ActionList _onUpdateList; // 0x90
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private ActionList _onExitList; // 0x98
		private bool enterListFinished; // 0xA0
	
		// Constructors
		public SuperActionState(); // 0x000000018155E370-0x000000018155E380
	
		// Methods
		public Task[] GetSubTasks(); // 0x000000018175DDF0-0x000000018175DF60
		public override void OnValidate(Graph assignedGraph); // 0x000000018175E1A0-0x000000018175E430
		protected override void OnEnter(); // 0x000000018175DF60-0x000000018175DF80
		protected override void OnUpdate(); // 0x000000018175E090-0x000000018175E1A0
		protected override void OnExit(); // 0x000000018175DF80-0x000000018175E050
		protected override void OnPause(); // 0x000000018175E050-0x000000018175E090
	}
}
