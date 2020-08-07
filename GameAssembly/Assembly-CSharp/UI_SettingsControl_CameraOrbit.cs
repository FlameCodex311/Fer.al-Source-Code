/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_SettingsControl_CameraOrbit : MonoBehaviour // TypeDefIndex: 13745
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _valueText; // 0x20
	private bool _cameraOrbitSetting; // 0x28

	// Properties
	public bool CameraOrbitSetting { get; private set; } // 0x00000001804C6790-0x00000001804C67A0 0x00000001804C6980-0x00000001804C6A60

	// Constructors
	public UI_SettingsControl_CameraOrbit(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void Start(); // 0x00000001804C6920-0x00000001804C6980
	public void BtnClicked_Next(); // 0x00000001804C6880-0x00000001804C6890
	public void BtnClicked_Prev(); // 0x00000001804C6880-0x00000001804C6890
	private void RefreshText(); // 0x00000001804C6890-0x00000001804C6920
}

