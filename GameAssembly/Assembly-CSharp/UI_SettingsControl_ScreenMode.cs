/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_SettingsControl_ScreenMode : MonoBehaviour // TypeDefIndex: 12201
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _screenModeText; // 0x20
	private bool _isFullscreen; // 0x28

	// Properties
	public bool IsFullscreen { get; private set; } // 0x00000001803A2790-0x00000001803A27A0 0x0000000180EF2F20-0x0000000180EF2FE0

	// Constructors
	public UI_SettingsControl_ScreenMode(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void Start(); // 0x0000000180EF2EC0-0x0000000180EF2F20
	public void BtnClicked_ScreenModeNext(); // 0x0000000180EF2DF0-0x0000000180EF2E00
	public void BtnClicked_ScreenModePrev(); // 0x0000000180EF2DF0-0x0000000180EF2E00
	private void RefreshScreenModeText(); // 0x0000000180EF2E00-0x0000000180EF2EC0
}

