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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class BuildersFollyGame : CasualGame<BuildersFollyGame> // TypeDefIndex: 10457
{
	// Fields
	public float unitMoveTime; // 0x30
	internal float moveTime; // 0x34
	internal float unitMoveScaler; // 0x38
	[Tooltip] // 0x00000001801F7CE0-0x00000001801F7D10
	public int stationMoveWaits; // 0x3C
	internal EGameMode gameMode; // 0x40
	[RootSelectorCompact] // 0x00000001801D1BA0-0x00000001801D1C00
	public string levelDefId; // 0x48
	public CachedUserVar levelScoresUserVar; // 0x50
	public CachedUserVar expertLevelScoresUserVar; // 0x58
	[Space] // 0x00000001801D3D10-0x00000001801D3D30
	public BuildersFollyResource junkResource; // 0x60
	[Header] // 0x00000001801F9530-0x00000001801F9560
	public BuildersFollyUIManager uiManager; // 0x68
	public BuildersFollyGridManager gridManager; // 0x70
	public BuildersFollyInputManager inputManager; // 0x78
	public BuildersFollyTileManager tileManager; // 0x80
	public BuildersFollyTwiggleManager twiggleManager; // 0x88
	[Space] // 0x00000001801D3D10-0x00000001801D3D30
	public BuildersFollyData_Scriptable buildersFollyData; // 0x90
	public Camera gameCamera; // 0x98
	public Transform worldCrates; // 0xA0
	[Space] // 0x00000001801D3D10-0x00000001801D3D30
	public float fastForwardSpeed; // 0xA8
	public float autoContinueDelay; // 0xAC
	public int tutorial2Level; // 0xB0
	private bool _expertModeUnlocked; // 0xB4
	[Header] // 0x00000001801D1FE0-0x00000001801D2010
	public bool showDevTools; // 0xB5
	public bool unlockAllLevels; // 0xB6
	public bool skipWalkthrough; // 0xB7
	public int minimumStarsToAward; // 0xB8
	public int setNormalHighScoresMaxLevel; // 0xBC
	public int setExpertHighScoresMaxLevel; // 0xC0
	private bool _showDevTools; // 0xC4
	internal EgameState gameState; // 0xC8
	internal EWalkthroughState walkthrougState; // 0xCC
	internal bool playWalkthrough1; // 0xD0
	internal bool playWalkthrough2; // 0xD1
	internal bool firstTimeTo3stars; // 0xD2
	internal bool _fastForward; // 0xD3
	internal bool fakeServer; // 0xD4
	internal float normalTimeScale; // 0xD8
	internal ObscuredInt selectedLevelIndex; // 0xDC
	internal ObscuredInt selectedExpertLevelIndex; // 0xF0
	internal ObscuredInt levelPoints; // 0x104
	internal BuildersFollyPathManager pathManager; // 0x118
	internal BuildersFollyLevel_Scriptable currentLevelData; // 0x120
	internal Reward[] rewards; // 0x128
	private string _scoreTrack; // 0x130
	private Stopwatch stopWatch; // 0x138
	private string _outFileName; // 0x140

	// Properties
	internal EgameState GameState { get; set; } // 0x00000001804E4DD0-0x00000001804E4DE0 0x0000000182139F60-0x000000018213A070
	internal EWalkthroughState WalkthrougState { get; set; } // 0x00000001806479E0-0x00000001806479F0 0x0000000181890AD0-0x0000000181890AE0
	internal bool FastForward { get; set; } // 0x0000000182139F20-0x0000000182139F30 0x0000000182139F30-0x0000000182139F60

	// Nested types
	internal enum EGameMode // TypeDefIndex: 10458
	{
		Normal = 0,
		Expert = 1
	}

	internal enum EgameState // TypeDefIndex: 10459
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

	internal enum EWalkthroughState // TypeDefIndex: 10460
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

	internal struct Reward // TypeDefIndex: 10461
	{
		// Fields
		internal string rewardDef; // 0x00
		internal int rewardCount; // 0x08
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 10462
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<bool> <>9__63_0; // 0x08
		public static Func<bool> <>9__63_2; // 0x10

		// Constructors
		static <>c(); // 0x000000018214C400-0x000000018214C460
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <Start>b__63_0(); // 0x000000018214C2A0-0x000000018214C360
		internal bool <Start>b__63_2(); // 0x000000018214C360-0x000000018214C400
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <StartSetup>d__76 : IEnumerator<object> // TypeDefIndex: 10463
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public BuildersFollyGame <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <StartSetup>d__76(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018214B940-0x000000018214C210
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018214C210-0x000000018214C260
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <ResourceDelivered>d__85 : IEnumerator<object> // TypeDefIndex: 10464
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public BuildersFollyGame <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <ResourceDelivered>d__85(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018214ADF0-0x000000018214AFC0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018214AFC0-0x000000018214B010
	}

	// Constructors
	public BuildersFollyGame(); // 0x0000000182139E00-0x0000000182139F20

	// Methods
	[DeMethodButton] // 0x00000001801F9C90-0x00000001801F9CF0
	private void OutputLevelGoals(); // 0x00000001803774A0-0x00000001803774B0
	private string GetLevelGoals(BuildersFollyLevel_Scriptable[] inLevels); // 0x0000000182133FE0-0x00000001821352C0
	private string GetMismatch(string inResource, int inNeed, int inHave); // 0x00000001821352C0-0x00000001821355D0
	private string GetInput(BuildersFollyResource inBuildersFollyResource, string inIndent, ref List<BuildersFollyResource> refResourcesNeeded, ref List<BuildersFollyData.EStationType> refStationsNeeded); // 0x00000001821339C0-0x0000000182133FE0
	private string GetStationMatchInfo(int inCount, BuildersFollyData.EStationType inStationType, ref List<BuildersFollyData.EStationType> refStationsNeeded); // 0x0000000182135990-0x0000000182135B60
	private int GetEntry(BuildersFollyResource inBuildersFollyResource); // 0x0000000182133760-0x00000001821339C0
	[DeMethodButton] // 0x00000001801FA080-0x00000001801FA0E0
	private void SetHighScores(); // 0x00000001803774A0-0x00000001803774B0
	protected override void Awake(); // 0x00000001821335D0-0x0000000182133620
	private void Start(); // 0x0000000182138170-0x0000000182138950
	private void Update(); // 0x0000000182139CB0-0x0000000182139E00
	protected override void OnDestroy(); // 0x0000000182136680-0x0000000182136770
	private void OnMinigamePrizeGiven(MinigamePrizeGiven msg); // 0x00000001803774A0-0x00000001803774B0
	private void OnMinigamePrizeSelected(MinigamePrizeSelected msg); // 0x0000000182136770-0x00000001821367E0
	internal void ReloadLevel(); // 0x0000000182136AD0-0x0000000182136EF0
	public void SelectPrize(int inLootListIndex, int inListIndex); // 0x0000000182137C00-0x0000000182137C60
	public void RedeemPrize(int inLootListIndex, int inListIndex); // 0x0000000182136880-0x00000001821368E0
	internal void SetCurrentLevel(); // 0x0000000182137DF0-0x0000000182137EE0
	internal void PlayWalkthrough1(); // 0x00000001821367E0-0x0000000182136830
	internal void PlayWalkthrough2(); // 0x0000000182136830-0x0000000182136880
	private void InitLevels(BuildersFollyLevel_Scriptable[] inLevels, EGameMode inGameMode); // 0x0000000182135B60-0x0000000182136020
	private void SelectPrizes(int inLootListIndex); // 0x0000000182137C60-0x0000000182137DF0
	[IteratorStateMachine] // 0x00000001801FA440-0x00000001801FA490
	public IEnumerator StartSetup(); // 0x0000000182138110-0x0000000182138170
	private int GetPrizeIndex(); // 0x00000001821355D0-0x0000000182135990
	internal void TutorialComplete1(); // 0x0000000182138950-0x0000000182138A20
	internal void TutorialComplete2(); // 0x0000000182138A20-0x0000000182138B00
	internal void StartPlay(); // 0x0000000182137FE0-0x0000000182138110
	internal BuildersFollyResource UpdateInfoOutput(BuildersFollyStationTile inStationTile, bool inLeft = true /* Metadata: 0x0077BC0F */); // 0x0000000182138C60-0x0000000182139CB0
	public void ExitGame(); // 0x00000001804D9E70-0x00000001804D9E80
	internal void SaveData(); // 0x0000000182136FA0-0x0000000182137C00
	internal void LevelSetup(); // 0x0000000182136020-0x00000001821360B0
	[IteratorStateMachine] // 0x00000001801FA770-0x00000001801FA7C0
	internal IEnumerator ResourceDelivered(); // 0x0000000182136EF0-0x0000000182136F50
	private void ClearData(BuildersFollyLevel_Scriptable.RowInfo[] inRowInfo); // 0x0000000182133620-0x0000000182133760
	private void SetData(BuildersFollyLevel_Scriptable.RowInfo[] inRowInfo, BuildersFollyTile inTile); // 0x0000000182137EE0-0x0000000182137FE0
	private void RedeemPrizes(int inLootListIndex); // 0x00000001821368E0-0x0000000182136AD0
	internal void RewardsRedeemed(); // 0x0000000182136F50-0x0000000182136FA0
	internal bool NextLevel(); // 0x00000001821363E0-0x0000000182136680
	private void LogIt(); // 0x00000001821360B0-0x00000001821363E0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Start>b__63_1(); // 0x0000000182138B00-0x0000000182138B90
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Start>b__63_3(); // 0x0000000182138B90-0x0000000182138C60
}

