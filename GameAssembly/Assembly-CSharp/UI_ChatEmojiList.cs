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

public class UI_ChatEmojiList : MonoBehaviour // TypeDefIndex: 11929
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_ChatEmojiItem _emojiItem; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Transform _emojiParent; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private TMP_InputField _chatInput; // 0x30
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _toggleEmojiBtn; // 0x38

	// Constructors
	public UI_ChatEmojiList(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void Start(); // 0x0000000180F22C10-0x0000000180F22C20
	private void SpawnListItems(); // 0x0000000180F22AC0-0x0000000180F22C10
	private void SpawnListItem(ChatEmojiDefComponent inEmoji); // 0x0000000180F228F0-0x0000000180F22AC0
	private void OnEmojiClicked(ChatEmojiDefComponent inEmoji); // 0x0000000180F227E0-0x0000000180F228F0
}

