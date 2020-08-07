/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;
using UniRx.Async;
using UniRx.Async.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Services.Chat
{
	[MessageRouteHandler] // 0x00000001801CDAD0-0x00000001801CDAE0
	public static class ChatSrvHandler // TypeDefIndex: 14354
	{
		// Fields
		private static ChatServiceRequests.ChatPingRequest _pingRequest; // 0x00
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <RequestConversation>d__3 : IAsyncStateMachine // TypeDefIndex: 14355
		{
			// Fields
			public int <>1__state; // 0x00
			public AsyncUniTaskMethodBuilder<ChatConversationGetResponse> <>t__builder; // 0x08
			public string inConversationId; // 0x20
			private TaskAwaiter<ChatConversationGetResponse> <>u__1; // 0x28
	
			// Methods
			private void MoveNext(); // 0x000000018001B220-0x000000018001B230
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018001B230-0x000000018001B280
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <RequestConversationCreate>d__4 : IAsyncStateMachine // TypeDefIndex: 14356
		{
			// Fields
			public int <>1__state; // 0x00
			public AsyncUniTaskMethodBuilder<ChatConversationCreateResponse> <>t__builder; // 0x08
			public string inName; // 0x20
			public string inConversationType; // 0x28
			public string[] inParticipants; // 0x30
			private TaskAwaiter<ChatConversationCreateResponse> <>u__1; // 0x38
	
			// Methods
			private void MoveNext(); // 0x000000018001B160-0x000000018001B170
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018001B170-0x000000018001B1C0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <RequestConversationWithUser>d__5 : IAsyncStateMachine // TypeDefIndex: 14357
		{
			// Fields
			public int <>1__state; // 0x00
			public AsyncUniTaskMethodBuilder<ChatConversationOpenResponse> <>t__builder; // 0x08
			public string inOtherParticipantUUID; // 0x20
			private TaskAwaiter<ChatConversationOpenResponse> <>u__1; // 0x28
	
			// Methods
			private void MoveNext(); // 0x000000018001B280-0x000000018001B290
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018001B290-0x000000018001B2E0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <RequestConversations>d__6 : IAsyncStateMachine // TypeDefIndex: 14358
		{
			// Fields
			public int <>1__state; // 0x00
			public AsyncUniTaskMethodBuilder<ChatConversationListResponse> <>t__builder; // 0x08
			public string inCursor; // 0x20
			public int inPageSize; // 0x28
			private TaskAwaiter<ChatConversationListResponse> <>u__1; // 0x30
	
			// Methods
			private void MoveNext(); // 0x000000018001B2E0-0x000000018001B2F0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018001B2F0-0x000000018001B340
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <RequestConversationHistory>d__7 : IAsyncStateMachine // TypeDefIndex: 14359
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
			private void MoveNext(); // 0x000000018001B1C0-0x000000018001B1D0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018001B1D0-0x000000018001B220
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <RequestConversationAdd>d__9 : IAsyncStateMachine // TypeDefIndex: 14360
		{
			// Fields
			public int <>1__state; // 0x00
			public AsyncUniTaskMethodBuilder<ConversationAddResponse> <>t__builder; // 0x08
			public string conversationId; // 0x20
			public string playerIdToAdd; // 0x28
			private TaskAwaiter<ConversationAddResponse> <>u__1; // 0x30
	
			// Methods
			private void MoveNext(); // 0x000000018001B100-0x000000018001B110
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018001B110-0x000000018001B160
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <SendMessage>d__11 : IAsyncStateMachine // TypeDefIndex: 14361
		{
			// Fields
			public int <>1__state; // 0x00
			public AsyncUniTaskMethodBuilder<ChatConversationServiceMessage> <>t__builder; // 0x08
			public string message; // 0x20
			public string conversationId; // 0x28
			private TaskAwaiter<ChatConversationServiceMessage> <>u__1; // 0x30
	
			// Methods
			private void MoveNext(); // 0x000000018001B3B0-0x000000018001B3C0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018001B3C0-0x000000018001B410
		}
	
		// Methods
		public static void RequestSessionStart(); // 0x0000000180764A70-0x0000000180764AE0
		public static void Ping(); // 0x0000000180764310-0x00000001807643B0
		[AsyncStateMachine] // 0x000000018021F2E0-0x000000018021F330
		public static UniTask<ChatConversationGetResponse> RequestConversation(string inConversationId); // 0x00000001807648A0-0x0000000180764980
		[AsyncStateMachine] // 0x000000018021F600-0x000000018021F650
		public static UniTask<ChatConversationCreateResponse> RequestConversationCreate(string inName, string inConversationType, string[] inParticipants); // 0x00000001807644A0-0x00000001807645A0
		[AsyncStateMachine] // 0x000000018021F7C0-0x000000018021F810
		public static UniTask<ChatConversationOpenResponse> RequestConversationWithUser(string inOtherParticipantUUID); // 0x00000001807647C0-0x00000001807648A0
		[AsyncStateMachine] // 0x000000018021FBA0-0x000000018021FBF0
		public static UniTask<ChatConversationListResponse> RequestConversations(string inCursor, int inPageSize); // 0x0000000180764980-0x0000000180764A70
		[AsyncStateMachine] // 0x000000018021FDB0-0x000000018021FE00
		public static UniTask<ChatConversationHistoryResponse> RequestConversationHistory(string inConversationId, string inCursor, int inPageSize, bool inIncludeMessages = true /* Metadata: 0x007BA7A4 */); // 0x00000001807645A0-0x00000001807646B0
		public static void RequestConversationRename(string newTitle, string conversationId); // 0x0000000180764730-0x00000001807647C0
		[AsyncStateMachine] // 0x0000000180220090-0x00000001802200E0
		public static UniTask<ConversationAddResponse> RequestConversationAdd(string conversationId, string playerIdToAdd); // 0x00000001807643B0-0x00000001807644A0
		public static void RequestConversationLeave(string conversationId); // 0x00000001807646B0-0x0000000180764730
		[AsyncStateMachine] // 0x0000000180220440-0x0000000180220490
		public static UniTask<ChatConversationServiceMessage> SendMessage(string message, string conversationId); // 0x0000000180764AE0-0x0000000180764C60
	}
}
