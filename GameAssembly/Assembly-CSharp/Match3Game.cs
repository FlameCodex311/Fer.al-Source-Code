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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class Match3Game : CasualGame<Match3Game> // TypeDefIndex: 10619
{
	// Fields
	public const int LEVEL_PRIZE_LIST_INDEX = 0; // Metadata: 0x0077BF60
	[RootSelectorCompact] // 0x00000001801D1BA0-0x00000001801D1C00
	public string LevelDefId; // 0x30
	public Match3GameBoard gameBoard; // 0x38
	public Match3UI ui; // 0x40
	public Match3LevelData levelData; // 0x48
	public Match3LevelObjectiveTracker levelTracker; // 0x50
	public PersistentAtomController persistentAtomController; // 0x58
	public Match3AchievementRewardController achievementRewardController; // 0x60
	[Header] // 0x00000001801D1DA0-0x00000001801D1DD0
	public CachedUserVar tutorialSeenUserVar; // 0x68
	[Header] // 0x0000000180232870-0x00000001802328A0
	public ObscuredIntReference playerScore; // 0x70
	public ObscuredIntReference playerHighScore; // 0x78
	public ObscuredIntReference totalScore; // 0x80
	public ObscuredIntReference playerPowerupMeter; // 0x88
	public ObscuredIntConstant powerupMax; // 0x90
	public ObscuredIntConstant powerupIncrement; // 0x98
	[Header] // 0x0000000180232A80-0x0000000180232AB0
	public VoidEvent startGameEvent; // 0xA0
	public IntEvent startLevelEvent; // 0xA8
	public VoidEvent powerupReadyEvent; // 0xB0
	public VoidEvent powerupHatchedEvent; // 0xB8
	public VoidEvent gameOverEvent; // 0xC0
	private readonly IDictionary<Match3Reward, int> _rewardsCountLookup; // 0xC8
	private ObscuredInt _currentLevelIndex; // 0xD0
	private ObscuredInt _prevPlayerScoreSent; // 0xE4
	private int totalGames; // 0xF8
	private float totalMoveCount; // 0xFC
	private List<int> allMoveCounts; // 0x100
	private int minMoveGame; // 0x108
	private int maxMoveGame; // 0x10C
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Match3DefComponent <GameData>k__BackingField; // 0x110

	// Properties
	public bool HasShownTutorial { get; set; } // 0x0000000180505DC0-0x0000000180505DF0 0x0000000180505EF0-0x0000000180505F20
	public int MoveCountAverage { get; } // 0x0000000180505DF0-0x0000000180505E80 
	public int MoveCountMedian { get; } // 0x0000000180505E80-0x0000000180505EF0 
	public int CurrentLevelIndex { get; } // 0x0000000180505D90-0x0000000180505DC0 
	public Match3DefComponent GameData { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180385320-0x0000000180385330 0x00000001804846D0-0x00000001804846E0

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 10620
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<bool> <>9__41_0; // 0x08
		public static Func<bool> <>9__41_2; // 0x10
		public static Func<bool> <>9__41_4; // 0x18

		// Constructors
		static <>c(); // 0x00000001805094C0-0x0000000180509520
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <Start>b__41_0(); // 0x0000000180509130-0x0000000180509280
		internal bool <Start>b__41_2(); // 0x0000000180509280-0x0000000180509300
		internal bool <Start>b__41_4(); // 0x0000000180509300-0x0000000180509370
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <DoLevelComplete>d__59 : IEnumerator<object> // TypeDefIndex: 10621
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Match3Game <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <DoLevelComplete>d__59(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180506170-0x0000000180506370
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180506370-0x0000000180506C50
	}

	// Constructors
	public Match3Game(); // 0x0000000180505CF0-0x0000000180505D90

	// Methods
	private void Start(); // 0x0000000180505480-0x0000000180505600
	private void LoadSavedValues(); // 0x0000000180503FF0-0x0000000180504010
	private void SaveSavedValues(); // 0x0000000180504F70-0x0000000180504F90
	protected override void OnDestroy(); // 0x0000000180504250-0x0000000180504310
	public void StartGame(); // 0x00000001805050F0-0x0000000180505480
	public void ExitGame(); // 0x0000000180503F00-0x0000000180503F20
	private void Update(); // 0x0000000180505CE0-0x0000000180505CF0
	private void UpdateUI(); // 0x0000000180505950-0x0000000180505CE0
	public void OnBoosterActivated(); // 0x0000000180504010-0x0000000180504250
	public void OnPowerupUsed(); // 0x0000000180504B20-0x0000000180504B90
	private void ResetPowerupMeter(); // 0x0000000180504E60-0x0000000180504F70
	public void OnScoreUpdated(ObscuredInt inCurrentScore, ObscuredInt inOldScore); // 0x0000000180504C60-0x0000000180504E60
	public void GoToNextLevel(); // 0x0000000180503F20-0x0000000180503FF0
	private void OnScoreLevelObjectiveUpdated(); // 0x0000000180504B90-0x0000000180504C60
	public void OnGameBoardMoveComplete(); // 0x0000000180504310-0x0000000180504700
	private void TriggerGameOver(); // 0x0000000180505600-0x0000000180505660
	public void OnGameOver(); // 0x0000000180504700-0x0000000180504920
	public void ShowLevelProgress(); // 0x0000000180504F90-0x00000001805050F0
	[IteratorStateMachine] // 0x0000000180233100-0x0000000180233150
	private IEnumerator DoLevelComplete(); // 0x0000000180503EA0-0x0000000180503F00
	private void OnMinigamePrizeGiven(MinigamePrizeGiven message); // 0x0000000180504920-0x0000000180504B20
	[DeMethodButton] // 0x0000000180233480-0x00000001802334E0
	private void DebugResetHighScore(); // 0x0000000180503D30-0x0000000180503D70
	[DeMethodButton] // 0x0000000180233930-0x0000000180233990
	private void DebugScreenCapture(); // 0x0000000180503D70-0x0000000180503EA0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Start>b__41_1(); // 0x0000000180505660-0x0000000180505850
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Start>b__41_3(); // 0x0000000180505850-0x00000001805058C0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Start>b__41_5(); // 0x00000001805058C0-0x0000000180505950
}

