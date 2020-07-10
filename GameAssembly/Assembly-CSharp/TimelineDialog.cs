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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ManagedBehaviourManager] // 0x0000000180153E00-0x0000000180153E30
public class TimelineDialog : ManagedBehaviour // TypeDefIndex: 11896
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _textMesh; // 0x50

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <SetDialogCoroutine>d__2 : IEnumerator<object> // TypeDefIndex: 11897
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public TimelineDialog <>4__this; // 0x20
		public string inDefId; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <SetDialogCoroutine>d__2(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181A0E4E0-0x0000000181A0E6B0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181A0E6B0-0x0000000181A0E700
	}

	// Constructors
	public TimelineDialog(); // 0x0000000181A0C990-0x0000000181A0C9F0

	// Methods
	public void SetDialog(string inDefId); // 0x0000000181A0C910-0x0000000181A0C990
	[IteratorStateMachine] // 0x0000000180153FF0-0x0000000180154040
	private IEnumerator SetDialogCoroutine(string inDefId); // 0x0000000181A0C8A0-0x0000000181A0C910
}

