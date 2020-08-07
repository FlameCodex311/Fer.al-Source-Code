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

public class ParlorManager : CasualGame<ParlorManager> // TypeDefIndex: 10760
{
	// Fields
	public Camera parlorCamera; // 0x30
	public ParlorUIManager uiManager; // 0x38
	public ParticleSystem gameOverWinEffect; // 0x40
	public Transform kinoLocator; // 0x48
	public ActorNPCSpawner kinoSpawner; // 0x50
	public ParlorGameBase[] parlorGames; // 0x58
	public float crystalZipAudioWait; // 0x60
	public int startingWager; // 0x64
	public int startingFunds; // 0x68
	public bool alwaysShowTutorialFirstTime; // 0x6C
	internal int maxWager; // 0x70
	internal ParlorGameBase currentParlorGame; // 0x78
	internal bool replayingParlorGame; // 0x80
	internal bool fakeServer; // 0x81
	internal Animator kinoAnimator; // 0x88
	internal EParlorState ParlorState; // 0x90
	private int _pot; // 0x94
	private int _totalFunds; // 0x98
	private EWinState _winState; // 0x9C
	private int _currentWager; // 0xA0
	internal const string GameCommand = "gameCommand"; // Metadata: 0x0077C0AC

	// Properties
	internal int Pot { get; set; } // 0x00000001804D9970-0x00000001804D9980 0x00000001804DBA00-0x00000001804DBAC0
	internal int TotalFunds { get; set; } // 0x00000001804D9960-0x00000001804D9970 0x00000001804DBAC0-0x00000001804DBB10
	internal EWinState WinState { get; set; } // 0x00000001804DB9F0-0x00000001804DBA00 0x00000001804DBB10-0x00000001804DBCD0

	// Nested types
	public enum EParlorGame // TypeDefIndex: 10761
	{
		None = 0,
		QueensDuel = 1,
		FourCrows = 2,
		MothsAndFlames = 3,
		MoonPhases = 4
	}

	internal enum EParlorState // TypeDefIndex: 10762
	{
		SelectGame = 0,
		PlaceWager = 1,
		PlayGame = 2,
		DoubleUp = 3,
		Payout = 4,
		PlayAgain = 5,
		NewGame = 6,
		ExitGame = 7
	}

	internal enum EWinState // TypeDefIndex: 10763
	{
		None = 0,
		Player = 1,
		Opponent = 2,
		Tie = 3
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 10764
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<bool> <>9__34_0; // 0x08
		public static Func<bool> <>9__34_2; // 0x10
		public static Func<bool> <>9__34_4; // 0x18

		// Constructors
		static <>c(); // 0x00000001804ED4D0-0x00000001804ED530
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <Start>b__34_0(); // 0x00000001804ECC80-0x00000001804ECCD0
		internal bool <Start>b__34_2(); // 0x00000001804ECCD0-0x00000001804ECD50
		internal bool <Start>b__34_4(); // 0x00000001804ECD50-0x00000001804ECDF0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <PlayerWin>d__54 : IEnumerator<object> // TypeDefIndex: 10765
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ParlorManager <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <PlayerWin>d__54(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001804EB510-0x00000001804EB680
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001804EB680-0x00000001804EB8A0
	}

	// Constructors
	public ParlorManager(); // 0x00000001804DB980-0x00000001804DB9F0

	// Methods
	protected override void Awake(); // 0x00000001804D9AA0-0x00000001804D9C10
	private void Start(); // 0x00000001804DB0B0-0x00000001804DB2A0
	protected override void OnDestroy(); // 0x00000001804DA850-0x00000001804DA8F0
	protected override void HandleGameCommand(CasualGameCommand inMessage); // 0x00000001804DA000-0x00000001804DA0F0
	public void KinoSpawned(); // 0x00000001804DA230-0x00000001804DA450
	internal void PlaceWager(); // 0x00000001804DADC0-0x00000001804DADE0
	private void OnMinigameMessage(ParlorGameCommand msg); // 0x00000001804DA8F0-0x00000001804DAA60
	private void MultiplierResults(int inMultiplyerResults); // 0x00000001804DA820-0x00000001804DA850
	internal void SendServerMessage(params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ string[] inData); // 0x00000001804DAFB0-0x00000001804DAFC0
	private void GameResponse(ParlorGameCommand parlorGameCommand); // 0x00000001804D9E80-0x00000001804DA000
	internal void PlaySnap(); // 0x00000001804DAF00-0x00000001804DAF50
	private void SetupParlor(); // 0x00000001804DAFC0-0x00000001804DB0B0
	internal void LoadParlorGameRequest(); // 0x00000001804DA690-0x00000001804DA820
	internal void LoadParlorGameAccepted(int inMaxWager, int[] inAdditionalParameters = null); // 0x00000001804DA450-0x00000001804DA690
	internal void PlaceWagerRequest(); // 0x00000001804DAC10-0x00000001804DADC0
	internal void PlayAgain(); // 0x00000001804DADE0-0x00000001804DAEB0
	private void WagerAccepted(int inAcceptedWager); // 0x00000001804DB8A0-0x00000001804DB980
	internal void DoubleUpRequest(bool inAccept); // 0x00000001804D9C10-0x00000001804D9D80
	private void DoubleUpResults(bool inIncreasePot); // 0x00000001804D9D80-0x00000001804D9E70
	internal void ParlorGameOver(); // 0x00000001804DAA60-0x00000001804DAC10
	internal void UnloadParlorGame(); // 0x00000001804DB700-0x00000001804DB8A0
	[IteratorStateMachine] // 0x000000018027CE10-0x000000018027CE60
	internal IEnumerator PlayerWin(); // 0x00000001804DAF50-0x00000001804DAFB0
	internal void ExitParlor(); // 0x00000001804D9E70-0x00000001804D9E80
	internal void PlayEffects(ParticleSystem inParticleSystem); // 0x00000001804DAEB0-0x00000001804DAF00
	internal string TimeIt(string inString); // 0x00000001804DB2A0-0x00000001804DB320
	internal bool HasSeenTutorial(string inGameName); // 0x00000001804DA0F0-0x00000001804DA230
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Start>b__34_1(); // 0x00000001804DB370-0x00000001804DB550
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Start>b__34_3(); // 0x00000001804DB550-0x00000001804DB560
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Start>b__34_5(); // 0x00000001804DB560-0x00000001804DB5F0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <ParlorGameOver>b__52_0(); // 0x00000001804DB320-0x00000001804DB370
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <UnloadParlorGame>b__53_0(); // 0x00000001804DB5F0-0x00000001804DB700
}

