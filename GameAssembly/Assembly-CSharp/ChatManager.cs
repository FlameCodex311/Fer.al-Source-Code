/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Services.Chat;
using UniRx.Async;
using UniRx.Async.CompilerServices;
using WW.Debug;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class ChatManager : SingletonManagerBase<ChatManager> // TypeDefIndex: 12166
{
	// Fields
	private ChatConversationData _roomConversation; // 0x60
	private const int CONVERSATION_CACHE_SIZE = 20; // Metadata: 0x007B95DC
	private ChatConversationData _openConversation; // 0x68
	private List<ChatConversationData> _cachedConversations; // 0x70
	private List<string> _unreadConversations; // 0x78
	private ChatConversationData _conversationBeingRead; // 0x80
	private ChatThrottler _chatThrottler; // 0x88
	private List<ChatEmojiDefComponent> _chatEmojis; // 0x90

	// Properties
	public ChatConversationData RoomConversation { get; } // 0x0000000180418970-0x0000000180418980 
	public List<ChatConversationData> Conversations { get; } // 0x0000000180418980-0x0000000180418990 
	public List<string> UnreadConversations { get; } // 0x0000000180418A40-0x0000000180418A50 
	public ChatConversationData ConversationBeingRead { get; } // 0x000000018040ED60-0x000000018040ED70 
	public List<ChatEmojiDefComponent> ChatEmojis { get; } // 0x00000001803D6D80-0x00000001803D6D90 

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 12167
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<bool> <>9__20_0; // 0x08
		public static Func<bool> <>9__27_0; // 0x10
		public static Func<bool> <>9__33_0; // 0x18
		public static Comparison<ChatConversationData> <>9__41_0; // 0x20

		// Constructors
		static <>c(); // 0x00000001804A9430-0x00000001804A9490
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <KeepAlive>b__20_0(); // 0x00000001804A8AE0-0x00000001804A8B40
		internal bool <OnRoomJoin>b__27_0(); // 0x00000001804A8B40-0x00000001804A8BA0
		internal bool <GetConversations>b__33_0(); // 0x00000001804A8A80-0x00000001804A8AE0
		internal int <SortCachedConversations>b__41_0(ChatConversationData a, ChatConversationData b); // 0x00000001804A8C90-0x00000001804A8D80
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <KeepAlive>d__20 : IAsyncStateMachine // TypeDefIndex: 12168
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public ChatManager <>4__this; // 0x28
		private UniTask.Awaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001800065E0-0x00000001800065F0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <OnLoginComplete>d__26 : IAsyncStateMachine // TypeDefIndex: 12169
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public ChatManager <>4__this; // 0x28
		private UniTask<List<ChatConversationData>> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x0000000180006610-0x0000000180006620
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <OnRoomJoin>d__27 : IAsyncStateMachine // TypeDefIndex: 12170
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public ChatManager <>4__this; // 0x28
		public RoomJoinSuccessMessage inMessage; // 0x30
		private ConversationAddResponse <addResponse>5__2; // 0x38
		private ChatConversationGetResponse <roomConversation>5__3; // 0x40
		private UniTask.Awaiter <>u__1; // 0x48
		private UniTask<ConversationAddResponse> <>u__2; // 0x50
		private UniTask<ChatConversationGetResponse> <>u__3; // 0x60
		private UniTask<bool> <>u__4; // 0x70

		// Methods
		private void MoveNext(); // 0x0000000180006620-0x0000000180006630
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <OnChatConversationMessage>d__28 : IAsyncStateMachine // TypeDefIndex: 12171
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public ChatConversationServiceMessage inMessage; // 0x28
		public ChatManager <>4__this; // 0x30
		private UniTask.Awaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001800065F0-0x0000000180006600
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <OnChatConversationMessage_Private>d__30 : IAsyncStateMachine // TypeDefIndex: 12172
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public ChatManager <>4__this; // 0x28
		public ChatConversationServiceMessage inMessage; // 0x30
		private UniTask<ChatConversationData> <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x0000000180006600-0x0000000180006610
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass31_0 // TypeDefIndex: 12173
	{
		// Fields
		public string inConvoId; // 0x10

		// Constructors
		public <>c__DisplayClass31_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <GetConversation>b__0(ChatConversationData c); // 0x00000001803E2140-0x00000001803E2170
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <GetConversation>d__31 : IAsyncStateMachine // TypeDefIndex: 12174
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncUniTaskMethodBuilder<ChatConversationData> <>t__builder; // 0x08
		public string inConvoId; // 0x20
		public ChatManager <>4__this; // 0x28
		public bool inOnlyCheckCache; // 0x30
		private ChatConversationData <conversation>5__2; // 0x38
		private ChatConversationGetResponse <conversationResponse>5__3; // 0x40
		private UniTask<ChatConversationGetResponse> <>u__1; // 0x48
		private UniTask.Awaiter <>u__2; // 0x58
		private UniTask<bool> <>u__3; // 0x60

		// Methods
		private void MoveNext(); // 0x00000001800050F0-0x0000000180005100
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180005100-0x0000000180005150
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <GetOrCreateConversation>d__32 : IAsyncStateMachine // TypeDefIndex: 12175
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncUniTaskMethodBuilder<ChatConversationData> <>t__builder; // 0x08
		public string inOtherParticipantUUID; // 0x20
		public ChatManager <>4__this; // 0x28
		private ChatConversationData <conversation>5__2; // 0x30
		private UniTask<ChatConversationOpenResponse> <>u__1; // 0x38
		private UniTask<ChatConversationData> <>u__2; // 0x48
		private UniTask<ChatConversationCreateResponse> <>u__3; // 0x58
		private UniTask<UserInfo> <>u__4; // 0x68

		// Methods
		private void MoveNext(); // 0x0000000180006580-0x0000000180006590
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180006590-0x00000001800065E0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <GetConversations>d__33 : IAsyncStateMachine // TypeDefIndex: 12176
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncUniTaskMethodBuilder<List<ChatConversationData>> <>t__builder; // 0x08
		public ChatManager <>4__this; // 0x20
		private ChatConversationListResponse <response>5__2; // 0x28
		private UniTask.Awaiter <>u__1; // 0x30
		private UniTask<ChatConversationListResponse> <>u__2; // 0x38

		// Methods
		private void MoveNext(); // 0x0000000180006520-0x0000000180006530
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180006530-0x0000000180006580
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <SendMessage>d__36 : IAsyncStateMachine // TypeDefIndex: 12177
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public ChatManager <>4__this; // 0x28
		public string inMessage; // 0x30
		public string conversationId; // 0x38
		public string inOtherParticipantUUID; // 0x40
		private UniTask<ChatConversationServiceMessage> <>u__1; // 0x48
		private UniTask<UserInfo> <>u__2; // 0x58

		// Methods
		private void MoveNext(); // 0x0000000180006650-0x0000000180006660
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <CreateConversation>d__37 : IAsyncStateMachine // TypeDefIndex: 12178
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncUniTaskMethodBuilder<string> <>t__builder; // 0x08
		public string inName; // 0x20
		public string inConversationType; // 0x28
		public string[] inParticipants; // 0x30
		private UniTask<ChatConversationCreateResponse> <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x0000000180005090-0x00000001800050A0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001800050A0-0x00000001800050F0
	}

	// Constructors
	public ChatManager(); // 0x00000001804A3B30-0x00000001804A3BC0

	// Methods
	public override void Init(); // 0x00000001804A2010-0x00000001804A22C0
	public override void Deinit(); // 0x00000001804A1B40-0x00000001804A1D20
	[AsyncStateMachine] // 0x0000000180245560-0x00000001802455B0
	private void KeepAlive(); // 0x00000001804A2310-0x00000001804A23C0
	private void LoadEmojiList(); // 0x00000001804A23C0-0x00000001804A25C0
	private void OnUserBlocked(UserBlockedMessage inMessage); // 0x00000001804A2F70-0x00000001804A2FA0
	private void OnUserUnblocked(UserUnblockedMessage inMessage); // 0x00000001804A2FA0-0x00000001804A2FC0
	private void OnChatFilterSettingChanged(ChatFilterSettingChangedMessage inMessage); // 0x00000001804A2950-0x00000001804A2DE0
	private void RefreshChatsWithUser(string inUUID); // 0x00000001804A3260-0x00000001804A3790
	[AsyncStateMachine] // 0x0000000180245740-0x0000000180245790
	private void OnLoginComplete(LoginCompleteResponse inMessage); // 0x00000001804A2DE0-0x00000001804A2E90
	[AsyncStateMachine] // 0x00000001802459F0-0x0000000180245A40
	private void OnRoomJoin(RoomJoinSuccessMessage inMessage); // 0x00000001804A2E90-0x00000001804A2F70
	[AsyncStateMachine] // 0x0000000180245BC0-0x0000000180245C10
	private void OnChatConversationMessage(ChatConversationServiceMessage inMessage); // 0x00000001804A2890-0x00000001804A2950
	private void OnChatConversationMessage_Room(ChatConversationServiceMessage inMessage); // 0x00000001804A27C0-0x00000001804A2890
	[AsyncStateMachine] // 0x0000000180245E40-0x0000000180245E90
	private void OnChatConversationMessage_Private(ChatConversationServiceMessage inMessage); // 0x00000001804A2700-0x00000001804A27C0
	[AsyncStateMachine] // 0x0000000180245FD0-0x0000000180246020
	public UniTask<ChatConversationData> GetConversation(string inConvoId, bool inOnlyCheckCache = false /* Metadata: 0x007B95DB */); // 0x00000001804A1D20-0x00000001804A1E20
	[AsyncStateMachine] // 0x0000000180246260-0x00000001802462B0
	public UniTask<ChatConversationData> GetOrCreateConversation(string inOtherParticipantUUID); // 0x00000001804A1F10-0x00000001804A2010
	[AsyncStateMachine] // 0x0000000180246480-0x0000000180246520
	[DebugButton] // 0x0000000180246480-0x0000000180246520
	private UniTask<List<ChatConversationData>> GetConversations(); // 0x00000001804A1E20-0x00000001804A1F10
	public void MarkConversationAsOpen(ChatConversationData inConversation, bool inIsOpen); // 0x00000001804A25C0-0x00000001804A2700
	private void SetConversationUnreadState(string inConversationId, bool inIsRead); // 0x00000001804A3890-0x00000001804A3A30
	[AsyncStateMachine] // 0x00000001802468E0-0x0000000180246930
	public void SendMessage(string inMessage, string conversationId, string inOtherParticipantUUID = null); // 0x00000001804A3790-0x00000001804A3890
	[AsyncStateMachine] // 0x0000000180246C40-0x0000000180246C90
	public UniTask<string> CreateConversation(string inName, string inConversationType, string[] inParticipants); // 0x00000001804A1A30-0x00000001804A1B40
	public void JoinConversation(string inConversationId); // 0x00000001803774A0-0x00000001803774B0
	public void InviteUserToConversation(string inUserUUID, string inConversationId); // 0x00000001804A22C0-0x00000001804A22E0
	public void LeaveConversation(string inConversationId); // 0x00000001803774A0-0x00000001803774B0
	private void SortCachedConversations(); // 0x00000001804A3A30-0x00000001804A3B30
	public string ProcessEmojiChatCommands(string inOriginalText); // 0x00000001804A2FC0-0x00000001804A3260
	public bool IsSingleEmojiChat(ChatEntry inChatEntry); // 0x00000001804A22E0-0x00000001804A2310
}

