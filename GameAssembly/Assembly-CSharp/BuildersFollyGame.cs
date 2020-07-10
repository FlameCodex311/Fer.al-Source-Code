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
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class BuildersFollyGame : CasualGame<BuildersFollyGame> // TypeDefIndex: 12799
{
	// Fields
	public float unitMoveTime; // 0x28
	internal float moveTime; // 0x2C
	internal float unitMoveScaler; // 0x30
	[Tooltip] // 0x0000000180125180-0x00000001801251B0
	public int stationMoveWaits; // 0x34
	internal EGameMode gameMode; // 0x38
	[RootSelectorCompact] // 0x00000001800FF260-0x00000001800FF2C0
	public string levelDefId; // 0x40
	public CachedUserVar levelScoresUserVar; // 0x48
	public CachedUserVar expertLevelScoresUserVar; // 0x50
	[Space] // 0x00000001800C6850-0x00000001800C6870
	public BuildersFollyResource junkResource; // 0x58
	[Header] // 0x00000001800F1570-0x00000001800F15A0
	public BuildersFollyUIManager uiManager; // 0x60
	public BuildersFollyGridManager gridManager; // 0x68
	public BuildersFollyInputManager inputManager; // 0x70
	public BuildersFollyTileManager tileManager; // 0x78
	public BuildersFollyTwiggleManager twiggleManager; // 0x80
	[Space] // 0x00000001800C6850-0x00000001800C6870
	public BuildersFollyData_Scriptable buildersFollyData; // 0x88
	public Camera gameCamera; // 0x90
	public Transform worldCrates; // 0x98
	[Space] // 0x00000001800C6850-0x00000001800C6870
	public float fastForwardSpeed; // 0xA0
	public float autoContinueDelay; // 0xA4
	public int tutorial2Level; // 0xA8
	private bool _expertModeUnlocked; // 0xAC
	[Header] // 0x00000001800FF680-0x00000001800FF6B0
	public bool showDevTools; // 0xAD
	public bool unlockAllLevels; // 0xAE
	public bool skipWalkthrough; // 0xAF
	public int minimumStarsToAward; // 0xB0
	public int setNormalHighScoresMaxLevel; // 0xB4
	public int setExpertHighScoresMaxLevel; // 0xB8
	private bool _showDevTools; // 0xBC
	internal EgameState gameState; // 0xC0
	internal EWalkthroughState walkthrougState; // 0xC4
	internal bool playWalkthrough1; // 0xC8
	internal bool playWalkthrough2; // 0xC9
	internal bool firstTimeTo3stars; // 0xCA
	internal bool _fastForward; // 0xCB
	internal bool fakeServer; // 0xCC
	internal float normalTimeScale; // 0xD0
	internal ObscuredInt selectedLevelIndex; // 0xD4
	internal ObscuredInt selectedExpertLevelIndex; // 0xE8
	internal ObscuredInt levelPoints; // 0xFC
	internal BuildersFollyPathManager pathManager; // 0x110
	internal BuildersFollyLevel_Scriptable currentLevelData; // 0x118
	internal Reward[] rewards; // 0x120
	private string _scoreTrack; // 0x128
	private Stopwatch stopWatch; // 0x130
	private string _outFileName; // 0x138

	// Properties
	internal EgameState GameState { get; set; } // 0x00000001804288C0-0x00000001804288D0 0x00000001814D9910-0x00000001814D9A20
	internal EWalkthroughState WalkthrougState { get; set; } // 0x0000000180A24AA0-0x0000000180A24AB0 0x00000001814D9A20-0x00000001814D9A30
	internal bool FastForward { get; set; } // 0x00000001814D98D0-0x00000001814D98E0 0x00000001814D98E0-0x00000001814D9910

	// Nested types
	internal enum EGameMode // TypeDefIndex: 12800
	{
		Normal = 0,
		Expert = 1
	}

	internal enum EgameState // TypeDefIndex: 12801
	{
		splashScreen = 0,
		tutorial = 1,
		autoTutorial = 2,
		levelSelect = 3,
		design = 4,
		running = 5,
		paused = 6,
		reward = 7,
		walkthrough1 = 8,
		walkthrough2 = 9
	}

	internal enum EWalkthroughState // TypeDefIndex: 12802
	{
		none = 0,
		intro = 1,
		showGoals = 2,
		showResources = 3,
		showResourceCounters = 4,
		showLogs = 5,
		clickToDragLogPath = 6,
		dragLogPath = 7,
		pressPlay1 = 8,
		building1 = 9,
		complete1 = 10,
		showCutStation = 11,
		clickToDragStation = 12,
		dragStation = 13,
		showRotate = 14,
		showFlip = 15,
		clickToDragResourcePath = 16,
		dragPathToStation = 17,
		pathIntro = 18,
		showStationInfo = 19,
		showEditInfo = 20,
		showInput = 21,
		showOutput = 22,
		showOptionArrows = 23,
		changeOption = 24,
		dragPathFromStationToDeliver = 25,
		pressPlay2 = 26,
		building2 = 27,
		complete2 = 28
	}

	internal struct Reward // TypeDefIndex: 12803
	{
		// Fields
		internal string rewardDef; // 0x00
		internal int rewardCount; // 0x08
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12804
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<bool> <>9__63_0; // 0x08
		public static Func<bool> <>9__63_2; // 0x10

		// Constructors
		static <>c(); // 0x00000001814EF100-0x00000001814EF160
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <Start>b__63_0(); // 0x00000001814EEFA0-0x00000001814EF060
		internal bool <Start>b__63_2(); // 0x00000001814EF060-0x00000001814EF100
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <StartSetup>d__76 : IEnumerator<object> // TypeDefIndex: 12805
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public BuildersFollyGame <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <StartSetup>d__76(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001814EE590-0x00000001814EEF40
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001814EEF40-0x00000001814EEF90
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <ResourceDelivered>d__85 : IEnumerator<object> // TypeDefIndex: 12806
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public BuildersFollyGame <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <ResourceDelivered>d__85(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001814EDA10-0x00000001814EDBF0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001814EDBF0-0x00000001814EDC40
	}

	// Constructors
	public BuildersFollyGame(); // 0x00000001814D9770-0x00000001814D98D0

	// Methods
	[DeMethodButton] // 0x0000000180126EF0-0x0000000180126F50
	private void OutputLevelGoals(); // 0x00000001803581E0-0x00000001803581F0
	private string GetLevelGoals(BuildersFollyLevel_Scriptable[] inLevels); // 0x00000001814D3580-0x00000001814D4950
	private string GetMismatch(string inResource, int inNeed, int inHave); // 0x00000001814D4950-0x00000001814D4C90
	private string GetInput(BuildersFollyResource inBuildersFollyResource, string inIndent, ref List<BuildersFollyResource> refResourcesNeeded, ref List<BuildersFollyData.EStationType> refStationsNeeded); // 0x00000001814D2F20-0x00000001814D3580
	private string GetStationMatchInfo(int inCount, BuildersFollyData.EStationType inStationType, ref List<BuildersFollyData.EStationType> refStationsNeeded); // 0x00000001814D5080-0x00000001814D5250
	private int GetEntry(BuildersFollyResource inBuildersFollyResource); // 0x00000001814D2CA0-0x00000001814D2F20
	[DeMethodButton] // 0x00000001801270B0-0x0000000180127110
	private void SetHighScores(); // 0x00000001803581E0-0x00000001803581F0
	protected override void Awake(); // 0x00000001814D2AF0-0x00000001814D2B40
	private void Start(); // 0x00000001814D7970-0x00000001814D8190
	private void Update(); // 0x00000001814D9620-0x00000001814D9770
	protected override void OnDestroy(); // 0x00000001814D5DF0-0x00000001814D5EE0
	private void OnMinigamePrizeGiven(MinigamePrizeGiven msg); // 0x00000001803581E0-0x00000001803581F0
	private void OnMinigamePrizeSelected(MinigamePrizeSelected msg); // 0x00000001814D5EE0-0x00000001814D5F50
	internal void ReloadLevel(); // 0x00000001814D6240-0x00000001814D6670
	public void SelectPrize(int inLootListIndex, int inListIndex); // 0x00000001814D73D0-0x00000001814D7430
	public void RedeemPrize(int inLootListIndex, int inListIndex); // 0x00000001814D5FF0-0x00000001814D6050
	internal void SetCurrentLevel(); // 0x00000001814D75C0-0x00000001814D76C0
	internal void PlayWalkthrough1(); // 0x00000001814D5F50-0x00000001814D5FA0
	internal void PlayWalkthrough2(); // 0x00000001814D5FA0-0x00000001814D5FF0
	private void InitLevels(BuildersFollyLevel_Scriptable[] inLevels, EGameMode inGameMode); // 0x00000001814D5250-0x00000001814D5750
	private void SelectPrizes(int inLootListIndex); // 0x00000001814D7430-0x00000001814D75C0
	[IteratorStateMachine] // 0x0000000180127340-0x0000000180127390
	public IEnumerator StartSetup(); // 0x00000001814D7910-0x00000001814D7970
	private int GetPrizeIndex(); // 0x00000001814D4C90-0x00000001814D5080
	internal void TutorialComplete1(); // 0x00000001814D8190-0x00000001814D8270
	internal void TutorialComplete2(); // 0x00000001814D8270-0x00000001814D8350
	internal void StartPlay(); // 0x00000001814D77E0-0x00000001814D7910
	internal BuildersFollyResource UpdateInfoOutput(BuildersFollyStationTile inStationTile, bool inLeft = true /* Metadata: 0x00783164 */); // 0x00000001814D84B0-0x00000001814D9620
	public void ExitGame(); // 0x000000018116CFB0-0x000000018116CFC0
	internal void SaveData(); // 0x00000001814D6720-0x00000001814D73D0
	internal void LevelSetup(); // 0x00000001814D5750-0x00000001814D57E0
	[IteratorStateMachine] // 0x0000000180127650-0x00000001801276A0
	internal IEnumerator ResourceDelivered(); // 0x00000001814D6670-0x00000001814D66D0
	private void ClearData(BuildersFollyLevel_Scriptable.RowInfo[] inRowInfo); // 0x00000001814D2B40-0x00000001814D2CA0
	private void SetData(BuildersFollyLevel_Scriptable.RowInfo[] inRowInfo, BuildersFollyTile inTile); // 0x00000001814D76C0-0x00000001814D77E0
	private void RedeemPrizes(int inLootListIndex); // 0x00000001814D6050-0x00000001814D6240
	internal void RewardsRedeemed(); // 0x00000001814D66D0-0x00000001814D6720
	internal bool NextLevel(); // 0x00000001814D5B40-0x00000001814D5DF0
	private void LogIt(); // 0x00000001814D57E0-0x00000001814D5B40
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Start>b__63_1(); // 0x00000001814D8350-0x00000001814D83E0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Start>b__63_3(); // 0x00000001814D83E0-0x00000001814D84B0
}

