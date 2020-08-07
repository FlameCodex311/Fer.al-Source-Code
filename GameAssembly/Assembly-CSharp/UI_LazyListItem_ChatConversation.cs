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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyListItem_ChatConversation : UI_LazyListItem<ChatConversationData> // TypeDefIndex: 13506
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _participantNameText; // 0x68
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _lastChatMessageText; // 0x70
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _lastChatTimeText; // 0x78
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Color _timeColorRead; // 0x80
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Color _timeColorUnread; // 0x90
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_OnlineStatus _onlineStatus; // 0xA0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Color _chatTextColorMe; // 0xA8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Color _chatTextColorOther; // 0xB8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RectTransform _windowBody; // 0xC8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<GameObject> _offOnCompressGameObjects; // 0xD0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<GameObject> _onOnCompressGameObjects; // 0xD8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _compressedWidthThreshold; // 0xE0

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 13507
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Predicate<string> <>9__12_0; // 0x08

		// Constructors
		static <>c(); // 0x000000018039E380-0x000000018039E3E0
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <Setup>b__12_0(string id); // 0x000000018039E330-0x000000018039E360
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <Setup>d__12 : IAsyncStateMachine // TypeDefIndex: 13508
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
		private void MoveNext(); // 0x00000001800021F0-0x0000000180002200
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Constructors
	public UI_LazyListItem_ChatConversation(); // 0x00000001803A2E10-0x00000001803A2EB0

	// Methods
	[AsyncStateMachine] // 0x0000000180252060-0x00000001802520B0
	public override void Setup(Action<UI_LazyListItem<ChatConversationData>> inOnClicked, Action<UI_LazyListItem<ChatConversationData>> inOnSelected, ChatConversationData inData, UI_LazyItemList<ChatConversationData> inItemList); // 0x00000001803A2BB0-0x00000001803A2CC0
	protected override void Start(); // 0x00000001803A2CC0-0x00000001803A2DA0
	private void OnDestroy(); // 0x00000001803A2550-0x00000001803A2620
	public void SetTextSize(int inTextSize); // 0x00000001803A2B30-0x00000001803A2BB0
	private void OnChatMessage(ChatConversationMessage inMessage); // 0x00000001803A2450-0x00000001803A24D0
	private void OnConversationReadStateChanged(ConversationReadStateChangedMessage inMessage); // 0x00000001803A24D0-0x00000001803A2550
	private void RefreshLastChatEntry(ChatEntry inChatEntry); // 0x00000001803A28C0-0x00000001803A2A80
	private void RefreshReadState(bool inIsRead); // 0x00000001803A2A80-0x00000001803A2B30
	public override void MarkAsSelected(bool inIsSelected); // 0x00000001803A23F0-0x00000001803A2450
	public void RefreshCompression(); // 0x00000001803A2620-0x00000001803A28C0
	[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
	[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
	private void <>n__0(Action<UI_LazyListItem<ChatConversationData>> inOnClicked, Action<UI_LazyListItem<ChatConversationData>> inOnSelected, ChatConversationData inData, UI_LazyItemList<ChatConversationData> inItemList); // 0x00000001803A2DA0-0x00000001803A2E10
}

