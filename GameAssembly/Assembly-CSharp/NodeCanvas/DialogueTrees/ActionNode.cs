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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.DialogueTrees
{
	[Description] // 0x0000000180200730-0x0000000180200790
	[Name] // 0x0000000180200730-0x0000000180200790
	public class ActionNode : DTNode, ITaskAssignable<ActionTask> // TypeDefIndex: 15116
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ActionTask _action; // 0x98
	
		// Properties
		public ActionTask action { get; set; } // 0x0000000180418990-0x00000001804189A0 0x0000000180419170-0x0000000180419180
		public Task task { get; set; } // 0x0000000180418990-0x00000001804189A0 0x000000018089EAB0-0x000000018089EB40
		public override bool requireActorSelection { get; } // 0x0000000180380B60-0x0000000180380B70 
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <UpdateAction>d__10 : IEnumerator<object> // TypeDefIndex: 15117
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public ActionNode <>4__this; // 0x20
			public Component actionAgent; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <UpdateAction>d__10(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x00000001808B7B80-0x00000001808B7CA0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001808B7CA0-0x00000001808B7CF0
		}
	
		// Constructors
		public ActionNode(); // 0x000000018089EA60-0x000000018089EAB0
	
		// Methods
		protected override Status OnExecute(Component agent, IBlackboard bb); // 0x000000018089E8B0-0x000000018089E9A0
		[IteratorStateMachine] // 0x0000000180200B20-0x0000000180200B70
		private IEnumerator UpdateAction(Component actionAgent); // 0x000000018089E9F0-0x000000018089EA60
		private void OnActionEnd(bool success); // 0x000000018089E840-0x000000018089E8B0
		protected override void OnReset(); // 0x000000018089E9D0-0x000000018089E9F0
		public override void OnGraphPaused(); // 0x000000018089E9A0-0x000000018089E9D0
	}
}
