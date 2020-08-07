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

public class MothsAndFlamesGame : ParlorGameBase // TypeDefIndex: 10750
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
	internal EgameState GameState { get; set; } // 0x00000001803D3ED0-0x00000001803D3EE0 0x00000001807C7A90-0x00000001807C7AA0

	// Nested types
	internal enum EBetTypes // TypeDefIndex: 10751
	{
		MMM = 0,
		MM = 1,
		FFF = 2,
		FF = 3,
		NONE = 4
	}

	internal enum EgameState // TypeDefIndex: 10752
	{
		Shake = 0,
		Bet = 1,
		Roll = 2,
		Results = 3
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <Load>d__28 : IEnumerator<object> // TypeDefIndex: 10753
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public MothsAndFlamesGame <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <Load>d__28(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001807D8820-0x00000001807D8A40
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001807D8A40-0x00000001807D8A90
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <StartGame>d__30 : IEnumerator<object> // TypeDefIndex: 10754
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public MothsAndFlamesGame <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <StartGame>d__30(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001807DA580-0x00000001807DA5F0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001807DA5F0-0x00000001807DA640
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <Reveal>d__38 : IEnumerator<object> // TypeDefIndex: 10755
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public MothsAndFlamesGame <>4__this; // 0x20
		public int inMultiplerResults; // 0x28
		private float <t>5__2; // 0x2C

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <Reveal>d__38(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001807D8D40-0x00000001807D92D0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001807D92D0-0x00000001807D9320
	}

	// Constructors
	public MothsAndFlamesGame(); // 0x00000001807C7A30-0x00000001807C7A90

	// Methods
	private void Awake(); // 0x00000001807C6280-0x00000001807C62C0
	private void Start(); // 0x00000001807C6FC0-0x00000001807C70E0
	private void Update(); // 0x00000001807C73A0-0x00000001807C7A30
	[IteratorStateMachine] // 0x0000000180277850-0x00000001802778A0
	internal override IEnumerator Load(int[] inAdditionalParameters); // 0x00000001807C6680-0x00000001807C66E0
	internal override void Unload(); // 0x00000001807C7200-0x00000001807C73A0
	[IteratorStateMachine] // 0x0000000180277C90-0x0000000180277CE0
	internal override IEnumerator StartGame(); // 0x00000001807C6ED0-0x00000001807C6F30
	internal override void Replay(bool inDoubleUp = false /* Metadata: 0x0077C087 */); // 0x00000001807C6760-0x00000001807C67A0
	internal void Setup(); // 0x00000001807C6C30-0x00000001807C6ED0
	internal Vector3 GetBoardClickPos(); // 0x00000001807C6570-0x00000001807C6680
	internal void BetSpotSelected(); // 0x00000001807C62C0-0x00000001807C63F0
	internal void RequestPlayerPlay(); // 0x00000001807C67A0-0x00000001807C6BC0
	internal override void GameResponse(ParlorGameCommand inParlorGameCommand); // 0x00000001807C64F0-0x00000001807C6570
	internal override void MultiplierResponse(int inMultiplerResults); // 0x00000001807C66E0-0x00000001807C6760
	[IteratorStateMachine] // 0x0000000180277FB0-0x0000000180278000
	private IEnumerator Reveal(int inMultiplerResults); // 0x00000001807C6BC0-0x00000001807C6C30
	internal void StartSelect(); // 0x00000001807C6F30-0x00000001807C6FC0
	internal void CupHitTable(); // 0x00000001807C63F0-0x00000001807C64F0
	[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
	[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
	private IEnumerator <>n__0(int[] inAdditionalParameters); // 0x00000001806A59D0-0x00000001806A59E0
	[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
	[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
	private IEnumerator <>n__1(); // 0x00000001806A59E0-0x00000001806A59F0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Setup>b__32_0(); // 0x00000001807C63F0-0x00000001807C64F0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Reveal>b__38_0(); // 0x00000001807C70E0-0x00000001807C7200
}

