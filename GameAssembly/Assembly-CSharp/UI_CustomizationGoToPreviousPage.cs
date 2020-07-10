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

public class UI_CustomizationGoToPreviousPage : MonoBehaviour // TypeDefIndex: 11983
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _pageNameText; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _button; // 0x28
	private UI_CustomizationPageInfo _pageInfo; // 0x30
	private UI_CustomizationPageNavigationController _navController; // 0x38

	// Constructors
	public UI_CustomizationGoToPreviousPage(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void Awake(); // 0x0000000180F2FF90-0x0000000180F30140
	private void GoToPreviousPage(); // 0x0000000180F30140-0x0000000180F301F0
	public void Setup(UI_CustomizationPageNavigationController inNavController, UI_CustomizationPageInfo inTargetPage); // 0x0000000180F301F0-0x0000000180F302C0
}

