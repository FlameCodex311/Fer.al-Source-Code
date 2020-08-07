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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ManagedBehaviourManager] // 0x0000000180239FC0-0x0000000180239FF0
public class TimelinePlayOnDirectors : ManagedBehaviour // TypeDefIndex: 13444
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private PlayableDirector[] playableDirectors; // 0x50
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private PlayableAsset[] playables; // 0x58

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <PlayCoroutine>d__3 : IEnumerator<object> // TypeDefIndex: 13445
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public TimelinePlayOnDirectors <>4__this; // 0x20
		public int inIndex; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <PlayCoroutine>d__3(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180F92430-0x0000000180F926A0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180F926A0-0x0000000180F926F0
	}

	// Constructors
	public TimelinePlayOnDirectors(); // 0x0000000180F900A0-0x0000000180F90100

	// Methods
	public void Play(int inIndex); // 0x0000000180F90020-0x0000000180F900A0
	[IteratorStateMachine] // 0x000000018023D480-0x000000018023D4D0
	private IEnumerator PlayCoroutine(int inIndex); // 0x0000000180F8FFB0-0x0000000180F90020
}

