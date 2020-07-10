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

public class UI_SettingsControl_ControlSetting : MonoBehaviour // TypeDefIndex: 12199
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _controlSettingText; // 0x20
	private int _controlSetting; // 0x28
	[TupleElementNames] // 0x000000018010BD90-0x000000018010BE10
	private List<ValueTuple<GameSettingsManager.ControlSetting, string>> _controlSettings; // 0x30

	// Properties
	public int ControlSetting { get; private set; } // 0x000000018038E0E0-0x000000018038E0F0 0x0000000180EF2840-0x0000000180EF2900

	// Constructors
	public UI_SettingsControl_ControlSetting(); // 0x0000000180EF27E0-0x0000000180EF2840

	// Methods
	private void Start(); // 0x0000000180EF2380-0x0000000180EF27E0
	public void BtnClicked_Next(); // 0x0000000180EF2170-0x0000000180EF2210
	public void BtnClicked_Prev(); // 0x0000000180EF2210-0x0000000180EF22B0
	public void BtnClicked_ControlInfo(); // 0x0000000180EF2160-0x0000000180EF2170
	private void RefreshControlSettingText(); // 0x0000000180EF22B0-0x0000000180EF2380
}

