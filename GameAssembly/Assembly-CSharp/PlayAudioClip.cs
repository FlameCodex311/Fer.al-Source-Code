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

[RequireComponent] // 0x00000001801D7AE0-0x00000001801D7B30
public class PlayAudioClip : ManagedBehaviour // TypeDefIndex: 11409
{
	// Fields
	private static PlayAudioClip _instance; // 0x00
	private AudioSource _audioSource; // 0x50

	// Properties
	public static PlayAudioClip instance { get; } // 0x00000001804E2E10-0x00000001804E2F00 
	public AudioSource audioSource { get; } // 0x00000001804E2D90-0x00000001804E2E10 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <PlayCoroutine>d__7 : IEnumerator<object> // TypeDefIndex: 11410
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public PlayAudioClip <>4__this; // 0x20
		public AudioClip inAudioClip; // 0x28
		public bool inLoop; // 0x30

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <PlayCoroutine>d__7(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001804EB300-0x00000001804EB4C0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001804EB4C0-0x00000001804EB510
	}

	// Constructors
	public PlayAudioClip(); // 0x00000001804E2D30-0x00000001804E2D90

	// Methods
	public void Play(AudioClip inAudioClip); // 0x00000001804E2CB0-0x00000001804E2D30
	[IteratorStateMachine] // 0x00000001801D7DD0-0x00000001801D7E20
	private IEnumerator PlayCoroutine(AudioClip inAudioClip, bool inLoop = true /* Metadata: 0x0077CAD5 */); // 0x00000001804E2C30-0x00000001804E2CB0
}

