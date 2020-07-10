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

public class MoonPhasesTile : MonoBehaviour // TypeDefIndex: 13055
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
	internal enum EMoveType // TypeDefIndex: 13056
	{
		Deal = 0,
		Collect = 1,
		DealerPlay = 2,
		FirstTile = 3
	}

	internal enum ETileType // TypeDefIndex: 13057
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

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <MoveTile>d__20 : IEnumerator<object> // TypeDefIndex: 13058
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <MoveTile>d__20(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001812ED7C0-0x00000001812EE120
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001812EE120-0x00000001812EE170
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <DealerFlip>d__21 : IEnumerator<object> // TypeDefIndex: 13059
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <DealerFlip>d__21(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001812EC550-0x00000001812ECA90
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001812ECA90-0x00000001812ED300
	}

	// Constructors
	public MoonPhasesTile(); // 0x00000001812DD210-0x00000001812DD340

	// Methods
	internal void InitTile(ETileType inTileType); // 0x00000001812DCD20-0x00000001812DCFD0
	private void OnMouseUp(); // 0x00000001812DD0E0-0x00000001812DD120
	private void OnMouseEnter(); // 0x00000001812DD070-0x00000001812DD0A0
	private void OnMouseExit(); // 0x00000001812DD0A0-0x00000001812DD0E0
	[IteratorStateMachine] // 0x00000001800CD8C0-0x00000001800CD910
	internal IEnumerator MoveTile(bool inPlayerTile, float inDelay, Transform inParent, EMoveType inMoveType); // 0x00000001812DCFD0-0x00000001812DD070
	[IteratorStateMachine] // 0x00000001800CDC90-0x00000001800CDCE0
	internal IEnumerator DealerFlip(); // 0x00000001812DCCC0-0x00000001812DCD20
	internal void SetTileFace(); // 0x00000001812DD170-0x00000001812DD210
	internal void Return(); // 0x00000001812DD120-0x00000001812DD170
}

