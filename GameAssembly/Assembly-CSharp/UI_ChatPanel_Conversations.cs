/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Services.Chat;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_ChatPanel_Conversations : MonoBehaviour // TypeDefIndex: 11934
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CanvasGroup _conversationListGroup; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CanvasGroup _messageListGroup; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CanvasGroup _closeConversationButtonGroup; // 0x30
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_ChatPanel_Private _privateChatPanel; // 0x38
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyItemList_ChatConversation _conversationItemList; // 0x40
	private ChatConversationData _conversation; // 0x48

	// Constructors
	public UI_ChatPanel_Conversations(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void Start(); // 0x0000000180F23310-0x0000000180F23400
	private void OnDestroy(); // 0x0000000180F22E70-0x0000000180F22F50
	public void SetSelectedConversation(ChatConversationData inData, bool inFromSetup = false /* Metadata: 0x00782D12 */); // 0x0000000180F22FA0-0x0000000180F23310
	public void BtnClicked_CloseConversation(); // 0x0000000180F22E40-0x0000000180F22E50
	public void BtnClicked_FindPlayer(); // 0x0000000180E4DDE0-0x0000000180E4DDF0
	private void OnConversationItemClicked(ChatConversationData inConversation); // 0x0000000180F22E50-0x0000000180F22E70
	public void RecalculateLayout(); // 0x0000000180F22F50-0x0000000180F22FA0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <SetSelectedConversation>b__8_0(); // 0x0000000180E84BB0-0x0000000180E84BF0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <SetSelectedConversation>b__8_1(); // 0x0000000180E816D0-0x0000000180E81710
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <SetSelectedConversation>b__8_2(); // 0x0000000180F23400-0x0000000180F23440
}

