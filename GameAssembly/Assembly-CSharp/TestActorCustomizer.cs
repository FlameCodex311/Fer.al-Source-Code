/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class TestActorCustomizer : ManagedBehaviour // TypeDefIndex: 10028
{
	// Fields
	private bool _visible; // 0x50
	private Vector2 _scrollPos; // 0x54
	private EventSystem _rewiredEventSystem; // 0x60

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <MoveToBottom>d__4 : IEnumerator<object> // TypeDefIndex: 10029
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public TestActorCustomizer <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <MoveToBottom>d__4(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181212240-0x00000001812123C0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001812123C0-0x0000000181212410
	}

	// Constructors
	public TestActorCustomizer(); // 0x000000018120F6C0-0x000000018120F720

	// Methods
	public override void MStart(); // 0x000000018120F050-0x000000018120F120
	[IteratorStateMachine] // 0x0000000180139EB0-0x0000000180139F00
	private IEnumerator MoveToBottom(); // 0x000000018120F120-0x000000018120F180
	private void OnGUI(); // 0x000000018120F180-0x000000018120F470
	private void OnWindow(int inID); // 0x000000018120F470-0x000000018120F6C0
}

