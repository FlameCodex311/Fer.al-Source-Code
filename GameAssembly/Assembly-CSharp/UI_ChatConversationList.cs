/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_ChatConversationList : MonoBehaviour // TypeDefIndex: 11925
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyItemList_ChatConversation _itemList; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _chatInputGroup; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _emojiBtn; // 0x30
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CanvasGroup _textSizeControl; // 0x38

	// Constructors
	public UI_ChatConversationList(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void Start(); // 0x0000000180F225F0-0x0000000180F22680
	private void OnEnable(); // 0x0000000180F22450-0x0000000180F22590
	private void OnDisable(); // 0x0000000180F22420-0x0000000180F22450
	private void OnDestroy(); // 0x0000000180F22390-0x0000000180F22420
	private void Setup(); // 0x0000000180F22590-0x0000000180F225F0
	private void OnConversationJoined(ChatConversationJoinedMessage inMessage); // 0x0000000180F22310-0x0000000180F22390
}

