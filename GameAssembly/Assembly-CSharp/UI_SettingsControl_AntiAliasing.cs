/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_SettingsControl_AntiAliasing : MonoBehaviour // TypeDefIndex: 13743
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _antiAliasingText; // 0x20
	private int _antiAliasing; // 0x28

	// Properties
	public int AntiAliasing { get; private set; } // 0x000000018043C680-0x000000018043C690 0x00000001804C65E0-0x00000001804C6690

	// Constructors
	public UI_SettingsControl_AntiAliasing(); // 0x00000001804C65D0-0x00000001804C65E0

	// Methods
	private void Start(); // 0x00000001804C6520-0x00000001804C65D0
	public void BtnClicked_Next(); // 0x00000001804C6400-0x00000001804C6430
	public void BtnClicked_Prev(); // 0x00000001804C6430-0x00000001804C6470
	private void RefreshAntiAliasingText(); // 0x00000001804C6470-0x00000001804C6520
}

