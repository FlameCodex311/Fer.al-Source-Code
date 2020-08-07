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

public class MoonPhasesTile : MonoBehaviour // TypeDefIndex: 10720
{
	// Fields
	public ParticleSystem tileHighlightFX; // 0x20
	public Renderer tileRenderer; // 0x28
	public Texture[] tileFaces; // 0x30
	public Vector3 playerPositionsRotation; // 0x38
	public Vector3 dealerPositionsRotation; // 0x44
	public Vector3 dealerPlaysRotation; // 0x50
	internal ETileType tileType; // 0x5C
	internal bool hasBeenDealt; // 0x60
	internal bool hasBeenPlayed; // 0x61
	internal int tileValue; // 0x64
	internal bool canSelect; // 0x68
	private MoonPhasesGame _game; // 0x70
	private MoonPhasesTileManager _tileManager; // 0x78
	private Vector3 _baseScale; // 0x80

	// Nested types
	internal enum EMoveType // TypeDefIndex: 10721
	{
		Deal = 0,
		Collect = 1,
		DealerPlay = 2,
		FirstTile = 3
	}

	internal enum ETileType // TypeDefIndex: 10722
	{
		Zero = 0,
		One = 1,
		Two = 2,
		Three = 3,
		Four = 4,
		Five = 5,
		Six = 6,
		Seven = 7
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <MoveTile>d__20 : IEnumerator<object> // TypeDefIndex: 10723
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public float inDelay; // 0x20
		public EMoveType inMoveType; // 0x24
		public bool inPlayerTile; // 0x28
		public MoonPhasesTile <>4__this; // 0x30
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
		public <MoveTile>d__20(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180C148C0-0x0000000180C151E0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180C151E0-0x0000000180C15230
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <DealerFlip>d__21 : IEnumerator<object> // TypeDefIndex: 10724
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public MoonPhasesTile <>4__this; // 0x20
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
		public <DealerFlip>d__21(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180C13050-0x0000000180C13590
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180C13590-0x0000000180C135E0
	}

	// Constructors
	public MoonPhasesTile(); // 0x0000000180C10460-0x0000000180C10590

	// Methods
	internal void InitTile(ETileType inTileType); // 0x0000000180C0FF90-0x0000000180C10230
	private void OnMouseUp(); // 0x0000000180C10340-0x0000000180C10370
	private void OnMouseEnter(); // 0x0000000180C102D0-0x0000000180C10300
	private void OnMouseExit(); // 0x0000000180C10300-0x0000000180C10340
	[IteratorStateMachine] // 0x00000001802666A0-0x00000001802666F0
	internal IEnumerator MoveTile(bool inPlayerTile, float inDelay, Transform inParent, EMoveType inMoveType); // 0x0000000180C10230-0x0000000180C102D0
	[IteratorStateMachine] // 0x0000000180266810-0x0000000180266860
	internal IEnumerator DealerFlip(); // 0x0000000180C0FF30-0x0000000180C0FF90
	internal void SetTileFace(); // 0x0000000180C103C0-0x0000000180C10460
	internal void Return(); // 0x0000000180C10370-0x0000000180C103C0
}

