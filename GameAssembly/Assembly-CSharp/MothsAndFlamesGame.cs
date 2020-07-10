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

public class MothsAndFlamesGame : ParlorGameBase // TypeDefIndex: 13085
{
	// Fields
	internal static MothsAndFlamesGame instance; // 0x00
	public MothsAndFlamesUIManager uiManager; // 0xA8
	public MothsAndFlamesDiceManager diceManager; // 0xB0
	public MothsAndFlamesBetSpotManager betSpotManager; // 0xB8
	public MothsAndFlamesToken crystalToken; // 0xC0
	public Animator cupAnimator; // 0xC8
	public float minMoveDistance; // 0xD0
	public GameObject cupRevealFogFX; // 0xD8
	public GameObject cupTrailFX; // 0xE0
	private EgameState _gameState; // 0xE8
	private bool _skipCompare; // 0xEC
	private bool _draggingCrystal; // 0xED
	private Vector3 _crystalTokenStartPosition; // 0xF0
	private Vector3 _lastPosition; // 0xFC
	private Vector3 _tokenClickOffset; // 0x108
	private Plane _intersectPlane; // 0x114
	private Ray _dragRay; // 0x124
	private Camera _camera; // 0x140
	private ParlorManager.EWinState _serverWinResults; // 0x148
	private MothsAndFlamesBetSpot _lastBetSpot; // 0x150

	// Properties
	internal EgameState GameState { get; set; } // 0x0000000180EE4B70-0x0000000180EE4B80 0x00000001810BB870-0x00000001810BB880

	// Nested types
	internal enum EBetTypes // TypeDefIndex: 13086
	{
		MMM = 0,
		MM = 1,
		FFF = 2,
		FF = 3,
		NONE = 4
	}

	internal enum EgameState // TypeDefIndex: 13087
	{
		Shake = 0,
		Bet = 1,
		Roll = 2,
		Results = 3
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <Load>d__28 : IEnumerator<object> // TypeDefIndex: 13088
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public MothsAndFlamesGame <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <Load>d__28(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001812ED550-0x00000001812ED770
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001812ED770-0x00000001812ED7C0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <StartGame>d__30 : IEnumerator<object> // TypeDefIndex: 13089
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public MothsAndFlamesGame <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <StartGame>d__30(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001812F1E80-0x00000001812F1EF0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001812F1EF0-0x00000001812F1F40
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <Reveal>d__38 : IEnumerator<object> // TypeDefIndex: 13090
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public MothsAndFlamesGame <>4__this; // 0x20
		public int inMultiplerResults; // 0x28
		private float <t>5__2; // 0x2C

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <Reveal>d__38(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001812EFBF0-0x00000001812F0210
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001812F0210-0x00000001812F0260
	}

	// Constructors
	public MothsAndFlamesGame(); // 0x00000001812E1EA0-0x00000001812E1F00

	// Methods
	private void Awake(); // 0x00000001812E03B0-0x00000001812E03F0
	private void Start(); // 0x00000001812E12F0-0x00000001812E14C0
	private void Update(); // 0x00000001812E17F0-0x00000001812E1EA0
	[IteratorStateMachine] // 0x00000001800DE340-0x00000001800DE390
	internal override IEnumerator Load(int[] inAdditionalParameters); // 0x00000001812E08D0-0x00000001812E0930
	internal override void Unload(); // 0x00000001812E16B0-0x00000001812E17F0
	[IteratorStateMachine] // 0x00000001800DE6A0-0x00000001800DE6F0
	internal override IEnumerator StartGame(); // 0x00000001812E1200-0x00000001812E1260
	internal override void Replay(bool inDoubleUp = false /* Metadata: 0x007835CC */); // 0x00000001812E09B0-0x00000001812E09F0
	internal void Setup(); // 0x00000001812E0EC0-0x00000001812E1200
	internal Vector3 GetBoardClickPos(); // 0x00000001812E07C0-0x00000001812E08D0
	internal void BetSpotSelected(); // 0x00000001812E03F0-0x00000001812E0520
	internal void RequestPlayerPlay(); // 0x00000001812E09F0-0x00000001812E0E50
	internal override void GameResponse(ParlorGameCommand inParlorGameCommand); // 0x00000001812E0740-0x00000001812E07C0
	internal override void MultiplierResponse(int inMultiplerResults); // 0x00000001812E0930-0x00000001812E09B0
	[IteratorStateMachine] // 0x00000001800DE9B0-0x00000001800DEA00
	private IEnumerator Reveal(int inMultiplerResults); // 0x00000001812E0E50-0x00000001812E0EC0
	internal void StartSelect(); // 0x00000001812E1260-0x00000001812E12F0
	internal void CupHitTable(); // 0x00000001812E0520-0x00000001812E0740
	[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
	[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
	private IEnumerator <>n__0(int[] inAdditionalParameters); // 0x00000001810BB6C0-0x00000001810BB6D0
	[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
	[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
	private IEnumerator <>n__1(); // 0x00000001810BB6D0-0x00000001810BB6E0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Setup>b__32_0(); // 0x00000001812E16A0-0x00000001812E16B0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Reveal>b__38_0(); // 0x00000001812E14C0-0x00000001812E16A0
}

