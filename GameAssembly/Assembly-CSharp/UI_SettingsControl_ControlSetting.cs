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

public class UI_SettingsControl_ControlSetting : MonoBehaviour // TypeDefIndex: 13746
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _controlSettingText; // 0x20
	private int _controlSetting; // 0x28
	[TupleElementNames] // 0x00000001801ED530-0x00000001801ED5B0
	private List<ValueTuple<GameSettingsManager.ControlSetting, string>> _controlSettings; // 0x30

	// Properties
	public int ControlSetting { get; private set; } // 0x000000018043C680-0x000000018043C690 0x00000001804C7140-0x00000001804C71F0

	// Constructors
	public UI_SettingsControl_ControlSetting(); // 0x00000001804C70E0-0x00000001804C7140

	// Methods
	private void Start(); // 0x00000001804C6C80-0x00000001804C70E0
	public void BtnClicked_Next(); // 0x00000001804C6A70-0x00000001804C6B10
	public void BtnClicked_Prev(); // 0x00000001804C6B10-0x00000001804C6BB0
	public void BtnClicked_ControlInfo(); // 0x00000001804C6A60-0x00000001804C6A70
	private void RefreshControlSettingText(); // 0x00000001804C6BB0-0x00000001804C6C80
}

