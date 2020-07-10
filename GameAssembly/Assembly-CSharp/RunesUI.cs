/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.DeInspektor.Attributes;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class RunesUI : MonoBehaviour // TypeDefIndex: 13172
{
	// Fields
	public GameObject splashScreen; // 0x20
	public RunesResultsScreen resultsScreen; // 0x28
	public GameObject quitPopup; // 0x30
	public GameObject gameHUD; // 0x38
	public GameObject closeButton; // 0x40
	[Space] // 0x00000001800C6850-0x00000001800C6870
	public GameObject tutorialScreen; // 0x48
	public List<GameObject> tutorialPages; // 0x50
	[Space] // 0x00000001800C6850-0x00000001800C6870
	public WWTextMeshProUGUI scoreText; // 0x58
	public WWTextMeshProUGUI highScoreText; // 0x60
	[Space] // 0x00000001800C6850-0x00000001800C6870
	public RuneTypeGroupUI flameUI; // 0x68
	public RuneTypeGroupUI floraUI; // 0x70
	public RuneTypeGroupUI miasmaUI; // 0x78
	[Space] // 0x00000001800C6850-0x00000001800C6870
	public WWImage inventoryIcon; // 0x80
	[Space] // 0x00000001800C6850-0x00000001800C6870
	public RunesGame game; // 0x88
	private int _tutorialPage; // 0x90
	private bool _showingPopup; // 0x94

	// Properties
	public bool IsShowingUI { get; } // 0x0000000180E0C620-0x0000000180E0C690 

	// Nested types
	[Serializable]
	public class RuneTypeGroupUI // TypeDefIndex: 13173
	{
		// Fields
		public Color color; // 0x10
		public Color bgColor; // 0x20
		public Transform scoreAnimateTo; // 0x30
		public WWImage rewardBurstImage; // 0x38
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private RawImage prizeIconImage1; // 0x40
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private RawImage prizeIconImage2; // 0x48
		public WWImage progressFillbarImage; // 0x50
		public WWImage progressBackgroundImage; // 0x58
		public WWTextMeshProUGUI progressText; // 0x60
		public WWTextMeshProUGUI levelText; // 0x68
		public ParticleSystem progressFx; // 0x70
		public WWTextMeshProUGUI progressIncrementText; // 0x78
		public string progressTweenGroupIn; // 0x80
		public string progressTweenGroupOut; // 0x88
		public HexTile queuedCycloneIndicator; // 0x90
		private RawImage _currentPrizeIcon; // 0x98
		private RawImage _nextPrizeIcon; // 0xA0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private int <progressIncrement>k__BackingField; // 0xA8
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private float <targetProgress>k__BackingField; // 0xAC

		// Properties
		public string ColorHex { get; } // 0x0000000180E08AF0-0x0000000180E08B10 
		public string BgColorHex { get; } // 0x0000000180E08AD0-0x0000000180E08AF0 
		public int progressIncrement { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180E08B10-0x0000000180E08B20 0x000000018046A090-0x000000018046A0A0
		public float targetProgress { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180E08B20-0x0000000180E08B30 0x0000000180E08B30-0x0000000180E08B40

		// Constructors
		public RuneTypeGroupUI(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		public RawImage GetCurrentPrizeIconImage(); // 0x0000000180E08850-0x0000000180E088E0
		public RawImage GetNextPrizeIconImage(); // 0x0000000180E088E0-0x0000000180E08970
		public void SwapIconImages(); // 0x0000000180E089D0-0x0000000180E08AD0
		public void ResetCurrentNextPrizeIcons(); // 0x0000000180E08970-0x0000000180E089D0
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 13174
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<bool> <>9__19_0; // 0x08

		// Constructors
		static <>c(); // 0x0000000180E3CD20-0x0000000180E3CD80
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <Start>b__19_0(); // 0x0000000180E3B800-0x0000000180E3B8A0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass54_0 // TypeDefIndex: 13175
	{
		// Fields
		public RawImage prizeIcon; // 0x10
		public Vector3 startPos; // 0x18
		public RunesUI <>4__this; // 0x28

		// Constructors
		public <>c__DisplayClass54_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <ShowPrizeRewarded>b__0(); // 0x0000000180E3BEB0-0x0000000180E3C1D0
	}

	// Constructors
	public RunesUI(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void Start(); // 0x0000000180E0C150-0x0000000180E0C2C0
	private void OnDestroy(); // 0x0000000180E0A710-0x0000000180E0A7A0
	private void OnBackButton(); // 0x0000000180E0A550-0x0000000180E0A710
	public bool AnyPopupOpen(); // 0x0000000180E09950-0x0000000180E099E0
	public void ShowSplashScreen(); // 0x0000000180E0BFF0-0x0000000180E0C080
	public void HideSplashScreen(); // 0x0000000180E0A450-0x0000000180E0A4D0
	public void ShowGameHUD(); // 0x0000000180E0B6C0-0x0000000180E0B740
	public void HideGameHUD(); // 0x0000000180E0A2B0-0x0000000180E0A330
	public void ShowResultsScreen(int score, List<RunesReward> inRewards, bool isProgressOnly = false /* Metadata: 0x0078376A */); // 0x0000000180E0BBE0-0x0000000180E0BFF0
	public void HideResultsScreen(); // 0x0000000180E0A330-0x0000000180E0A450
	public void ShowTutorialScreen(); // 0x0000000180E09A60-0x0000000180E09B00
	public void HideTutorialScreen(); // 0x0000000180E0A4D0-0x0000000180E0A550
	public void ShowCloseButton(); // 0x0000000180E0B640-0x0000000180E0B6C0
	public void HideCloseButton(); // 0x0000000180E0A230-0x0000000180E0A2B0
	public void BtnClicked_PlayGame(); // 0x0000000180E09B40-0x0000000180E09C10
	public void BtnClicked_PlayGameWithTutorial(); // 0x0000000180E09B00-0x0000000180E09B40
	private void DoGameStart(bool tutorialOn); // 0x0000000180E0A150-0x0000000180E0A200
	public void BtnClicked_ExitGame(); // 0x0000000180E099E0-0x0000000180E09A60
	public void BtnClicked_ResultsExitGame(); // 0x0000000180E09C90-0x0000000180E09D40
	public void BtnClicked_TutorialNextPage(); // 0x0000000180E09DF0-0x0000000180E09E20
	public void BtnClicked_TutorialGoToPage(int inPage); // 0x0000000180E09DD0-0x0000000180E09DF0
	public void BtnClicked_TutorialOK(); // 0x0000000180E09E20-0x0000000180E09E40
	public void BtnClicked_ShowGameProgress(); // 0x0000000180E09D40-0x0000000180E09DD0
	public void BtnClicked_HelpPlease(); // 0x0000000180E09A60-0x0000000180E09B00
	public void BtnClicked_QuitCancel(); // 0x0000000180E09C10-0x0000000180E09C90
	private void ShowTutorialPage(int inPage); // 0x0000000180E0C080-0x0000000180E0C150
	public void SetScore(int inScore); // 0x0000000180E0B5A0-0x0000000180E0B640
	public void SetHighScore(long inHighScore); // 0x0000000180E0A9E0-0x0000000180E0AA80
	public void SetRuneLevelProgress(RuneType inType, int inProgress, int inDeltaProgress, int inLevelThreshold, int inLevelIndex); // 0x0000000180E0B4A0-0x0000000180E0B560
	private void SetLevelProgress(RuneTypeGroupUI inGroupUI, int inProgress, int inDeltaProgress, int inLevelThreshold, int inLevelIndex); // 0x0000000180E0AA80-0x0000000180E0B0B0
	public void ResetScoreProgressIncrementText(); // 0x0000000180E0A930-0x0000000180E0A9E0
	private void PlayLevelProgressSfx(RuneType inType); // 0x0000000180E0A7A0-0x0000000180E0A7D0
	private RuneTypeGroupUI GetGroupUIFromRuneType(RuneType inRuneType); // 0x0000000180E0A200-0x0000000180E0A230
	public void SetRunePrizeIcon(RuneType inRuneType, string inItemDefId, int inCount); // 0x0000000180E0B560-0x0000000180E0B5A0
	private void SetPrizeIcon(RuneTypeGroupUI inGroupUI, string inItemDefId, int inCount); // 0x0000000180E0B0B0-0x0000000180E0B3F0
	public void ShowPrizeRewarded(RuneType inRuneType, int inLevel); // 0x0000000180E0B740-0x0000000180E0BBE0
	public void ClearRewardsUI(); // 0x0000000180E09F30-0x0000000180E0A150
	public void SetQueuedCycloneVisible(RuneType inType, bool inVisible); // 0x0000000180E0B3F0-0x0000000180E0B4A0
	public void ClearAllQueuedCyclones(); // 0x0000000180E09E40-0x0000000180E09F30
	[DeMethodButton] // 0x0000000180105210-0x0000000180105290
	private void PulseInventoryIcon(); // 0x0000000180E0A7D0-0x0000000180E0A930
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Start>b__19_1(); // 0x0000000180E0C590-0x0000000180E0C620
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <OnBackButton>b__21_0(bool result); // 0x0000000180E0C2C0-0x0000000180E0C2F0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <ResetScoreProgressIncrementText>b__49_0(); // 0x0000000180E0C2F0-0x0000000180E0C390
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <ResetScoreProgressIncrementText>b__49_1(); // 0x0000000180E0C390-0x0000000180E0C590
}

