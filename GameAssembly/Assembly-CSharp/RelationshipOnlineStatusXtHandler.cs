/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Server;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[MessageRouteHandler] // 0x00000001800B36B0-0x00000001800B36C0
public static class RelationshipOnlineStatusXtHandler // TypeDefIndex: 11232
{
	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestOnlineStatus>d__2 : IAsyncStateMachine // TypeDefIndex: 11233
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<OnlineStatusResponse> <>t__builder; // 0x08
		public string userId; // 0x20
		private TaskAwaiter<OnlineStatusResponse> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x00000001801F7450-0x00000001801F7460
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F7460-0x00000001801F74B0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestJumpToRoom>d__3 : IAsyncStateMachine // TypeDefIndex: 11234
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public string targetUserUUID; // 0x20
		public List<string> inEventNames; // 0x28
		public List<Action<IMessage>> inCallbacks; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F7440-0x00000001801F7450
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018000DC90-0x000000018000DCA0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestFindPlayerUUID>d__4 : IAsyncStateMachine // TypeDefIndex: 11235
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<RelationshipFollowingFindPlayerUUIDResponse> <>t__builder; // 0x08
		public string targetUserDisplayName; // 0x20
		private TaskAwaiter<RelationshipFollowingFindPlayerUUIDResponse> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x00000001801F73E0-0x00000001801F73F0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F73F0-0x00000001801F7440
	}

	// Methods
	[MessageRoute] // 0x0000000180135AD0-0x0000000180135AF0
	private static void HandleRelationshipFollowerList(RelationshipFollowingListResponse response); // 0x00000001810136D0-0x0000000181013730
	[MessageRoute] // 0x0000000180135C40-0x0000000180135C60
	private static void HandleRelationshipFollowOnlineStatusUpdate(RelationshipFollowOnlineStatusUpdateResponse response); // 0x0000000181013670-0x00000001810136D0
	[AsyncStateMachine] // 0x0000000180135CD0-0x0000000180135D40
	[MessageSender] // 0x0000000180135CD0-0x0000000180135D40
	public static Task<OnlineStatusResponse> RequestOnlineStatus(string userId); // 0x0000000181013970-0x0000000181013A50
	[AsyncStateMachine] // 0x0000000180136020-0x0000000180136090
	[MessageSender] // 0x0000000180136020-0x0000000180136090
	public static Task RequestJumpToRoom(string targetUserUUID, List<string> inEventNames, List<Action<IMessage>> inCallbacks); // 0x0000000181013870-0x0000000181013970
	[AsyncStateMachine] // 0x00000001801361C0-0x0000000180136230
	[MessageSender] // 0x00000001801361C0-0x0000000180136230
	public static Task<RelationshipFollowingFindPlayerUUIDResponse> RequestFindPlayerUUID(string targetUserDisplayName); // 0x0000000181013790-0x0000000181013870
	[MessageRoute] // 0x0000000180136460-0x0000000180136480
	public static void HandleRelationshipFollowingFindPlayerUUID(RelationshipFollowingFindPlayerUUIDResponse response); // 0x0000000181013730-0x0000000181013790
}

