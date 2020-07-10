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

public class UI_SettingsPanel_Chat : MonoBehaviour // TypeDefIndex: 12203
{
	// Fields
	[Header] // 0x000000018010C5F0-0x000000018010C640
	[SerializeField] // 0x000000018010C5F0-0x000000018010C640
	private FeralButton _chatBubbleToggle; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _chatBubbleValueText; // 0x28
	[Header] // 0x000000018010C840-0x000000018010C890
	[SerializeField] // 0x000000018010C840-0x000000018010C890
	private FeralButton _chatFilterToggle; // 0x30
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _chatFilterValueText; // 0x38

	// Constructors
	public UI_SettingsPanel_Chat(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void Start(); // 0x0000000180EF3790-0x0000000180EF38A0
	private void OnEnable(); // 0x0000000180EF3610-0x0000000180EF3790
	public void BtnClicked_ChatFilterInfo(); // 0x0000000180EF3550-0x0000000180EF3560
	private void BtnClicked_ChatBubbleToggle(bool inIsOn); // 0x0000000180EF34A0-0x0000000180EF3550
	private void BtnClicked_ChatFilterToggle(bool inIsOn); // 0x0000000180EF3560-0x0000000180EF3610
}

