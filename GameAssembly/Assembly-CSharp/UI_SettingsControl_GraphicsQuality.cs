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

public class UI_SettingsControl_GraphicsQuality : MonoBehaviour // TypeDefIndex: 12200
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _qualityLevelText; // 0x20
	private DeviceQualityLevel _qualityLevel; // 0x28
	private List<DeviceQualityLevel> _qualityLevels; // 0x30

	// Properties
	public DeviceQualityLevel QualityLevel { get; private set; } // 0x000000018038E0E0-0x000000018038E0F0 0x0000000180EF2D00-0x0000000180EF2DF0

	// Constructors
	public UI_SettingsControl_GraphicsQuality(); // 0x0000000180EF2C30-0x0000000180EF2D00

	// Methods
	private void Start(); // 0x0000000180EF2BD0-0x0000000180EF2C30
	public void BtnClicked_Next(); // 0x0000000180EF2900-0x0000000180EF29F0
	public void BtnClicked_Prev(); // 0x0000000180EF29F0-0x0000000180EF2AE0
	private void RefreshQualityText(); // 0x0000000180EF2AE0-0x0000000180EF2BD0
}

