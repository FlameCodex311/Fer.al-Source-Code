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

public class UI_XPIndicator : MonoBehaviour // TypeDefIndex: 12635
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _levelText; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWImage _levelProgressImage; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_Tooltip _tooltip; // 0x30
	private string _userUUID; // 0x38
	private IPlayerLevel _playerLevel; // 0x40

	// Constructors
	public UI_XPIndicator(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	public void Setup(string inUserUUID); // 0x0000000180F88AE0-0x0000000180F88B40
	private void RefreshGraphics(); // 0x0000000180F88830-0x0000000180F88AE0
	private void GetPlayerLevel(); // 0x0000000180F887E0-0x0000000180F88830
}

