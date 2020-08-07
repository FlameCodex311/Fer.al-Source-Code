/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class RelationshipSrvHandler // TypeDefIndex: 12520
{
	// Properties
	public static string Host { get; } // 0x00000001804AA570-0x00000001804AA5D0 

	// Nested types
	[Serializable]
	public class BlockUserResponse // TypeDefIndex: 12521
	{
		// Fields
		public string error; // 0x10

		// Properties
		public bool IsSuccess { get; } // 0x00000001803F4620-0x00000001803F4630 

		// Constructors
		public BlockUserResponse(); // 0x0000000180373240-0x0000000180373250
	}

	[Serializable]
	public class UnblockUserResponse // TypeDefIndex: 12522
	{
		// Fields
		public string error; // 0x10

		// Properties
		public bool IsSuccess { get; } // 0x00000001803F4620-0x00000001803F4630 

		// Constructors
		public UnblockUserResponse(); // 0x0000000180373240-0x0000000180373250
	}

	[Serializable]
	public class CheckIsBlockedResponse // TypeDefIndex: 12523
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string created_at; // 0x10
		private DateTime _blockedAt; // 0x18
		public string error; // 0x20

		// Properties
		public DateTime BlockedAt { get; } // 0x00000001804A95F0-0x00000001804A9670 
		public bool IsBlocked { get; } // 0x00000001804A9670-0x00000001804A9680 

		// Constructors
		public CheckIsBlockedResponse(); // 0x0000000180373240-0x0000000180373250
	}

	[Serializable]
	public class FollowUserResponse // TypeDefIndex: 12524
	{
		// Fields
		public string error; // 0x10

		// Properties
		public bool IsSuccess { get; } // 0x00000001803F4620-0x00000001803F4630 

		// Constructors
		public FollowUserResponse(); // 0x0000000180373240-0x0000000180373250
	}

	[Serializable]
	public class UnfollowUserResponse // TypeDefIndex: 12525
	{
		// Fields
		public string error; // 0x10

		// Properties
		public bool IsSuccess { get; } // 0x00000001803F4620-0x00000001803F4630 

		// Constructors
		public UnfollowUserResponse(); // 0x0000000180373240-0x0000000180373250
	}

	[Serializable]
	public class CheckIsFollowedResponse // TypeDefIndex: 12526
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string followed_at; // 0x10
		private DateTime _followedAt; // 0x18
		public string error; // 0x20

		// Properties
		public DateTime FollowedAt { get; } // 0x00000001804A96C0-0x00000001804A9740 
		public bool IsFollowed { get; } // 0x00000001804A9670-0x00000001804A9680 

		// Constructors
		public CheckIsFollowedResponse(); // 0x00000001804A9680-0x00000001804A96C0
	}

	[Serializable]
	public class ListFollowsResponse // TypeDefIndex: 12527
	{
		// Fields
		public string error; // 0x10
		public FollowItem[] followItems; // 0x18

		// Properties
		public bool IsSuccess { get; } // 0x00000001803F4620-0x00000001803F4630 

		// Nested types
		[Serializable]
		public class FollowItem // TypeDefIndex: 12528
		{
			// Fields
			[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
			private string created_at; // 0x10
			private DateTime _createdAt; // 0x18
			[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
			private string updated_at; // 0x20
			private DateTime _updatedAt; // 0x28
			public string uuid; // 0x30
			public bool favorite; // 0x38

			// Properties
			public DateTime CreatedAt { get; } // 0x00000001804A98B0-0x00000001804A9930 
			public DateTime UpdatedAt { get; } // 0x00000001804A9930-0x00000001804A99B0 

			// Constructors
			public FollowItem(); // 0x00000001804A9850-0x00000001804A98B0
		}

		// Constructors
		public ListFollowsResponse(); // 0x0000000180373240-0x0000000180373250
	}

	[Serializable]
	public class ListFollowersResponse // TypeDefIndex: 12529
	{
		// Fields
		public string error; // 0x10
		public FollowerItem[] followerItems; // 0x18

		// Properties
		public bool IsSuccess { get; } // 0x00000001803F4620-0x00000001803F4630 

		// Nested types
		[Serializable]
		public class FollowerItem // TypeDefIndex: 12530
		{
			// Fields
			public string uuid; // 0x10
			public bool favorite; // 0x18

			// Constructors
			public FollowerItem(); // 0x0000000180373240-0x0000000180373250
		}

		// Constructors
		public ListFollowersResponse(); // 0x0000000180373240-0x0000000180373250
	}

	[Serializable]
	public class FavoriteUserResponse // TypeDefIndex: 12531
	{
		// Fields
		public string error; // 0x10

		// Properties
		public bool IsSuccess { get; } // 0x00000001803F4620-0x00000001803F4630 

		// Constructors
		public FavoriteUserResponse(); // 0x0000000180373240-0x0000000180373250
	}

	[Serializable]
	public class UnfavoriteUserResponse // TypeDefIndex: 12532
	{
		// Fields
		public string error; // 0x10

		// Properties
		public bool IsSuccess { get; } // 0x00000001803F4620-0x00000001803F4630 

		// Constructors
		public UnfavoriteUserResponse(); // 0x0000000180373240-0x0000000180373250
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <BlockUser>d__2 : IAsyncStateMachine // TypeDefIndex: 12533
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse<BlockUserResponse>> <>t__builder; // 0x08
		public string inUserToBlockUUID; // 0x20
		private TaskAwaiter<WWWResponse<BlockUserResponse>> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x00000001800051E0-0x00000001800051F0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001800051F0-0x0000000180005240
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <UnblockUser>d__3 : IAsyncStateMachine // TypeDefIndex: 12534
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse<UnblockUserResponse>> <>t__builder; // 0x08
		public string inUserToUnblockUUID; // 0x20
		private TaskAwaiter<WWWResponse<UnblockUserResponse>> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x0000000180005650-0x0000000180005660
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180005660-0x00000001800056B0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <CheckIsBlocked>d__4 : IAsyncStateMachine // TypeDefIndex: 12535
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse<CheckIsBlockedResponse>> <>t__builder; // 0x08
		public string inUserToCheckUUID; // 0x20
		private TaskAwaiter<WWWResponse<CheckIsBlockedResponse>> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x0000000180005240-0x0000000180005250
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180005250-0x00000001800052A0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <FollowUser>d__8 : IAsyncStateMachine // TypeDefIndex: 12536
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse<FollowUserResponse>> <>t__builder; // 0x08
		public string inUserToFollowUUID; // 0x20
		private TaskAwaiter<WWWResponse<FollowUserResponse>> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x0000000180005390-0x00000001800053A0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001800053A0-0x00000001800053F0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <UnfollowUser>d__9 : IAsyncStateMachine // TypeDefIndex: 12537
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse<UnfollowUserResponse>> <>t__builder; // 0x08
		public string inUserToUnfollowUUID; // 0x20
		private TaskAwaiter<WWWResponse<UnfollowUserResponse>> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x0000000180005730-0x0000000180005740
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180005740-0x0000000180005790
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestFollows>d__10 : IAsyncStateMachine // TypeDefIndex: 12538
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse<ListFollowsResponse>> <>t__builder; // 0x08
		private TaskAwaiter<WWWResponse> <>u__1; // 0x20

		// Methods
		private void MoveNext(); // 0x00000001800054F0-0x0000000180005500
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180005500-0x0000000180005550
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestFollowers>d__11 : IAsyncStateMachine // TypeDefIndex: 12539
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse<ListFollowersResponse>> <>t__builder; // 0x08
		public int inPageIndex; // 0x20
		public int inPageSize; // 0x24
		private TaskAwaiter<WWWResponse> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x0000000180005490-0x00000001800054A0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001800054A0-0x00000001800054F0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <FavoriteUser>d__17 : IAsyncStateMachine // TypeDefIndex: 12540
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse<FavoriteUserResponse>> <>t__builder; // 0x08
		public string inUserToFavoriteUUID; // 0x20
		private TaskAwaiter<WWWResponse<FavoriteUserResponse>> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x0000000180005310-0x0000000180005320
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180005320-0x0000000180005370
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <UnfavoriteUser>d__18 : IAsyncStateMachine // TypeDefIndex: 12541
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse<UnfavoriteUserResponse>> <>t__builder; // 0x08
		public string inUserToUnfavoriteUUID; // 0x20
		private TaskAwaiter<WWWResponse<UnfavoriteUserResponse>> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x00000001800056B0-0x00000001800056C0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001800056C0-0x0000000180005710
	}

	// Constructors
	public RelationshipSrvHandler(); // 0x0000000180373240-0x0000000180373250

	// Methods
	[AsyncStateMachine] // 0x00000001801DD2F0-0x00000001801DD340
	public static Task<WWWResponse<BlockUserResponse>> BlockUser(string inUserToBlockUUID); // 0x00000001804A9D90-0x00000001804A9E70
	[AsyncStateMachine] // 0x00000001801DD610-0x00000001801DD660
	public static Task<WWWResponse<UnblockUserResponse>> UnblockUser(string inUserToUnblockUUID); // 0x00000001804AA2D0-0x00000001804AA3B0
	[AsyncStateMachine] // 0x00000001801DDAC0-0x00000001801DDB10
	public static Task<WWWResponse<CheckIsBlockedResponse>> CheckIsBlocked(string inUserToCheckUUID); // 0x00000001804A9E70-0x00000001804A9F50
	[AsyncStateMachine] // 0x00000001801DDBA0-0x00000001801DDBF0
	public static Task<WWWResponse<FollowUserResponse>> FollowUser(string inUserToFollowUUID); // 0x00000001804AA030-0x00000001804AA110
	[AsyncStateMachine] // 0x00000001801DDE80-0x00000001801DDED0
	public static Task<WWWResponse<UnfollowUserResponse>> UnfollowUser(string inUserToUnfollowUUID); // 0x00000001804AA490-0x00000001804AA570
	[AsyncStateMachine] // 0x00000001801DE1D0-0x00000001801DE220
	public static Task<WWWResponse<ListFollowsResponse>> RequestFollows(); // 0x00000001804AA200-0x00000001804AA2D0
	[AsyncStateMachine] // 0x00000001801DE3D0-0x00000001801DE420
	public static Task<WWWResponse<ListFollowersResponse>> RequestFollowers(int inPageIndex = -1 /* Metadata: 0x007B9BD4 */, int inPageSize = -1 /* Metadata: 0x007B9BD8 */); // 0x00000001804AA110-0x00000001804AA200
	[AsyncStateMachine] // 0x00000001801DE670-0x00000001801DE6C0
	public static Task<WWWResponse<FavoriteUserResponse>> FavoriteUser(string inUserToFavoriteUUID); // 0x00000001804A9F50-0x00000001804AA030
	[AsyncStateMachine] // 0x00000001801DE880-0x00000001801DE8D0
	public static Task<WWWResponse<UnfavoriteUserResponse>> UnfavoriteUser(string inUserToUnfavoriteUUID); // 0x00000001804AA3B0-0x00000001804AA490
}

