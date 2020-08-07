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

public class UI_SettingsControl_GraphicsQuality : MonoBehaviour // TypeDefIndex: 13747
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _qualityLevelText; // 0x20
	private DeviceQualityLevel _qualityLevel; // 0x28
	private List<DeviceQualityLevel> _qualityLevels; // 0x30
	private Dictionary<DeviceQualityLevel, string> _qualityLevelNames; // 0x38

	// Properties
	public DeviceQualityLevel QualityLevel { get; private set; } // 0x000000018043C680-0x000000018043C690 0x00000001804C7650-0x00000001804C7700

	// Constructors
	public UI_SettingsControl_GraphicsQuality(); // 0x00000001804C74E0-0x00000001804C7650

	// Methods
	private void Start(); // 0x00000001804C7480-0x00000001804C74E0
	public void BtnClicked_Next(); // 0x00000001804C71F0-0x00000001804C72E0
	public void BtnClicked_Prev(); // 0x00000001804C72E0-0x00000001804C73D0
	private void RefreshQualityText(); // 0x00000001804C73D0-0x00000001804C7480
}

