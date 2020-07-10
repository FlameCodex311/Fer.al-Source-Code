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

public class FourCrowsCrow : MonoBehaviour // TypeDefIndex: 13026
{
	// Fields
	public FCCrowIdle fCCrowIdle; // 0x20
	public GameObject crowGeometry; // 0x28
	public ParticleSystem appearEffect; // 0x30
	public ParticleSystem disappearEffect; // 0x38

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass5_0 // TypeDefIndex: 13027
	{
		// Fields
		public FourCrowsCrow <>4__this; // 0x10
		public bool inShow; // 0x18

		// Constructors
		public <>c__DisplayClass5_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <ShowCrow>b__0(); // 0x0000000181115410-0x0000000181115470
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <LoseGame>d__6 : IEnumerator<object> // TypeDefIndex: 13028
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public FourCrowsCrow <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <LoseGame>d__6(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181113C50-0x0000000181113D70
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181113D70-0x0000000181113DC0
	}

	// Constructors
	public FourCrowsCrow(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void Awake(); // 0x000000018110C370-0x000000018110C420
	internal void ShowCrow(bool inShow, bool inPlayFX); // 0x000000018110C4C0-0x000000018110C650
	[IteratorStateMachine] // 0x00000001800BD2F0-0x00000001800BD340
	internal IEnumerator LoseGame(); // 0x000000018110C420-0x000000018110C480
	internal void ResetCrow(); // 0x000000018110C480-0x000000018110C4C0
}

