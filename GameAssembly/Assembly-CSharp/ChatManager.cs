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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class ChatManager : SingletonManagerBase<ChatManager> // TypeDefIndex: 10663
{
	// Fields
	private ChatConversationData _roomConversation; // 0x60
	private const int CONVERSATION_CACHE_SIZE = 20; // Metadata: 0x00781F19
	private ChatConversationData _openConversation; // 0x68
	private List<ChatConversationData> _cachedConversations; // 0x70
	private List<string> _unreadConversations; // 0x78
	private ChatConversationData _conversationBeingRead; // 0x80
	private ChatThrottler _chatThrottler; // 0x88
	private List<ChatEmojiDefComponent> _chatEmojis; // 0x90

	// Properties
	public ChatConversationData RoomConversation { get; } // 0x0000000180369B40-0x0000000180369B50 
	public List<ChatConversationData> Conversations { get; } // 0x0000000180369B50-0x0000000180369B60 
	public List<string> UnreadConversations { get; } // 0x0000000180369C70-0x0000000180369C80 
	public ChatConversationData ConversationBeingRead { get; } // 0x000000018035FCB0-0x000000018035FCC0 
	public List<ChatEmojiDefComponent> ChatEmojis { get; } // 0x0000000180382A80-0x0000000180382A90 

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 10664
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<bool> <>9__20_0; // 0x08
		public static Func<bool> <>9__27_0; // 0x10
		public static Func<bool> <>9__33_0; // 0x18
		public static Comparison<ChatConversationData> <>9__41_0; // 0x20

		// Constructors
		static <>c(); // 0x00000001810346C0-0x0000000181034720
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <KeepAlive>b__20_0(); // 0x0000000181033DD0-0x0000000181033E30
		internal bool <OnRoomJoin>b__27_0(); // 0x0000000181033E30-0x0000000181033E90
		internal bool <GetConversations>b__33_0(); // 0x0000000181033D70-0x0000000181033DD0
		internal int <SortCachedConversations>b__41_0(ChatConversationData a, ChatConversationData b); // 0x0000000181033F80-0x0000000181034070
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <KeepAlive>d__20 : IAsyncStateMachine // TypeDefIndex: 10665
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public ChatManager <>4__this; // 0x28
		private UniTask.Awaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F7C90-0x00000001801F7CA0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <OnLoginComplete>d__26 : IAsyncStateMachine // TypeDefIndex: 10666
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public ChatManager <>4__this; // 0x28
		private UniTask<List<ChatConversationData>> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F7CC0-0x00000001801F7CD0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <OnRoomJoin>d__27 : IAsyncStateMachine // TypeDefIndex: 10667
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
		private void MoveNext(); // 0x00000001801F7CD0-0x00000001801F7CE0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <OnChatConversationMessage>d__28 : IAsyncStateMachine // TypeDefIndex: 10668
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public ChatConversationServiceMessage inMessage; // 0x28
		public ChatManager <>4__this; // 0x30
		private UniTask.Awaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F7CA0-0x00000001801F7CB0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <OnChatConversationMessage_Private>d__30 : IAsyncStateMachine // TypeDefIndex: 10669
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public ChatManager <>4__this; // 0x28
		public ChatConversationServiceMessage inMessage; // 0x30
		private UniTask<ChatConversationData> <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F7CB0-0x00000001801F7CC0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass31_0 // TypeDefIndex: 10670
	{
		// Fields
		public string inConvoId; // 0x10

		// Constructors
		public <>c__DisplayClass31_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <GetConversation>b__0(ChatConversationData c); // 0x0000000180EB3C90-0x0000000180EB3CC0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <GetConversation>d__31 : IAsyncStateMachine // TypeDefIndex: 10671
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
		private void MoveNext(); // 0x00000001801F7B70-0x00000001801F7B80
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F7B80-0x00000001801F7BD0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <GetOrCreateConversation>d__32 : IAsyncStateMachine // TypeDefIndex: 10672
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
		private void MoveNext(); // 0x00000001801F7C30-0x00000001801F7C40
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F7C40-0x00000001801F7C90
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <GetConversations>d__33 : IAsyncStateMachine // TypeDefIndex: 10673
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncUniTaskMethodBuilder<List<ChatConversationData>> <>t__builder; // 0x08
		public ChatManager <>4__this; // 0x20
		private ChatConversationListResponse <response>5__2; // 0x28
		private UniTask.Awaiter <>u__1; // 0x30
		private UniTask<ChatConversationListResponse> <>u__2; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F7BD0-0x00000001801F7BE0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F7BE0-0x00000001801F7C30
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <SendMessage>d__36 : IAsyncStateMachine // TypeDefIndex: 10674
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
		private void MoveNext(); // 0x00000001801F7D00-0x00000001801F7D10
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <CreateConversation>d__37 : IAsyncStateMachine // TypeDefIndex: 10675
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncUniTaskMethodBuilder<string> <>t__builder; // 0x08
		public string inName; // 0x20
		public string inConversationType; // 0x28
		public string[] inParticipants; // 0x30
		private UniTask<ChatConversationCreateResponse> <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F7AF0-0x00000001801F7B00
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F7B00-0x00000001801F7B50
	}

	// Constructors
	public ChatManager(); // 0x000000018102B340-0x000000018102B3D0

	// Methods
	public override void Init(); // 0x0000000181029730-0x0000000181029A40
	public override void Deinit(); // 0x0000000181029260-0x0000000181029440
	[AsyncStateMachine] // 0x0000000180165930-0x0000000180165980
	private void KeepAlive(); // 0x0000000181029A90-0x0000000181029B40
	private void LoadEmojiList(); // 0x0000000181029B40-0x0000000181029D40
	private void OnUserBlocked(UserBlockedMessage inMessage); // 0x000000018102A720-0x000000018102A760
	private void OnUserUnblocked(UserUnblockedMessage inMessage); // 0x000000018102A760-0x000000018102A790
	private void OnChatFilterSettingChanged(ChatFilterSettingChangedMessage inMessage); // 0x000000018102A0E0-0x000000018102A590
	private void RefreshChatsWithUser(string inUUID); // 0x000000018102AA40-0x000000018102AF90
	[AsyncStateMachine] // 0x0000000180165C10-0x0000000180165C60
	private void OnLoginComplete(LoginCompleteResponse inMessage); // 0x000000018102A590-0x000000018102A640
	[AsyncStateMachine] // 0x0000000180165F10-0x0000000180165F60
	private void OnRoomJoin(RoomJoinSuccessMessage inMessage); // 0x000000018102A640-0x000000018102A720
	[AsyncStateMachine] // 0x00000001801661F0-0x0000000180166240
	private void OnChatConversationMessage(ChatConversationServiceMessage inMessage); // 0x000000018102A020-0x000000018102A0E0
	private void OnChatConversationMessage_Room(ChatConversationServiceMessage inMessage); // 0x0000000181029F40-0x000000018102A020
	[AsyncStateMachine] // 0x0000000180167750-0x00000001801677A0
	private void OnChatConversationMessage_Private(ChatConversationServiceMessage inMessage); // 0x0000000181029E80-0x0000000181029F40
	[AsyncStateMachine] // 0x00000001801679C0-0x0000000180167A10
	public UniTask<ChatConversationData> GetConversation(string inConvoId, bool inOnlyCheckCache = false /* Metadata: 0x00781F18 */); // 0x0000000181029440-0x0000000181029540
	[AsyncStateMachine] // 0x0000000180167BD0-0x0000000180167C20
	public UniTask<ChatConversationData> GetOrCreateConversation(string inOtherParticipantUUID); // 0x0000000181029630-0x0000000181029730
	[AsyncStateMachine] // 0x0000000180167F90-0x0000000180168030
	[DebugButton] // 0x0000000180167F90-0x0000000180168030
	private UniTask<List<ChatConversationData>> GetConversations(); // 0x0000000181029540-0x0000000181029630
	public void MarkConversationAsOpen(ChatConversationData inConversation, bool inIsOpen); // 0x0000000181029D40-0x0000000181029E80
	private void SetConversationUnreadState(string inConversationId, bool inIsRead); // 0x000000018102B090-0x000000018102B240
	[AsyncStateMachine] // 0x0000000180168470-0x00000001801684C0
	public void SendMessage(string inMessage, string conversationId, string inOtherParticipantUUID = null); // 0x000000018102AF90-0x000000018102B090
	[AsyncStateMachine] // 0x00000001801686F0-0x0000000180168740
	public UniTask<string> CreateConversation(string inName, string inConversationType, string[] inParticipants); // 0x0000000181029150-0x0000000181029260
	public void JoinConversation(string inConversationId); // 0x00000001803581E0-0x00000001803581F0
	public void InviteUserToConversation(string inUserUUID, string inConversationId); // 0x0000000181029A40-0x0000000181029A60
	public void LeaveConversation(string inConversationId); // 0x00000001803581E0-0x00000001803581F0
	private void SortCachedConversations(); // 0x000000018102B240-0x000000018102B340
	public string ProcessEmojiChatCommands(string inOriginalText); // 0x000000018102A790-0x000000018102AA40
	public bool IsSingleEmojiChat(ChatEntry inChatEntry); // 0x0000000181029A60-0x0000000181029A90
}

