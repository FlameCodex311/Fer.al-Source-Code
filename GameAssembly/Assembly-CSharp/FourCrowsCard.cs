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

public class FourCrowsCard : MonoBehaviour // TypeDefIndex: 13021
{
	// Fields
	public Renderer cardRenderer; // 0x20
	public Texture[] cardFaces; // 0x28
	public Vector3 playerPositionsRotation; // 0x30
	public Vector3 dealerPositionsRotation; // 0x3C
	public Vector3 dealerPlaysRotation; // 0x48
	internal ECardType cardType; // 0x54
	internal bool hasBeenDealt; // 0x58
	internal bool hasBeenPlayed; // 0x59
	internal bool canDrop; // 0x5A
	internal int cardValue; // 0x5C
	internal bool canSelect; // 0x60
	private FourCrowsGame _game; // 0x68
	private FourCrowsDeckManager _deckManager; // 0x70

	// Nested types
	internal enum EMoveType // TypeDefIndex: 13022
	{
		Deal = 0,
		Collect = 1,
		DealerPlay = 2
	}

	internal enum ECardType // TypeDefIndex: 13023
	{
		Positive2 = 0,
		Positive1 = 1,
		Negative1 = 2,
		Negative2 = 3,
		Skip = 4,
		Reset = 5
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <MoveCard>d__19 : IEnumerator<object> // TypeDefIndex: 13024
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public float inDelay; // 0x20
		public EMoveType inMoveType; // 0x24
		public bool inPlayerCard; // 0x28
		public FourCrowsCard <>4__this; // 0x30
		public Transform inParent; // 0x38
		private Quaternion <startQ>5__2; // 0x40
		private Quaternion <endQ>5__3; // 0x50
		private Vector3 <startPosition>5__4; // 0x60
		private Vector3 <endPosition>5__5; // 0x6C
		private float <dealTime>5__6; // 0x78
		private float <t>5__7; // 0x7C

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <MoveCard>d__19(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181113DC0-0x00000001811144A0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001811144A0-0x00000001811144F0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <DealerFlip>d__20 : IEnumerator<object> // TypeDefIndex: 13025
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public FourCrowsCard <>4__this; // 0x20
		private Vector3 <startPosition>5__2; // 0x28
		private Vector3 <midPosition>5__3; // 0x34
		private Quaternion <startQ>5__4; // 0x40
		private Quaternion <endQ>5__5; // 0x50
		private float <halfTime>5__6; // 0x60
		private float <t>5__7; // 0x64

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <DealerFlip>d__20(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001811111E0-0x0000000181111750
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181111750-0x00000001811117A0
	}

	// Constructors
	public FourCrowsCard(); // 0x000000018110C2A0-0x000000018110C370

	// Methods
	internal void SetCardFace(); // 0x000000018110BEC0-0x000000018110C2A0
	internal void InitCard(ECardType inCardType); // 0x000000018110BAC0-0x000000018110BCA0
	private void OnMouseDown(); // 0x000000018110BD40-0x000000018110BDF0
	private void OnMouseUp(); // 0x000000018110BDF0-0x000000018110BEA0
	[IteratorStateMachine] // 0x00000001800BAD30-0x00000001800BAD80
	internal IEnumerator MoveCard(bool inPlayerCard, float inDelay, Transform inParent, EMoveType inMoveType); // 0x000000018110BCA0-0x000000018110BD40
	[IteratorStateMachine] // 0x00000001800BAEE0-0x00000001800BAF30
	internal IEnumerator DealerFlip(); // 0x000000018110BA60-0x000000018110BAC0
	internal void Return(); // 0x000000018110BEA0-0x000000018110BEC0
}

