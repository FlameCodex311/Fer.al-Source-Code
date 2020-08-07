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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class TestActorCustomizer : ManagedBehaviour // TypeDefIndex: 11519
{
	// Fields
	private bool _visible; // 0x50
	private Vector2 _scrollPos; // 0x54
	private EventSystem _rewiredEventSystem; // 0x60

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <MoveToBottom>d__4 : IEnumerator<object> // TypeDefIndex: 11520
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public TestActorCustomizer <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <MoveToBottom>d__4(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001809614C0-0x0000000180961630
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180961630-0x0000000180961680
	}

	// Constructors
	public TestActorCustomizer(); // 0x000000018095F640-0x000000018095F6A0

	// Methods
	public override void MStart(); // 0x000000018095EFD0-0x000000018095F0A0
	[IteratorStateMachine] // 0x0000000180213270-0x00000001802132C0
	private IEnumerator MoveToBottom(); // 0x000000018095F0A0-0x000000018095F100
	private void OnGUI(); // 0x000000018095F100-0x000000018095F3F0
	private void OnWindow(int inID); // 0x000000018095F3F0-0x000000018095F640
}

