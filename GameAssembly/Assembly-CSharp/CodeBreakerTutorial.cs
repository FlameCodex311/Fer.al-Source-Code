/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class CodeBreakerTutorial : MonoBehaviour // TypeDefIndex: 10573
{
	// Fields
	public CodeBreakerGame game; // 0x20
	public CodeBreakerDialogPopup tutorialDialog; // 0x28
	public List<CodeBreakerTutorialStep> tutorialSteps; // 0x30
	public GameObject tutorialButton; // 0x38
	public GameObject quitButton; // 0x40
	private int _tutorialState; // 0x48
	private bool _showingQuitConfirmation; // 0x4C

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 10574
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<bool> <>9__7_0; // 0x08

		// Constructors
		static <>c(); // 0x0000000180538BA0-0x0000000180538C00
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <Start>b__7_0(); // 0x0000000180538380-0x0000000180538420
	}

	// Constructors
	public CodeBreakerTutorial(); // 0x000000018052F750-0x000000018052F760

	// Methods
	private void Start(); // 0x000000018052F520-0x000000018052F640
	private void OnDestroy(); // 0x000000018052F140-0x000000018052F210
	public void Restart(); // 0x000000018052F510-0x000000018052F520
	private void OnIngredientSelected(IngredientSelectedMessage inMessage); // 0x000000018052F390-0x000000018052F500
	private void OnIngredientDropped(IngredientDropMessage inMessage); // 0x000000018052F210-0x000000018052F390
	private void Update(); // 0x000000018052F730-0x000000018052F750
	private void GoToState(int inState); // 0x000000018052E680-0x000000018052E740
	private void HandleStateLeave(int leaveState); // 0x000000018052EB80-0x000000018052EC20
	private void HandleStateEnter(int enterState); // 0x000000018052E740-0x000000018052EB80
	private void HandleStateUpdate(int inState); // 0x000000018052EC20-0x000000018052F140
	public void BtnClicked_TutorialDrop(); // 0x000000018052E3E0-0x000000018052E4E0
	public void BtnClicked_TutorialMix(); // 0x000000018052E4E0-0x000000018052E590
	public void BtnClicked_TutorialQuitPopup(); // 0x000000018052E640-0x000000018052E680
	public void QuitPopupClosed(); // 0x000000018052F500-0x000000018052F510
	public void BtnClicked_TutorialPopup(); // 0x000000018052E590-0x000000018052E640
	public void TutorialPopupClosed(); // 0x00000001803774A0-0x00000001803774B0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Start>b__7_1(); // 0x000000018052F660-0x000000018052F730
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <HandleStateEnter>b__15_0(); // 0x000000018052F650-0x000000018052F660
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <BtnClicked_TutorialMix>b__18_0(); // 0x000000018052F640-0x000000018052F650
}

