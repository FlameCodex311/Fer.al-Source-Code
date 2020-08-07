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

public class FourCrowsCard : MonoBehaviour // TypeDefIndex: 10686
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
	internal enum EMoveType // TypeDefIndex: 10687
	{
		Deal = 0,
		Collect = 1,
		DealerPlay = 2
	}

	internal enum ECardType // TypeDefIndex: 10688
	{
		Positive2 = 0,
		Positive1 = 1,
		Negative1 = 2,
		Negative2 = 3,
		Skip = 4,
		Reset = 5
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <MoveCard>d__19 : IEnumerator<object> // TypeDefIndex: 10689
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <MoveCard>d__19(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001806A8B40-0x00000001806A9220
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001806A9220-0x00000001806A9270
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <DealerFlip>d__20 : IEnumerator<object> // TypeDefIndex: 10690
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <DealerFlip>d__20(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001806A6B20-0x00000001806A7070
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001806A7070-0x00000001806A70C0
	}

	// Constructors
	public FourCrowsCard(); // 0x00000001806A2220-0x00000001806A22F0

	// Methods
	internal void SetCardFace(); // 0x00000001806A1E70-0x00000001806A2220
	internal void InitCard(ECardType inCardType); // 0x00000001806A1A80-0x00000001806A1C50
	private void OnMouseDown(); // 0x00000001806A1CF0-0x00000001806A1DA0
	private void OnMouseUp(); // 0x00000001806A1DA0-0x00000001806A1E50
	[IteratorStateMachine] // 0x00000001802549A0-0x00000001802549F0
	internal IEnumerator MoveCard(bool inPlayerCard, float inDelay, Transform inParent, EMoveType inMoveType); // 0x00000001806A1C50-0x00000001806A1CF0
	[IteratorStateMachine] // 0x0000000180254D70-0x0000000180254DC0
	internal IEnumerator DealerFlip(); // 0x00000001806A1A20-0x00000001806A1A80
	internal void Return(); // 0x00000001806A1E50-0x00000001806A1E70
}

