/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_ChatPanel_Settings : MonoBehaviour // TypeDefIndex: 13492
{
	// Fields
	private const string KEY_TEXTSIZE = "ChatSetting_TextSize"; // Metadata: 0x007BA421
	private const string KEY_OPACITY = "ChatSetting_Opacity"; // Metadata: 0x007BA439
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_Window_Chat _chatWindow; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _textSizeText; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _opacityText; // 0x30
	private int? _textSize; // 0x38
	private int? _opacity; // 0x40

	// Properties
	private int TextSize { get; set; } // 0x0000000180543370-0x0000000180543490 0x00000001805435D0-0x0000000180543710
	private int Opacity { get; set; } // 0x00000001805431F0-0x0000000180543370 0x0000000180543490-0x00000001805435D0

	// Constructors
	public UI_ChatPanel_Settings(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void Awake(); // 0x0000000180542FB0-0x0000000180542FD0
	private void OnTextSizeChanged(); // 0x0000000180543140-0x00000001805431F0
	private void OnOpacityChanged(); // 0x0000000180543090-0x0000000180543140
	public void BtnClicked_TextSize_Increase(); // 0x0000000180543060-0x0000000180543090
	public void BtnClicked_TextSize_Decrease(); // 0x0000000180543030-0x0000000180543060
	public void BtnClicked_Opacity_Increase(); // 0x0000000180543000-0x0000000180543030
	public void BtnClicked_Opacity_Decrease(); // 0x0000000180542FD0-0x0000000180543000
}

