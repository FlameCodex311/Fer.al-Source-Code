/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class ParlorUIManager : MonoBehaviour // TypeDefIndex: 13101
{
	// Fields
	public Camera uiCamera; // 0x20
	public GameObject gameHud; // 0x28
	public GameObject selectGameScreen; // 0x30
	public GameObject[] selectGameButtons; // 0x38
	public WWTextMeshProUGUI[] selectGameButtonNames; // 0x40
	public WWImage[] selectGameImages; // 0x48
	public GameObject selectGameMainScreen; // 0x50
	public WWTextMeshProUGUI selectGameName; // 0x58
	public WWTextMeshProUGUI selectGameDescription; // 0x60
	public BuildersFollyUI_Tutorial[] tutorials; // 0x68
	public WWTextMeshProUGUI pot; // 0x70
	public WWTextMeshProUGUI totalFunds; // 0x78
	public GameObject wagerScreen; // 0x80
	public TMP_InputField currentWager; // 0x88
	public GameObject doubleUpScreen; // 0x90
	public WWTextMeshProUGUI doubleUpDescription; // 0x98
	public GameObject playAgainScreen; // 0xA0
	public GameObject newGameScreen; // 0xA8
	public GameObject exitGameScreen; // 0xB0
	public GameObject exitParlorScreen; // 0xB8
	public GameObject payoutScreen; // 0xC0
	public WWTextMeshProUGUI payoutAmount; // 0xC8
	public GameObject noFundsScreen; // 0xD0
	public GameObject HideDuringTutorial; // 0xD8
	public GameObject results; // 0xE0
	public WWTextMeshProUGUI resultsTXT; // 0xE8
	private int _wager; // 0xF0
	private ParlorManager _parlorManager; // 0xF8
	private int _selectedGameIndex; // 0x100
	private int _tutorialPage; // 0x104
	private bool _firstTimeTutorial_startGame; // 0x108
	public float fadeInTime; // 0x10C
	public WWImage fadeInSceeen; // 0x110
	internal static bool isTutorialWindowUp; // 0x00

	// Properties
	internal int Wager { get; set; } // 0x000000018081E130-0x000000018081E140 0x0000000181171020-0x0000000181171120

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <DoFadeIn>d__38 : IEnumerator<object> // TypeDefIndex: 13102
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ParlorUIManager <>4__this; // 0x20
		private Color <startColor>5__2; // 0x28
		private Color <endColor>5__3; // 0x38
		private float <t>5__4; // 0x48

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <DoFadeIn>d__38(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181179560-0x0000000181179720
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181179720-0x0000000181179770
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <Payout>d__45 : IEnumerator<object> // TypeDefIndex: 13103
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ParlorUIManager <>4__this; // 0x20
		public int inPayout; // 0x28
		private float <t>5__2; // 0x2C

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <Payout>d__45(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181179C90-0x0000000181179EC0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181179EC0-0x0000000181179F10
	}

	// Constructors
	public ParlorUIManager(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	internal void Init(); // 0x000000018116FF80-0x0000000181170590
	internal void ShowDoubleUp(bool inShow, bool inOverDoubleUpLimit = false /* Metadata: 0x00783644 */); // 0x0000000181170600-0x0000000181170760
	[IteratorStateMachine] // 0x00000001800E3F40-0x00000001800E3F90
	internal IEnumerator DoFadeIn(); // 0x000000018116FF20-0x000000018116FF80
	internal void ShowPlayAgain(bool inShow); // 0x0000000181170900-0x0000000181170980
	internal void ShowNewGame(bool inShow); // 0x0000000180E772A0-0x0000000180E772D0
	internal void ShowExitGame(bool inShow); // 0x0000000181170760-0x0000000181170790
	internal void ShowExitParlor(bool inShow); // 0x0000000181170790-0x00000001811707C0
	private void ShowSelectGame(bool inShow); // 0x0000000181170AE0-0x0000000181170B30
	internal void ShowResults(bool inShow); // 0x0000000181170980-0x0000000181170AE0
	[IteratorStateMachine] // 0x00000001800E4240-0x00000001800E4290
	private IEnumerator Payout(int inPayout); // 0x0000000181170590-0x0000000181170600
	internal void ShowPayout(bool inShow, int inPayout = 0 /* Metadata: 0x00783645 */, bool inRefresh = true /* Metadata: 0x00783649 */); // 0x00000001811707C0-0x0000000181170900
	internal void ShowGameHud(bool inShow); // 0x0000000181005100-0x0000000181005120
	private void ShowWagerScreen(bool inShow); // 0x0000000181170DD0-0x0000000181170F20
	internal void ShowTutorial(bool inShow); // 0x0000000181170D20-0x0000000181170DD0
	private void ShowTutorialPage(); // 0x0000000181170B30-0x0000000181170D20
	public void BtnClicked_NoFundsOK(); // 0x000000018116F200-0x000000018116F240
	public void BtnClicked_PayoutOK(); // 0x000000018116F3B0-0x000000018116F470
	public void BtnClicked_SelectGame(int inGame); // 0x000000018116F700-0x000000018116F990
	public void BtnClicked_selectGameTutorial(); // 0x000000018116FD10-0x000000018116FF20
	public void BtnClicked_TutorialNextPage(); // 0x000000018116FB50-0x000000018116FB70
	public void BtnClicked_TutorialClose(); // 0x000000018116F990-0x000000018116FB50
	public void BtnClicked_SelectGameStart(); // 0x000000018116F650-0x000000018116F700
	public void WagerValidate(); // 0x0000000181170F50-0x0000000181171020
	public void BtnClicked_WagerScreenPlaceBet(); // 0x000000018116FCB0-0x000000018116FD10
	public void BtnClicked_WagerIncrease(); // 0x000000018116FBB0-0x000000018116FC10
	public void BtnClicked_WagerMax(); // 0x000000018116FC10-0x000000018116FCB0
	public void BtnClicked_WagerDecrease(); // 0x000000018116FB70-0x000000018116FBB0
	public void BtnClicked_DoubleUp(bool inYes); // 0x000000018116EDB0-0x000000018116EE80
	public void BtnClicked_PlayAgain(bool inYes); // 0x000000018116F470-0x000000018116F650
	public void BtnClicked_NewGame(bool inYes); // 0x000000018116F150-0x000000018116F200
	public void BtnClicked_ExitGame(bool inYes); // 0x000000018116EE80-0x000000018116F060
	public void BtnClicked_ExitParlor(bool inYes); // 0x000000018116F060-0x000000018116F150
	public void BtnClicked_Parlor_X(); // 0x000000018116F240-0x000000018116F3B0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <ShowDoubleUp>b__35_0(); // 0x0000000181170F20-0x0000000181170F50
}

