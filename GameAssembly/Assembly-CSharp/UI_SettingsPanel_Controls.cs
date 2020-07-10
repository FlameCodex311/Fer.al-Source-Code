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

public class UI_SettingsPanel_Controls : MonoBehaviour // TypeDefIndex: 12204
{
	// Fields
	[Header] // 0x000000018010CA30-0x000000018010CA80
	[SerializeField] // 0x000000018010CA30-0x000000018010CA80
	private Slider _sensitivitySlider; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _sensitivityValueText; // 0x28
	[Header] // 0x000000018010CB90-0x000000018010CBE0
	[SerializeField] // 0x000000018010CB90-0x000000018010CBE0
	private FeralButton _invertCameraToggleBtn; // 0x30
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _invertCameraValueText; // 0x38

	// Constructors
	public UI_SettingsPanel_Controls(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void Start(); // 0x0000000180EF3AE0-0x0000000180EF3CF0
	private void OnEnable(); // 0x0000000180EF3960-0x0000000180EF3A30
	public void BtnClicked_Hotkeys(); // 0x0000000180EF38A0-0x0000000180EF38B0
	private void SliderValueChanged_CameraSensitivity(float inSensitivity); // 0x0000000180EF3A30-0x0000000180EF3AE0
	private void BtnClicked_InvertCameraToggle(bool inIsOn); // 0x0000000180EF38B0-0x0000000180EF3960
}

