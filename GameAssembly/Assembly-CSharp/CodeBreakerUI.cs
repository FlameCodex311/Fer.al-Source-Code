/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class CodeBreakerUI : MonoBehaviour // TypeDefIndex: 12911
{
	// Fields
	public GameObject startScreen; // 0x20
	public CodeBreakerLevelSelect levelSelectScreen; // 0x28
	public GameObject HUD; // 0x30
	public GameObject successPopup; // 0x38
	public GameObject failPopup; // 0x40
	public GameObject quitPopup; // 0x48
	public GameObject tutorialPopup; // 0x50
	public CodeBreakerTutorial forcedTutorial; // 0x58
	public WWButton startButton; // 0x60
	public GameObject dropButton; // 0x68
	public GameObject mixButton; // 0x70
	public CodeBreakerScoreUI scoreResults; // 0x78
	public CodeBreakerRewardUI rewardUI; // 0x80
	public Sprite levelIcon_Normal; // 0x88
	public Sprite levelIcon_Red; // 0x90
	public WWImage successLevelIcon; // 0x98
	public WWTextMeshProUGUI successLevelText; // 0xA0
	public WWImage pausedLevelIcon; // 0xA8
	public WWTextMeshProUGUI pausedLevelText; // 0xB0
	public WWTextMeshProUGUI failureHintText; // 0xB8
	public CodeNoteUI failSecretCode; // 0xC0
	public GameObject codeNoteRules_DuplicatesAllowed; // 0xC8
	public GameObject codeNoteRules_NoDuplicatesAllowed; // 0xD0
	public RectTransform codeNoteRulesContainer; // 0xD8
	public CodeBreakerGame game; // 0xE0
	public CodeNoteUI codeNoteTemplate; // 0xE8
	public float codeNoteSpacing; // 0xF0
	public int maxNotesVisible; // 0xF4
	public CodeBreakerScroll scroll; // 0xF8
	public TextMeshPro timerText; // 0x100
	public CodeBreakerDialogPopup dialogPopup; // 0x108
	[RootSelectorCompact] // 0x0000000180146EE0-0x0000000180146F40
	public List<string> missMargueriteDialog; // 0x110
	[RootSelectorCompact] // 0x0000000180147100-0x0000000180147160
	public string missMargueriteWinDialog; // 0x118
	[RootSelectorCompact] // 0x0000000180147380-0x00000001801473E0
	public string missMargueriteLoseDialog; // 0x120
	[RootSelectorCompact] // 0x0000000180147520-0x0000000180147580
	public List<string> failureHintStringIds; // 0x128
	[RootSelectorCompact] // 0x0000000180147520-0x0000000180147580
	public string failureHintNoDupes; // 0x130
	private List<CodeNoteUI> _codeNotes; // 0x138
	private List<CodeAttempt> _codeHistory; // 0x140
	private float startPosY; // 0x148
	private bool _showingTutorial; // 0x14C
	private CodeNoteUI _codeNoteNextAttempt; // 0x150
	private int _pausedCount; // 0x158
	private Tween _timerPausedTween; // 0x160
	private float _tweenTime; // 0x168
	private bool _waitingForNextCodeNote; // 0x16C

	// Properties
	private bool Paused { get; } // 0x000000018127B490-0x000000018127B4A0 

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12912
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<bool> <>9__44_0; // 0x08
		public static Func<bool> <>9__44_2; // 0x10
		public static Func<bool> <>9__63_0; // 0x18
		public static Action <>9__63_1; // 0x20

		// Constructors
		static <>c(); // 0x0000000181282070-0x00000001812820D0
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <Start>b__44_0(); // 0x00000001812819A0-0x0000000181281A40
		internal bool <Start>b__44_2(); // 0x0000000181281A40-0x0000000181281AE0
		internal bool <ShowStartScreen>b__63_0(); // 0x0000000181281840-0x0000000181281890
		internal void <ShowStartScreen>b__63_1(); // 0x0000000181281890-0x00000001812819A0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass52_0 // TypeDefIndex: 12913
	{
		// Fields
		public CodeBreakerUI <>4__this; // 0x10
		public int inDialogIndex; // 0x18

		// Constructors
		public <>c__DisplayClass52_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <ShowDialog>b__0(); // 0x0000000181281E30-0x0000000181281EF0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <ShowNewCodeAttempt>d__56 : IEnumerator<object> // TypeDefIndex: 12914
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public CodeBreakerUI <>4__this; // 0x20
		public CodeAttempt inAttempt; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <ShowNewCodeAttempt>d__56(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181281180-0x0000000181281380
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181281380-0x00000001812813D0
	}

	// Constructors
	public CodeBreakerUI(); // 0x000000018127B470-0x000000018127B490

	// Methods
	private void Start(); // 0x000000018127AE70-0x000000018127B180
	private void OnDestroy(); // 0x0000000181278AF0-0x0000000181278C20
	private void OnBackButton(); // 0x0000000181278820-0x0000000181278A60
	public void SetTimerText(float inSeconds); // 0x0000000181279590-0x00000001812796D0
	private void OnCodeAttempt(CodeAttemptMessage inMessage); // 0x0000000181278A60-0x0000000181278AF0
	private void OnGamePaused(CodeBreakerGamePausedMessage inMessage); // 0x0000000181278C20-0x0000000181278E10
	public void ShowDialog(int inDialogIndex); // 0x00000001812796D0-0x00000001812797D0
	public void ShowWinDialog(); // 0x000000018127ADD0-0x000000018127AE70
	public void ShowLoseDialog(); // 0x0000000181279A20-0x0000000181279AC0
	[IteratorStateMachine] // 0x0000000180147AB0-0x0000000180147B00
	private IEnumerator ShowNewCodeAttempt(CodeAttempt inAttempt); // 0x0000000181279AC0-0x0000000181279B30
	public void SetNotesCodeLength(int inLength); // 0x0000000181279560-0x0000000181279590
	public void SetLevelRules(); // 0x0000000181279200-0x0000000181279560
	public void SetLevelRulesForTutorial(); // 0x00000001812791C0-0x0000000181279200
	private void CreateNextCodeNote(); // 0x0000000181277A40-0x0000000181277B30
	public void ClearNotes(); // 0x0000000181277860-0x0000000181277A40
	private void RepositionNotes(); // 0x0000000181278E10-0x00000001812791C0
	public void ShowStartScreen(); // 0x000000018127AB20-0x000000018127AD00
	public void HideStartScreen(); // 0x00000001812786B0-0x0000000181278820
	public void ShowLevelSelectScreen(); // 0x0000000181279930-0x0000000181279A20
	public void HideLevelSelectScreen(); // 0x00000001812783F0-0x0000000181278490
	public void ShowHUD(); // 0x00000001812798B0-0x0000000181279930
	public void HideHUD(); // 0x0000000181278370-0x00000001812783F0
	public void ShowResults(bool inSuccess); // 0x0000000181279E20-0x000000018127AB20
	public void HideResults(); // 0x00000001812785A0-0x00000001812786B0
	public void ShowForcedTutorial(); // 0x00000001812797D0-0x0000000181279870
	public void HideForcedTutorial(); // 0x0000000181278290-0x0000000181278330
	public void ShowQuitConfirmation(); // 0x0000000181279B30-0x0000000181279E20
	public void HideQuitConfirmation(); // 0x0000000181278490-0x00000001812785A0
	public void ShowTutorialPopup(); // 0x000000018127AD00-0x000000018127ADD0
	public void HideTutorialPopup(); // 0x0000000181277070-0x0000000181277140
	public void BtnClicked_StartGame(); // 0x0000000181277620-0x0000000181277850
	public void BtnClicked_QuitConfirmation(); // 0x0000000181277390-0x00000001812773A0
	public void BtnClicked_QuitCancel(); // 0x0000000181277380-0x0000000181277390
	public void BtnClicked_QuitToLevelSelect(); // 0x00000001812773A0-0x0000000181277480
	public void BtnClicked_Quit(); // 0x0000000181277480-0x00000001812774B0
	public void BtnClicked_LevelSelectQuit(); // 0x0000000181277140-0x00000001812771D0
	public void BtnClicked_NextLevel(); // 0x0000000181277200-0x00000001812772B0
	public void BtnClicked_PrevLevel(); // 0x00000001812772B0-0x0000000181277380
	public void BtnClicked_ReplayLevel(); // 0x00000001812774B0-0x0000000181277590
	public void BtnClicked_RestartGame(); // 0x0000000181277590-0x0000000181277620
	public void BtnClicked_LevelSelect(); // 0x00000001812771D0-0x0000000181277200
	public void BtnClicked_TutorialPopup(); // 0x0000000181277850-0x0000000181277860
	public void BtnClicked_ExitTutorial(); // 0x0000000181277070-0x0000000181277140
	private int GetTotalCorrectPositionsFromNotes(); // 0x0000000181277F20-0x0000000181278170
	private int GetTotalCorrectColorsFromNotes(); // 0x0000000181277CD0-0x0000000181277F20
	public void HideGameplayButtons(); // 0x0000000181278330-0x0000000181278370
	public void ShowGameplayButtons(); // 0x0000000181279870-0x00000001812798B0
	private void GiveRewards(int inLevel, int inStarCount, bool inHasWon3StarReward); // 0x0000000181278170-0x0000000181278290
	private int DetermineReward(int inLevel, int inStar, bool inHasWon3StarReward); // 0x0000000181277B30-0x0000000181277CD0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Start>b__44_1(); // 0x000000018127B2C0-0x000000018127B3E0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Start>b__44_3(); // 0x000000018127B3E0-0x000000018127B470
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private float <OnGamePaused>b__51_0(); // 0x000000018127B1B0-0x000000018127B1C0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <OnGamePaused>b__51_1(float x); // 0x000000018127B1C0-0x000000018127B200
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <ShowWinDialog>b__53_0(); // 0x000000018127B280-0x000000018127B2C0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <ShowLoseDialog>b__54_0(); // 0x000000018127B200-0x000000018127B240
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <ShowNewCodeAttempt>b__56_0(); // 0x000000018127B240-0x000000018127B280
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <BtnClicked_LevelSelectQuit>b__82_0(bool result); // 0x000000018127B180-0x000000018127B1B0
}

