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

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

public class ExampleGestureHandler : UnityEngine.MonoBehaviour // TypeDefIndex: 9294
{
	// Fields
	public UnityEngine.UI.Text textResult; // 0x18
	public Transform referenceRoot; // 0x20
	private GesturePatternDraw[] references; // 0x28

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass6_0 // TypeDefIndex: 9295
	{
		// Fields
		public string id; // 0x10

		// Constructors
		public <>c__DisplayClass6_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <Blink>b__0(GesturePatternDraw e); // 0x00000001815ED8B0-0x00000001815ED8F0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <Blink>d__6 : IEnumerator<object> // TypeDefIndex: 9296
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <Blink>d__6(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001815ECE20-0x00000001815ED030
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001815ED030-0x00000001815ED080
	}

	// Constructors
	public ExampleGestureHandler(); // 0x0000000180407560-0x0000000180407570

	// Methods
	private void Start(); // 0x00000001815D0D60-0x00000001815D0F80
	private void ShowAll(); // 0x00000001815D0CB0-0x00000001815D0D60
	public void OnRecognize(RecognitionResult result); // 0x00000001815D0860-0x00000001815D0CB0
	[IteratorStateMachine] // 0x0000000180117D30-0x0000000180117D80
	private IEnumerator Blink(string id); // 0x00000001815D07F0-0x00000001815D0860
}

