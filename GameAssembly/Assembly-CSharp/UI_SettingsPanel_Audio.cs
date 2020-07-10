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

public class UI_SettingsPanel_Audio : MonoBehaviour // TypeDefIndex: 12202
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Slider _musicSlider; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _musicVolumeText; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _noMusicGroup; // 0x30
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Slider _sfxSlider; // 0x38
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _sfxVolumeText; // 0x40
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _noSfxGroup; // 0x48

	// Constructors
	public UI_SettingsPanel_Audio(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void OnEnable(); // 0x0000000180EF2FE0-0x0000000180EF3240
	public void SliderValueChanged_MusicVolume(float inVolume); // 0x0000000180EF3240-0x0000000180EF3370
	public void SliderValueChanged_SFXVolume(float inVolume); // 0x0000000180EF3370-0x0000000180EF34A0
}

