/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Services.Chat;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_ChatPanel_Conversations : MonoBehaviour // TypeDefIndex: 13480
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CanvasGroup _conversationListGroup; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CanvasGroup _messageListGroup; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CanvasGroup _closeConversationButtonGroup; // 0x30
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_ChatPanel_Private _privateChatPanel; // 0x38
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyItemList_ChatConversation _conversationItemList; // 0x40
	private ChatConversationData _conversation; // 0x48

	// Constructors
	public UI_ChatPanel_Conversations(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void Start(); // 0x0000000180540D60-0x0000000180540E50
	private void OnDestroy(); // 0x00000001805408D0-0x00000001805409B0
	public void SetSelectedConversation(ChatConversationData inData, bool inFromSetup = false /* Metadata: 0x007BA420 */); // 0x0000000180540A00-0x0000000180540D60
	public void BtnClicked_CloseConversation(); // 0x00000001805408A0-0x00000001805408B0
	public void BtnClicked_FindPlayer(); // 0x00000001803861E0-0x00000001803861F0
	private void OnConversationItemClicked(ChatConversationData inConversation); // 0x00000001805408B0-0x00000001805408D0
	public void RecalculateLayout(); // 0x00000001805409B0-0x0000000180540A00
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <SetSelectedConversation>b__8_0(); // 0x0000000180540E50-0x0000000180540E90
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <SetSelectedConversation>b__8_1(); // 0x00000001803CB010-0x00000001803CB050
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <SetSelectedConversation>b__8_2(); // 0x0000000180540E90-0x0000000180540ED0
}

