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

public class CFX_ShurikenThreadFix : MonoBehaviour // TypeDefIndex: 13691
{
	// Fields
	private ParticleSystem[] systems; // 0x20

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <WaitFrame>d__2 : IEnumerator<object> // TypeDefIndex: 13692
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public CFX_ShurikenThreadFix <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <WaitFrame>d__2(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181034720-0x00000001810347E0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001810347E0-0x0000000181034830
	}

	// Constructors
	public CFX_ShurikenThreadFix(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void OnEnable(); // 0x0000000181020E50-0x0000000181020F30
	[IteratorStateMachine] // 0x00000001800F3F20-0x00000001800F3F70
	private IEnumerator WaitFrame(); // 0x0000000181020F30-0x0000000181020F90
}

