/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_GoToCustomizationPage : MonoBehaviour // TypeDefIndex: 13536
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _button; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _text; // 0x28
	private UI_CustomizationPageNavigationController _navController; // 0x30
	private UI_CustomizationPageInfo _pageInfo; // 0x38

	// Constructors
	public UI_GoToCustomizationPage(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void Awake(); // 0x0000000180378690-0x0000000180378750
	private void GoToCustomizationPage(); // 0x0000000180378750-0x0000000180378810
	public void Setup(UI_CustomizationPageNavigationController inNavController, UI_CustomizationPageInfo inPageInfo); // 0x0000000180378810-0x0000000180378970
}

