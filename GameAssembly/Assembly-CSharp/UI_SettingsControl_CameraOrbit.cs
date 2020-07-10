/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_SettingsControl_CameraOrbit : MonoBehaviour // TypeDefIndex: 12198
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _valueText; // 0x20
	private bool _cameraOrbitSetting; // 0x28

	// Properties
	public bool CameraOrbitSetting { get; private set; } // 0x00000001803A2790-0x00000001803A27A0 0x0000000180EF2080-0x0000000180EF2160

	// Constructors
	public UI_SettingsControl_CameraOrbit(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void Start(); // 0x0000000180EF2020-0x0000000180EF2080
	public void BtnClicked_Next(); // 0x0000000180EF1F80-0x0000000180EF1F90
	public void BtnClicked_Prev(); // 0x0000000180EF1F80-0x0000000180EF1F90
	private void RefreshText(); // 0x0000000180EF1F90-0x0000000180EF2020
}

