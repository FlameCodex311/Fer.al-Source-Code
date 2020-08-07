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

[ManagedBehaviourManager] // 0x00000001801E3560-0x00000001801E3590
public class SanctuaryTwiggle : ManagedBehaviour // TypeDefIndex: 13388
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	protected GameObject _twiggleGameObjectRef; // 0x50
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	protected ActorNPCSpawner _twiggleSpawnerRef; // 0x58

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <InitWait>d__3 : IEnumerator<object> // TypeDefIndex: 13389
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <InitWait>d__3(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001803C5AF0-0x00000001803C5B00
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180401CC0-0x0000000180401D10
	}

	// Constructors
	public SanctuaryTwiggle(); // 0x00000001803F85D0-0x00000001803F8630

	// Methods
	public override void MStart(); // 0x00000001803F92A0-0x00000001803F92E0
	[IteratorStateMachine] // 0x00000001802206C0-0x0000000180220710
	protected virtual IEnumerator InitWait(); // 0x00000001803F9250-0x00000001803F92A0
}

