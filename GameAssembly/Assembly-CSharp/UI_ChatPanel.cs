/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Services.Chat;
using TMPro;
using UniRx.Async;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public abstract class UI_ChatPanel : MonoBehaviour // TypeDefIndex: 11932
{
	// Fields
	protected const int MAX_CHAT_ITEMS = 10000; // Metadata: 0x00782D0E
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	protected UI_LazyItemList_ChatEntry _itemList; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	protected ScrollRect _scrollRect; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	protected TMP_InputField _chatInput; // 0x30
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	protected CanvasGroup _scrollToBottomGroup; // 0x38
	protected List<UI_ChatItem> _chatItems; // 0x40
	protected bool _isAtBottom; // 0x48
	protected bool _ignoreScrollChanges; // 0x49

	// Properties
	protected bool IsAtBottom { get; set; } // 0x00000001805E3A60-0x00000001805E3A70 0x0000000180F268B0-0x0000000180F26960

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <SnapToBottom>d__29 : IAsyncStateMachine // TypeDefIndex: 11933
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_ChatPanel <>4__this; // 0x28
		public bool inInstant; // 0x30
		private UniTask<int> <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F1420-0x00000001801F1430
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	// Constructors
	protected UI_ChatPanel(); // 0x0000000180F24850-0x0000000180F248C0

	// Methods
	protected virtual void Awake(); // 0x000000018090E380-0x000000018090E3A0
	protected virtual void OnDestroy(); // 0x00000001803581E0-0x00000001803581F0
	protected virtual void OnEnable(); // 0x0000000180F23960-0x0000000180F23A70
	protected virtual void OnDisable(); // 0x0000000180F23850-0x0000000180F23960
	public void SelectInputField(); // 0x0000000180F254D0-0x0000000180F25500
	public void BtnClicked_SubmitChat(); // 0x0000000180F22DA0-0x0000000180F22E40
	public void BtnClicked_ScrollToBottom(); // 0x0000000180F22D70-0x0000000180F22DA0
	public virtual void SubmitChat(string inChatText); // 0x0000000180F25F30-0x0000000180F25FD0
	protected virtual void OnValueChanged(string inChatText); // 0x0000000180F23B80-0x0000000180F23C20
	public virtual void RecalculateLayout(); // 0x0000000180F248C0-0x0000000180F248E0
	protected virtual string PrepareChatForSubmission(string inChatText); // 0x0000000180F23C20-0x0000000180F23E30
	protected virtual void DoChatSubmission(string inChatText); // 0x00000001803581E0-0x00000001803581F0
	protected virtual void CreateChatConversation(); // 0x00000001803581E0-0x00000001803581F0
	protected static string ReplaceCaseInsensitive(string input, string search, string replacement); // 0x0000000180F248E0-0x0000000180F249A0
	public void SetTextSize(int inTextSize); // 0x0000000180F25500-0x0000000180F25540
	public virtual void OnScrollPositionChanged(Vector2 inPosition); // 0x0000000180F23A70-0x0000000180F23B80
	protected abstract void SpawnInitialChatItems();
	protected virtual void SpawnChatItem(ChatEntry inChatEntry, bool inFromSetup = false /* Metadata: 0x00782D0C */); // 0x0000000180F25D60-0x0000000180F25F30
	[AsyncStateMachine] // 0x000000018015EEA0-0x000000018015EEF0
	protected void SnapToBottom(bool inInstant = true /* Metadata: 0x00782D0D */); // 0x0000000180F25CA0-0x0000000180F25D60
}

