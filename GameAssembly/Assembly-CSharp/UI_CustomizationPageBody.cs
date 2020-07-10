/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_CustomizationPageBody : MonoBehaviour // TypeDefIndex: 11985
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CanvasGroup _canvasGroup; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _titleText; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Transform _fullPageControlParent; // 0x30
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _assembledContentGroup; // 0x38
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Transform _navControlParent; // 0x40
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Transform _standardControlParent; // 0x48
	private UI_CustomizationPageInfo _currentPageInfo; // 0x50
	public List<UI_GoToCustomizationPage> navButtons; // 0x58

	// Properties
	public CanvasGroup CanvasGroup { get; } // 0x000000018036AC70-0x000000018036AC80 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass11_0 // TypeDefIndex: 11986
	{
		// Fields
		public UI_CustomizationPageBody <>4__this; // 0x10
		public UI_CustomizationPageNavigationController inNavigationController; // 0x18

		// Constructors
		public <>c__DisplayClass11_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <Hide>b__0(); // 0x0000000180F1F040-0x0000000180F1F0A0
	}

	// Constructors
	public UI_CustomizationPageBody(); // 0x0000000180F31AD0-0x0000000180F31B30

	// Methods
	public void Show(bool inForward); // 0x0000000180F31940-0x0000000180F31AD0
	public void Hide(bool inForward, UI_CustomizationPageNavigationController inNavigationController); // 0x0000000180F317F0-0x0000000180F31940
	public void AttachPage(UI_CustomizationPageInfo inPage, UI_CustomizationPageNavigationController inNavigationController); // 0x0000000180F30CC0-0x0000000180F313F0
	public void DetachPage(UI_CustomizationPageInfo inPage, UI_CustomizationPageNavigationController inNavigationController); // 0x0000000180F313F0-0x0000000180F317F0
}

