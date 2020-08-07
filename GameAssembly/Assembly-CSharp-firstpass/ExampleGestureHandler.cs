/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GestureRecognizer;
using UnityEngine;
using UnityEngine.UI;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

public class ExampleGestureHandler : UnityEngine.MonoBehaviour // TypeDefIndex: 9698
{
	// Fields
	public UnityEngine.UI.Text textResult; // 0x18
	public Transform referenceRoot; // 0x20
	private GesturePatternDraw[] references; // 0x28

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass6_0 // TypeDefIndex: 9699
	{
		// Fields
		public string id; // 0x10

		// Constructors
		public <>c__DisplayClass6_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <Blink>b__0(GesturePatternDraw e); // 0x000000018108D510-0x000000018108D550
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <Blink>d__6 : IEnumerator<object> // TypeDefIndex: 9700
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public string id; // 0x20
		public ExampleGestureHandler <>4__this; // 0x28
		private GesturePatternDraw <draw>5__2; // 0x30
		private WaitForSeconds <seconds>5__3; // 0x38
		private int <i>5__4; // 0x40

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <Blink>d__6(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018108CAA0-0x000000018108CCA0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018108CCA0-0x000000018108CCF0
	}

	// Constructors
	public ExampleGestureHandler(); // 0x0000000180568C50-0x0000000180569020

	// Methods
	private void Start(); // 0x000000018107AAF0-0x000000018107AD00
	private void ShowAll(); // 0x000000018107AA50-0x000000018107AAF0
	public void OnRecognize(RecognitionResult result); // 0x000000018107A630-0x000000018107AA50
	[IteratorStateMachine] // 0x00000001801E7040-0x00000001801E7090
	private IEnumerator Blink(string id); // 0x000000018107A5C0-0x000000018107A630
}

