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

public class QueensDuelGame : ParlorGameBase // TypeDefIndex: 10787
{
	// Fields
	public static QueensDuelGame instance; // 0x00
	[Header] // 0x00000001801F9530-0x00000001801F9560
	public QueensDuelUIManager uiManager; // 0xA8
	public QueensDuelDiceManager diceManager; // 0xB0
	public GameObject[] WinLaneFX; // 0xB8
	public GameObject[] LoseLaneFX; // 0xC0
	public ParticleSystem[] dividerParticles; // 0xC8
	public float mistRevealWaitTime; // 0xD0
	public float minMoveDistance; // 0xD4
	public float laneFXdelay; // 0xD8
	internal EgameState _gameState; // 0xDC
	internal bool fakeServer; // 0xE0
	private bool[] _rowsResultsShown; // 0xE8
	private bool _doReveal; // 0xF0
	private List<int> _tieColumns; // 0xF8
	private ParticleSystem[][] _dividerParticles; // 0x100
	private string[] _opponentRow; // 0x108
	private Vector3 _lastPosition; // 0x110
	private Plane _intersectPlane; // 0x11C
	private Ray _dragRay; // 0x12C
	private Camera _camera; // 0x148
	private int _timesDoubledUp; // 0x150
	private ParlorManager.EWinState _serverWinResults; // 0x154
	private string _scoreTrack; // 0x158
	private string _outFileName; // 0x160

	// Properties
	internal EgameState GameState { get; set; } // 0x0000000180475720-0x0000000180475730 0x0000000180479300-0x0000000180479310

	// Nested types
	internal enum EgameState // TypeDefIndex: 10788
	{
		Shake1 = 0,
		Select1 = 1,
		Shake2 = 2,
		Select2 = 3,
		Reveal = 4,
		TieShake = 5,
		TieCompare = 6,
		Results = 7
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <StartGame>d__27 : IEnumerator<object> // TypeDefIndex: 10789
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public QueensDuelGame <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <StartGame>d__27(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018065DA70-0x000000018065DC10
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018065DC10-0x000000018065DC60
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <Reveal>d__34 : IEnumerator<object> // TypeDefIndex: 10790
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public QueensDuelGame <>4__this; // 0x20
		public string inResults; // 0x28
		private float <t>5__2; // 0x30

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <Reveal>d__34(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018065C560-0x000000018065C710
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018065C710-0x000000018065C760
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <TallyScore>d__35 : IEnumerator<object> // TypeDefIndex: 10791
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public QueensDuelGame <>4__this; // 0x20
		private float <t>5__2; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <TallyScore>d__35(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018065DC60-0x000000018065DF00
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018065DF00-0x000000018065DF50
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 10792
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action <>9__36_0; // 0x08
		public static Action <>9__36_1; // 0x10

		// Constructors
		static <>c(); // 0x000000018065F5E0-0x000000018065F640
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <EnableDividerParticles>b__36_0(); // 0x000000018065F130-0x000000018065F180
		internal void <EnableDividerParticles>b__36_1(); // 0x000000018065F180-0x000000018065F1D0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <DealerAutoRoll>d__41 : IEnumerator<object> // TypeDefIndex: 10793
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public QueensDuelGame <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <DealerAutoRoll>d__41(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180658D10-0x0000000180658E10
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180658E10-0x0000000180658E60
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <ShowRowResults>d__47 : IEnumerator<object> // TypeDefIndex: 10794
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public QueensDuelUI_ColumnScore inColumnScore; // 0x20
		public GameObject inGameObject; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <ShowRowResults>d__47(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018065C760-0x000000018065C850
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018065C850-0x000000018065C8A0
	}

	// Constructors
	public QueensDuelGame(); // 0x0000000180A3C050-0x0000000180A3C0F0

	// Methods
	private void Awake(); // 0x0000000180A389C0-0x0000000180A38A00
	private void Start(); // 0x0000000180A3A5B0-0x0000000180A3AC50
	[IteratorStateMachine] // 0x000000018028CAB0-0x000000018028CB00
	internal override IEnumerator StartGame(); // 0x0000000180A3A2B0-0x0000000180A3A320
	private void Update(); // 0x0000000180A3BD00-0x0000000180A3C050
	internal Vector3 GetBoardClickPos(); // 0x0000000180A39100-0x0000000180A39210
	internal override void GameResponse(ParlorGameCommand inParlorGameCommand); // 0x0000000180A38EE0-0x0000000180A39100
	private void ReceivedOpponentSelection(ParlorGameCommand parlorGameCommand); // 0x0000000180A39730-0x0000000180A39B30
	private string GetPlayerDice(int inLocatorIndex); // 0x0000000180A39210-0x0000000180A39460
	internal void RequestCompare(); // 0x0000000180A39DF0-0x0000000180A3A050
	[IteratorStateMachine] // 0x000000018028CC30-0x000000018028CC80
	internal IEnumerator Reveal(string inResults); // 0x0000000180A3A050-0x0000000180A3A0D0
	[IteratorStateMachine] // 0x000000018028CDF0-0x000000018028CE40
	private IEnumerator TallyScore(); // 0x0000000180A3B160-0x0000000180A3B1D0
	internal void EnableDividerParticles(bool inEnable); // 0x0000000180A38A70-0x0000000180A38EE0
	internal void Setup(); // 0x0000000180A3A0D0-0x0000000180A3A1A0
	internal void StateUpdate(); // 0x0000000180A3AC50-0x0000000180A3AD50
	private void OpponentSelect(); // 0x0000000180A39460-0x0000000180A396A0
	internal void Shake(); // 0x0000000180A3A1A0-0x0000000180A3A230
	[IteratorStateMachine] // 0x000000018028CFD0-0x000000018028D020
	internal IEnumerator DealerAutoRoll(); // 0x0000000180A38A00-0x0000000180A38A70
	internal void TieShake(); // 0x0000000180A3BAD0-0x0000000180A3BB60
	private void TieShakeResponse(ParlorGameCommand parlorGameCommand); // 0x0000000180A3B820-0x0000000180A3BAD0
	private void StartTieBreaker(); // 0x0000000180A3A320-0x0000000180A3A5B0
	private void TallyFinalScore(); // 0x0000000180A3AD50-0x0000000180A3B160
	[IteratorStateMachine] // 0x000000018028D2E0-0x000000018028D330
	private IEnumerator ShowRowResults(QueensDuelUI_ColumnScore inColumnScore, GameObject inGameObject); // 0x0000000180A3A230-0x0000000180A3A2B0
	private void TieChq(int inColumnIndex); // 0x0000000180A3B760-0x0000000180A3B820
	internal void TallySideScore(bool inPlayer); // 0x0000000180A3B1D0-0x0000000180A3B760
	internal override void Replay(bool inDoubleUp = false /* Metadata: 0x0077C11A */); // 0x0000000180A39B30-0x0000000180A39DF0
	internal override void Unload(); // 0x0000000180A3BB60-0x0000000180A3BD00
	internal override bool OverDoubleUpLimit(); // 0x0000000180A396A0-0x0000000180A39730
	private void LogIt(); // 0x00000001803774A0-0x00000001803774B0
	[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
	[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
	private IEnumerator <>n__0(); // 0x00000001806A59E0-0x00000001806A59F0
}

