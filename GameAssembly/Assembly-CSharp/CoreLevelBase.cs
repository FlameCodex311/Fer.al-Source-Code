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

public abstract class CoreLevelBase : MonoBehaviour // TypeDefIndex: 11093
{
	// Fields
	public static CoreLevelBase instance; // 0x00

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <InitFromManager>d__3 : IEnumerator<object> // TypeDefIndex: 11094
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <InitFromManager>d__3(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001803C5AF0-0x00000001803C5B00
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180A78DD0-0x0000000180A78E20
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <WaitForThingsToFinish>d__4 : IEnumerator<object> // TypeDefIndex: 11095
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <WaitForThingsToFinish>d__4(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001803C5AF0-0x00000001803C5B00
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180A7C2E0-0x0000000180A7C330
	}

	// Constructors
	protected CoreLevelBase(); // 0x00000001803743C0-0x00000001803743D0
	static CoreLevelBase(); // 0x00000001803774A0-0x00000001803774B0

	// Methods
	private void OnEnable(); // 0x0000000180A6CC10-0x0000000180A6CC70
	private void OnDisable(); // 0x0000000180A6CBB0-0x0000000180A6CC10
	[IteratorStateMachine] // 0x0000000180231E10-0x0000000180231E60
	public virtual IEnumerator InitFromManager(Transform tSpawnPoint = null); // 0x0000000180A6CB60-0x0000000180A6CBB0
	[IteratorStateMachine] // 0x0000000180232160-0x00000001802321B0
	public virtual IEnumerator WaitForThingsToFinish(); // 0x0000000180A6CC70-0x0000000180A6CCC0
}

