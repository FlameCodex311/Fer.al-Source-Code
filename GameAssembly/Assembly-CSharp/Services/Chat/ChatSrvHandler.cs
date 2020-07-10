/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;
using UniRx.Async;
using UniRx.Async.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Services.Chat
{
	[MessageRouteHandler] // 0x00000001800B36B0-0x00000001800B36C0
	public static class ChatSrvHandler // TypeDefIndex: 15967
	{
		// Fields
		private static ChatServiceRequests.ChatPingRequest _pingRequest; // 0x00
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <RequestConversation>d__3 : IAsyncStateMachine // TypeDefIndex: 15968
		{
			// Fields
			public int <>1__state; // 0x00
			public AsyncUniTaskMethodBuilder<ChatConversationGetResponse> <>t__builder; // 0x08
			public string inConversationId; // 0x20
			private TaskAwaiter<ChatConversationGetResponse> <>u__1; // 0x28
	
			// Methods
			private void MoveNext(); // 0x00000001801F0CD0-0x00000001801F0CE0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0CE0-0x00000001801F0D30
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <RequestConversationCreate>d__4 : IAsyncStateMachine // TypeDefIndex: 15969
		{
			// Fields
			public int <>1__state; // 0x00
			public AsyncUniTaskMethodBuilder<ChatConversationCreateResponse> <>t__builder; // 0x08
			public string inName; // 0x20
			public string inConversationType; // 0x28
			public string[] inParticipants; // 0x30
			private TaskAwaiter<ChatConversationCreateResponse> <>u__1; // 0x38
	
			// Methods
			private void MoveNext(); // 0x00000001801F0C10-0x00000001801F0C20
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0C20-0x00000001801F0C70
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <RequestConversationWithUser>d__5 : IAsyncStateMachine // TypeDefIndex: 15970
		{
			// Fields
			public int <>1__state; // 0x00
			public AsyncUniTaskMethodBuilder<ChatConversationOpenResponse> <>t__builder; // 0x08
			public string inOtherParticipantUUID; // 0x20
			private TaskAwaiter<ChatConversationOpenResponse> <>u__1; // 0x28
	
			// Methods
			private void MoveNext(); // 0x00000001801F0D30-0x00000001801F0D40
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0D40-0x00000001801F0D90
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <RequestConversations>d__6 : IAsyncStateMachine // TypeDefIndex: 15971
		{
			// Fields
			public int <>1__state; // 0x00
			public AsyncUniTaskMethodBuilder<ChatConversationListResponse> <>t__builder; // 0x08
			public string inCursor; // 0x20
			public int inPageSize; // 0x28
			private TaskAwaiter<ChatConversationListResponse> <>u__1; // 0x30
	
			// Methods
			private void MoveNext(); // 0x00000001801F0D90-0x00000001801F0DA0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0DA0-0x00000001801F0DF0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <RequestConversationHistory>d__7 : IAsyncStateMachine // TypeDefIndex: 15972
		{
			// Fields
			public int <>1__state; // 0x00
			public AsyncUniTaskMethodBuilder<ChatConversationHistoryResponse> <>t__builder; // 0x08
			public string inConversationId; // 0x20
			public string inCursor; // 0x28
			public int inPageSize; // 0x30
			public bool inIncludeMessages; // 0x34
			private TaskAwaiter<ChatConversationHistoryResponse> <>u__1; // 0x38
	
			// Methods
			private void MoveNext(); // 0x00000001801F0C70-0x00000001801F0C80
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0C80-0x00000001801F0CD0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <RequestConversationAdd>d__9 : IAsyncStateMachine // TypeDefIndex: 15973
		{
			// Fields
			public int <>1__state; // 0x00
			public AsyncUniTaskMethodBuilder<ConversationAddResponse> <>t__builder; // 0x08
			public string conversationId; // 0x20
			public string playerIdToAdd; // 0x28
			private TaskAwaiter<ConversationAddResponse> <>u__1; // 0x30
	
			// Methods
			private void MoveNext(); // 0x00000001801F0BB0-0x00000001801F0BC0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0BC0-0x00000001801F0C10
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <SendMessage>d__11 : IAsyncStateMachine // TypeDefIndex: 15974
		{
			// Fields
			public int <>1__state; // 0x00
			public AsyncUniTaskMethodBuilder<ChatConversationServiceMessage> <>t__builder; // 0x08
			public string message; // 0x20
			public string conversationId; // 0x28
			private TaskAwaiter<ChatConversationServiceMessage> <>u__1; // 0x30
	
			// Methods
			private void MoveNext(); // 0x00000001801F0EC0-0x00000001801F0ED0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0ED0-0x00000001801F0F20
		}
	
		// Methods
		public static void RequestSessionStart(); // 0x0000000180EB49B0-0x0000000180EB4A20
		public static void Ping(); // 0x0000000180EB4250-0x0000000180EB42F0
		[AsyncStateMachine] // 0x00000001800DDD40-0x00000001800DDD90
		public static UniTask<ChatConversationGetResponse> RequestConversation(string inConversationId); // 0x0000000180EB47E0-0x0000000180EB48C0
		[AsyncStateMachine] // 0x00000001800DE190-0x00000001800DE1E0
		public static UniTask<ChatConversationCreateResponse> RequestConversationCreate(string inName, string inConversationType, string[] inParticipants); // 0x0000000180EB43E0-0x0000000180EB44E0
		[AsyncStateMachine] // 0x00000001800DE450-0x00000001800DE4A0
		public static UniTask<ChatConversationOpenResponse> RequestConversationWithUser(string inOtherParticipantUUID); // 0x0000000180EB4700-0x0000000180EB47E0
		[AsyncStateMachine] // 0x00000001800DE770-0x00000001800DE7C0
		public static UniTask<ChatConversationListResponse> RequestConversations(string inCursor, int inPageSize); // 0x0000000180EB48C0-0x0000000180EB49B0
		[AsyncStateMachine] // 0x00000001800DEAF0-0x00000001800DEB40
		public static UniTask<ChatConversationHistoryResponse> RequestConversationHistory(string inConversationId, string inCursor, int inPageSize, bool inIncludeMessages = true /* Metadata: 0x0078507A */); // 0x0000000180EB44E0-0x0000000180EB45F0
		public static void RequestConversationRename(string newTitle, string conversationId); // 0x0000000180EB4670-0x0000000180EB4700
		[AsyncStateMachine] // 0x00000001800DEDA0-0x00000001800DEDF0
		public static UniTask<ConversationAddResponse> RequestConversationAdd(string conversationId, string playerIdToAdd); // 0x0000000180EB42F0-0x0000000180EB43E0
		public static void RequestConversationLeave(string conversationId); // 0x0000000180EB45F0-0x0000000180EB4670
		[AsyncStateMachine] // 0x00000001800DF0C0-0x00000001800DF110
		public static UniTask<ChatConversationServiceMessage> SendMessage(string message, string conversationId); // 0x0000000180EB4A20-0x0000000180EB4B10
	}
}
