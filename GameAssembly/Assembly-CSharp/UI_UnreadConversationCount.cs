/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_UnreadConversationCount : MonoBehaviour // TypeDefIndex: 13510
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _unreadCountText; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralAudioInfo _unreadAudioInfo; // 0x28

	// Constructors
	public UI_UnreadConversationCount(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void Start(); // 0x000000018063C1F0-0x000000018063C2C0
	private void OnDestroy(); // 0x000000018063C080-0x000000018063C110
	private void OnConversationReadStateChanged(ConversationReadStateChangedMessage inMessage); // 0x000000018063BFC0-0x000000018063C080
	private void RefreshText(int inUnreadCount); // 0x000000018063C110-0x000000018063C1F0
}

