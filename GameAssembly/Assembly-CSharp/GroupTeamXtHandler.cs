/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Server;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[MessageRouteHandler] // 0x00000001801CDAD0-0x00000001801CDAE0
public static class GroupTeamXtHandler // TypeDefIndex: 12699
{
	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestGroupTeamCreate>d__0 : IAsyncStateMachine // TypeDefIndex: 12700
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public string questDefId; // 0x20
		public Action<RequestGroupTeamCreateSuccessMessage> onSuccess; // 0x28
		public Action<RequestGroupTeamCreateFailedMessage> onFailed; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x000000018000B380-0x000000018000B390
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002500-0x0000000180002510
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 12701
	{
		// Fields
		public Action<RequestGroupTeamCreateSuccessMessage> onSuccess; // 0x10
		public Action<RequestGroupTeamCreateFailedMessage> onFailed; // 0x18

		// Constructors
		public <>c__DisplayClass1_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <SendRequestGroupTeamCreate>b__0(RequestGroupTeamCreateSuccessMessage s); // 0x000000018068E3C0-0x000000018068E410
		internal void <SendRequestGroupTeamCreate>b__1(RequestGroupTeamCreateFailedMessage f); // 0x000000018068E410-0x000000018068E460
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <SendRequestGroupTeamCreate>d__1 : IAsyncStateMachine // TypeDefIndex: 12702
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public Action<RequestGroupTeamCreateSuccessMessage> onSuccess; // 0x20
		public Action<RequestGroupTeamCreateFailedMessage> onFailed; // 0x28
		public string questDefId; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x000000018000B430-0x000000018000B440
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002500-0x0000000180002510
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestGroupTeamJoin>d__2 : IAsyncStateMachine // TypeDefIndex: 12703
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public string hostUserUUIDToJoin; // 0x20
		public Action<RequestGroupTeamJoinSuccessMessage> onSuccess; // 0x28
		public Action<RequestGroupTeamJoinFailedMessage> onFailed; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x000000018000B3A0-0x000000018000B3B0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002500-0x0000000180002510
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass3_0 // TypeDefIndex: 12704
	{
		// Fields
		public Action<RequestGroupTeamJoinSuccessMessage> onSuccess; // 0x10
		public Action<RequestGroupTeamJoinFailedMessage> onFailed; // 0x18

		// Constructors
		public <>c__DisplayClass3_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <SendRequestGroupTeamJoin>b__0(RequestGroupTeamJoinSuccessMessage s); // 0x000000018068E460-0x000000018068E4B0
		internal void <SendRequestGroupTeamJoin>b__1(RequestGroupTeamJoinFailedMessage f); // 0x000000018068E4B0-0x000000018068E500
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <SendRequestGroupTeamJoin>d__3 : IAsyncStateMachine // TypeDefIndex: 12705
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public Action<RequestGroupTeamJoinSuccessMessage> onSuccess; // 0x20
		public Action<RequestGroupTeamJoinFailedMessage> onFailed; // 0x28
		public string hostUserUUIDToJoin; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x000000018000B450-0x000000018000B460
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002500-0x0000000180002510
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestGroupTeamInvite>d__5 : IAsyncStateMachine // TypeDefIndex: 12706
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public string inUserUUIDToAdd; // 0x20
		public Action<RequestGroupTeamInviteSuccessMessage> onSuccess; // 0x28
		public Action<RequestGroupTeamInviteFailedMessage> onFailed; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x000000018000B390-0x000000018000B3A0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002500-0x0000000180002510
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass6_0 // TypeDefIndex: 12707
	{
		// Fields
		public Action<RequestGroupTeamInviteSuccessMessage> onSuccess; // 0x10
		public Action<RequestGroupTeamInviteFailedMessage> onFailed; // 0x18

		// Constructors
		public <>c__DisplayClass6_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <SendRequestGroupTeamInvite>b__0(RequestGroupTeamInviteSuccessMessage s); // 0x000000018068E8C0-0x000000018068E910
		internal void <SendRequestGroupTeamInvite>b__1(RequestGroupTeamInviteFailedMessage f); // 0x000000018068E910-0x000000018068E960
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <SendRequestGroupTeamInvite>d__6 : IAsyncStateMachine // TypeDefIndex: 12708
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public Action<RequestGroupTeamInviteSuccessMessage> onSuccess; // 0x20
		public Action<RequestGroupTeamInviteFailedMessage> onFailed; // 0x28
		public string inUserUUIDToAdd; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x000000018000B440-0x000000018000B450
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002500-0x0000000180002510
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestAcceptGroupTeamInvitation>d__7 : IAsyncStateMachine // TypeDefIndex: 12709
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public string inGroupCreatorUUID; // 0x20
		public Action<RequestAcceptGroupTeamInvitationSuccessMessage> onSuccess; // 0x28
		public Action<RequestAcceptGroupTeamInvitationFailedMessage> onFailed; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x000000018000B360-0x000000018000B370
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002500-0x0000000180002510
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass8_0 // TypeDefIndex: 12710
	{
		// Fields
		public Action<RequestAcceptGroupTeamInvitationSuccessMessage> onSuccess; // 0x10
		public Action<RequestAcceptGroupTeamInvitationFailedMessage> onFailed; // 0x18

		// Constructors
		public <>c__DisplayClass8_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <SendRequestAcceptGroupTeamInvitation>b__0(RequestAcceptGroupTeamInvitationSuccessMessage s); // 0x000000018068E990-0x000000018068E9E0
		internal void <SendRequestAcceptGroupTeamInvitation>b__1(RequestAcceptGroupTeamInvitationFailedMessage f); // 0x000000018068E9E0-0x000000018068EA30
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <SendRequestAcceptGroupTeamInvitation>d__8 : IAsyncStateMachine // TypeDefIndex: 12711
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public Action<RequestAcceptGroupTeamInvitationSuccessMessage> onSuccess; // 0x20
		public Action<RequestAcceptGroupTeamInvitationFailedMessage> onFailed; // 0x28
		public string inGroupCreatorUUID; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x000000018000B410-0x000000018000B420
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002500-0x0000000180002510
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestRejectGroupTeamInvitation>d__9 : IAsyncStateMachine // TypeDefIndex: 12712
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public string inGroupCreatorUUID; // 0x20
		public Action<RequestRejectGroupTeamInvitationSuccessMessage> onSuccess; // 0x28
		public Action<RequestRejectGroupTeamInvitationFailedMessage> onFailed; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x000000018000B3C0-0x000000018000B3D0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002500-0x0000000180002510
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass10_0 // TypeDefIndex: 12713
	{
		// Fields
		public Action<RequestRejectGroupTeamInvitationSuccessMessage> onSuccess; // 0x10
		public Action<RequestRejectGroupTeamInvitationFailedMessage> onFailed; // 0x18

		// Constructors
		public <>c__DisplayClass10_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <SendRequestRejectGroupTeamInvitation>b__0(RequestRejectGroupTeamInvitationSuccessMessage s); // 0x000000018068E280-0x000000018068E2D0
		internal void <SendRequestRejectGroupTeamInvitation>b__1(RequestRejectGroupTeamInvitationFailedMessage f); // 0x000000018068E2D0-0x000000018068E320
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <SendRequestRejectGroupTeamInvitation>d__10 : IAsyncStateMachine // TypeDefIndex: 12714
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public Action<RequestRejectGroupTeamInvitationSuccessMessage> onSuccess; // 0x20
		public Action<RequestRejectGroupTeamInvitationFailedMessage> onFailed; // 0x28
		public string inGroupCreatorUUID; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x000000018000B460-0x000000018000B470
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002500-0x0000000180002510
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestGroupTeamAnnounce>d__11 : IAsyncStateMachine // TypeDefIndex: 12715
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
		private void MoveNext(); // 0x000000018000B370-0x000000018000B380
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002500-0x0000000180002510
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass12_0 // TypeDefIndex: 12716
	{
		// Fields
		public Action<RequestGroupTeamAnnounceSuccessMessage> onSuccess; // 0x10
		public Action<RequestGroupTeamAnnounceFailedMessage> onFailed; // 0x18

		// Constructors
		public <>c__DisplayClass12_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <SendRequestGroupTeamAnnounce>b__0(RequestGroupTeamAnnounceSuccessMessage s); // 0x000000018068E320-0x000000018068E370
		internal void <SendRequestGroupTeamAnnounce>b__1(RequestGroupTeamAnnounceFailedMessage f); // 0x000000018068E370-0x000000018068E3C0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <SendRequestGroupTeamAnnounce>d__12 : IAsyncStateMachine // TypeDefIndex: 12717
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
		private void MoveNext(); // 0x000000018000B420-0x000000018000B430
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002500-0x0000000180002510
	}

	// Methods
	[AsyncStateMachine] // 0x0000000180202E20-0x0000000180202E70
	internal static Task RequestGroupTeamCreate(string questDefId, Action<RequestGroupTeamCreateSuccessMessage> onSuccess = null, Action<RequestGroupTeamCreateFailedMessage> onFailed = null); // 0x0000000180686220-0x0000000180686320
	[AsyncStateMachine] // 0x00000001802030E0-0x0000000180203150
	[MessageSender] // 0x00000001802030E0-0x0000000180203150
	private static Task SendRequestGroupTeamCreate(string questDefId, Action<RequestGroupTeamCreateSuccessMessage> onSuccess = null, Action<RequestGroupTeamCreateFailedMessage> onFailed = null); // 0x0000000180686910-0x0000000180686A10
	[AsyncStateMachine] // 0x0000000180203610-0x0000000180203660
	internal static Task RequestGroupTeamJoin(string hostUserUUIDToJoin, Action<RequestGroupTeamJoinSuccessMessage> onSuccess = null, Action<RequestGroupTeamJoinFailedMessage> onFailed = null); // 0x0000000180686420-0x0000000180686520
	[AsyncStateMachine] // 0x00000001802038E0-0x0000000180203950
	[MessageSender] // 0x00000001802038E0-0x0000000180203950
	private static Task SendRequestGroupTeamJoin(string hostUserUUIDToJoin, Action<RequestGroupTeamJoinSuccessMessage> onSuccess = null, Action<RequestGroupTeamJoinFailedMessage> onFailed = null); // 0x0000000180686B10-0x0000000180686C10
	[MessageSender] // 0x0000000180205150-0x0000000180205170
	public static void RequestGroupTeamLeave(); // 0x0000000180686520-0x0000000180686580
	[AsyncStateMachine] // 0x0000000180205300-0x0000000180205350
	internal static Task RequestGroupTeamInvite(string inUserUUIDToAdd, Action<RequestGroupTeamInviteSuccessMessage> onSuccess = null, Action<RequestGroupTeamInviteFailedMessage> onFailed = null); // 0x0000000180686320-0x0000000180686420
	[AsyncStateMachine] // 0x0000000180205580-0x00000001802055F0
	[MessageSender] // 0x0000000180205580-0x00000001802055F0
	private static Task SendRequestGroupTeamInvite(string inUserUUIDToAdd, Action<RequestGroupTeamInviteSuccessMessage> onSuccess = null, Action<RequestGroupTeamInviteFailedMessage> onFailed = null); // 0x0000000180686A10-0x0000000180686B10
	[AsyncStateMachine] // 0x00000001802059A0-0x00000001802059F0
	internal static Task RequestAcceptGroupTeamInvitation(string inGroupCreatorUUID, Action<RequestAcceptGroupTeamInvitationSuccessMessage> onSuccess = null, Action<RequestAcceptGroupTeamInvitationFailedMessage> onFailed = null); // 0x0000000180686010-0x0000000180686110
	[AsyncStateMachine] // 0x0000000180205C10-0x0000000180205C80
	[MessageSender] // 0x0000000180205C10-0x0000000180205C80
	private static Task SendRequestAcceptGroupTeamInvitation(string inGroupCreatorUUID, Action<RequestAcceptGroupTeamInvitationSuccessMessage> onSuccess = null, Action<RequestAcceptGroupTeamInvitationFailedMessage> onFailed = null); // 0x0000000180686700-0x0000000180686800
	[AsyncStateMachine] // 0x0000000180205D40-0x0000000180205D90
	internal static Task RequestRejectGroupTeamInvitation(string inGroupCreatorUUID, Action<RequestRejectGroupTeamInvitationSuccessMessage> onSuccess = null, Action<RequestRejectGroupTeamInvitationFailedMessage> onFailed = null); // 0x0000000180686600-0x0000000180686700
	[AsyncStateMachine] // 0x0000000180206020-0x0000000180206090
	[MessageSender] // 0x0000000180206020-0x0000000180206090
	private static Task SendRequestRejectGroupTeamInvitation(string inGroupCreatorUUID, Action<RequestRejectGroupTeamInvitationSuccessMessage> onSuccess = null, Action<RequestRejectGroupTeamInvitationFailedMessage> onFailed = null); // 0x0000000180686C10-0x0000000180686D10
	[AsyncStateMachine] // 0x0000000180206560-0x00000001802065B0
	internal static Task RequestGroupTeamAnnounce(LobbyManager.ELobbyType inType, string inAssocDefID, Action<RequestGroupTeamAnnounceSuccessMessage> onSuccess = null, Action<RequestGroupTeamAnnounceFailedMessage> onFailed = null); // 0x0000000180686110-0x0000000180686220
	[AsyncStateMachine] // 0x0000000180206740-0x00000001802067B0
	[MessageSender] // 0x0000000180206740-0x00000001802067B0
	private static Task SendRequestGroupTeamAnnounce(string inType, string inAssocDefID, Action<RequestGroupTeamAnnounceSuccessMessage> onSuccess = null, Action<RequestGroupTeamAnnounceFailedMessage> onFailed = null); // 0x0000000180686800-0x0000000180686910
	internal static void RequestGroupTeamQuest(string inQuestDefID); // 0x0000000180686580-0x0000000180686600
	[MessageSender] // 0x0000000180206AD0-0x0000000180206AF0
	private static void SendRequestGroupTeamQuest(string inQuestDefID); // 0x0000000180686580-0x0000000180686600
	[MessageRoute] // 0x0000000180206C30-0x0000000180206C50
	private static void HandleGroupTeamCreate(ReceivedGroupTeamCreateMessage message); // 0x00000001803774A0-0x00000001803774B0
	[MessageRoute] // 0x0000000180206EE0-0x0000000180206F00
	private static void HandleGroupTeamJoin(ReceivedGroupTeamJoinMessage message); // 0x00000001803774A0-0x00000001803774B0
	[MessageRoute] // 0x0000000180207160-0x0000000180207180
	private static void HandleGroupTeamLeave(ReceivedGroupTeamLeaveMessage message); // 0x00000001803774A0-0x00000001803774B0
	[MessageRoute] // 0x0000000180207450-0x0000000180207470
	private static void HandleGroupTeamUserJoined(ReceivedGroupTeamUserJoinedMessage message); // 0x00000001803774A0-0x00000001803774B0
	[MessageRoute] // 0x0000000180207580-0x00000001802075A0
	private static void HandleGroupTeamUserLeft(ReceivedGroupTeamLeftMessage message); // 0x00000001803774A0-0x00000001803774B0
}

