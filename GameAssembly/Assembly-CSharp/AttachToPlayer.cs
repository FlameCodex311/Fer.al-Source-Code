/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class AttachToPlayer : ManagedBehaviour // TypeDefIndex: 10051
{
	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <AttachToPlayerCoroutine>d__1 : IEnumerator<object> // TypeDefIndex: 10052
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public AttachToPlayer <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <AttachToPlayerCoroutine>d__1(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x000000018104A930-0x000000018104AAB0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x000000018104AAB0-0x000000018104B280
	}

	// Constructors
	public AttachToPlayer(); // 0x000000018103DE10-0x000000018103DE70

	// Methods
	public override void MOnEnable(); // 0x000000018103DDA0-0x000000018103DE10
	[IteratorStateMachine] // 0x000000018013FC40-0x000000018013FC90
	private IEnumerator AttachToPlayerCoroutine(); // 0x000000018103DD40-0x000000018103DDA0
}

