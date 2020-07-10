/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.DialogueTrees
{
	[Description] // 0x00000001800B7E30-0x00000001800B7E90
	[Name] // 0x00000001800B7E30-0x00000001800B7E90
	public class ActionNode : DTNode, ITaskAssignable<ActionTask> // TypeDefIndex: 14091
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private ActionTask _action; // 0x88
	
		// Properties
		public ActionTask action { get; set; } // 0x0000000180424200-0x0000000180424210 0x000000018049D700-0x000000018049D710
		public Task task { get; set; } // 0x0000000180424200-0x0000000180424210 0x000000018155E3F0-0x000000018155E480
		public override bool requireActorSelection { get; } // 0x00000001803C29F0-0x00000001803C2A00 
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <UpdateAction>d__10 : IEnumerator<object> // TypeDefIndex: 14092
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public ActionNode <>4__this; // 0x20
			public Component actionAgent; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <UpdateAction>d__10(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001815764B0-0x00000001815765D0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001815765D0-0x0000000181576620
		}
	
		// Constructors
		public ActionNode(); // 0x000000018155E380-0x000000018155E3C0
	
		// Methods
		protected override Status OnExecute(Component agent, IBlackboard bb); // 0x000000018155E130-0x000000018155E220
		[IteratorStateMachine] // 0x00000001800B8230-0x00000001800B8280
		private IEnumerator UpdateAction(Component actionAgent); // 0x000000018155E300-0x000000018155E370
		private void OnActionEnd(bool success); // 0x000000018155E0A0-0x000000018155E100
		protected override void OnReset(); // 0x000000018155E2E0-0x000000018155E300
		public override void OnGraphPaused(); // 0x000000018155E220-0x000000018155E270
	}
}
