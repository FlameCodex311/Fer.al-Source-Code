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

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x0000000180112DE0-0x0000000180112E40
	[Description] // 0x0000000180112DE0-0x0000000180112E40
	public class MoveLocalPlayer : ActionTask<Transform> // TypeDefIndex: 14376
	{
		// Properties
		protected override string info { get; } // 0x0000000181551670-0x00000001815516C0 
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <Move>d__3 : IEnumerator<object> // TypeDefIndex: 14377
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public MoveLocalPlayer <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <Move>d__3(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018155B900-0x000000018155BBC0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018155BBC0-0x000000018155BC10
		}
	
		// Constructors
		public MoveLocalPlayer(); // 0x0000000181551630-0x0000000181551670
	
		// Methods
		protected override void OnExecute(); // 0x0000000181551370-0x00000001815513E0
		[IteratorStateMachine] // 0x0000000180112FD0-0x0000000180113020
		private IEnumerator Move(); // 0x0000000181551310-0x0000000181551370
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private void <Move>b__3_0(); // 0x00000001815513E0-0x0000000181551630
	}
}
