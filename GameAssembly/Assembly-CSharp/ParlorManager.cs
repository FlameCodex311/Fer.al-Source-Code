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

public class ParlorManager : CasualGame<ParlorManager> // TypeDefIndex: 13095
{
	// Fields
	public Camera parlorCamera; // 0x28
	public ParlorUIManager uiManager; // 0x30
	public ParticleSystem gameOverWinEffect; // 0x38
	public Transform kinoLocator; // 0x40
	public ActorNPCSpawner kinoSpawner; // 0x48
	public ParlorGameBase[] parlorGames; // 0x50
	public float crystalZipAudioWait; // 0x58
	public int startingWager; // 0x5C
	public int startingFunds; // 0x60
	public bool alwaysShowTutorialFirstTime; // 0x64
	internal int maxWager; // 0x68
	internal ParlorGameBase currentParlorGame; // 0x70
	internal bool replayingParlorGame; // 0x78
	internal bool fakeServer; // 0x79
	internal Animator kinoAnimator; // 0x80
	internal EParlorState ParlorState; // 0x88
	private int _pot; // 0x8C
	private int _totalFunds; // 0x90
	private EWinState _winState; // 0x94
	private int _currentWager; // 0x98
	internal const string GameCommand = "gameCommand"; // Metadata: 0x007835F1

	// Properties
	internal int Pot { get; set; } // 0x00000001804D0670-0x00000001804D0680 0x000000018116EAD0-0x000000018116EB90
	internal int TotalFunds { get; set; } // 0x00000001804A1060-0x00000001804A1070 0x000000018116EB90-0x000000018116EBE0
	internal EWinState WinState { get; set; } // 0x00000001804D0680-0x00000001804D0690 0x000000018116EBE0-0x000000018116EDB0

	// Nested types
	public enum EParlorGame // TypeDefIndex: 13096
	{
		None = 0,
		QueensDuel = 1,
		FourCrows = 2,
		MothsAndFlames = 3,
		MoonPhases = 4
	}

	internal enum EParlorState // TypeDefIndex: 13097
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

	internal enum EWinState // TypeDefIndex: 13098
	{
		None = 0,
		Player = 1,
		Opponent = 2,
		Tie = 3
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 13099
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<bool> <>9__34_0; // 0x08
		public static Func<bool> <>9__34_2; // 0x10
		public static Func<bool> <>9__34_4; // 0x18

		// Constructors
		static <>c(); // 0x000000018117C300-0x000000018117C360
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <Start>b__34_0(); // 0x000000018117B5C0-0x000000018117B610
		internal bool <Start>b__34_2(); // 0x000000018117B610-0x000000018117B690
		internal bool <Start>b__34_4(); // 0x000000018117B690-0x000000018117B730
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <PlayerWin>d__53 : IEnumerator<object> // TypeDefIndex: 13100
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ParlorManager <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <PlayerWin>d__53(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181179F10-0x000000018117A090
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x000000018117A090-0x000000018117A2B0
	}

	// Constructors
	public ParlorManager(); // 0x000000018116EA60-0x000000018116EAD0

	// Methods
	protected override void Awake(); // 0x000000018116CBA0-0x000000018116CD30
	private void Start(); // 0x000000018116E180-0x000000018116E370
	protected override void OnDestroy(); // 0x000000018116D8E0-0x000000018116D980
	public void KinoSpawned(); // 0x000000018116D280-0x000000018116D4B0
	internal void PlaceWager(); // 0x000000018116DE80-0x000000018116DEA0
	private void OnMinigameMessage(ParlorGameCommand msg); // 0x000000018116D980-0x000000018116DAF0
	private void MultiplierResults(int inMultiplyerResults); // 0x000000018116D8B0-0x000000018116D8E0
	internal void SendServerMessage(params /* 0x00000001800B36B0-0x00000001800B36C0 */ string[] inData); // 0x000000018116E070-0x000000018116E080
	private void GameResponse(ParlorGameCommand parlorGameCommand); // 0x000000018116CFC0-0x000000018116D140
	internal void PlaySnap(); // 0x000000018116DFC0-0x000000018116E010
	private void SetupParlor(); // 0x000000018116E080-0x000000018116E180
	internal void LoadParlorGameRequest(); // 0x000000018116D700-0x000000018116D8B0
	internal void LoadParlorGameAccepted(int inMaxWager, int[] inAdditionalParameters = null); // 0x000000018116D4B0-0x000000018116D700
	internal void PlaceWagerRequest(); // 0x000000018116DCC0-0x000000018116DE80
	internal void PlayAgain(); // 0x000000018116DEA0-0x000000018116DF70
	private void WagerAccepted(int inAcceptedWager); // 0x000000018116E980-0x000000018116EA60
	internal void DoubleUpRequest(bool inAccept); // 0x000000018116CD30-0x000000018116CEB0
	private void DoubleUpResults(bool inIncreasePot); // 0x000000018116CEB0-0x000000018116CFB0
	internal void ParlorGameOver(); // 0x000000018116DAF0-0x000000018116DCC0
	internal void UnloadParlorGame(); // 0x000000018116E7E0-0x000000018116E980
	[IteratorStateMachine] // 0x00000001800E2C60-0x00000001800E2CB0
	internal IEnumerator PlayerWin(); // 0x000000018116E010-0x000000018116E070
	internal void ExitParlor(); // 0x000000018116CFB0-0x000000018116CFC0
	internal void PlayEffects(ParticleSystem inParticleSystem); // 0x000000018116DF70-0x000000018116DFC0
	internal string TimeIt(string inString); // 0x000000018116E370-0x000000018116E3F0
	internal bool HasSeenTutorial(string inGameName); // 0x000000018116D140-0x000000018116D280
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Start>b__34_1(); // 0x000000018116E450-0x000000018116E630
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Start>b__34_3(); // 0x000000018116E630-0x000000018116E640
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Start>b__34_5(); // 0x000000018116E640-0x000000018116E6D0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <ParlorGameOver>b__51_0(); // 0x000000018116E3F0-0x000000018116E450
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <UnloadParlorGame>b__52_0(); // 0x000000018116E6D0-0x000000018116E7E0
}

