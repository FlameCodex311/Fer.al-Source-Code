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

public class FourCrowsCrow : MonoBehaviour // TypeDefIndex: 10691
{
	// Fields
	public FCCrowIdle fCCrowIdle; // 0x20
	public GameObject crowGeometry; // 0x28
	public ParticleSystem appearEffect; // 0x30
	public ParticleSystem disappearEffect; // 0x38

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass5_0 // TypeDefIndex: 10692
	{
		// Fields
		public FourCrowsCrow <>4__this; // 0x10
		public bool inShow; // 0x18

		// Constructors
		public <>c__DisplayClass5_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <ShowCrow>b__0(); // 0x00000001806A9A70-0x00000001806A9AD0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <LoseGame>d__6 : IEnumerator<object> // TypeDefIndex: 10693
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public FourCrowsCrow <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <LoseGame>d__6(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001806A89E0-0x00000001806A8AF0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001806A8AF0-0x00000001806A8B40
	}

	// Constructors
	public FourCrowsCrow(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void Awake(); // 0x00000001806A22F0-0x00000001806A23A0
	internal void ShowCrow(bool inShow, bool inPlayFX); // 0x00000001806A2440-0x00000001806A25C0
	[IteratorStateMachine] // 0x0000000180255E10-0x0000000180255E60
	internal IEnumerator LoseGame(); // 0x00000001806A23A0-0x00000001806A2400
	internal void ResetCrow(); // 0x00000001806A2400-0x00000001806A2440
}

