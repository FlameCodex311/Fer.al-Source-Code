/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_ChatPanel_Settings : MonoBehaviour // TypeDefIndex: 11946
{
	// Fields
	private const string KEY_TEXTSIZE = "ChatSetting_TextSize"; // Metadata: 0x00782D13
	private const string KEY_OPACITY = "ChatSetting_Opacity"; // Metadata: 0x00782D2B
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_Window_Chat _chatWindow; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _textSizeText; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _opacityText; // 0x30
	private int? _textSize; // 0x38
	private int? _opacity; // 0x40

	// Properties
	private int TextSize { get; set; } // 0x0000000180F25900-0x0000000180F25A20 0x0000000180F25B60-0x0000000180F25CA0
	private int Opacity { get; set; } // 0x0000000180F25780-0x0000000180F25900 0x0000000180F25A20-0x0000000180F25B60

	// Constructors
	public UI_ChatPanel_Settings(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void Awake(); // 0x0000000180F25540-0x0000000180F25560
	private void OnTextSizeChanged(); // 0x0000000180F256D0-0x0000000180F25780
	private void OnOpacityChanged(); // 0x0000000180F25620-0x0000000180F256D0
	public void BtnClicked_TextSize_Increase(); // 0x0000000180F255F0-0x0000000180F25620
	public void BtnClicked_TextSize_Decrease(); // 0x0000000180F255C0-0x0000000180F255F0
	public void BtnClicked_Opacity_Increase(); // 0x0000000180F25590-0x0000000180F255C0
	public void BtnClicked_Opacity_Decrease(); // 0x0000000180F25560-0x0000000180F25590
}

