/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ManagedBehaviourManager] // 0x0000000180239FC0-0x0000000180239FF0
public class TimelineDialog : ManagedBehaviour // TypeDefIndex: 13432
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _textMesh; // 0x50

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <SetDialogCoroutine>d__2 : IEnumerator<object> // TypeDefIndex: 13433
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public TimelineDialog <>4__this; // 0x20
		public string inDefId; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <SetDialogCoroutine>d__2(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180F926F0-0x0000000180F928C0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180F928C0-0x0000000180F92910
	}

	// Constructors
	public TimelineDialog(); // 0x0000000180F8DE10-0x0000000180F8DE70

	// Methods
	public void SetDialog(string inDefId); // 0x0000000180F8DD90-0x0000000180F8DE10
	[IteratorStateMachine] // 0x000000018023A330-0x000000018023A380
	private IEnumerator SetDialogCoroutine(string inDefId); // 0x0000000180F8DD20-0x0000000180F8DD90
}

