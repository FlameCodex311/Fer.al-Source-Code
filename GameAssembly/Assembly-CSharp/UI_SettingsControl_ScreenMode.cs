/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_SettingsControl_ScreenMode : MonoBehaviour // TypeDefIndex: 13749
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _screenModeText; // 0x20
	private bool _isFullscreen; // 0x28

	// Properties
	public bool IsFullscreen { get; private set; } // 0x00000001804C6790-0x00000001804C67A0 0x00000001804C7C00-0x00000001804C7CC0

	// Constructors
	public UI_SettingsControl_ScreenMode(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void Start(); // 0x00000001804C7BA0-0x00000001804C7C00
	public void BtnClicked_ScreenModeNext(); // 0x00000001804C7AE0-0x00000001804C7AF0
	public void BtnClicked_ScreenModePrev(); // 0x00000001804C7AE0-0x00000001804C7AF0
	private void RefreshScreenModeText(); // 0x00000001804C7AF0-0x00000001804C7BA0
}

