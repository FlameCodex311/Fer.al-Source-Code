/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_ChatEmojiItem : MonoBehaviour // TypeDefIndex: 13474
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _text; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_Tooltip _tooltip; // 0x28
	private ChatEmojiDefComponent _emoji; // 0x30
	private Action<ChatEmojiDefComponent> _onClickedAction; // 0x38

	// Constructors
	public UI_ChatEmojiItem(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	public void Setup(ChatEmojiDefComponent inEmoji, Action<ChatEmojiDefComponent> inOnClickedAction); // 0x0000000180540150-0x0000000180540250
	public void BtnClicked_Emoji(); // 0x0000000180540100-0x0000000180540150
}

