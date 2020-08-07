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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class RunesUI : MonoBehaviour // TypeDefIndex: 10837
{
	// Fields
	public GameObject splashScreen; // 0x20
	public RunesResultsScreen resultsScreen; // 0x28
	public GameObject quitPopup; // 0x30
	public GameObject gameHUD; // 0x38
	public GameObject closeButton; // 0x40
	[Space] // 0x00000001801D3D10-0x00000001801D3D30
	public GameObject tutorialScreen; // 0x48
	public List<GameObject> tutorialPages; // 0x50
	[Space] // 0x00000001801D3D10-0x00000001801D3D30
	public WWTextMeshProUGUI scoreText; // 0x58
	public WWTextMeshProUGUI highScoreText; // 0x60
	[Space] // 0x00000001801D3D10-0x00000001801D3D30
	public RuneTypeGroupUI flameUI; // 0x68
	public RuneTypeGroupUI floraUI; // 0x70
	public RuneTypeGroupUI miasmaUI; // 0x78
	[Space] // 0x00000001801D3D10-0x00000001801D3D30
	public WWImage inventoryIcon; // 0x80
	[Space] // 0x00000001801D3D10-0x00000001801D3D30
	public RunesGame game; // 0x88
	private int _tutorialPage; // 0x90
	private bool _showingPopup; // 0x94

	// Properties
	public bool IsShowingUI { get; } // 0x000000018073E4A0-0x000000018073E510 

	// Nested types
	[Serializable]
	public class RuneTypeGroupUI // TypeDefIndex: 10838
	{
		// Fields
		public Color color; // 0x10
		public Color bgColor; // 0x20
		public Transform scoreAnimateTo; // 0x30
		public WWImage rewardBurstImage; // 0x38
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private RawImage prizeIconImage1; // 0x40
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
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
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int <progressIncrement>k__BackingField; // 0xA8
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float <targetProgress>k__BackingField; // 0xAC

		// Properties
		public string ColorHex { get; } // 0x000000018072EFD0-0x000000018072EFF0 
		public string BgColorHex { get; } // 0x000000018072EFB0-0x000000018072EFD0 
		public int progressIncrement { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x000000018072EFF0-0x000000018072F000 0x000000018072F010-0x000000018072F020
		public float targetProgress { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x000000018072F000-0x000000018072F010 0x000000018072F020-0x000000018072F030

		// Constructors
		public RuneTypeGroupUI(); // 0x0000000180373240-0x0000000180373250

		// Methods
		public RawImage GetCurrentPrizeIconImage(); // 0x000000018072ED30-0x000000018072EDC0
		public RawImage GetNextPrizeIconImage(); // 0x000000018072EDC0-0x000000018072EE50
		public void SwapIconImages(); // 0x000000018072EEB0-0x000000018072EFB0
		public void ResetCurrentNextPrizeIcons(); // 0x000000018072EE50-0x000000018072EEB0
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 10839
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<bool> <>9__19_0; // 0x08

		// Constructors
		static <>c(); // 0x000000018074A700-0x000000018074A760
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <Start>b__19_0(); // 0x00000001807498C0-0x0000000180749960
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass54_0 // TypeDefIndex: 10840
	{
		// Fields
		public RawImage prizeIcon; // 0x10
		public Vector3 startPos; // 0x18
		public RunesUI <>4__this; // 0x28

		// Constructors
		public <>c__DisplayClass54_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <ShowPrizeRewarded>b__0(); // 0x0000000180749D30-0x000000018074A0E0
	}

	// Constructors
	public RunesUI(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void Start(); // 0x000000018073DFE0-0x000000018073E150
	private void OnDestroy(); // 0x000000018073C320-0x000000018073C3B0
	private void OnBackButton(); // 0x000000018073C160-0x000000018073C320
	public bool AnyPopupOpen(); // 0x000000018073B4D0-0x000000018073B560
	public void ShowSplashScreen(); // 0x000000018073DDF0-0x000000018073DF10
	public void HideSplashScreen(); // 0x000000018073C060-0x000000018073C0E0
	public void ShowGameHUD(); // 0x000000018073D4E0-0x000000018073D560
	public void HideGameHUD(); // 0x000000018073BEC0-0x000000018073BF40
	public void ShowResultsScreen(int score, List<RunesReward> inRewards, bool isProgressOnly = false /* Metadata: 0x0077C225 */); // 0x000000018073D9F0-0x000000018073DDF0
	public void HideResultsScreen(); // 0x000000018073BF40-0x000000018073C060
	public void ShowTutorialScreen(); // 0x000000018073B5E0-0x000000018073B680
	public void HideTutorialScreen(); // 0x000000018073C0E0-0x000000018073C160
	public void ShowCloseButton(); // 0x000000018073D460-0x000000018073D4E0
	public void HideCloseButton(); // 0x000000018073BE40-0x000000018073BEC0
	public void BtnClicked_PlayGame(); // 0x000000018073B6C0-0x000000018073B7A0
	public void BtnClicked_PlayGameWithTutorial(); // 0x000000018073B680-0x000000018073B6C0
	private void DoGameStart(bool tutorialOn); // 0x000000018073BCC0-0x000000018073BE10
	public void BtnClicked_ExitGame(); // 0x000000018073B560-0x000000018073B5E0
	public void BtnClicked_ResultsExitGame(); // 0x000000018073B820-0x000000018073B8D0
	public void BtnClicked_TutorialNextPage(); // 0x000000018073B970-0x000000018073B9A0
	public void BtnClicked_TutorialGoToPage(int inPage); // 0x000000018073B950-0x000000018073B970
	public void BtnClicked_TutorialOK(); // 0x000000018073B9A0-0x000000018073B9C0
	public void BtnClicked_ShowGameProgress(); // 0x000000018073B8D0-0x000000018073B950
	public void BtnClicked_HelpPlease(); // 0x000000018073B5E0-0x000000018073B680
	public void BtnClicked_QuitCancel(); // 0x000000018073B7A0-0x000000018073B820
	private void ShowTutorialPage(int inPage); // 0x000000018073DF10-0x000000018073DFE0
	public void SetScore(int inScore); // 0x000000018073D3C0-0x000000018073D460
	public void SetHighScore(long inHighScore); // 0x000000018073C7C0-0x000000018073C860
	public void SetRuneLevelProgress(RuneType inType, int inProgress, int inDeltaProgress, int inLevelThreshold, int inLevelIndex); // 0x000000018073D2E0-0x000000018073D380
	private void SetLevelProgress(RuneTypeGroupUI inGroupUI, int inProgress, int inDeltaProgress, int inLevelThreshold, int inLevelIndex); // 0x000000018073C860-0x000000018073CEE0
	public void ResetScoreProgressIncrementText(); // 0x000000018073C710-0x000000018073C7C0
	private void PlayLevelProgressSfx(RuneType inType); // 0x000000018073C3B0-0x000000018073C5B0
	private RuneTypeGroupUI GetGroupUIFromRuneType(RuneType inRuneType); // 0x000000018073BE10-0x000000018073BE40
	public void SetRunePrizeIcon(RuneType inRuneType, string inItemDefId, int inCount); // 0x000000018073D380-0x000000018073D3C0
	private void SetPrizeIcon(RuneTypeGroupUI inGroupUI, string inItemDefId, int inCount); // 0x000000018073CEE0-0x000000018073D210
	public void ShowPrizeRewarded(RuneType inRuneType, int inLevel); // 0x000000018073D560-0x000000018073D9F0
	public void ClearRewardsUI(); // 0x000000018073BAA0-0x000000018073BCC0
	public void SetQueuedCycloneVisible(RuneType inType, bool inVisible); // 0x000000018073D210-0x000000018073D2E0
	public void ClearAllQueuedCyclones(); // 0x000000018073B9C0-0x000000018073BAA0
	[DeMethodButton] // 0x00000001801D7D50-0x00000001801D7DD0
	private void PulseInventoryIcon(); // 0x000000018073C5B0-0x000000018073C710
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Start>b__19_1(); // 0x000000018073E410-0x000000018073E4A0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <OnBackButton>b__21_0(bool result); // 0x000000018073E150-0x000000018073E180
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <ResetScoreProgressIncrementText>b__49_0(); // 0x000000018073E180-0x000000018073E220
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <ResetScoreProgressIncrementText>b__49_1(); // 0x000000018073E220-0x000000018073E410
}

