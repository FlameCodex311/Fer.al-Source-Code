/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_SettingsControl_AntiAliasing : MonoBehaviour // TypeDefIndex: 12196
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _antiAliasingText; // 0x20
	private int _antiAliasing; // 0x28

	// Properties
	public int AntiAliasing { get; private set; } // 0x000000018038E0E0-0x000000018038E0F0 0x0000000180EF1CE0-0x0000000180EF1DA0

	// Constructors
	public UI_SettingsControl_AntiAliasing(); // 0x0000000180EF1CD0-0x0000000180EF1CE0

	// Methods
	private void Start(); // 0x0000000180EF1C20-0x0000000180EF1CD0
	public void BtnClicked_Next(); // 0x0000000180EF1B00-0x0000000180EF1B30
	public void BtnClicked_Prev(); // 0x0000000180EF1B30-0x0000000180EF1B70
	private void RefreshAntiAliasingText(); // 0x0000000180EF1B70-0x0000000180EF1C20
}

