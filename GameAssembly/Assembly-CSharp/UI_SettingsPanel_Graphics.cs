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

public class UI_SettingsPanel_Graphics : MonoBehaviour // TypeDefIndex: 13753
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_SettingsControl_ScreenMode _screenModeControl; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_SettingsControl_GraphicsQuality _graphicsQualityControl; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _resolutionText; // 0x30
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _resolutionDownBtn; // 0x38
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _resolutionUpBtn; // 0x40
	private bool _isInitialized; // 0x48
	private Resolution _resolution; // 0x4C

	// Constructors
	public UI_SettingsPanel_Graphics(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void Start(); // 0x00000001804C8DD0-0x00000001804C8E90
	private void OnDestroy(); // 0x00000001804C8BE0-0x00000001804C8CA0
	private void RefreshResolutionText(); // 0x00000001804C8CA0-0x00000001804C8DD0
	public void BtnClicked_ResolutionDown(); // 0x00000001804C89A0-0x00000001804C8AB0
	public void BtnClicked_ResolutionUp(); // 0x00000001804C8AB0-0x00000001804C8BE0
}

