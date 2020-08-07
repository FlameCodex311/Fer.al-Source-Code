/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using LitJson;
using UniRx.Async;
using UniRx.Async.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Services.Chat
{
	public class ChatConversationData // TypeDefIndex: 14366
	{
		// Fields
		public string id; // 0x10
		public string title; // 0x18
		public List<string> participants; // 0x20
		public List<ChatEntry> messages; // 0x28
		private const int PAGE_SIZE = 50; // Metadata: 0x007BA7A5
		private const int MAX_PAGES = 6; // Metadata: 0x007BA7A9
		private int _cacheStartIndex; // 0x30
		private float _cacheCooldown; // 0x34
		private bool _canUpdateCache; // 0x38
		private bool _hasOldestMessages; // 0x39
		public Action<ChatEntry> OnCachedMessageAdded; // 0x40
		public Action<ChatEntry> OnCachedMessageRemoved; // 0x48
		private List<string> _cursors; // 0x50
		private ChatEntry _mostRecentMessage; // 0x58
	
		// Properties
		public bool HasAllMessages { get; } // 0x00000001803F3450-0x00000001803F3470 
		public ChatEntry MostRecentMessage { get; } // 0x00000001803F34C0-0x00000001803F3520 
		public bool IsRoomChat { get; } // 0x00000001803F3470-0x00000001803F34C0 
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <InitializeChatEntries>d__21 : IAsyncStateMachine // TypeDefIndex: 14367
		{
			// Fields
			public int <>1__state; // 0x00
			public AsyncUniTaskMethodBuilder <>t__builder; // 0x08
			public ChatConversationData <>4__this; // 0x18
			private UniTask.Awaiter <>u__1; // 0x20
	
			// Methods
			private void MoveNext(); // 0x0000000180002AB0-0x0000000180002AC0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002020-0x0000000180002030
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <RequestAdditionalChats>d__22 : IAsyncStateMachine // TypeDefIndex: 14368
		{
			// Fields
			public int <>1__state; // 0x00
			public AsyncUniTaskMethodBuilder<bool> <>t__builder; // 0x08
			public ChatConversationData <>4__this; // 0x20
			public bool inGetOlder; // 0x28
			private int <pageIndex>5__2; // 0x2C
			private int <endIndex>5__3; // 0x30
			private UniTask<string> <>u__1; // 0x38
			private UniTask<ChatConversationHistoryResponse> <>u__2; // 0x48
			private UniTask.Awaiter <>u__3; // 0x58
	
			// Methods
			private void MoveNext(); // 0x0000000180002BB0-0x0000000180002BC0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002BC0-0x0000000180002C10
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <GetCursor>d__23 : IAsyncStateMachine // TypeDefIndex: 14369
		{
			// Fields
			public int <>1__state; // 0x00
			public AsyncUniTaskMethodBuilder<string> <>t__builder; // 0x08
			public ChatConversationData <>4__this; // 0x20
			public int inPageIndex; // 0x28
			private UniTask<ChatConversationHistoryResponse> <>u__1; // 0x30
	
			// Methods
			private void MoveNext(); // 0x00000001800029F0-0x0000000180002A00
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002A00-0x0000000180002A50
		}
	
		// Constructors
		public ChatConversationData(JsonData jsonData); // 0x00000001803F2D50-0x00000001803F3450
	
		// Methods
		[AsyncStateMachine] // 0x0000000180222BD0-0x0000000180222C20
		public UniTask InitializeChatEntries(); // 0x00000001803F2A30-0x00000001803F2AC0
		[AsyncStateMachine] // 0x0000000180223040-0x0000000180223090
		public UniTask<bool> RequestAdditionalChats(bool inGetOlder); // 0x00000001803F2C40-0x00000001803F2D40
		[AsyncStateMachine] // 0x0000000180223220-0x0000000180223270
		private UniTask<string> GetCursor(int inPageIndex); // 0x00000001803F2940-0x00000001803F2A30
		private void ConstrainCachedChats(bool inGetOlder, bool inReportRemovals); // 0x00000001803F2800-0x00000001803F2940
		public void OnChatMessage(ChatEntry inChatEntry); // 0x00000001803F2AC0-0x00000001803F2C40
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void <RequestAdditionalChats>b__22_0(); // 0x00000001803F2D40-0x00000001803F2D50
	}
}
