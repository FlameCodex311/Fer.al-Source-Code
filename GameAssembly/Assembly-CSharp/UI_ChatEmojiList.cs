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

public class UI_ChatEmojiList : MonoBehaviour // TypeDefIndex: 13475
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_ChatEmojiItem _emojiItem; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Transform _emojiParent; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private TMP_InputField _chatInput; // 0x30
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _toggleEmojiBtn; // 0x38

	// Constructors
	public UI_ChatEmojiList(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void Start(); // 0x0000000180540660-0x0000000180540670
	private void SpawnListItems(); // 0x0000000180540520-0x0000000180540660
	private void SpawnListItem(ChatEmojiDefComponent inEmoji); // 0x0000000180540360-0x0000000180540520
	private void OnEmojiClicked(ChatEmojiDefComponent inEmoji); // 0x0000000180540250-0x0000000180540360
}

