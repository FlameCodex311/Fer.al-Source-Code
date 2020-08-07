/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using TMPro;
using UnityAtoms;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class Match3UI : MonoBehaviour // TypeDefIndex: 10665
{
	// Fields
	public Match3Game game; // 0x20
	public WWTextMeshProUGUI totalGamesText; // 0x28
	public WWTextMeshProUGUI averageMovesText; // 0x30
	public WWTextMeshProUGUI medianMovesText; // 0x38
	public WWTextMeshProUGUI leastMovesText; // 0x40
	public WWTextMeshProUGUI mostMovesText; // 0x48
	public WWTextMeshProUGUI currentMoveText; // 0x50
	public WWTextMeshProUGUI availableMovesText; // 0x58
	public WWTextMeshProUGUI scoreText; // 0x60
	public WWTextMeshProUGUI levelCountText; // 0x68
	public WWTextMeshProUGUI highScoreText; // 0x70
	public WWImage levelScoreFillbar; // 0x78
	public WWImage powerUpFillbar; // 0x80
	public ParticleSystem scoreMeterFx; // 0x88
	public GameObject scoreMeterFxFloor; // 0x90
	public GameObject scoreMeterFxCeiling; // 0x98
	public GameObject splashScreen; // 0xA0
	public FeralButton startButton; // 0xA8
	public GameObject powerupReady; // 0xB0
	public GameObject powerupDisabled; // 0xB8
	public GameObject hud; // 0xC0
	public UI_CasualGameSlideshow tutorialSlideshow; // 0xC8
	public Match3UI_PuzzleList puzzleList; // 0xD0
	public Match3UI_PuzzleGallery puzzleGallery; // 0xD8
	public GameObject quitConfirmation; // 0xE0
	public GameObject levelCompleteFx; // 0xE8
	public GameObject dizzyBirdActivateFx; // 0xF0
	public GameObject doublePeacockClearFx; // 0xF8
	public string levelObjectiveTweenUI; // 0x100
	public GameObject singleObjectiveContainer; // 0x108
	public GameObject doubleObjectiveContainer; // 0x110
	public LevelObjectiveUIGroup singleObjective; // 0x118
	public LevelObjectiveUIGroup doubleObjective1; // 0x120
	public LevelObjectiveUIGroup doubleObjective2; // 0x128
	public Match3UI_ResultsScreen resultsScreen; // 0x130
	public WWTextMeshProUGUI rewardCounter; // 0x138
	public Match3UI_RewardToast rewardToast; // 0x140
	public Match3UI_ScoreFlashup scoreFlashup; // 0x148
	public VoidEvent powerupUsedEvent; // 0x150
	private int _unreadRewardCount; // 0x158

	// Nested types
	[Serializable]
	public class LevelObjectiveUIGroup // TypeDefIndex: 10666
	{
		// Fields
		public WWImage icon; // 0x10
		public WWTextMeshProUGUI label; // 0x18
		public WWTextMeshProUGUI value; // 0x20
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Match3LevelObjectiveType <currentObjectiveType>k__BackingField; // 0x28

		// Properties
		public Match3LevelObjectiveType currentObjectiveType { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x000000018043C680-0x000000018043C690 0x000000018041A3A0-0x000000018041A3B0

		// Constructors
		public LevelObjectiveUIGroup(); // 0x0000000180373240-0x0000000180373250
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 10667
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<bool> <>9__41_0; // 0x08
		public static Func<bool> <>9__46_0; // 0x10
		public static Action <>9__46_1; // 0x18
		public static Action <>9__68_0; // 0x20

		// Constructors
		static <>c(); // 0x00000001807F1510-0x00000001807F1570
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <Start>b__41_0(); // 0x00000001807F0D30-0x00000001807F0DD0
		internal bool <ShowSplashScreen>b__46_0(); // 0x00000001807F0C80-0x00000001807F0D20
		internal void <ShowSplashScreen>b__46_1(); // 0x00000001807F0D20-0x00000001807F0D30
		internal void <SetPowerUpFill>b__68_0(); // 0x00000001807F0C70-0x00000001807F0C80
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass69_0 // TypeDefIndex: 10668
	{
		// Fields
		public Action onUpdate; // 0x10
		public Action onComplete; // 0x18

		// Constructors
		public <>c__DisplayClass69_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <SetImageFill>b__0(); // 0x00000001807F1140-0x00000001807F1160
		internal void <SetImageFill>b__1(); // 0x00000001807F1160-0x00000001807F1180
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass72_0 // TypeDefIndex: 10669
	{
		// Fields
		public int levelIndex; // 0x10
		public Match3UI <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass72_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <GetRewardIndex>b__0(Match3LevelReward reward); // 0x00000001807F1220-0x00000001807F1280
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <DoScoreFlashup>d__87 : IEnumerator<object> // TypeDefIndex: 10670
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Match3UI <>4__this; // 0x20
		public Vector3 inPosition; // 0x28
		public int inScore; // 0x34
		public Color inColor; // 0x38
		public bool doMovement; // 0x48
		private Match3UI_ScoreFlashup <newFlashup>5__2; // 0x50

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <DoScoreFlashup>d__87(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001807EC1F0-0x00000001807EC540
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001807EC540-0x00000001807EE540
	}

	// Constructors
	public Match3UI(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void Start(); // 0x00000001807EA200-0x00000001807EA390
	private void OnDestroy(); // 0x00000001807E47B0-0x00000001807E4840
	private void HideAllScreens(); // 0x00000001807E42C0-0x00000001807E4480
	private void SetScreenVisible(GameObject inScreen, bool inVisible); // 0x00000001807E9CD0-0x00000001807E9D50
	public void HideSplashScreen(); // 0x00000001807E4640-0x00000001807E46C0
	public void ShowSplashScreen(); // 0x00000001807EA010-0x00000001807EA200
	public void ShowQuitConfirmation(); // 0x00000001807E3B30-0x00000001807E3C00
	public void HideQuitConfirmation(); // 0x00000001807E4570-0x00000001807E4640
	public void ShowHUD(); // 0x00000001807E9D50-0x00000001807E9DD0
	public void HideHUD(); // 0x00000001807E4480-0x00000001807E4570
	public void BtnClicked_StartGame(); // 0x00000001807E3CA0-0x00000001807E3D30
	public void BtnClicked_QuitGame(); // 0x00000001807E3C00-0x00000001807E3C80
	public void BtnClicked_QuitConfirmation(); // 0x00000001807E3B30-0x00000001807E3C00
	public void BtnClicked_CancelQuitConfirmation(); // 0x00000001807E3AF0-0x00000001807E3B00
	public void BtnClicked_Tutorial(); // 0x00000001807E3D30-0x00000001807E3D60
	public void BtnClicked_Puzzles(); // 0x00000001807E3B00-0x00000001807E3B30
	public void BtnClicked_ShowGameProgress(); // 0x00000001807E3C80-0x00000001807E3CA0
	public void BtnClicked_UsePowerupDizzyBird(); // 0x00000001807E3D60-0x00000001807E3D80
	public void UpdateDebugValues(int inTotalGames, int inMoveCountAverage, int inMoveCountMedian, int inLeastMoves, int inMostMoves, int inCurrentMoves, int availableMoves, int inHighScore); // 0x00000001807EA4B0-0x00000001807EA7E0
	public void SetLevelText(int inLevelIndex); // 0x00000001807E98E0-0x00000001807E9970
	public void OnLevelStarted(int inLevelIndex); // 0x00000001807E48D0-0x00000001807E4970
	public void OnScoreUpdated(ObscuredInt inCurrentScore); // 0x00000001807E4D00-0x00000001807E4DA0
	public void OnLevelScoreMeterUpdated(Match3LevelObjectiveTrackingInfo scoreTrackedObjective); // 0x00000001807E4840-0x00000001807E48D0
	private void SetScoreFill(float inFillAmount); // 0x00000001807E9B80-0x00000001807E9CD0
	private void UpdateScoreFxPosition(); // 0x00000001807EA7E0-0x00000001807EA9F0
	private void CompleteScoreFxPosition(); // 0x00000001807E3E70-0x00000001807E3F00
	public void SetPowerUpFill(ObscuredInt inPowerupMeterObscured); // 0x00000001807E9B40-0x00000001807E9B80
	public void SetPowerUpFill(int inPowerupMeter); // 0x00000001807E9970-0x00000001807E9B40
	private void SetImageFill(WWImage inFillImage, float inFillAmount, Action onUpdate = null, Action onComplete = null); // 0x00000001807E8E50-0x00000001807E8FC0
	public void ShowResultsScreen(int inLevel, float inLevelProgress, int inScore, IReadOnlyDictionary<Match3Reward, int> rewardCounts, bool isGameProgress); // 0x00000001807E9DD0-0x00000001807E9F50
	public void GiveRewards(); // 0x00000001807E4130-0x00000001807E42C0
	private int GetRewardIndex(int levelIndex); // 0x00000001807E4040-0x00000001807E4130
	private bool IsLevelInRange(int levelIndex, Match3LevelReward reward); // 0x00000001807E46C0-0x00000001807E4700
	public void ClearMeters(); // 0x00000001807E3D80-0x00000001807E3E70
	public void OnPowerupReady(); // 0x00000001807E4A80-0x00000001807E4B60
	public void OnPowerupUsed(); // 0x00000001807E4B60-0x00000001807E4D00
	public void PlayLevelCompleteFx(); // 0x00000001807E4E40-0x00000001807E4EF0
	public void DisableLevelCompleteFx(); // 0x00000001807E3F00-0x00000001807E3F90
	public void PlayDizzyBirdActivateFx(); // 0x00000001807E4DA0-0x00000001807E4E40
	public void StopDizzyBirdActivateFx(); // 0x00000001807EA390-0x00000001807EA420
	public void PlayDoublePeacockClearFx(); // 0x00000001807E4700-0x00000001807E47B0
	public void OnBoosterComboActivated_DoublePeacock(); // 0x00000001807E4700-0x00000001807E47B0
	public void SetLevelObjectiveUI(List<SpecialOrderType> inSpecialOrders, List<Match3LevelObjectiveTrackingInfo> inTrackingInfo); // 0x00000001807E8FC0-0x00000001807E98E0
	public void UpdateSpecialOrderObjectiveUI(Match3LevelObjectiveTrackingInfo inTrackingInfo); // 0x00000001807EA9F0-0x00000001807EAC00
	private void OnMinigamePrizeGiven(MinigamePrizeGiven inMessage); // 0x00000001807E4970-0x00000001807E4A80
	public void ShowScoreFlashup(int inScore, Color inColor, bool doMovement, Vector3 inPosition); // 0x00000001807E9F50-0x00000001807EA010
	[IteratorStateMachine] // 0x000000018024C0F0-0x000000018024C140
	private IEnumerator DoScoreFlashup(int inScore, Color inColor, bool doMovement, Vector3 inPosition); // 0x00000001807E3F90-0x00000001807E4040
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Start>b__41_1(); // 0x00000001807EA420-0x00000001807EA4B0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <OnPowerupUsed>b__76_0(); // 0x00000001807EA390-0x00000001807EA420
}

