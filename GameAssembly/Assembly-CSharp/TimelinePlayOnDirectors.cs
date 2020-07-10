/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Playables;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ManagedBehaviourManager] // 0x0000000180153E00-0x0000000180153E30
public class TimelinePlayOnDirectors : ManagedBehaviour // TypeDefIndex: 11908
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private PlayableDirector[] playableDirectors; // 0x50
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private PlayableAsset[] playables; // 0x58

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <PlayCoroutine>d__3 : IEnumerator<object> // TypeDefIndex: 11909
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public TimelinePlayOnDirectors <>4__this; // 0x20
		public int inIndex; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <PlayCoroutine>d__3(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180FB0340-0x0000000180FB05D0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180FB05D0-0x0000000180FB0620
	}

	// Constructors
	public TimelinePlayOnDirectors(); // 0x0000000180FA21D0-0x0000000180FA2230

	// Methods
	public void Play(int inIndex); // 0x0000000180FA2150-0x0000000180FA21D0
	[IteratorStateMachine] // 0x0000000180157B40-0x0000000180157B90
	private IEnumerator PlayCoroutine(int inIndex); // 0x0000000180FA20E0-0x0000000180FA2150
}

