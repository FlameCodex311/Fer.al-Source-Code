/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ExecuteAlways] // 0x00000001800B36B0-0x00000001800B36C0
public class UI_ChatPanel_Emoji : MonoBehaviour // TypeDefIndex: 11935
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CanvasGroup _canvasGroup; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private EmojiGridLayoutGroup _gridLayout; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Canvas _windowedCanvas; // 0x30
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Canvas _expandedCanvas; // 0x38
	private bool? _gridExceedsBounds; // 0x40

	// Constructors
	public UI_ChatPanel_Emoji(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	public void ToggleBtnClicked_Emoji(bool inIsOn); // 0x0000000180F23710-0x0000000180F23820
	private void Start(); // 0x0000000180F23620-0x0000000180F23710
	private void RefreshCanvasChoice(); // 0x0000000180F23440-0x0000000180F23620
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <ToggleBtnClicked_Emoji>b__5_0(); // 0x0000000180F23820-0x0000000180F23850
}

