/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class NPCMover : MonoBehaviour // TypeDefIndex: 12384
{
	// Fields
	public Animator animator; // 0x20
	public ActorBase actorBase; // 0x28

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <Init>d__3 : IEnumerator<object> // TypeDefIndex: 12385
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public NPCMover <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <Init>d__3(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001807D85E0-0x00000001807D87D0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001807D87D0-0x00000001807D8820
	}

	// Constructors
	public NPCMover(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void Awake(); // 0x00000001807C9B40-0x00000001807C9C00
	[IteratorStateMachine] // 0x00000001802891F0-0x0000000180289240
	private IEnumerator Init(); // 0x00000001807C9C00-0x00000001807C9C60
	public void Set(); // 0x00000001807C9B40-0x00000001807C9C00
}

