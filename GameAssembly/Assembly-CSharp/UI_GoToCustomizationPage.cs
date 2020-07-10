/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_GoToCustomizationPage : MonoBehaviour // TypeDefIndex: 11990
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _button; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _text; // 0x28
	private UI_CustomizationPageNavigationController _navController; // 0x30
	private UI_CustomizationPageInfo _pageInfo; // 0x38

	// Constructors
	public UI_GoToCustomizationPage(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void Awake(); // 0x0000000180E40E90-0x0000000180E40F60
	private void GoToCustomizationPage(); // 0x0000000180E40F60-0x0000000180E41020
	public void Setup(UI_CustomizationPageNavigationController inNavController, UI_CustomizationPageInfo inPageInfo); // 0x0000000180E41020-0x0000000180E41180
}

