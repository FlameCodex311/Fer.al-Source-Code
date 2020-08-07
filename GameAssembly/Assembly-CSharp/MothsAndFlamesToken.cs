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

public class MothsAndFlamesToken : MonoBehaviour // TypeDefIndex: 10756
{
	// Fields
	public float moveTime; // 0x20
	public GameObject crystalGlowBlueFX; // 0x28
	public GameObject crystalGlowOrangeFX; // 0x30
	internal MothsAndFlamesBetSpot betSpot; // 0x38
	private Coroutine MoveTokenCoroutine; // 0x40

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <MoveToken>d__6 : IEnumerator<object> // TypeDefIndex: 10757
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <MoveToken>d__6(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001807D8A90-0x00000001807D8CF0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001807D8CF0-0x00000001807D8D40
	}

	// Constructors
	public MothsAndFlamesToken(); // 0x0000000180499690-0x00000001804996A0

	// Methods
	internal void BetSpotSelected(Vector3 inEndPosition, bool inPlayPlacedAudio, bool inPlayPickupAudio); // 0x00000001807C7AA0-0x00000001807C7B70
	[IteratorStateMachine] // 0x000000018027B420-0x000000018027B470
	private IEnumerator MoveToken(Vector3 inEndPosition, bool inPlayPlacedAudio); // 0x00000001807C7B70-0x00000001807C7C00
	internal void Unload(Vector3 inPosition); // 0x00000001807C7C00-0x00000001807C7C80
}

