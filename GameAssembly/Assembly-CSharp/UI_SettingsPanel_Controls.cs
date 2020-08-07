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

public class UI_SettingsPanel_Controls : MonoBehaviour // TypeDefIndex: 13752
{
	// Fields
	[Header] // 0x00000001801EED50-0x00000001801EEDA0
	[SerializeField] // 0x00000001801EED50-0x00000001801EEDA0
	private Slider _sensitivitySlider; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _sensitivityValueText; // 0x28
	[Header] // 0x00000001801EF0A0-0x00000001801EF0F0
	[SerializeField] // 0x00000001801EF0A0-0x00000001801EF0F0
	private FeralButton _invertCameraToggleBtn; // 0x30
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _invertCameraValueText; // 0x38

	// Constructors
	public UI_SettingsPanel_Controls(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void Start(); // 0x00000001804C8790-0x00000001804C89A0
	private void OnEnable(); // 0x00000001804C8610-0x00000001804C86E0
	public void BtnClicked_Hotkeys(); // 0x00000001804C8550-0x00000001804C8560
	private void SliderValueChanged_CameraSensitivity(float inSensitivity); // 0x00000001804C86E0-0x00000001804C8790
	private void BtnClicked_InvertCameraToggle(bool inIsOn); // 0x00000001804C8560-0x00000001804C8610
}

