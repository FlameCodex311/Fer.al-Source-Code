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

[ManagedBehaviourManager] // 0x0000000180106CD0-0x0000000180106D00
public class SanctuaryTwiggle : ManagedBehaviour // TypeDefIndex: 11852
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	protected GameObject _twiggleGameObjectRef; // 0x50
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	protected ActorNPCSpawner _twiggleSpawnerRef; // 0x58

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <InitWait>d__3 : IEnumerator<object> // TypeDefIndex: 11853
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <InitWait>d__3(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180EE0630-0x0000000180EE0640
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181376250-0x00000001813762A0
	}

	// Constructors
	public SanctuaryTwiggle(); // 0x000000018136F8B0-0x000000018136F910

	// Methods
	public override void MStart(); // 0x0000000181370590-0x00000001813705D0
	[IteratorStateMachine] // 0x0000000180139870-0x00000001801398C0
	protected virtual IEnumerator InitWait(); // 0x0000000181370540-0x0000000181370590
}

