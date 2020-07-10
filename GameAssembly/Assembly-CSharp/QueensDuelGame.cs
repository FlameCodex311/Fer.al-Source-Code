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

public class QueensDuelGame : ParlorGameBase // TypeDefIndex: 13122
{
	// Fields
	public static QueensDuelGame instance; // 0x00
	[Header] // 0x00000001800F1570-0x00000001800F15A0
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
	internal EgameState GameState { get; set; } // 0x00000001804A24E0-0x00000001804A24F0 0x00000001804A22D0-0x00000001804A22E0

	// Nested types
	internal enum EgameState // TypeDefIndex: 13123
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

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <StartGame>d__27 : IEnumerator<object> // TypeDefIndex: 13124
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public QueensDuelGame <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <StartGame>d__27(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181605DD0-0x00000001816060C0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001816060C0-0x0000000181606110
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <Reveal>d__34 : IEnumerator<object> // TypeDefIndex: 13125
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public QueensDuelGame <>4__this; // 0x20
		public string inResults; // 0x28
		private float <t>5__2; // 0x30

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <Reveal>d__34(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181603860-0x0000000181603AA0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181603AA0-0x0000000181603AF0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <TallyScore>d__35 : IEnumerator<object> // TypeDefIndex: 13126
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public QueensDuelGame <>4__this; // 0x20
		private float <t>5__2; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <TallyScore>d__35(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001816076D0-0x0000000181607970
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181607970-0x00000001816079C0
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 13127
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action <>9__36_0; // 0x08
		public static Action <>9__36_1; // 0x10

		// Constructors
		static <>c(); // 0x0000000181608050-0x00000001816080B0
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <EnableDividerParticles>b__36_0(); // 0x0000000181607C40-0x0000000181607D20
		internal void <EnableDividerParticles>b__36_1(); // 0x0000000181607D20-0x0000000181607E00
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <DealerAutoRoll>d__41 : IEnumerator<object> // TypeDefIndex: 13128
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public QueensDuelGame <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <DealerAutoRoll>d__41(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181601E30-0x0000000181601F80
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181601F80-0x0000000181601FD0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <ShowRowResults>d__47 : IEnumerator<object> // TypeDefIndex: 13129
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public QueensDuelUI_ColumnScore inColumnScore; // 0x20
		public GameObject inGameObject; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <ShowRowResults>d__47(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181605C00-0x0000000181605D80
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181605D80-0x0000000181605DD0
	}

	// Constructors
	public QueensDuelGame(); // 0x00000001815FEAF0-0x00000001815FEB90

	// Methods
	private void Awake(); // 0x00000001815FB360-0x00000001815FB3A0
	private void Start(); // 0x00000001815FCF40-0x00000001815FD630
	[IteratorStateMachine] // 0x00000001800F1670-0x00000001800F16C0
	internal override IEnumerator StartGame(); // 0x00000001815FCC30-0x00000001815FCC90
	private void Update(); // 0x00000001815FE7A0-0x00000001815FEAF0
	internal Vector3 GetBoardClickPos(); // 0x00000001815FBAB0-0x00000001815FBBC0
	internal override void GameResponse(ParlorGameCommand inParlorGameCommand); // 0x00000001815FB890-0x00000001815FBAB0
	private void ReceivedOpponentSelection(ParlorGameCommand parlorGameCommand); // 0x00000001815FC100-0x00000001815FC540
	private string GetPlayerDice(int inLocatorIndex); // 0x00000001815FBBC0-0x00000001815FBE20
	internal void RequestCompare(); // 0x00000001815FC770-0x00000001815FC9F0
	[IteratorStateMachine] // 0x00000001800F1940-0x00000001800F1990
	internal IEnumerator Reveal(string inResults); // 0x00000001815FC9F0-0x00000001815FCA60
	[IteratorStateMachine] // 0x00000001800F1C60-0x00000001800F1CB0
	private IEnumerator TallyScore(); // 0x00000001815FDB60-0x00000001815FDBC0
	internal void EnableDividerParticles(bool inEnable); // 0x00000001815FB400-0x00000001815FB890
	internal void Setup(); // 0x00000001815FCA60-0x00000001815FCB30
	internal void StateUpdate(); // 0x00000001815FD630-0x00000001815FD700
	private void OpponentSelect(); // 0x00000001815FBE20-0x00000001815FC070
	internal void Shake(); // 0x00000001815FCB30-0x00000001815FCBC0
	[IteratorStateMachine] // 0x00000001800F1E10-0x00000001800F1E60
	internal IEnumerator DealerAutoRoll(); // 0x00000001815FB3A0-0x00000001815FB400
	internal void TieShake(); // 0x00000001815FE560-0x00000001815FE5F0
	private void TieShakeResponse(ParlorGameCommand parlorGameCommand); // 0x00000001815FE280-0x00000001815FE560
	private void StartTieBreaker(); // 0x00000001815FCC90-0x00000001815FCF40
	private void TallyFinalScore(); // 0x00000001815FD700-0x00000001815FDB60
	[IteratorStateMachine] // 0x00000001800F2130-0x00000001800F2180
	private IEnumerator ShowRowResults(QueensDuelUI_ColumnScore inColumnScore, GameObject inGameObject); // 0x00000001815FCBC0-0x00000001815FCC30
	private void TieChq(int inColumnIndex); // 0x00000001815FE1A0-0x00000001815FE280
	internal void TallySideScore(bool inPlayer); // 0x00000001815FDBC0-0x00000001815FE1A0
	internal override void Replay(bool inDoubleUp = false /* Metadata: 0x0078365F */); // 0x00000001815FC540-0x00000001815FC770
	internal override void Unload(); // 0x00000001815FE5F0-0x00000001815FE7A0
	internal override bool OverDoubleUpLimit(); // 0x00000001815FC070-0x00000001815FC100
	private void LogIt(); // 0x00000001803581E0-0x00000001803581F0
	[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
	[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
	private IEnumerator <>n__0(); // 0x00000001810BB6D0-0x00000001810BB6E0
}

