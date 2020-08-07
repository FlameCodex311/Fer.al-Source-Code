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

public class UI_CustomizationGoToPreviousPage : MonoBehaviour // TypeDefIndex: 13529
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _pageNameText; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _button; // 0x28
	private UI_CustomizationPageInfo _pageInfo; // 0x30
	private UI_CustomizationPageNavigationController _navController; // 0x38

	// Constructors
	public UI_CustomizationGoToPreviousPage(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void Awake(); // 0x000000018054D6F0-0x000000018054D8A0
	private void GoToPreviousPage(); // 0x000000018054D8A0-0x000000018054D950
	public void Setup(UI_CustomizationPageNavigationController inNavController, UI_CustomizationPageInfo inTargetPage); // 0x000000018054D950-0x000000018054DA20
}

