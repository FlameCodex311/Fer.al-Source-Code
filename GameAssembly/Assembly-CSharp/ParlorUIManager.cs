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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class ParlorUIManager : MonoBehaviour // TypeDefIndex: 10766
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
	internal int Wager { get; set; } // 0x00000001804DE030-0x00000001804DE040 0x00000001804DE040-0x00000001804DE140

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <DoFadeIn>d__38 : IEnumerator<object> // TypeDefIndex: 10767
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ParlorUIManager <>4__this; // 0x20
		private Color <startColor>5__2; // 0x28
		private Color <endColor>5__3; // 0x38
		private float <t>5__4; // 0x48

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <DoFadeIn>d__38(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001804EA980-0x00000001804EAB40
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001804EAB40-0x00000001804EAB90
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <Payout>d__45 : IEnumerator<object> // TypeDefIndex: 10768
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ParlorUIManager <>4__this; // 0x20
		public int inPayout; // 0x28
		private float <t>5__2; // 0x2C

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <Payout>d__45(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001804EB090-0x00000001804EB2B0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001804EB2B0-0x00000001804EB300
	}

	// Constructors
	public ParlorUIManager(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	internal void Init(); // 0x00000001804DCFF0-0x00000001804DD5C0
	internal void ShowDoubleUp(bool inShow, bool inOverDoubleUpLimit = false /* Metadata: 0x0077C0FF */); // 0x00000001804DD630-0x00000001804DD790
	[IteratorStateMachine] // 0x000000018027F670-0x000000018027F6C0
	internal IEnumerator DoFadeIn(); // 0x00000001804DCF90-0x00000001804DCFF0
	internal void ShowPlayAgain(bool inShow); // 0x00000001804DD940-0x00000001804DD9C0
	internal void ShowNewGame(bool inShow); // 0x00000001803A8DF0-0x00000001803A8E20
	internal void ShowExitGame(bool inShow); // 0x00000001804DD790-0x00000001804DD7C0
	internal void ShowExitParlor(bool inShow); // 0x00000001804DD7C0-0x00000001804DD7F0
	private void ShowSelectGame(bool inShow); // 0x00000001804DDB20-0x00000001804DDB60
	internal void ShowResults(bool inShow); // 0x00000001804DD9C0-0x00000001804DDB20
	[IteratorStateMachine] // 0x000000018027F830-0x000000018027F880
	private IEnumerator Payout(int inPayout); // 0x00000001804DD5C0-0x00000001804DD630
	internal void ShowPayout(bool inShow, int inPayout = 0 /* Metadata: 0x0077C100 */, bool inRefresh = true /* Metadata: 0x0077C104 */); // 0x00000001804DD810-0x00000001804DD940
	internal void ShowGameHud(bool inShow); // 0x00000001804DD7F0-0x00000001804DD810
	private void ShowWagerScreen(bool inShow); // 0x00000001804DDDE0-0x00000001804DDF30
	internal void ShowTutorial(bool inShow); // 0x00000001804DDD30-0x00000001804DDDE0
	private void ShowTutorialPage(); // 0x00000001804DDB60-0x00000001804DDD30
	public void BtnClicked_NoFundsOK(); // 0x00000001804DC110-0x00000001804DC160
	public void BtnClicked_PayoutOK(); // 0x00000001804DC2D0-0x00000001804DC390
	public void BtnClicked_SelectGame(int inGame); // 0x00000001804DC610-0x00000001804DC880
	public void BtnClicked_selectGameTutorial(); // 0x00000001804DCD80-0x00000001804DCF90
	public void BtnClicked_TutorialNextPage(); // 0x00000001804DCA30-0x00000001804DCA50
	public void BtnClicked_TutorialClose(); // 0x00000001804DC880-0x00000001804DCA30
	public void BtnClicked_SelectGameStart(); // 0x00000001804DC570-0x00000001804DC610
	public void WagerValidate(); // 0x00000001804DDF60-0x00000001804DE030
	public void BtnClicked_WagerScreenPlaceBet(); // 0x00000001804DCB80-0x00000001804DCD80
	public void BtnClicked_WagerIncrease(); // 0x00000001804DCA90-0x00000001804DCAF0
	public void BtnClicked_WagerMax(); // 0x00000001804DCAF0-0x00000001804DCB80
	public void BtnClicked_WagerDecrease(); // 0x00000001804DCA50-0x00000001804DCA90
	public void BtnClicked_DoubleUp(bool inYes); // 0x00000001804DBCD0-0x00000001804DBDA0
	public void BtnClicked_PlayAgain(bool inYes); // 0x00000001804DC390-0x00000001804DC570
	public void BtnClicked_NewGame(bool inYes); // 0x00000001804DC060-0x00000001804DC110
	public void BtnClicked_ExitGame(bool inYes); // 0x00000001804DBDA0-0x00000001804DBF70
	public void BtnClicked_ExitParlor(bool inYes); // 0x00000001804DBF70-0x00000001804DC060
	public void BtnClicked_Parlor_X(); // 0x00000001804DC160-0x00000001804DC2D0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <ShowDoubleUp>b__35_0(); // 0x00000001804DDF30-0x00000001804DDF60
}

