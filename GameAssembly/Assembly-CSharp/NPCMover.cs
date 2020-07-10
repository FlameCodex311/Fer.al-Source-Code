/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class NPCMover : MonoBehaviour // TypeDefIndex: 11447
{
	// Fields
	public Animator animator; // 0x20
	public ActorBase actorBase; // 0x28

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <Init>d__3 : IEnumerator<object> // TypeDefIndex: 11448
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public NPCMover <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <Init>d__3(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001812ED300-0x00000001812ED500
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001812ED500-0x00000001812ED550
	}

	// Constructors
	public NPCMover(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void Awake(); // 0x00000001812E4020-0x00000001812E40E0
	[IteratorStateMachine] // 0x00000001800B6F50-0x00000001800B6FA0
	private IEnumerator Init(); // 0x00000001812E40E0-0x00000001812E4140
	public void Set(); // 0x00000001812E4020-0x00000001812E40E0
}

