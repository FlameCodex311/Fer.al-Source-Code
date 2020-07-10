/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class AttachToCamera : ManagedBehaviour // TypeDefIndex: 10049
{
	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <AttachToCameraCoroutine>d__1 : IEnumerator<object> // TypeDefIndex: 10050
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public AttachToCamera <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <AttachToCameraCoroutine>d__1(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x000000018104A6F0-0x000000018104A8E0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x000000018104A8E0-0x000000018104A930
	}

	// Constructors
	public AttachToCamera(); // 0x000000018103DB20-0x000000018103DB80

	// Methods
	public override void MOnEnable(); // 0x000000018103DAB0-0x000000018103DB20
	[IteratorStateMachine] // 0x000000018013F490-0x000000018013F4E0
	private IEnumerator AttachToCameraCoroutine(); // 0x000000018103DA50-0x000000018103DAB0
}

