/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[RequireComponent] // 0x0000000180100190-0x00000001801001E0
public class PlayAudioClip : ManagedBehaviour // TypeDefIndex: 13736
{
	// Fields
	private static PlayAudioClip _instance; // 0x00
	private AudioSource _audioSource; // 0x50

	// Properties
	public static PlayAudioClip instance { get; } // 0x0000000181159BB0-0x0000000181159CA0 
	public AudioSource audioSource { get; } // 0x0000000181159B30-0x0000000181159BB0 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <PlayCoroutine>d__7 : IEnumerator<object> // TypeDefIndex: 13737
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public PlayAudioClip <>4__this; // 0x20
		public AudioClip inAudioClip; // 0x28
		public bool inLoop; // 0x30

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <PlayCoroutine>d__7(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181165650-0x0000000181165820
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181165820-0x0000000181165870
	}

	// Constructors
	public PlayAudioClip(); // 0x0000000181159AD0-0x0000000181159B30

	// Methods
	public void Play(AudioClip inAudioClip); // 0x0000000181159A50-0x0000000181159AD0
	[IteratorStateMachine] // 0x0000000180100670-0x00000001801006C0
	private IEnumerator PlayCoroutine(AudioClip inAudioClip, bool inLoop = true /* Metadata: 0x00784016 */); // 0x00000001811599D0-0x0000000181159A50
}

