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

public class MothsAndFlamesToken : MonoBehaviour // TypeDefIndex: 13091
{
	// Fields
	public float moveTime; // 0x20
	public GameObject crystalGlowBlueFX; // 0x28
	public GameObject crystalGlowOrangeFX; // 0x30
	internal MothsAndFlamesBetSpot betSpot; // 0x38
	private Coroutine MoveTokenCoroutine; // 0x40

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <MoveToken>d__6 : IEnumerator<object> // TypeDefIndex: 13092
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public MothsAndFlamesToken <>4__this; // 0x20
		public Vector3 inEndPosition; // 0x28
		public bool inPlayPlacedAudio; // 0x34
		private Vector3 <startPosition>5__2; // 0x38
		private float <t>5__3; // 0x44

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <MoveToken>d__6(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001812EEBA0-0x00000001812EEEB0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001812EEEB0-0x00000001812EEF00
	}

	// Constructors
	public MothsAndFlamesToken(); // 0x0000000180FF7F40-0x0000000180FF7F50

	// Methods
	internal void BetSpotSelected(Vector3 inEndPosition, bool inPlayPlacedAudio, bool inPlayPickupAudio); // 0x00000001812E1F00-0x00000001812E1FD0
	[IteratorStateMachine] // 0x00000001800E1020-0x00000001800E1070
	private IEnumerator MoveToken(Vector3 inEndPosition, bool inPlayPlacedAudio); // 0x00000001812E1FD0-0x00000001812E2060
	internal void Unload(Vector3 inPosition); // 0x00000001812E2060-0x00000001812E20F0
}

