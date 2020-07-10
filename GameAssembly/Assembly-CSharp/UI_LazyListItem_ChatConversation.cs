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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyListItem_ChatConversation : UI_LazyListItem<ChatConversationData> // TypeDefIndex: 11958
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _participantNameText; // 0x68
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _lastChatMessageText; // 0x70
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _lastChatTimeText; // 0x78
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color _timeColorRead; // 0x80
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color _timeColorUnread; // 0x90
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_OnlineStatus _onlineStatus; // 0xA0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color _chatTextColorMe; // 0xA8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color _chatTextColorOther; // 0xB8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private RectTransform _windowBody; // 0xC8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private List<GameObject> _offOnCompressGameObjects; // 0xD0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private List<GameObject> _onOnCompressGameObjects; // 0xD8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _compressedWidthThreshold; // 0xE0

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 11959
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Predicate<string> <>9__12_0; // 0x08

		// Constructors
		static <>c(); // 0x0000000180E5AB50-0x0000000180E5ABB0
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <Setup>b__12_0(string id); // 0x0000000180E5A740-0x0000000180E5A780
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <Setup>d__12 : IAsyncStateMachine // TypeDefIndex: 11960
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_LazyListItem_ChatConversation <>4__this; // 0x28
		public Action<UI_LazyListItem<ChatConversationData>> inOnClicked; // 0x30
		public Action<UI_LazyListItem<ChatConversationData>> inOnSelected; // 0x38
		public ChatConversationData inData; // 0x40
		public UI_LazyItemList<ChatConversationData> inItemList; // 0x48
		private string <otherUserId>5__2; // 0x50
		private UniTask<UserInfo> <>u__1; // 0x58

		// Methods
		private void MoveNext(); // 0x00000001801F0550-0x00000001801F0560
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	// Constructors
	public UI_LazyListItem_ChatConversation(); // 0x0000000180E6F600-0x0000000180E6F6A0

	// Methods
	[AsyncStateMachine] // 0x000000018016BF70-0x000000018016BFC0
	public override void Setup(Action<UI_LazyListItem<ChatConversationData>> inOnClicked, Action<UI_LazyListItem<ChatConversationData>> inOnSelected, ChatConversationData inData, UI_LazyItemList<ChatConversationData> inItemList); // 0x0000000180E6F3A0-0x0000000180E6F4B0
	protected override void Start(); // 0x0000000180E6F4B0-0x0000000180E6F590
	private void OnDestroy(); // 0x0000000180E6ED30-0x0000000180E6EE00
	public void SetTextSize(int inTextSize); // 0x0000000180E6F320-0x0000000180E6F3A0
	private void OnChatMessage(ChatConversationMessage inMessage); // 0x0000000180E6EC30-0x0000000180E6ECB0
	private void OnConversationReadStateChanged(ConversationReadStateChangedMessage inMessage); // 0x0000000180E6ECB0-0x0000000180E6ED30
	private void RefreshLastChatEntry(ChatEntry inChatEntry); // 0x0000000180E6F0A0-0x0000000180E6F270
	private void RefreshReadState(bool inIsRead); // 0x0000000180E6F270-0x0000000180E6F320
	public override void MarkAsSelected(bool inIsSelected); // 0x0000000180E6EBD0-0x0000000180E6EC30
	public void RefreshCompression(); // 0x0000000180E6EE00-0x0000000180E6F0A0
	[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
	[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
	private void <>n__0(Action<UI_LazyListItem<ChatConversationData>> inOnClicked, Action<UI_LazyListItem<ChatConversationData>> inOnSelected, ChatConversationData inData, UI_LazyItemList<ChatConversationData> inItemList); // 0x0000000180E6F590-0x0000000180E6F600
}

