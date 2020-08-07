/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_CustomizationPageBody : MonoBehaviour // TypeDefIndex: 13531
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CanvasGroup _canvasGroup; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _titleText; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Transform _fullPageControlParent; // 0x30
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _assembledContentGroup; // 0x38
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Transform _navControlParent; // 0x40
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Transform _standardControlParent; // 0x48
	private UI_CustomizationPageInfo _currentPageInfo; // 0x50
	public List<UI_GoToCustomizationPage> navButtons; // 0x58

	// Properties
	public CanvasGroup CanvasGroup { get; } // 0x0000000180374AF0-0x0000000180374B00 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass11_0 // TypeDefIndex: 13532
	{
		// Fields
		public UI_CustomizationPageBody <>4__this; // 0x10
		public UI_CustomizationPageNavigationController inNavigationController; // 0x18

		// Constructors
		public <>c__DisplayClass11_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <Hide>b__0(); // 0x000000018053CFA0-0x000000018053D000
	}

	// Constructors
	public UI_CustomizationPageBody(); // 0x000000018054F1A0-0x000000018054F200

	// Methods
	public void Show(bool inForward); // 0x000000018054F010-0x000000018054F1A0
	public void Hide(bool inForward, UI_CustomizationPageNavigationController inNavigationController); // 0x000000018054EEC0-0x000000018054F010
	public void AttachPage(UI_CustomizationPageInfo inPage, UI_CustomizationPageNavigationController inNavigationController); // 0x000000018054E3E0-0x000000018054EAD0
	public void DetachPage(UI_CustomizationPageInfo inPage, UI_CustomizationPageNavigationController inNavigationController); // 0x000000018054EAD0-0x000000018054EEC0
}

