/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Services.Chat;
using UniRx.Async;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_ChatPanel_Trade : UI_ChatPanel // TypeDefIndex: 13493
{
	// Fields
	private string _conversationId; // 0x50

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <CreateChatConversation>d__4 : IAsyncStateMachine // TypeDefIndex: 13494
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_ChatPanel_Trade <>4__this; // 0x28
		private UniTask<string> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x0000000180006660-0x0000000180006670
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <OnChatMessage>d__6 : IAsyncStateMachine // TypeDefIndex: 13495
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_ChatPanel_Trade <>4__this; // 0x28
		public ChatConversationServiceMessage inMessage; // 0x30
		private UniTask.Awaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x0000000180006690-0x00000001800066A0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <OnItemAddedToTrade>d__8 : IAsyncStateMachine // TypeDefIndex: 13496
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public ItemAddedToTradeMessage inMessage; // 0x28
		public UI_ChatPanel_Trade <>4__this; // 0x30
		private ChatEntry <chatEntry>5__2; // 0x38
		private UniTask.Awaiter <>u__1; // 0x40

		// Methods
		private void MoveNext(); // 0x00000001800066A0-0x00000001800066B0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <OnItemRemovedFromTrade>d__9 : IAsyncStateMachine // TypeDefIndex: 13497
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public ItemRemovedFromTradeMessage inMessage; // 0x28
		public UI_ChatPanel_Trade <>4__this; // 0x30
		private ChatEntry <chatEntry>5__2; // 0x38
		private UniTask.Awaiter <>u__1; // 0x40

		// Methods
		private void MoveNext(); // 0x00000001800066B0-0x00000001800066C0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <SpawnInitialChatItems>d__11 : IAsyncStateMachine // TypeDefIndex: 13498
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_ChatPanel_Trade <>4__this; // 0x28
		private UniTask<int> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x0000000180006730-0x0000000180006740
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Constructors
	public UI_ChatPanel_Trade(); // 0x00000001805422E0-0x0000000180542350

	// Methods
	public void Setup(string inConversationId); // 0x00000001803F7B90-0x00000001803F7BA0
	protected override void Awake(); // 0x0000000180543A30-0x0000000180543C90
	protected override void OnDestroy(); // 0x0000000180543E90-0x0000000180544020
	[AsyncStateMachine] // 0x000000018024C600-0x000000018024C650
	protected override void CreateChatConversation(); // 0x0000000180543C90-0x0000000180543D40
	protected override void DoChatSubmission(string inChatText); // 0x0000000180543D40-0x0000000180543DD0
	[AsyncStateMachine] // 0x000000018024C880-0x000000018024C8D0
	private void OnChatMessage(ChatConversationServiceMessage inMessage); // 0x0000000180543DD0-0x0000000180543E90
	private void OnTradeChatConversationJoined(TradeChatConversationJoinedMessage inMessage); // 0x00000001805441A0-0x00000001805441C0
	[AsyncStateMachine] // 0x000000018024CA70-0x000000018024CAC0
	private void OnItemAddedToTrade(ItemAddedToTradeMessage inMessage); // 0x0000000180544020-0x00000001805440E0
	[AsyncStateMachine] // 0x000000018024CC10-0x000000018024CC60
	private void OnItemRemovedFromTrade(ItemRemovedFromTradeMessage inMessage); // 0x00000001805440E0-0x00000001805441A0
	private void OnTradeConfirmationUpdated(TradeConfirmationUpdatedMessage inMessage); // 0x00000001805441C0-0x0000000180544280
	[AsyncStateMachine] // 0x000000018024CE90-0x000000018024CEE0
	protected override void SpawnInitialChatItems(); // 0x0000000180544280-0x0000000180544330
}

