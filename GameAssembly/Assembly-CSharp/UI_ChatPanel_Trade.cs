/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Services.Chat;
using UniRx.Async;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_ChatPanel_Trade : UI_ChatPanel // TypeDefIndex: 11947
{
	// Fields
	private string _conversationId; // 0x50

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <CreateChatConversation>d__4 : IAsyncStateMachine // TypeDefIndex: 11948
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_ChatPanel_Trade <>4__this; // 0x28
		private UniTask<string> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F1360-0x00000001801F1370
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <OnChatMessage>d__6 : IAsyncStateMachine // TypeDefIndex: 11949
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_ChatPanel_Trade <>4__this; // 0x28
		public ChatConversationServiceMessage inMessage; // 0x30
		private UniTask.Awaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F1390-0x00000001801F13A0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <OnItemAddedToTrade>d__8 : IAsyncStateMachine // TypeDefIndex: 11950
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public ItemAddedToTradeMessage inMessage; // 0x28
		public UI_ChatPanel_Trade <>4__this; // 0x30
		private ChatEntry <chatEntry>5__2; // 0x38
		private UniTask.Awaiter <>u__1; // 0x40

		// Methods
		private void MoveNext(); // 0x00000001801F13A0-0x00000001801F13B0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <OnItemRemovedFromTrade>d__9 : IAsyncStateMachine // TypeDefIndex: 11951
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public ItemRemovedFromTradeMessage inMessage; // 0x28
		public UI_ChatPanel_Trade <>4__this; // 0x30
		private ChatEntry <chatEntry>5__2; // 0x38
		private UniTask.Awaiter <>u__1; // 0x40

		// Methods
		private void MoveNext(); // 0x00000001801F13B0-0x00000001801F13C0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <SpawnInitialChatItems>d__11 : IAsyncStateMachine // TypeDefIndex: 11952
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_ChatPanel_Trade <>4__this; // 0x28
		private UniTask<int> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F1430-0x00000001801F1440
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	// Constructors
	public UI_ChatPanel_Trade(); // 0x0000000180F24850-0x0000000180F248C0

	// Methods
	public void Setup(string inConversationId); // 0x00000001803A2850-0x00000001803A2860
	protected override void Awake(); // 0x0000000180F25FD0-0x0000000180F26230
	protected override void OnDestroy(); // 0x0000000180F26410-0x0000000180F265A0
	[AsyncStateMachine] // 0x0000000180165810-0x0000000180165860
	protected override void CreateChatConversation(); // 0x0000000180F26230-0x0000000180F262E0
	protected override void DoChatSubmission(string inChatText); // 0x0000000180F262E0-0x0000000180F26350
	[AsyncStateMachine] // 0x0000000180165B10-0x0000000180165B60
	private void OnChatMessage(ChatConversationServiceMessage inMessage); // 0x0000000180F26350-0x0000000180F26410
	private void OnTradeChatConversationJoined(TradeChatConversationJoinedMessage inMessage); // 0x0000000180F26720-0x0000000180F26740
	[AsyncStateMachine] // 0x0000000180165DA0-0x0000000180165DF0
	private void OnItemAddedToTrade(ItemAddedToTradeMessage inMessage); // 0x0000000180F265A0-0x0000000180F26660
	[AsyncStateMachine] // 0x0000000180166140-0x0000000180166190
	private void OnItemRemovedFromTrade(ItemRemovedFromTradeMessage inMessage); // 0x0000000180F26660-0x0000000180F26720
	private void OnTradeConfirmationUpdated(TradeConfirmationUpdatedMessage inMessage); // 0x0000000180F26740-0x0000000180F26800
	[AsyncStateMachine] // 0x0000000180167650-0x00000001801676A0
	protected override void SpawnInitialChatItems(); // 0x0000000180F26800-0x0000000180F268B0
}

