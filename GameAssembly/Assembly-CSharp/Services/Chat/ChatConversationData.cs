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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Services.Chat
{
	public class ChatConversationData // TypeDefIndex: 15979
	{
		// Fields
		public string id; // 0x10
		public string title; // 0x18
		public List<string> participants; // 0x20
		public List<ChatEntry> messages; // 0x28
		private const int PAGE_SIZE = 50; // Metadata: 0x0078507B
		private const int MAX_PAGES = 6; // Metadata: 0x0078507F
		private int _cacheStartIndex; // 0x30
		private float _cacheCooldown; // 0x34
		private bool _canUpdateCache; // 0x38
		private bool _hasOldestMessages; // 0x39
		public Action<ChatEntry> OnCachedMessageAdded; // 0x40
		public Action<ChatEntry> OnCachedMessageRemoved; // 0x48
		private List<string> _cursors; // 0x50
		private ChatEntry _mostRecentMessage; // 0x58
	
		// Properties
		public bool HasAllMessages { get; } // 0x0000000180EB35B0-0x0000000180EB35D0 
		public ChatEntry MostRecentMessage { get; } // 0x0000000180EB3620-0x0000000180EB3680 
		public bool IsRoomChat { get; } // 0x0000000180EB35D0-0x0000000180EB3620 
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <InitializeChatEntries>d__21 : IAsyncStateMachine // TypeDefIndex: 15980
		{
			// Fields
			public int <>1__state; // 0x00
			public AsyncUniTaskMethodBuilder <>t__builder; // 0x08
			public ChatConversationData <>4__this; // 0x18
			private UniTask.Awaiter <>u__1; // 0x20
	
			// Methods
			private void MoveNext(); // 0x00000001801F0970-0x00000001801F0980
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0500-0x00000001801F0510
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <RequestAdditionalChats>d__22 : IAsyncStateMachine // TypeDefIndex: 15981
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
			private void MoveNext(); // 0x00000001801F0A30-0x00000001801F0A40
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0A40-0x00000001801F0A90
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <GetCursor>d__23 : IAsyncStateMachine // TypeDefIndex: 15982
		{
			// Fields
			public int <>1__state; // 0x00
			public AsyncUniTaskMethodBuilder<string> <>t__builder; // 0x08
			public ChatConversationData <>4__this; // 0x20
			public int inPageIndex; // 0x28
			private UniTask<ChatConversationHistoryResponse> <>u__1; // 0x30
	
			// Methods
			private void MoveNext(); // 0x00000001801F0910-0x00000001801F0920
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0920-0x00000001801F0970
		}
	
		// Constructors
		public ChatConversationData(JsonData jsonData); // 0x0000000180EB2E90-0x0000000180EB35B0
	
		// Methods
		[AsyncStateMachine] // 0x00000001800E1860-0x00000001800E18B0
		public UniTask InitializeChatEntries(); // 0x0000000180EB2B60-0x0000000180EB2BF0
		[AsyncStateMachine] // 0x00000001800E1A50-0x00000001800E1AA0
		public UniTask<bool> RequestAdditionalChats(bool inGetOlder); // 0x0000000180EB2D80-0x0000000180EB2E80
		[AsyncStateMachine] // 0x00000001800E1D60-0x00000001800E1DB0
		private UniTask<string> GetCursor(int inPageIndex); // 0x0000000180EB2A70-0x0000000180EB2B60
		private void ConstrainCachedChats(bool inGetOlder, bool inReportRemovals); // 0x0000000180EB2920-0x0000000180EB2A70
		public void OnChatMessage(ChatEntry inChatEntry); // 0x0000000180EB2BF0-0x0000000180EB2D80
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private void <RequestAdditionalChats>b__22_0(); // 0x0000000180EB2E80-0x0000000180EB2E90
	}
}
