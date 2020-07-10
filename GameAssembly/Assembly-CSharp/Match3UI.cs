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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class Match3UI : MonoBehaviour // TypeDefIndex: 13000
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
	public class LevelObjectiveUIGroup // TypeDefIndex: 13001
	{
		// Fields
		public WWImage icon; // 0x10
		public WWTextMeshProUGUI label; // 0x18
		public WWTextMeshProUGUI value; // 0x20
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Match3LevelObjectiveType <currentObjectiveType>k__BackingField; // 0x28

		// Properties
		public Match3LevelObjectiveType currentObjectiveType { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018038E0E0-0x000000018038E0F0 0x000000018036B790-0x000000018036B7A0

		// Constructors
		public LevelObjectiveUIGroup(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 13002
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<bool> <>9__41_0; // 0x08
		public static Func<bool> <>9__46_0; // 0x10
		public static Action <>9__46_1; // 0x18
		public static Action <>9__68_0; // 0x20

		// Constructors
		static <>c(); // 0x00000001810BDA10-0x00000001810BDA70
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <Start>b__41_0(); // 0x00000001810BD3E0-0x00000001810BD480
		internal bool <ShowSplashScreen>b__46_0(); // 0x00000001810BD330-0x00000001810BD3D0
		internal void <ShowSplashScreen>b__46_1(); // 0x00000001810BD3D0-0x00000001810BD3E0
		internal void <SetPowerUpFill>b__68_0(); // 0x00000001810BD320-0x00000001810BD330
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass69_0 // TypeDefIndex: 13003
	{
		// Fields
		public Action onUpdate; // 0x10
		public Action onComplete; // 0x18

		// Constructors
		public <>c__DisplayClass69_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <SetImageFill>b__0(); // 0x00000001810BD7E0-0x00000001810BD800
		internal void <SetImageFill>b__1(); // 0x00000001810BD800-0x00000001810BD820
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass72_0 // TypeDefIndex: 13004
	{
		// Fields
		public int levelIndex; // 0x10
		public Match3UI <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass72_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <GetRewardIndex>b__0(Match3LevelReward reward); // 0x00000001810BD890-0x00000001810BD8F0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <DoScoreFlashup>d__87 : IEnumerator<object> // TypeDefIndex: 13005
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <DoScoreFlashup>d__87(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001810BBEB0-0x00000001810BC210
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001810BC210-0x00000001810BC260
	}

	// Constructors
	public Match3UI(); // 0x0000000180407560-0x0000000180407570

	// Methods
	private void Start(); // 0x00000001810ADB20-0x00000001810ADCB0
	private void OnDestroy(); // 0x00000001810A7F60-0x00000001810A7FF0
	private void HideAllScreens(); // 0x00000001810A7B40-0x00000001810A7CA0
	private void SetScreenVisible(GameObject inScreen, bool inVisible); // 0x00000001810AD5E0-0x00000001810AD660
	public void HideSplashScreen(); // 0x00000001810A7DF0-0x00000001810A7E70
	public void ShowSplashScreen(); // 0x00000001810AD930-0x00000001810ADB20
	public void ShowQuitConfirmation(); // 0x00000001810A7290-0x00000001810A7360
	public void HideQuitConfirmation(); // 0x00000001810A7D20-0x00000001810A7DF0
	public void ShowHUD(); // 0x00000001810AD660-0x00000001810AD6E0
	public void HideHUD(); // 0x00000001810A7CA0-0x00000001810A7D20
	public void BtnClicked_StartGame(); // 0x00000001810A7400-0x00000001810A7490
	public void BtnClicked_QuitGame(); // 0x00000001810A7360-0x00000001810A73E0
	public void BtnClicked_QuitConfirmation(); // 0x00000001810A7290-0x00000001810A7360
	public void BtnClicked_CancelQuitConfirmation(); // 0x00000001810A7250-0x00000001810A7260
	public void BtnClicked_Tutorial(); // 0x00000001810A7490-0x00000001810A74C0
	public void BtnClicked_Puzzles(); // 0x00000001810A7260-0x00000001810A7290
	public void BtnClicked_ShowGameProgress(); // 0x00000001810A73E0-0x00000001810A7400
	public void BtnClicked_UsePowerupDizzyBird(); // 0x00000001810A74C0-0x00000001810A74E0
	public void UpdateDebugValues(int inTotalGames, int inMoveCountAverage, int inMoveCountMedian, int inLeastMoves, int inMostMoves, int inCurrentMoves, int availableMoves, int inHighScore); // 0x00000001810ADDD0-0x00000001810AE110
	public void SetLevelText(int inLevelIndex); // 0x00000001810AD1D0-0x00000001810AD270
	public void OnLevelStarted(int inLevelIndex); // 0x00000001810A8080-0x00000001810A8120
	public void OnScoreUpdated(ObscuredInt inCurrentScore); // 0x00000001810A84C0-0x00000001810A8560
	public void OnLevelScoreMeterUpdated(Match3LevelObjectiveTrackingInfo scoreTrackedObjective); // 0x00000001810A7FF0-0x00000001810A8080
	private void SetScoreFill(float inFillAmount); // 0x00000001810AD490-0x00000001810AD5E0
	private void UpdateScoreFxPosition(); // 0x00000001810AE110-0x00000001810AE330
	private void CompleteScoreFxPosition(); // 0x00000001810A75D0-0x00000001810A7660
	public void SetPowerUpFill(ObscuredInt inPowerupMeterObscured); // 0x00000001810AD450-0x00000001810AD490
	public void SetPowerUpFill(int inPowerupMeter); // 0x00000001810AD270-0x00000001810AD450
	private void SetImageFill(WWImage inFillImage, float inFillAmount, Action onUpdate = null, Action onComplete = null); // 0x00000001810AC6E0-0x00000001810AC850
	public void ShowResultsScreen(int inLevel, float inLevelProgress, int inScore, IReadOnlyDictionary<Match3Reward, int> rewardCounts, bool isGameProgress); // 0x00000001810AD6E0-0x00000001810AD870
	public void GiveRewards(); // 0x00000001810A78A0-0x00000001810A7B40
	private int GetRewardIndex(int levelIndex); // 0x00000001810A77A0-0x00000001810A78A0
	private bool IsLevelInRange(int levelIndex, Match3LevelReward reward); // 0x00000001810A7E70-0x00000001810A7EB0
	public void ClearMeters(); // 0x00000001810A74E0-0x00000001810A75D0
	public void OnPowerupReady(); // 0x00000001810A8240-0x00000001810A8320
	public void OnPowerupUsed(); // 0x00000001810A8320-0x00000001810A84C0
	public void PlayLevelCompleteFx(); // 0x00000001810A8600-0x00000001810A86B0
	public void DisableLevelCompleteFx(); // 0x00000001810A7660-0x00000001810A76F0
	public void PlayDizzyBirdActivateFx(); // 0x00000001810A8560-0x00000001810A8600
	public void StopDizzyBirdActivateFx(); // 0x00000001810ADCB0-0x00000001810ADD40
	public void PlayDoublePeacockClearFx(); // 0x00000001810A7EB0-0x00000001810A7F60
	public void OnBoosterComboActivated_DoublePeacock(); // 0x00000001810A7EB0-0x00000001810A7F60
	public void SetLevelObjectiveUI(List<SpecialOrderType> inSpecialOrders, List<Match3LevelObjectiveTrackingInfo> inTrackingInfo); // 0x00000001810AC850-0x00000001810AD1D0
	public void UpdateSpecialOrderObjectiveUI(Match3LevelObjectiveTrackingInfo inTrackingInfo); // 0x00000001810AE330-0x00000001810AE560
	private void OnMinigamePrizeGiven(MinigamePrizeGiven inMessage); // 0x00000001810A8120-0x00000001810A8240
	public void ShowScoreFlashup(int inScore, Color inColor, bool doMovement, Vector3 inPosition); // 0x00000001810AD870-0x00000001810AD930
	[IteratorStateMachine] // 0x0000000180173970-0x00000001801739C0
	private IEnumerator DoScoreFlashup(int inScore, Color inColor, bool doMovement, Vector3 inPosition); // 0x00000001810A76F0-0x00000001810A77A0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Start>b__41_1(); // 0x00000001810ADD40-0x00000001810ADDD0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <OnPowerupUsed>b__76_0(); // 0x00000001810ADCB0-0x00000001810ADD40
}

