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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class CodeBreakerUI : MonoBehaviour // TypeDefIndex: 10576
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
	[RootSelectorCompact] // 0x00000001802267C0-0x0000000180226820
	public List<string> missMargueriteDialog; // 0x110
	[RootSelectorCompact] // 0x00000001802269C0-0x0000000180226A20
	public string missMargueriteWinDialog; // 0x118
	[RootSelectorCompact] // 0x0000000180226C20-0x0000000180226C80
	public string missMargueriteLoseDialog; // 0x120
	[RootSelectorCompact] // 0x0000000180226E40-0x0000000180226EA0
	public List<string> failureHintStringIds; // 0x128
	[RootSelectorCompact] // 0x0000000180226E40-0x0000000180226EA0
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
	private bool Paused { get; } // 0x0000000180533630-0x0000000180533640 

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 10577
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<bool> <>9__44_0; // 0x08
		public static Func<bool> <>9__44_2; // 0x10
		public static Func<bool> <>9__64_0; // 0x18
		public static Action <>9__64_1; // 0x20

		// Constructors
		static <>c(); // 0x00000001807870C0-0x0000000180787120
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <Start>b__44_0(); // 0x0000000180786AD0-0x0000000180786CC0
		internal bool <Start>b__44_2(); // 0x0000000180786CC0-0x0000000180786D60
		internal bool <ShowStartScreen>b__64_0(); // 0x0000000180786A00-0x0000000180786A50
		internal void <ShowStartScreen>b__64_1(); // 0x0000000180786A50-0x0000000180786AD0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass53_0 // TypeDefIndex: 10578
	{
		// Fields
		public CodeBreakerUI <>4__this; // 0x10
		public int inDialogIndex; // 0x18

		// Constructors
		public <>c__DisplayClass53_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <ShowDialog>b__0(); // 0x0000000180786EF0-0x0000000180786FA0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <ShowNewCodeAttempt>d__57 : IEnumerator<object> // TypeDefIndex: 10579
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public CodeBreakerUI <>4__this; // 0x20
		public CodeAttempt inAttempt; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <ShowNewCodeAttempt>d__57(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180786380-0x0000000180786580
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180786580-0x00000001807865D0
	}

	// Constructors
	public CodeBreakerUI(); // 0x0000000180533610-0x0000000180533630

	// Methods
	private void Start(); // 0x0000000180532FD0-0x00000001805332E0
	private void OnDestroy(); // 0x00000001805311F0-0x0000000180531360
	private void OnMinigamePrizeGiven(MinigamePrizeGiven inMessage); // 0x0000000180531550-0x0000000180531620
	private void OnBackButton(); // 0x0000000180530F20-0x0000000180531160
	public void SetTimerText(float inSeconds); // 0x0000000180531CF0-0x0000000180531E20
	private void OnCodeAttempt(CodeAttemptMessage inMessage); // 0x0000000180531160-0x00000001805311F0
	private void OnGamePaused(CodeBreakerGamePausedMessage inMessage); // 0x0000000180531360-0x0000000180531550
	public void ShowDialog(int inDialogIndex); // 0x0000000180531E20-0x0000000180531F20
	public void ShowWinDialog(); // 0x0000000180532F30-0x0000000180532FD0
	public void ShowLoseDialog(); // 0x0000000180532170-0x0000000180532210
	[IteratorStateMachine] // 0x0000000180227160-0x00000001802271B0
	private IEnumerator ShowNewCodeAttempt(CodeAttempt inAttempt); // 0x0000000180532210-0x0000000180532290
	public void SetNotesCodeLength(int inLength); // 0x0000000180531CC0-0x0000000180531CF0
	public void SetLevelRules(); // 0x0000000180531980-0x0000000180531CC0
	public void SetLevelRulesForTutorial(); // 0x0000000180531940-0x0000000180531980
	private void CreateNextCodeNote(); // 0x0000000180530120-0x0000000180530200
	public void ClearNotes(); // 0x000000018052FF40-0x0000000180530120
	private void RepositionNotes(); // 0x0000000180531620-0x0000000180531940
	public void ShowStartScreen(); // 0x0000000180532C80-0x0000000180532E60
	public void HideStartScreen(); // 0x0000000180530DB0-0x0000000180530F20
	public void ShowLevelSelectScreen(); // 0x0000000180532080-0x0000000180532170
	public void HideLevelSelectScreen(); // 0x0000000180530A90-0x0000000180530B30
	public void ShowHUD(); // 0x0000000180532000-0x0000000180532080
	public void HideHUD(); // 0x0000000180530A10-0x0000000180530A90
	public void ShowResults(bool inSuccess, Code inSecretCode = null, int inIngredientScore = -1 /* Metadata: 0x0077BDB0 */, int inTimeScore = -1 /* Metadata: 0x0077BDB4 */, int inFirstGuessBonus = -1 /* Metadata: 0x0077BDB8 */, int inLastIngredientBonus = -1 /* Metadata: 0x0077BDBC */); // 0x0000000180532570-0x0000000180532C80
	public void HideResults(); // 0x0000000180530C40-0x0000000180530DB0
	public void ShowForcedTutorial(); // 0x0000000180531F20-0x0000000180531FC0
	public void HideForcedTutorial(); // 0x0000000180530930-0x00000001805309D0
	public void ShowQuitConfirmation(); // 0x0000000180532290-0x0000000180532570
	public void HideQuitConfirmation(); // 0x0000000180530B30-0x0000000180530C40
	public void ShowTutorialPopup(); // 0x0000000180532E60-0x0000000180532F30
	public void HideTutorialPopup(); // 0x000000018052F760-0x000000018052F830
	public void BtnClicked_StartGame(); // 0x000000018052FD10-0x000000018052FF30
	public void BtnClicked_QuitConfirmation(); // 0x000000018052FA80-0x000000018052FA90
	public void BtnClicked_QuitCancel(); // 0x000000018052FA70-0x000000018052FA80
	public void BtnClicked_QuitToLevelSelect(); // 0x000000018052FA90-0x000000018052FB70
	public void BtnClicked_Quit(); // 0x000000018052FB70-0x000000018052FBA0
	public void BtnClicked_LevelSelectQuit(); // 0x000000018052F830-0x000000018052F8C0
	public void BtnClicked_NextLevel(); // 0x000000018052F8F0-0x000000018052F9A0
	public void BtnClicked_PrevLevel(); // 0x000000018052F9A0-0x000000018052FA70
	public void BtnClicked_ReplayLevel(); // 0x000000018052FBA0-0x000000018052FC80
	public void BtnClicked_RestartGame(); // 0x000000018052FC80-0x000000018052FD10
	public void BtnClicked_LevelSelect(); // 0x000000018052F8C0-0x000000018052F8F0
	public void BtnClicked_TutorialPopup(); // 0x000000018052FF30-0x000000018052FF40
	public void BtnClicked_ExitTutorial(); // 0x000000018052F760-0x000000018052F830
	private int GetTotalCorrectPositionsFromNotes(); // 0x00000001805305D0-0x0000000180530810
	private int GetTotalCorrectColorsFromNotes(); // 0x0000000180530390-0x00000001805305D0
	public void HideGameplayButtons(); // 0x00000001805309D0-0x0000000180530A10
	public void ShowGameplayButtons(); // 0x0000000180531FC0-0x0000000180532000
	private void GiveRewards(int inLevel, int inStarCount, bool inHasWon3StarReward); // 0x0000000180530810-0x0000000180530930
	private int DetermineReward(int inLevel, int inStar, bool inHasWon3StarReward); // 0x0000000180530200-0x0000000180530390
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Start>b__44_1(); // 0x0000000180533420-0x0000000180533580
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Start>b__44_3(); // 0x0000000180533580-0x0000000180533610
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float <OnGamePaused>b__52_0(); // 0x0000000180533310-0x0000000180533320
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <OnGamePaused>b__52_1(float x); // 0x0000000180533320-0x0000000180533360
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <ShowWinDialog>b__54_0(); // 0x00000001805333E0-0x0000000180533420
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <ShowLoseDialog>b__55_0(); // 0x0000000180533360-0x00000001805333A0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <ShowNewCodeAttempt>b__57_0(); // 0x00000001805333A0-0x00000001805333E0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <BtnClicked_LevelSelectQuit>b__83_0(bool result); // 0x00000001805332E0-0x0000000180533310
}

