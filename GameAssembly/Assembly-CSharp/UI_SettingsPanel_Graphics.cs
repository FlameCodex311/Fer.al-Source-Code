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

public class UI_SettingsPanel_Graphics : MonoBehaviour // TypeDefIndex: 12205
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_SettingsControl_ScreenMode _screenModeControl; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_SettingsControl_GraphicsQuality _graphicsQualityControl; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _resolutionText; // 0x30
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _resolutionDownBtn; // 0x38
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _resolutionUpBtn; // 0x40
	private Resolution _resolution; // 0x48

	// Constructors
	public UI_SettingsPanel_Graphics(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void Start(); // 0x0000000180EF4130-0x0000000180EF41F0
	private void OnDestroy(); // 0x0000000180EF3F40-0x0000000180EF4000
	private void RefreshResolutionText(); // 0x0000000180EF4000-0x0000000180EF4130
	public void BtnClicked_ResolutionDown(); // 0x0000000180EF3CF0-0x0000000180EF3E00
	public void BtnClicked_ResolutionUp(); // 0x0000000180EF3E00-0x0000000180EF3F40
}

