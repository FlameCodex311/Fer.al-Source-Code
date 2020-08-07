/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_ChatConversationList : MonoBehaviour // TypeDefIndex: 13471
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyItemList_ChatConversation _itemList; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _chatInputGroup; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _emojiBtn; // 0x30
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CanvasGroup _textSizeControl; // 0x38

	// Constructors
	public UI_ChatConversationList(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void Start(); // 0x0000000180540070-0x0000000180540100
	private void OnEnable(); // 0x000000018053FED0-0x0000000180540010
	private void OnDisable(); // 0x000000018053FEA0-0x000000018053FED0
	private void OnDestroy(); // 0x000000018053FE10-0x000000018053FEA0
	private void Setup(); // 0x0000000180540010-0x0000000180540070
	private void OnConversationJoined(ChatConversationJoinedMessage inMessage); // 0x000000018053FD90-0x000000018053FE10
}

