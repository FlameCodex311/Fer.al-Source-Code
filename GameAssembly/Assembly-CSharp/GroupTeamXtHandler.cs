/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Server;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[MessageRouteHandler] // 0x00000001800B36B0-0x00000001800B36C0
public static class GroupTeamXtHandler // TypeDefIndex: 11173
{
	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestGroupTeamCreate>d__0 : IAsyncStateMachine // TypeDefIndex: 11174
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public string questDefId; // 0x20
		public Action<RequestGroupTeamCreateSuccessMessage> onSuccess; // 0x28
		public Action<RequestGroupTeamCreateFailedMessage> onFailed; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F9000-0x00000001801F9010
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018000DC90-0x000000018000DCA0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 11175
	{
		// Fields
		public Action<RequestGroupTeamCreateSuccessMessage> onSuccess; // 0x10
		public Action<RequestGroupTeamCreateFailedMessage> onFailed; // 0x18

		// Constructors
		public <>c__DisplayClass1_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <SendRequestGroupTeamCreate>b__0(RequestGroupTeamCreateSuccessMessage s); // 0x0000000181065F90-0x0000000181065FE0
		internal void <SendRequestGroupTeamCreate>b__1(RequestGroupTeamCreateFailedMessage f); // 0x0000000181065FE0-0x0000000181066030
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <SendRequestGroupTeamCreate>d__1 : IAsyncStateMachine // TypeDefIndex: 11176
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public Action<RequestGroupTeamCreateSuccessMessage> onSuccess; // 0x20
		public Action<RequestGroupTeamCreateFailedMessage> onFailed; // 0x28
		public string questDefId; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F90B0-0x00000001801F90C0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018000DC90-0x000000018000DCA0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestGroupTeamJoin>d__2 : IAsyncStateMachine // TypeDefIndex: 11177
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public string hostUserUUIDToJoin; // 0x20
		public Action<RequestGroupTeamJoinSuccessMessage> onSuccess; // 0x28
		public Action<RequestGroupTeamJoinFailedMessage> onFailed; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F9020-0x00000001801F9030
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018000DC90-0x000000018000DCA0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass3_0 // TypeDefIndex: 11178
	{
		// Fields
		public Action<RequestGroupTeamJoinSuccessMessage> onSuccess; // 0x10
		public Action<RequestGroupTeamJoinFailedMessage> onFailed; // 0x18

		// Constructors
		public <>c__DisplayClass3_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <SendRequestGroupTeamJoin>b__0(RequestGroupTeamJoinSuccessMessage s); // 0x00000001810660E0-0x0000000181066130
		internal void <SendRequestGroupTeamJoin>b__1(RequestGroupTeamJoinFailedMessage f); // 0x0000000181066130-0x0000000181066180
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <SendRequestGroupTeamJoin>d__3 : IAsyncStateMachine // TypeDefIndex: 11179
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public Action<RequestGroupTeamJoinSuccessMessage> onSuccess; // 0x20
		public Action<RequestGroupTeamJoinFailedMessage> onFailed; // 0x28
		public string hostUserUUIDToJoin; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F90D0-0x00000001801F90E0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018000DC90-0x000000018000DCA0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestGroupTeamInvite>d__5 : IAsyncStateMachine // TypeDefIndex: 11180
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public string inUserUUIDToAdd; // 0x20
		public Action<RequestGroupTeamInviteSuccessMessage> onSuccess; // 0x28
		public Action<RequestGroupTeamInviteFailedMessage> onFailed; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F9010-0x00000001801F9020
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018000DC90-0x000000018000DCA0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass6_0 // TypeDefIndex: 11181
	{
		// Fields
		public Action<RequestGroupTeamInviteSuccessMessage> onSuccess; // 0x10
		public Action<RequestGroupTeamInviteFailedMessage> onFailed; // 0x18

		// Constructors
		public <>c__DisplayClass6_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <SendRequestGroupTeamInvite>b__0(RequestGroupTeamInviteSuccessMessage s); // 0x0000000181066180-0x00000001810661D0
		internal void <SendRequestGroupTeamInvite>b__1(RequestGroupTeamInviteFailedMessage f); // 0x00000001810661D0-0x0000000181066220
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <SendRequestGroupTeamInvite>d__6 : IAsyncStateMachine // TypeDefIndex: 11182
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public Action<RequestGroupTeamInviteSuccessMessage> onSuccess; // 0x20
		public Action<RequestGroupTeamInviteFailedMessage> onFailed; // 0x28
		public string inUserUUIDToAdd; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F90C0-0x00000001801F90D0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018000DC90-0x000000018000DCA0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestAcceptGroupTeamInvitation>d__7 : IAsyncStateMachine // TypeDefIndex: 11183
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public string inGroupCreatorUUID; // 0x20
		public Action<RequestAcceptGroupTeamInvitationSuccessMessage> onSuccess; // 0x28
		public Action<RequestAcceptGroupTeamInvitationFailedMessage> onFailed; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F8FE0-0x00000001801F8FF0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018000DC90-0x000000018000DCA0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass8_0 // TypeDefIndex: 11184
	{
		// Fields
		public Action<RequestAcceptGroupTeamInvitationSuccessMessage> onSuccess; // 0x10
		public Action<RequestAcceptGroupTeamInvitationFailedMessage> onFailed; // 0x18

		// Constructors
		public <>c__DisplayClass8_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <SendRequestAcceptGroupTeamInvitation>b__0(RequestAcceptGroupTeamInvitationSuccessMessage s); // 0x0000000181066250-0x00000001810662A0
		internal void <SendRequestAcceptGroupTeamInvitation>b__1(RequestAcceptGroupTeamInvitationFailedMessage f); // 0x00000001810662A0-0x00000001810662F0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <SendRequestAcceptGroupTeamInvitation>d__8 : IAsyncStateMachine // TypeDefIndex: 11185
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public Action<RequestAcceptGroupTeamInvitationSuccessMessage> onSuccess; // 0x20
		public Action<RequestAcceptGroupTeamInvitationFailedMessage> onFailed; // 0x28
		public string inGroupCreatorUUID; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F9090-0x00000001801F90A0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018000DC90-0x000000018000DCA0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestRejectGroupTeamInvitation>d__9 : IAsyncStateMachine // TypeDefIndex: 11186
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public string inGroupCreatorUUID; // 0x20
		public Action<RequestRejectGroupTeamInvitationSuccessMessage> onSuccess; // 0x28
		public Action<RequestRejectGroupTeamInvitationFailedMessage> onFailed; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F9040-0x00000001801F9050
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018000DC90-0x000000018000DCA0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass10_0 // TypeDefIndex: 11187
	{
		// Fields
		public Action<RequestRejectGroupTeamInvitationSuccessMessage> onSuccess; // 0x10
		public Action<RequestRejectGroupTeamInvitationFailedMessage> onFailed; // 0x18

		// Constructors
		public <>c__DisplayClass10_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <SendRequestRejectGroupTeamInvitation>b__0(RequestRejectGroupTeamInvitationSuccessMessage s); // 0x0000000181065DA0-0x0000000181065DF0
		internal void <SendRequestRejectGroupTeamInvitation>b__1(RequestRejectGroupTeamInvitationFailedMessage f); // 0x0000000181065DF0-0x0000000181065E40
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <SendRequestRejectGroupTeamInvitation>d__10 : IAsyncStateMachine // TypeDefIndex: 11188
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public Action<RequestRejectGroupTeamInvitationSuccessMessage> onSuccess; // 0x20
		public Action<RequestRejectGroupTeamInvitationFailedMessage> onFailed; // 0x28
		public string inGroupCreatorUUID; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F90E0-0x00000001801F90F0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018000DC90-0x000000018000DCA0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestGroupTeamAnnounce>d__11 : IAsyncStateMachine // TypeDefIndex: 11189
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public LobbyManager.ELobbyType inType; // 0x20
		public string inAssocDefID; // 0x28
		public Action<RequestGroupTeamAnnounceSuccessMessage> onSuccess; // 0x30
		public Action<RequestGroupTeamAnnounceFailedMessage> onFailed; // 0x38
		private TaskAwaiter <>u__1; // 0x40

		// Methods
		private void MoveNext(); // 0x00000001801F8FF0-0x00000001801F9000
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018000DC90-0x000000018000DCA0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass12_0 // TypeDefIndex: 11190
	{
		// Fields
		public Action<RequestGroupTeamAnnounceSuccessMessage> onSuccess; // 0x10
		public Action<RequestGroupTeamAnnounceFailedMessage> onFailed; // 0x18

		// Constructors
		public <>c__DisplayClass12_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <SendRequestGroupTeamAnnounce>b__0(RequestGroupTeamAnnounceSuccessMessage s); // 0x0000000181065EF0-0x0000000181065F40
		internal void <SendRequestGroupTeamAnnounce>b__1(RequestGroupTeamAnnounceFailedMessage f); // 0x0000000181065F40-0x0000000181065F90
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <SendRequestGroupTeamAnnounce>d__12 : IAsyncStateMachine // TypeDefIndex: 11191
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public Action<RequestGroupTeamAnnounceSuccessMessage> onSuccess; // 0x20
		public Action<RequestGroupTeamAnnounceFailedMessage> onFailed; // 0x28
		public string inType; // 0x30
		public string inAssocDefID; // 0x38
		private TaskAwaiter <>u__1; // 0x40

		// Methods
		private void MoveNext(); // 0x00000001801F90A0-0x00000001801F90B0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018000DC90-0x000000018000DCA0
	}

	// Methods
	[AsyncStateMachine] // 0x000000018011EC50-0x000000018011ECA0
	internal static Task RequestGroupTeamCreate(string questDefId, Action<RequestGroupTeamCreateSuccessMessage> onSuccess = null, Action<RequestGroupTeamCreateFailedMessage> onFailed = null); // 0x000000018105ABD0-0x000000018105ACD0
	[AsyncStateMachine] // 0x000000018011EEF0-0x000000018011EF60
	[MessageSender] // 0x000000018011EEF0-0x000000018011EF60
	private static Task SendRequestGroupTeamCreate(string questDefId, Action<RequestGroupTeamCreateSuccessMessage> onSuccess = null, Action<RequestGroupTeamCreateFailedMessage> onFailed = null); // 0x000000018105B2C0-0x000000018105B3C0
	[AsyncStateMachine] // 0x000000018011F1F0-0x000000018011F240
	internal static Task RequestGroupTeamJoin(string hostUserUUIDToJoin, Action<RequestGroupTeamJoinSuccessMessage> onSuccess = null, Action<RequestGroupTeamJoinFailedMessage> onFailed = null); // 0x000000018105ADD0-0x000000018105AED0
	[AsyncStateMachine] // 0x000000018011F430-0x000000018011F4A0
	[MessageSender] // 0x000000018011F430-0x000000018011F4A0
	private static Task SendRequestGroupTeamJoin(string hostUserUUIDToJoin, Action<RequestGroupTeamJoinSuccessMessage> onSuccess = null, Action<RequestGroupTeamJoinFailedMessage> onFailed = null); // 0x000000018105B4C0-0x000000018105B5C0
	[MessageSender] // 0x000000018011F8A0-0x000000018011F8C0
	public static void RequestGroupTeamLeave(); // 0x000000018105AED0-0x000000018105AF30
	[AsyncStateMachine] // 0x000000018011FAA0-0x000000018011FAF0
	internal static Task RequestGroupTeamInvite(string inUserUUIDToAdd, Action<RequestGroupTeamInviteSuccessMessage> onSuccess = null, Action<RequestGroupTeamInviteFailedMessage> onFailed = null); // 0x000000018105ACD0-0x000000018105ADD0
	[AsyncStateMachine] // 0x000000018011FCB0-0x000000018011FD20
	[MessageSender] // 0x000000018011FCB0-0x000000018011FD20
	private static Task SendRequestGroupTeamInvite(string inUserUUIDToAdd, Action<RequestGroupTeamInviteSuccessMessage> onSuccess = null, Action<RequestGroupTeamInviteFailedMessage> onFailed = null); // 0x000000018105B3C0-0x000000018105B4C0
	[AsyncStateMachine] // 0x000000018011FEF0-0x000000018011FF40
	internal static Task RequestAcceptGroupTeamInvitation(string inGroupCreatorUUID, Action<RequestAcceptGroupTeamInvitationSuccessMessage> onSuccess = null, Action<RequestAcceptGroupTeamInvitationFailedMessage> onFailed = null); // 0x000000018105A9C0-0x000000018105AAC0
	[AsyncStateMachine] // 0x0000000180120200-0x0000000180120270
	[MessageSender] // 0x0000000180120200-0x0000000180120270
	private static Task SendRequestAcceptGroupTeamInvitation(string inGroupCreatorUUID, Action<RequestAcceptGroupTeamInvitationSuccessMessage> onSuccess = null, Action<RequestAcceptGroupTeamInvitationFailedMessage> onFailed = null); // 0x000000018105B0B0-0x000000018105B1B0
	[AsyncStateMachine] // 0x0000000180120590-0x00000001801205E0
	internal static Task RequestRejectGroupTeamInvitation(string inGroupCreatorUUID, Action<RequestRejectGroupTeamInvitationSuccessMessage> onSuccess = null, Action<RequestRejectGroupTeamInvitationFailedMessage> onFailed = null); // 0x000000018105AFB0-0x000000018105B0B0
	[AsyncStateMachine] // 0x00000001801208A0-0x0000000180120910
	[MessageSender] // 0x00000001801208A0-0x0000000180120910
	private static Task SendRequestRejectGroupTeamInvitation(string inGroupCreatorUUID, Action<RequestRejectGroupTeamInvitationSuccessMessage> onSuccess = null, Action<RequestRejectGroupTeamInvitationFailedMessage> onFailed = null); // 0x000000018105B5C0-0x000000018105B6C0
	[AsyncStateMachine] // 0x0000000180121EB0-0x0000000180121F00
	internal static Task RequestGroupTeamAnnounce(LobbyManager.ELobbyType inType, string inAssocDefID, Action<RequestGroupTeamAnnounceSuccessMessage> onSuccess = null, Action<RequestGroupTeamAnnounceFailedMessage> onFailed = null); // 0x000000018105AAC0-0x000000018105ABD0
	[AsyncStateMachine] // 0x00000001801220B0-0x0000000180122120
	[MessageSender] // 0x00000001801220B0-0x0000000180122120
	private static Task SendRequestGroupTeamAnnounce(string inType, string inAssocDefID, Action<RequestGroupTeamAnnounceSuccessMessage> onSuccess = null, Action<RequestGroupTeamAnnounceFailedMessage> onFailed = null); // 0x000000018105B1B0-0x000000018105B2C0
	internal static void RequestGroupTeamQuest(string inQuestDefID); // 0x000000018105AF30-0x000000018105AFB0
	[MessageSender] // 0x00000001801223F0-0x0000000180122410
	private static void SendRequestGroupTeamQuest(string inQuestDefID); // 0x000000018105AF30-0x000000018105AFB0
	[MessageRoute] // 0x0000000180122470-0x0000000180122490
	private static void HandleGroupTeamCreate(ReceivedGroupTeamCreateMessage message); // 0x00000001803581E0-0x00000001803581F0
	[MessageRoute] // 0x00000001801226A0-0x00000001801226C0
	private static void HandleGroupTeamJoin(ReceivedGroupTeamJoinMessage message); // 0x00000001803581E0-0x00000001803581F0
	[MessageRoute] // 0x0000000180122820-0x0000000180122840
	private static void HandleGroupTeamLeave(ReceivedGroupTeamLeaveMessage message); // 0x00000001803581E0-0x00000001803581F0
	[MessageRoute] // 0x00000001801229E0-0x0000000180122A00
	private static void HandleGroupTeamUserJoined(ReceivedGroupTeamUserJoinedMessage message); // 0x00000001803581E0-0x00000001803581F0
	[MessageRoute] // 0x0000000180122B20-0x0000000180122B40
	private static void HandleGroupTeamUserLeft(ReceivedGroupTeamLeftMessage message); // 0x00000001803581E0-0x00000001803581F0
}

