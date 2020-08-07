/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class QRoutineCollection // TypeDefIndex: 11227
{
	// Fields
	public bool verbose; // 0x10
	protected List<QRoutine> _qroutines; // 0x18

	// Properties
	public bool HasQRoutines { get; } // 0x0000000180A2CEC0-0x0000000180A2CF00 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <WaitForQRoutines>d__5 : IEnumerator<object> // TypeDefIndex: 11228
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public QRoutineCollection <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <WaitForQRoutines>d__5(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180A44580-0x0000000180A449C0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180A449C0-0x0000000180A44A10
	}

	// Constructors
	public QRoutineCollection(); // 0x0000000180A2CE60-0x0000000180A2CEC0

	// Methods
	public QRoutine Add(QRoutine inQRoutine); // 0x0000000180A2CDA0-0x0000000180A2CE00
	[IteratorStateMachine] // 0x0000000180262680-0x00000001802626D0
	public IEnumerator WaitForQRoutines(); // 0x0000000180A2CE00-0x0000000180A2CE60
}

