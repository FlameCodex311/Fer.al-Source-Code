/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public abstract class CoreLevelBase : MonoBehaviour // TypeDefIndex: 13422
{
	// Fields
	public static CoreLevelBase instance; // 0x00

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <InitFromManager>d__3 : IEnumerator<object> // TypeDefIndex: 13423
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <InitFromManager>d__3(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180EE0630-0x0000000180EE0640
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181327E50-0x0000000181327EA0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <WaitForThingsToFinish>d__4 : IEnumerator<object> // TypeDefIndex: 13424
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <WaitForThingsToFinish>d__4(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180EE0630-0x0000000180EE0640
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x000000018132A440-0x000000018132A490
	}

	// Constructors
	protected CoreLevelBase(); // 0x0000000180E095D0-0x0000000180E095E0
	static CoreLevelBase(); // 0x00000001803581E0-0x00000001803581F0

	// Methods
	private void OnEnable(); // 0x0000000181312660-0x00000001813126C0
	private void OnDisable(); // 0x0000000181312600-0x0000000181312660
	[IteratorStateMachine] // 0x000000018014D6D0-0x000000018014D720
	public virtual IEnumerator InitFromManager(); // 0x00000001813125B0-0x0000000181312600
	[IteratorStateMachine] // 0x000000018014D9B0-0x000000018014DA00
	public virtual IEnumerator WaitForThingsToFinish(); // 0x00000001813126C0-0x0000000181312710
}

