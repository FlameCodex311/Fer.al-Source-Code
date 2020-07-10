/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class RelationshipSrvHandler // TypeDefIndex: 10995
{
	// Properties
	public static string Host { get; } // 0x0000000181014230-0x0000000181014290 

	// Nested types
	[Serializable]
	public class BlockUserResponse // TypeDefIndex: 10996
	{
		// Fields
		public string error; // 0x10

		// Properties
		public bool IsSuccess { get; } // 0x0000000180EB96D0-0x0000000180EB96E0 

		// Constructors
		public BlockUserResponse(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	[Serializable]
	public class UnblockUserResponse // TypeDefIndex: 10997
	{
		// Fields
		public string error; // 0x10

		// Properties
		public bool IsSuccess { get; } // 0x0000000180EB96D0-0x0000000180EB96E0 

		// Constructors
		public UnblockUserResponse(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	[Serializable]
	public class CheckIsBlockedResponse // TypeDefIndex: 10998
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private string created_at; // 0x10
		private DateTime _blockedAt; // 0x18
		public string error; // 0x20

		// Properties
		public DateTime BlockedAt { get; } // 0x0000000180FC8DC0-0x0000000180FC8E40 
		public bool IsBlocked { get; } // 0x0000000180FC8E40-0x0000000180FC8E50 

		// Constructors
		public CheckIsBlockedResponse(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	[Serializable]
	public class FollowUserResponse // TypeDefIndex: 10999
	{
		// Fields
		public string error; // 0x10

		// Properties
		public bool IsSuccess { get; } // 0x0000000180EB96D0-0x0000000180EB96E0 

		// Constructors
		public FollowUserResponse(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	[Serializable]
	public class UnfollowUserResponse // TypeDefIndex: 11000
	{
		// Fields
		public string error; // 0x10

		// Properties
		public bool IsSuccess { get; } // 0x0000000180EB96D0-0x0000000180EB96E0 

		// Constructors
		public UnfollowUserResponse(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	[Serializable]
	public class CheckIsFollowedResponse // TypeDefIndex: 11001
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private string followed_at; // 0x10
		private DateTime _followedAt; // 0x18
		public string error; // 0x20

		// Properties
		public DateTime FollowedAt { get; } // 0x0000000180FC8E90-0x0000000180FC8F10 
		public bool IsFollowed { get; } // 0x0000000180FC8E40-0x0000000180FC8E50 

		// Constructors
		public CheckIsFollowedResponse(); // 0x0000000180FC8E50-0x0000000180FC8E90
	}

	[Serializable]
	public class ListFollowsResponse // TypeDefIndex: 11002
	{
		// Fields
		public string error; // 0x10
		public FollowItem[] followItems; // 0x18

		// Properties
		public bool IsSuccess { get; } // 0x0000000180EB96D0-0x0000000180EB96E0 

		// Nested types
		[Serializable]
		public class FollowItem // TypeDefIndex: 11003
		{
			// Fields
			[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
			private string created_at; // 0x10
			private DateTime _createdAt; // 0x18
			[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
			private string updated_at; // 0x20
			private DateTime _updatedAt; // 0x28
			public string uuid; // 0x30
			public bool favorite; // 0x38

			// Properties
			public DateTime CreatedAt { get; } // 0x0000000180FC9080-0x0000000180FC9100 
			public DateTime UpdatedAt { get; } // 0x0000000180FC9100-0x0000000180FC9180 

			// Constructors
			public FollowItem(); // 0x0000000180FC9020-0x0000000180FC9080
		}

		// Constructors
		public ListFollowsResponse(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	[Serializable]
	public class ListFollowersResponse // TypeDefIndex: 11004
	{
		// Fields
		public string error; // 0x10
		public FollowerItem[] followerItems; // 0x18

		// Properties
		public bool IsSuccess { get; } // 0x0000000180EB96D0-0x0000000180EB96E0 

		// Nested types
		[Serializable]
		public class FollowerItem // TypeDefIndex: 11005
		{
			// Fields
			public string uuid; // 0x10
			public bool favorite; // 0x18

			// Constructors
			public FollowerItem(); // 0x000000018036B6C0-0x000000018036B6D0
		}

		// Constructors
		public ListFollowersResponse(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	[Serializable]
	public class FavoriteUserResponse // TypeDefIndex: 11006
	{
		// Fields
		public string error; // 0x10

		// Properties
		public bool IsSuccess { get; } // 0x0000000180EB96D0-0x0000000180EB96E0 

		// Constructors
		public FavoriteUserResponse(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	[Serializable]
	public class UnfavoriteUserResponse // TypeDefIndex: 11007
	{
		// Fields
		public string error; // 0x10

		// Properties
		public bool IsSuccess { get; } // 0x0000000180EB96D0-0x0000000180EB96E0 

		// Constructors
		public UnfavoriteUserResponse(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <BlockUser>d__2 : IAsyncStateMachine // TypeDefIndex: 11008
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse<BlockUserResponse>> <>t__builder; // 0x08
		public string inUserToBlockUUID; // 0x20
		private TaskAwaiter<WWWResponse<BlockUserResponse>> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x00000001801F66C0-0x00000001801F66D0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F66D0-0x00000001801F6720
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <UnblockUser>d__3 : IAsyncStateMachine // TypeDefIndex: 11009
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse<UnblockUserResponse>> <>t__builder; // 0x08
		public string inUserToUnblockUUID; // 0x20
		private TaskAwaiter<WWWResponse<UnblockUserResponse>> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x00000001801F6980-0x00000001801F6990
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F6990-0x00000001801F69E0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <CheckIsBlocked>d__4 : IAsyncStateMachine // TypeDefIndex: 11010
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse<CheckIsBlockedResponse>> <>t__builder; // 0x08
		public string inUserToCheckUUID; // 0x20
		private TaskAwaiter<WWWResponse<CheckIsBlockedResponse>> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x00000001801F6720-0x00000001801F6730
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F6730-0x00000001801F6780
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <FollowUser>d__8 : IAsyncStateMachine // TypeDefIndex: 11011
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse<FollowUserResponse>> <>t__builder; // 0x08
		public string inUserToFollowUUID; // 0x20
		private TaskAwaiter<WWWResponse<FollowUserResponse>> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x00000001801F6850-0x00000001801F6860
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F6860-0x00000001801F68B0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <UnfollowUser>d__9 : IAsyncStateMachine // TypeDefIndex: 11012
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse<UnfollowUserResponse>> <>t__builder; // 0x08
		public string inUserToUnfollowUUID; // 0x20
		private TaskAwaiter<WWWResponse<UnfollowUserResponse>> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x00000001801F6A40-0x00000001801F6A50
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F6A50-0x00000001801F6B90
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestFollows>d__10 : IAsyncStateMachine // TypeDefIndex: 11013
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse<ListFollowsResponse>> <>t__builder; // 0x08
		private TaskAwaiter<WWWResponse> <>u__1; // 0x20

		// Methods
		private void MoveNext(); // 0x00000001801F6910-0x00000001801F6920
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F6920-0x00000001801F6970
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestFollowers>d__11 : IAsyncStateMachine // TypeDefIndex: 11014
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse<ListFollowersResponse>> <>t__builder; // 0x08
		public int inPageIndex; // 0x20
		public int inPageSize; // 0x24
		private TaskAwaiter<WWWResponse> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x00000001801F68B0-0x00000001801F68C0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F68C0-0x00000001801F6910
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <FavoriteUser>d__17 : IAsyncStateMachine // TypeDefIndex: 11015
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse<FavoriteUserResponse>> <>t__builder; // 0x08
		public string inUserToFavoriteUUID; // 0x20
		private TaskAwaiter<WWWResponse<FavoriteUserResponse>> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x00000001801F67F0-0x00000001801F6800
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F6800-0x00000001801F6850
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <UnfavoriteUser>d__18 : IAsyncStateMachine // TypeDefIndex: 11016
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse<UnfavoriteUserResponse>> <>t__builder; // 0x08
		public string inUserToUnfavoriteUUID; // 0x20
		private TaskAwaiter<WWWResponse<UnfavoriteUserResponse>> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x00000001801F69E0-0x00000001801F69F0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F69F0-0x00000001801F6A40
	}

	// Constructors
	public RelationshipSrvHandler(); // 0x000000018036B6C0-0x000000018036B6D0

	// Methods
	[AsyncStateMachine] // 0x0000000180102C50-0x0000000180102CA0
	public static Task<WWWResponse<BlockUserResponse>> BlockUser(string inUserToBlockUUID); // 0x0000000181013A50-0x0000000181013B30
	[AsyncStateMachine] // 0x0000000180102DB0-0x0000000180102E00
	public static Task<WWWResponse<UnblockUserResponse>> UnblockUser(string inUserToUnblockUUID); // 0x0000000181013F90-0x0000000181014070
	[AsyncStateMachine] // 0x0000000180102F80-0x0000000180102FD0
	public static Task<WWWResponse<CheckIsBlockedResponse>> CheckIsBlocked(string inUserToCheckUUID); // 0x0000000181013B30-0x0000000181013C10
	[AsyncStateMachine] // 0x0000000180103250-0x00000001801032A0
	public static Task<WWWResponse<FollowUserResponse>> FollowUser(string inUserToFollowUUID); // 0x0000000181013CF0-0x0000000181013DD0
	[AsyncStateMachine] // 0x0000000180103430-0x0000000180103480
	public static Task<WWWResponse<UnfollowUserResponse>> UnfollowUser(string inUserToUnfollowUUID); // 0x0000000181014150-0x0000000181014230
	[AsyncStateMachine] // 0x0000000180103740-0x0000000180103790
	public static Task<WWWResponse<ListFollowsResponse>> RequestFollows(); // 0x0000000181013EC0-0x0000000181013F90
	[AsyncStateMachine] // 0x0000000180103A20-0x0000000180103A70
	public static Task<WWWResponse<ListFollowersResponse>> RequestFollowers(int inPageIndex = -1 /* Metadata: 0x0078248C */, int inPageSize = -1 /* Metadata: 0x00782490 */); // 0x0000000181013DD0-0x0000000181013EC0
	[AsyncStateMachine] // 0x0000000180103CA0-0x0000000180103CF0
	public static Task<WWWResponse<FavoriteUserResponse>> FavoriteUser(string inUserToFavoriteUUID); // 0x0000000181013C10-0x0000000181013CF0
	[AsyncStateMachine] // 0x0000000180104060-0x00000001801040B0
	public static Task<WWWResponse<UnfavoriteUserResponse>> UnfavoriteUser(string inUserToUnfavoriteUUID); // 0x0000000181014070-0x0000000181014150
}

