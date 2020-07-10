/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using DG.DeInspektor.Attributes;
using UnityAtoms;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class Match3Game : CasualGame<Match3Game> // TypeDefIndex: 12954
{
	// Fields
	public const int LEVEL_PRIZE_LIST_INDEX = 0; // Metadata: 0x007834A5
	[RootSelectorCompact] // 0x00000001800FF260-0x00000001800FF2C0
	public string LevelDefId; // 0x28
	public Match3GameBoard gameBoard; // 0x30
	public Match3UI ui; // 0x38
	public Match3LevelData levelData; // 0x40
	public Match3LevelObjectiveTracker levelTracker; // 0x48
	public PersistentAtomController persistentAtomController; // 0x50
	public Match3AchievementRewardController achievementRewardController; // 0x58
	[Header] // 0x00000001800FF4E0-0x00000001800FF510
	public CachedUserVar tutorialSeenUserVar; // 0x60
	[Header] // 0x00000001801541C0-0x00000001801541F0
	public ObscuredIntReference playerScore; // 0x68
	public ObscuredIntReference playerHighScore; // 0x70
	public ObscuredIntReference totalScore; // 0x78
	public ObscuredIntReference playerPowerupMeter; // 0x80
	public ObscuredIntConstant powerupMax; // 0x88
	public ObscuredIntConstant powerupIncrement; // 0x90
	[Header] // 0x0000000180154340-0x0000000180154370
	public VoidEvent startGameEvent; // 0x98
	public IntEvent startLevelEvent; // 0xA0
	public VoidEvent powerupReadyEvent; // 0xA8
	public VoidEvent powerupHatchedEvent; // 0xB0
	public VoidEvent gameOverEvent; // 0xB8
	private readonly IDictionary<Match3Reward, int> _rewardsCountLookup; // 0xC0
	private ObscuredInt _currentLevelIndex; // 0xC8
	private int totalGames; // 0xDC
	private float totalMoveCount; // 0xE0
	private List<int> allMoveCounts; // 0xE8
	private int minMoveGame; // 0xF0
	private int maxMoveGame; // 0xF4
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private Match3DefComponent <GameData>k__BackingField; // 0xF8

	// Properties
	public bool HasShownTutorial { get; set; } // 0x00000001816CD0A0-0x00000001816CD0D0 0x00000001816CD1D0-0x00000001816CD200
	public int MoveCountAverage { get; } // 0x00000001816CD0D0-0x00000001816CD160 
	public int MoveCountMedian { get; } // 0x00000001816CD160-0x00000001816CD1D0 
	public int CurrentLevelIndex { get; } // 0x00000001816CD070-0x00000001816CD0A0 
	public Match3DefComponent GameData { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001803BD310-0x00000001803BD320 0x00000001803BE530-0x00000001803BE540

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12955
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<bool> <>9__40_0; // 0x08
		public static Func<bool> <>9__40_2; // 0x10
		public static Func<bool> <>9__40_4; // 0x18

		// Constructors
		static <>c(); // 0x00000001816D5B30-0x00000001816D5B90
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <Start>b__40_0(); // 0x00000001816D5760-0x00000001816D58B0
		internal bool <Start>b__40_2(); // 0x00000001816D58B0-0x00000001816D5930
		internal bool <Start>b__40_4(); // 0x00000001816D5930-0x00000001816D59A0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <DoLevelComplete>d__58 : IEnumerator<object> // TypeDefIndex: 12956
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Match3Game <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <DoLevelComplete>d__58(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001816D0E00-0x00000001816D1120
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001816D1120-0x00000001816D3100
	}

	// Constructors
	public Match3Game(); // 0x00000001816CCFD0-0x00000001816CD070

	// Methods
	private void Start(); // 0x00000001816CC730-0x00000001816CC8C0
	private void LoadSavedValues(); // 0x00000001816CB3F0-0x00000001816CB410
	private void SaveSavedValues(); // 0x00000001816CC230-0x00000001816CC250
	protected override void OnDestroy(); // 0x00000001816CB660-0x00000001816CB720
	public void StartGame(); // 0x00000001816CC3C0-0x00000001816CC730
	public void ExitGame(); // 0x00000001816CB300-0x00000001816CB320
	private void Update(); // 0x00000001816CCFC0-0x00000001816CCFD0
	private void UpdateUI(); // 0x00000001816CCC20-0x00000001816CCFC0
	public void OnBoosterActivated(); // 0x00000001816CB410-0x00000001816CB660
	public void OnPowerupUsed(); // 0x00000001816CBDD0-0x00000001816CBE40
	private void ResetPowerupMeter(); // 0x00000001816CC120-0x00000001816CC230
	public void OnScoreUpdated(ObscuredInt inCurrentScore, ObscuredInt inOldScore); // 0x00000001816CBF20-0x00000001816CC120
	public void GoToNextLevel(); // 0x00000001816CB320-0x00000001816CB3F0
	private void OnScoreLevelObjectiveUpdated(); // 0x00000001816CBE40-0x00000001816CBF20
	public void OnGameBoardMoveComplete(); // 0x00000001816CB720-0x00000001816CB9A0
	private void TriggerGameOver(); // 0x00000001816CC8C0-0x00000001816CC930
	public void OnGameOver(); // 0x00000001816CB9A0-0x00000001816CBBC0
	public void ShowLevelProgress(); // 0x00000001816CC250-0x00000001816CC3C0
	[IteratorStateMachine] // 0x0000000180154AB0-0x0000000180154B00
	private IEnumerator DoLevelComplete(); // 0x00000001816CB2A0-0x00000001816CB300
	private void OnMinigamePrizeGiven(MinigamePrizeGiven message); // 0x00000001816CBBC0-0x00000001816CBDD0
	[DeMethodButton] // 0x0000000180154D10-0x0000000180154D70
	private void DebugResetHighScore(); // 0x00000001816CB120-0x00000001816CB160
	[DeMethodButton] // 0x0000000180155120-0x0000000180155180
	private void DebugScreenCapture(); // 0x00000001816CB160-0x00000001816CB2A0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Start>b__40_1(); // 0x00000001816CC930-0x00000001816CCB20
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Start>b__40_3(); // 0x00000001816CCB20-0x00000001816CCB90
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Start>b__40_5(); // 0x00000001816CCB90-0x00000001816CCC20
}

