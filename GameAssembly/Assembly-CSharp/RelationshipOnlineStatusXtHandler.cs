/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Server;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[MessageRouteHandler] // 0x00000001801CDAD0-0x00000001801CDAE0
public static class RelationshipOnlineStatusXtHandler // TypeDefIndex: 12758
{
	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestOnlineStatus>d__2 : IAsyncStateMachine // TypeDefIndex: 12759
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<OnlineStatusResponse> <>t__builder; // 0x08
		public string userId; // 0x20
		private TaskAwaiter<OnlineStatusResponse> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x0000000180005560-0x0000000180005570
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180005570-0x00000001800055C0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestJumpToRoom>d__3 : IAsyncStateMachine // TypeDefIndex: 12760
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public string targetUserUUID; // 0x20
		public List<string> inEventNames; // 0x28
		public List<Action<IMessage>> inCallbacks; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x0000000180005550-0x0000000180005560
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002500-0x0000000180002510
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestFindPlayerUUID>d__4 : IAsyncStateMachine // TypeDefIndex: 12761
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<RelationshipFollowingFindPlayerUUIDResponse> <>t__builder; // 0x08
		public string targetUserDisplayName; // 0x20
		private TaskAwaiter<RelationshipFollowingFindPlayerUUIDResponse> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x0000000180005430-0x0000000180005440
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180005440-0x0000000180005490
	}

	// Methods
	[MessageRoute] // 0x000000018021CA70-0x000000018021CA90
	private static void HandleRelationshipFollowerList(RelationshipFollowingListResponse response); // 0x00000001804A9A10-0x00000001804A9A70
	[MessageRoute] // 0x000000018021CBC0-0x000000018021CBE0
	private static void HandleRelationshipFollowOnlineStatusUpdate(RelationshipFollowOnlineStatusUpdateResponse response); // 0x00000001804A99B0-0x00000001804A9A10
	[AsyncStateMachine] // 0x000000018021CE20-0x000000018021CE90
	[MessageSender] // 0x000000018021CE20-0x000000018021CE90
	public static Task<OnlineStatusResponse> RequestOnlineStatus(string userId); // 0x00000001804A9CB0-0x00000001804A9D90
	[AsyncStateMachine] // 0x000000018021D310-0x000000018021D380
	[MessageSender] // 0x000000018021D310-0x000000018021D380
	public static Task RequestJumpToRoom(string targetUserUUID, List<string> inEventNames, List<Action<IMessage>> inCallbacks); // 0x00000001804A9BB0-0x00000001804A9CB0
	[AsyncStateMachine] // 0x000000018021D710-0x000000018021D780
	[MessageSender] // 0x000000018021D710-0x000000018021D780
	public static Task<RelationshipFollowingFindPlayerUUIDResponse> RequestFindPlayerUUID(string targetUserDisplayName); // 0x00000001804A9AD0-0x00000001804A9BB0
	[MessageRoute] // 0x000000018021DBC0-0x000000018021DBE0
	public static void HandleRelationshipFollowingFindPlayerUUID(RelationshipFollowingFindPlayerUUIDResponse response); // 0x00000001804A9A70-0x00000001804A9AD0
}

