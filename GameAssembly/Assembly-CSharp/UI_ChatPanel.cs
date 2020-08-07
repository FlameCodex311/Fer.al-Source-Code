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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public abstract class UI_ChatPanel : MonoBehaviour // TypeDefIndex: 13478
{
	// Fields
	protected const int MAX_CHAT_ITEMS = 10000; // Metadata: 0x007BA41C
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	protected UI_LazyItemList_ChatEntry _itemList; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	protected ScrollRect _scrollRect; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	protected TMP_InputField _chatInput; // 0x30
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	protected CanvasGroup _scrollToBottomGroup; // 0x38
	protected List<UI_ChatItem> _chatItems; // 0x40
	protected bool _isAtBottom; // 0x48
	protected bool _ignoreScrollChanges; // 0x49

	// Properties
	protected bool IsAtBottom { get; set; } // 0x00000001803C9D60-0x00000001803C9D70 0x0000000180544330-0x00000001805443E0

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <SnapToBottom>d__29 : IAsyncStateMachine // TypeDefIndex: 13479
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_ChatPanel <>4__this; // 0x28
		public bool inInstant; // 0x30
		private UniTask<int> <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x0000000180006720-0x0000000180006730
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Constructors
	protected UI_ChatPanel(); // 0x00000001805422E0-0x0000000180542350

	// Methods
	protected virtual void Awake(); // 0x00000001805407C0-0x00000001805407E0
	protected virtual void OnDestroy(); // 0x00000001803774A0-0x00000001803774B0
	protected virtual void OnEnable(); // 0x00000001805413E0-0x00000001805414F0
	protected virtual void OnDisable(); // 0x00000001805412D0-0x00000001805413E0
	public void SelectInputField(); // 0x0000000180542F40-0x0000000180542F70
	public void BtnClicked_SubmitChat(); // 0x0000000180540810-0x00000001805408A0
	public void BtnClicked_ScrollToBottom(); // 0x00000001805407E0-0x0000000180540810
	public virtual void SubmitChat(string inChatText); // 0x0000000180543990-0x0000000180543A30
	protected virtual void OnValueChanged(string inChatText); // 0x0000000180541600-0x00000001805416A0
	public virtual void RecalculateLayout(); // 0x0000000180542350-0x0000000180542370
	protected virtual string PrepareChatForSubmission(string inChatText); // 0x00000001805416A0-0x00000001805418B0
	protected virtual void DoChatSubmission(string inChatText); // 0x00000001803774A0-0x00000001803774B0
	protected virtual void CreateChatConversation(); // 0x00000001803774A0-0x00000001803774B0
	protected static string ReplaceCaseInsensitive(string input, string search, string replacement); // 0x0000000180542370-0x0000000180542420
	public void SetTextSize(int inTextSize); // 0x0000000180542F70-0x0000000180542FB0
	public virtual void OnScrollPositionChanged(Vector2 inPosition); // 0x00000001805414F0-0x0000000180541600
	protected abstract void SpawnInitialChatItems();
	protected virtual void SpawnChatItem(ChatEntry inChatEntry, bool inFromSetup = false /* Metadata: 0x007BA41A */); // 0x00000001805437D0-0x0000000180543990
	[AsyncStateMachine] // 0x00000001802473D0-0x0000000180247420
	protected void SnapToBottom(bool inInstant = true /* Metadata: 0x007BA41B */); // 0x0000000180543710-0x00000001805437D0
}

