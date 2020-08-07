/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_SettingsControl_CameraFollow : MonoBehaviour // TypeDefIndex: 13744
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _valueText; // 0x20
	private bool _cameraFollowSetting; // 0x28

	// Properties
	public bool CameraFollowSetting { get; private set; } // 0x00000001804C6790-0x00000001804C67A0 0x00000001804C67A0-0x00000001804C6880

	// Constructors
	public UI_SettingsControl_CameraFollow(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void Start(); // 0x00000001804C6730-0x00000001804C6790
	public void BtnClicked_Next(); // 0x00000001804C6690-0x00000001804C66A0
	public void BtnClicked_Prev(); // 0x00000001804C6690-0x00000001804C66A0
	private void RefreshText(); // 0x00000001804C66A0-0x00000001804C6730
}

