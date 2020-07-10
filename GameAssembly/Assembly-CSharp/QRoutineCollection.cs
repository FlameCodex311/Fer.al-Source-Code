/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class QRoutineCollection // TypeDefIndex: 13556
{
	// Fields
	public bool verbose; // 0x10
	protected List<QRoutine> _qroutines; // 0x18

	// Properties
	public bool HasQRoutines { get; } // 0x00000001815EF2E0-0x00000001815EF330 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <WaitForQRoutines>d__5 : IEnumerator<object> // TypeDefIndex: 13557
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public QRoutineCollection <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <WaitForQRoutines>d__5(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181608110-0x0000000181608580
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181608580-0x00000001816085D0
	}

	// Constructors
	public QRoutineCollection(); // 0x00000001815EF280-0x00000001815EF2E0

	// Methods
	public QRoutine Add(QRoutine inQRoutine); // 0x00000001815EF1C0-0x00000001815EF220
	[IteratorStateMachine] // 0x00000001800C6800-0x00000001800C6850
	public IEnumerator WaitForQRoutines(); // 0x00000001815EF220-0x00000001815EF280
}

