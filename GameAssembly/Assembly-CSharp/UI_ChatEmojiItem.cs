/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_ChatEmojiItem : MonoBehaviour // TypeDefIndex: 11928
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _text; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_Tooltip _tooltip; // 0x28
	private ChatEmojiDefComponent _emoji; // 0x30
	private Action<ChatEmojiDefComponent> _onClickedAction; // 0x38

	// Constructors
	public UI_ChatEmojiItem(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	public void Setup(ChatEmojiDefComponent inEmoji, Action<ChatEmojiDefComponent> inOnClickedAction); // 0x0000000180F226D0-0x0000000180F227E0
	public void BtnClicked_Emoji(); // 0x0000000180F22680-0x0000000180F226D0
}

