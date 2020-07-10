/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class CodeBreakerTutorial : MonoBehaviour // TypeDefIndex: 12908
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
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12909
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<bool> <>9__7_0; // 0x08

		// Constructors
		static <>c(); // 0x0000000181282190-0x00000001812821F0
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <Start>b__7_0(); // 0x0000000181281B70-0x0000000181281C10
	}

	// Constructors
	public CodeBreakerTutorial(); // 0x0000000181277060-0x0000000181277070

	// Methods
	private void Start(); // 0x0000000181276E30-0x0000000181276F50
	private void OnDestroy(); // 0x0000000181276A20-0x0000000181276AF0
	public void Restart(); // 0x0000000181276E20-0x0000000181276E30
	private void OnIngredientSelected(IngredientSelectedMessage inMessage); // 0x0000000181276C90-0x0000000181276E10
	private void OnIngredientDropped(IngredientDropMessage inMessage); // 0x0000000181276AF0-0x0000000181276C90
	private void Update(); // 0x0000000181277040-0x0000000181277060
	private void GoToState(int inState); // 0x0000000181275F30-0x0000000181275FF0
	private void HandleStateLeave(int leaveState); // 0x0000000181276450-0x00000001812764F0
	private void HandleStateEnter(int enterState); // 0x0000000181275FF0-0x0000000181276450
	private void HandleStateUpdate(int inState); // 0x00000001812764F0-0x0000000181276A20
	public void BtnClicked_TutorialDrop(); // 0x0000000181275C90-0x0000000181275D90
	public void BtnClicked_TutorialMix(); // 0x0000000181275D90-0x0000000181275E40
	public void BtnClicked_TutorialQuitPopup(); // 0x0000000181275EF0-0x0000000181275F30
	public void QuitPopupClosed(); // 0x0000000181276E10-0x0000000181276E20
	public void BtnClicked_TutorialPopup(); // 0x0000000181275E40-0x0000000181275EF0
	public void TutorialPopupClosed(); // 0x00000001803581E0-0x00000001803581F0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Start>b__7_1(); // 0x0000000181276F70-0x0000000181277040
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <HandleStateEnter>b__15_0(); // 0x0000000181276F60-0x0000000181276F70
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <BtnClicked_TutorialMix>b__18_0(); // 0x0000000181276F50-0x0000000181276F60
}

