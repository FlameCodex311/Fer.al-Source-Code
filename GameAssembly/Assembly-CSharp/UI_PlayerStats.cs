/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_PlayerStats : MonoBehaviour // TypeDefIndex: 13919
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _playerNameText; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _currencyText; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _levelNumText; // 0x30
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_XPIndicator _xpIndicator; // 0x38

	// Constructors
	public UI_PlayerStats(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void OnEnable(); // 0x00000001803D18C0-0x00000001803D19A0
	private void OnDisable(); // 0x00000001803D17F0-0x00000001803D18C0
	private void RefreshName(); // 0x00000001803D1C20-0x00000001803D1CC0
	private void OnLevelLoaded(Message inMessage); // 0x00000001803D1AA0-0x00000001803D1C20
	private void OnInventoryItemAdded(InventoryItemAddedEvent inMessage); // 0x00000001803D19A0-0x00000001803D1AA0
}

