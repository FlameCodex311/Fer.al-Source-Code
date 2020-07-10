/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_PlayerStats : MonoBehaviour // TypeDefIndex: 12335
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _playerNameText; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _currencyText; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _levelNumText; // 0x30
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_XPIndicator _xpIndicator; // 0x38

	// Constructors
	public UI_PlayerStats(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void OnEnable(); // 0x0000000180EE2490-0x0000000180EE2570
	private void OnDisable(); // 0x0000000180EE23C0-0x0000000180EE2490
	private void RefreshName(); // 0x0000000180EE2800-0x0000000180EE28A0
	private void OnLevelLoaded(Message inMessage); // 0x0000000180EE2670-0x0000000180EE2800
	private void OnInventoryItemAdded(InventoryItemAddedEvent inMessage); // 0x0000000180EE2570-0x0000000180EE2670
}

