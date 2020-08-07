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

public class UI_SettingsPanel_Audio : MonoBehaviour // TypeDefIndex: 13750
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Slider _musicSlider; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _musicVolumeText; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _noMusicGroup; // 0x30
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Slider _sfxSlider; // 0x38
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _sfxVolumeText; // 0x40
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _noSfxGroup; // 0x48

	// Constructors
	public UI_SettingsPanel_Audio(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void OnEnable(); // 0x00000001804C7CC0-0x00000001804C7F10
	public void SliderValueChanged_MusicVolume(float inVolume); // 0x00000001804C7F10-0x00000001804C8040
	public void SliderValueChanged_SFXVolume(float inVolume); // 0x00000001804C8040-0x00000001804C8170
}

