/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_UnreadConversationCount : MonoBehaviour // TypeDefIndex: 11964
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _unreadCountText; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralAudioInfo _unreadAudioInfo; // 0x28

	// Constructors
	public UI_UnreadConversationCount(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void Start(); // 0x0000000180F9B8D0-0x0000000180F9B9B0
	private void OnDestroy(); // 0x0000000180F9B760-0x0000000180F9B7F0
	private void OnConversationReadStateChanged(ConversationReadStateChangedMessage inMessage); // 0x0000000180F9B6A0-0x0000000180F9B760
	private void RefreshText(int inUnreadCount); // 0x0000000180F9B7F0-0x0000000180F9B8D0
}

