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

[RequireComponent] // 0x0000000180290950-0x00000001802909A0
public class CFX_AutoDestructShuriken : MonoBehaviour // TypeDefIndex: 11356
{
	// Fields
	public bool OnlyDeactivate; // 0x20

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <CheckIfAlive>d__2 : IEnumerator<object> // TypeDefIndex: 11357
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public CFX_AutoDestructShuriken <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <CheckIfAlive>d__2(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001804A71C0-0x00000001804A7300
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001804A7300-0x00000001804A78B0
	}

	// Constructors
	public CFX_AutoDestructShuriken(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void OnEnable(); // 0x00000001804990A0-0x00000001804990E0
	[IteratorStateMachine] // 0x0000000180290AC0-0x0000000180290B10
	private IEnumerator CheckIfAlive(); // 0x0000000180499040-0x00000001804990A0
}

