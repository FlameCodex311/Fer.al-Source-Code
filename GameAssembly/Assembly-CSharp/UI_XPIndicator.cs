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

public class UI_XPIndicator : MonoBehaviour // TypeDefIndex: 14237
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _levelText; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWImage _levelProgressImage; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_Tooltip _tooltip; // 0x30
	private string _userUUID; // 0x38
	private IPlayerLevel _playerLevel; // 0x40

	// Constructors
	public UI_XPIndicator(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	public void Setup(string inUserUUID); // 0x0000000180454940-0x00000001804549A0
	private void RefreshGraphics(); // 0x00000001804546B0-0x0000000180454940
	private void GetPlayerLevel(); // 0x0000000180454660-0x00000001804546B0
}

