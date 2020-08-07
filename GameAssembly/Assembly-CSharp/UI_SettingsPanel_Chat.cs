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

public class UI_SettingsPanel_Chat : MonoBehaviour // TypeDefIndex: 13751
{
	// Fields
	[Header] // 0x00000001801EE620-0x00000001801EE670
	[SerializeField] // 0x00000001801EE620-0x00000001801EE670
	private FeralButton _chatBubbleToggle; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _chatBubbleValueText; // 0x28
	[Header] // 0x00000001801EEAE0-0x00000001801EEB30
	[SerializeField] // 0x00000001801EEAE0-0x00000001801EEB30
	private FeralButton _chatFilterToggle; // 0x30
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _chatFilterValueText; // 0x38

	// Constructors
	public UI_SettingsPanel_Chat(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void Start(); // 0x00000001804C8450-0x00000001804C8550
	private void OnEnable(); // 0x00000001804C82E0-0x00000001804C8450
	public void BtnClicked_ChatFilterInfo(); // 0x00000001804C8220-0x00000001804C8230
	private void BtnClicked_ChatBubbleToggle(bool inIsOn); // 0x00000001804C8170-0x00000001804C8220
	private void BtnClicked_ChatFilterToggle(bool inIsOn); // 0x00000001804C8230-0x00000001804C82E0
}

