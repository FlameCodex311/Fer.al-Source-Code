/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UniRx.Async;
using UniRx.Async.CompilerServices;
using UnityEngine;
using WW.Debug;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class RelationshipManager : SingletonManagerBase<RelationshipManager> // TypeDefIndex: 12260
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<Follower> _followers; // 0x60
	private const int FOLLOWER_PAGE_SIZE = 10; // Metadata: 0x007B96E0
	private const float FOLLOWERS_ALL_CACHED_COOLDOWN = 10f; // Metadata: 0x007B96E4
	private bool _requestingFollowers; // 0x68
	private bool _allFollowersCached; // 0x69
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<Follow> _follows; // 0x70
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<Block> _blocks; // 0x78
	private Dictionary<string, bool> _blockChecks; // 0x80
	private List<string> _blockChecksInProgress; // 0x88
	public const float ONLINE_CACHE_LIFETIME = 30f; // Metadata: 0x007B96E8
	private Dictionary<string, CachedOnlineStatus> _onlineStatuses; // 0x90
	public string userToJoin; // 0x98

	// Properties
	public List<Follower> Followers { get; } // 0x0000000180418970-0x0000000180418980 
	public List<Follow> Follows { get; } // 0x0000000180418980-0x0000000180418990 
	public List<Block> Blocks { get; } // 0x0000000180418A40-0x0000000180418A50 

	// Nested types
	[Serializable]
	public class Follower // TypeDefIndex: 12261
	{
		// Fields
		public string userUUID; // 0x10
		public bool isFavorite; // 0x18

		// Constructors
		public Follower(); // 0x0000000180373240-0x0000000180373250
	}

	[Serializable]
	public class Follow // TypeDefIndex: 12262
	{
		// Fields
		public string userUUID; // 0x10
		public bool isFavorite; // 0x18
		public DateTime followedAt; // 0x20

		// Constructors
		public Follow(); // 0x0000000180373240-0x0000000180373250
	}

	[Serializable]
	public class Block // TypeDefIndex: 12263
	{
		// Fields
		public string userUUID; // 0x10
		public DateTime blockedAtTime; // 0x18

		// Constructors
		public Block(); // 0x0000000180373240-0x0000000180373250
	}

	public struct CachedOnlineStatus // TypeDefIndex: 12264
	{
		// Fields
		public OnlineStatus status; // 0x00
		public float cachedAtTime; // 0x04

		// Properties
		public bool IsExpired { get; } // 0x0000000180005170-0x00000001800051E0 

		// Constructors
		public CachedOnlineStatus(OnlineStatus inOnlineStatus); // 0x0000000180005150-0x0000000180005170
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <FollowUser>d__23 : IAsyncStateMachine // TypeDefIndex: 12265
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public string inUserToFollowUUID; // 0x28
		public RelationshipManager <>4__this; // 0x30
		private TaskAwaiter<WWWResponse<RelationshipSrvHandler.FollowUserResponse>> <>u__1; // 0x38
		private TaskAwaiter<OnlineStatusResponse> <>u__2; // 0x40
		private UniTask<UserInfo> <>u__3; // 0x48

		// Methods
		private void MoveNext(); // 0x0000000180005380-0x0000000180005390
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass24_0 // TypeDefIndex: 12266
	{
		// Fields
		public string inUserToUnfollowUUID; // 0x10

		// Constructors
		public <>c__DisplayClass24_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <UnfollowUser>b__0(Follow follow); // 0x00000001803E2140-0x00000001803E2170
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <UnfollowUser>d__24 : IAsyncStateMachine // TypeDefIndex: 12267
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public string inUserToUnfollowUUID; // 0x28
		public RelationshipManager <>4__this; // 0x30
		private <>c__DisplayClass24_0 <>8__1; // 0x38
		private TaskAwaiter<WWWResponse<RelationshipSrvHandler.UnfollowUserResponse>> <>u__1; // 0x40

		// Methods
		private void MoveNext(); // 0x0000000180005720-0x0000000180005730
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass25_0 // TypeDefIndex: 12268
	{
		// Fields
		public string inUserToFavoriteUUID; // 0x10

		// Constructors
		public <>c__DisplayClass25_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <FavoriteUser>b__0(Follow follow); // 0x00000001803E2140-0x00000001803E2170
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <FavoriteUser>d__25 : IAsyncStateMachine // TypeDefIndex: 12269
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public string inUserToFavoriteUUID; // 0x28
		public RelationshipManager <>4__this; // 0x30
		private <>c__DisplayClass25_0 <>8__1; // 0x38
		private TaskAwaiter<WWWResponse<RelationshipSrvHandler.FavoriteUserResponse>> <>u__1; // 0x40

		// Methods
		private void MoveNext(); // 0x0000000180005370-0x0000000180005380
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass26_0 // TypeDefIndex: 12270
	{
		// Fields
		public string inUserToUnfavoriteUUID; // 0x10

		// Constructors
		public <>c__DisplayClass26_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <UnfavoriteUser>b__0(Follow follow); // 0x00000001803E2140-0x00000001803E2170
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <UnfavoriteUser>d__26 : IAsyncStateMachine // TypeDefIndex: 12271
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public string inUserToUnfavoriteUUID; // 0x28
		public RelationshipManager <>4__this; // 0x30
		private <>c__DisplayClass26_0 <>8__1; // 0x38
		private TaskAwaiter<WWWResponse<RelationshipSrvHandler.UnfavoriteUserResponse>> <>u__1; // 0x40

		// Methods
		private void MoveNext(); // 0x0000000180005710-0x0000000180005720
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <BlockUser>d__27 : IAsyncStateMachine // TypeDefIndex: 12272
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public string inUserToBlockUUID; // 0x28
		public RelationshipManager <>4__this; // 0x30
		private TaskAwaiter<WWWResponse<RelationshipSrvHandler.BlockUserResponse>> <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x000000018000A290-0x000000018000A2A0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass28_0 // TypeDefIndex: 12273
	{
		// Fields
		public string inUserToUnblockUUID; // 0x10

		// Constructors
		public <>c__DisplayClass28_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <UnblockUser>b__0(Block block); // 0x00000001803E2140-0x00000001803E2170
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <UnblockUser>d__28 : IAsyncStateMachine // TypeDefIndex: 12274
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public string inUserToUnblockUUID; // 0x28
		public RelationshipManager <>4__this; // 0x30
		private <>c__DisplayClass28_0 <>8__1; // 0x38
		private TaskAwaiter<WWWResponse<RelationshipSrvHandler.UnblockUserResponse>> <>u__1; // 0x40

		// Methods
		private void MoveNext(); // 0x0000000180005640-0x0000000180005650
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass29_0 // TypeDefIndex: 12275
	{
		// Fields
		public RelationshipManager <>4__this; // 0x10
		public string inUserToCheckUUID; // 0x18

		// Constructors
		public <>c__DisplayClass29_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <UserIsBlocked>b__0(); // 0x000000018065F310-0x000000018065F370
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <UserIsBlocked>d__29 : IAsyncStateMachine // TypeDefIndex: 12276
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncUniTaskMethodBuilder<bool> <>t__builder; // 0x08
		public RelationshipManager <>4__this; // 0x20
		public string inUserToCheckUUID; // 0x28
		private <>c__DisplayClass29_0 <>8__1; // 0x30
		private UniTask.Awaiter <>u__1; // 0x38
		private TaskAwaiter<WWWResponse<RelationshipSrvHandler.CheckIsBlockedResponse>> <>u__2; // 0x40

		// Methods
		private void MoveNext(); // 0x0000000180005790-0x00000001800057A0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001800057A0-0x00000001800057F0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <UserIsOnline>d__30 : IAsyncStateMachine // TypeDefIndex: 12277
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<bool> <>t__builder; // 0x08
		public string inUserToCheckUUID; // 0x20
		public RelationshipManager <>4__this; // 0x28
		private TaskAwaiter<OnlineStatusResponse> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001800057F0-0x0000000180005800
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180005800-0x0000000180005850
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass32_0 // TypeDefIndex: 12278
	{
		// Fields
		public string inUserToCheckUUID; // 0x10

		// Constructors
		public <>c__DisplayClass32_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <UserIsFollowed>b__0(Follow follow); // 0x00000001803E2140-0x00000001803E2170
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass33_0 // TypeDefIndex: 12279
	{
		// Fields
		public string inUserToCheckUUID; // 0x10

		// Constructors
		public <>c__DisplayClass33_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <GetFollow>b__0(Follow follow); // 0x00000001803E2140-0x00000001803E2170
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestAdditionalFollowers>d__34 : IAsyncStateMachine // TypeDefIndex: 12280
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public RelationshipManager <>4__this; // 0x28
		private int <alreadyReceivedCount>5__2; // 0x30
		private TaskAwaiter<WWWResponse<RelationshipSrvHandler.ListFollowersResponse>> <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x0000000180005420-0x0000000180005430
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass36_0 // TypeDefIndex: 12281
	{
		// Fields
		public RelationshipManager <>4__this; // 0x10
		public string inUUID; // 0x18
		public List<string> eventNames; // 0x20
		public List<Action<IMessage>> callbacks; // 0x28

		// Nested types
		private struct <<GoToPlayer>b__1>d : IAsyncStateMachine // TypeDefIndex: 12282
		{
			// Fields
			public int <>1__state; // 0x00
			public AsyncVoidMethodBuilder <>t__builder; // 0x08
			public <>c__DisplayClass36_0 <>4__this; // 0x28
			private UniTask<UserInfo> <>u__1; // 0x30

			// Methods
			private void MoveNext(); // 0x000000018000A2D0-0x000000018000A2E0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
		}

		private struct <<GoToPlayer>b__2>d : IAsyncStateMachine // TypeDefIndex: 12283
		{
			// Fields
			public int <>1__state; // 0x00
			public AsyncVoidMethodBuilder <>t__builder; // 0x08
			public IMessage inJumpToPlayerResponse; // 0x28
			public <>c__DisplayClass36_0 <>4__this; // 0x30
			private UniTask<UserInfo> <>u__1; // 0x38

			// Methods
			private void MoveNext(); // 0x000000018000A2E0-0x000000018000A2F0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
		}

		private struct <<GoToPlayer>b__3>d : IAsyncStateMachine // TypeDefIndex: 12284
		{
			// Fields
			public int <>1__state; // 0x00
			public AsyncTaskMethodBuilder <>t__builder; // 0x08
			public <>c__DisplayClass36_0 <>4__this; // 0x20
			private TaskAwaiter <>u__1; // 0x28

			// Methods
			private void MoveNext(); // 0x000000018000A2F0-0x000000018000A300
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002500-0x0000000180002510
		}

		// Constructors
		public <>c__DisplayClass36_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <GoToPlayer>b__0(IMessage inRoomJoinSuccessMessage); // 0x000000018065F370-0x000000018065F3A0
		[AsyncStateMachine] // 0x0000000180270780-0x00000001802707D0
		internal void <GoToPlayer>b__1(IMessage inRoomJoinFailedMessage); // 0x000000018065F3A0-0x000000018065F450
		[AsyncStateMachine] // 0x0000000180270950-0x00000001802709A0
		internal void <GoToPlayer>b__2(IMessage inJumpToPlayerResponse); // 0x000000018065F450-0x000000018065F510
		[AsyncStateMachine] // 0x0000000180270B70-0x0000000180270BC0
		internal Task <GoToPlayer>b__3(); // 0x000000018065F510-0x000000018065F5E0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <GoToPlayer>d__36 : IAsyncStateMachine // TypeDefIndex: 12285
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public RelationshipManager <>4__this; // 0x28
		public string inUUID; // 0x30
		private <>c__DisplayClass36_0 <>8__1; // 0x38
		private TaskAwaiter<bool> <>u__1; // 0x40
		private TaskAwaiter <>u__2; // 0x48

		// Methods
		private void MoveNext(); // 0x00000001800053F0-0x0000000180005400
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <TeleportToPlayer>d__37 : IAsyncStateMachine // TypeDefIndex: 12286
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public WorldObject inPlayerWorldObject; // 0x28
		private TaskAwaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x0000000180005630-0x0000000180005640
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <SearchForPlayer>d__38 : IAsyncStateMachine // TypeDefIndex: 12287
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<string> <>t__builder; // 0x08
		public string inDisplayName; // 0x20
		private TaskAwaiter<RelationshipFollowingFindPlayerUUIDResponse> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x00000001800055C0-0x00000001800055D0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001800055D0-0x0000000180005620
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RefreshFollows>d__39 : IAsyncStateMachine // TypeDefIndex: 12288
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public RelationshipManager <>4__this; // 0x28
		private TaskAwaiter<WWWResponse<RelationshipSrvHandler.ListFollowsResponse>> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x0000000180005410-0x0000000180005420
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <OnUserBlocked>d__43 : IAsyncStateMachine // TypeDefIndex: 12289
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UserBlockedMessage inMessage; // 0x28
		private UniTask<UserInfo> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x0000000180005400-0x0000000180005410
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Constructors
	public RelationshipManager(); // 0x0000000180658590-0x00000001806586B0

	// Methods
	public override void Init(); // 0x00000001806577A0-0x0000000180657900
	public override void Deinit(); // 0x0000000180657340-0x00000001806574A0
	[AsyncStateMachine] // 0x0000000180268A10-0x0000000180268AB0
	[DebugButton] // 0x0000000180268A10-0x0000000180268AB0
	public void FollowUser(string inUserToFollowUUID); // 0x0000000180657560-0x0000000180657630
	[AsyncStateMachine] // 0x0000000180268D20-0x0000000180268DC0
	[DebugButton] // 0x0000000180268D20-0x0000000180268DC0
	public void UnfollowUser(string inUserToUnfollowUUID); // 0x0000000180658180-0x0000000180658240
	[AsyncStateMachine] // 0x00000001802690D0-0x0000000180269170
	[DebugButton] // 0x00000001802690D0-0x0000000180269170
	public void FavoriteUser(string inUserToFavoriteUUID); // 0x00000001806574A0-0x0000000180657560
	[AsyncStateMachine] // 0x00000001802694E0-0x0000000180269580
	[DebugButton] // 0x00000001802694E0-0x0000000180269580
	public void UnfavoriteUser(string inUserToUnfavoriteUUID); // 0x00000001806580C0-0x0000000180658180
	[AsyncStateMachine] // 0x00000001802698C0-0x0000000180269960
	[DebugButton] // 0x00000001802698C0-0x0000000180269960
	public void BlockUser(string inUserToBlockUUID); // 0x00000001806571E0-0x00000001806572A0
	[AsyncStateMachine] // 0x0000000180269C00-0x0000000180269CA0
	[DebugButton] // 0x0000000180269C00-0x0000000180269CA0
	public void UnblockUser(string inUserToUnblockUUID); // 0x0000000180658000-0x00000001806580C0
	[AsyncStateMachine] // 0x000000018026A100-0x000000018026A150
	public UniTask<bool> UserIsBlocked(string inUserToCheckUUID); // 0x0000000180658240-0x0000000180658340
	[AsyncStateMachine] // 0x000000018026A3D0-0x000000018026A420
	public Task<bool> UserIsOnline(string inUserToCheckUUID); // 0x00000001806584A0-0x0000000180658590
	public bool UserIsOnlineImmediate(string inUserToCheckUUID); // 0x0000000180658400-0x00000001806584A0
	public bool UserIsFollowed(string inUserToCheckUUID); // 0x0000000180658340-0x0000000180658400
	public Follow GetFollow(string inUserToCheckUUID); // 0x0000000180657630-0x00000001806576E0
	[AsyncStateMachine] // 0x000000018026A690-0x000000018026A6E0
	public void RequestAdditionalFollowers(); // 0x0000000180657D50-0x0000000180657E00
	public void ClearFollowersCache(); // 0x00000001806572A0-0x0000000180657340
	[AsyncStateMachine] // 0x000000018026A7A0-0x000000018026A840
	[DebugButton] // 0x000000018026A7A0-0x000000018026A840
	public void GoToPlayer(string inUUID); // 0x00000001806576E0-0x00000001806577A0
	[AsyncStateMachine] // 0x000000018026AC60-0x000000018026ACB0
	public void TeleportToPlayer(WorldObject inPlayerWorldObject); // 0x0000000180657EE0-0x0000000180657F90
	[AsyncStateMachine] // 0x000000018026AEB0-0x000000018026AF00
	public Task<string> SearchForPlayer(string inDisplayName); // 0x0000000180657E00-0x0000000180657EE0
	[AsyncStateMachine] // 0x000000018026B130-0x000000018026B180
	private void RefreshFollows(); // 0x0000000180657A40-0x0000000180657AF0
	private void OnLoginComplete(LoginCompleteResponse inMessage); // 0x0000000180657A40-0x0000000180657AF0
	private void OnRelationshipFollowingListResponse(RelationshipFollowingListResponse inMessage); // 0x0000000180657AF0-0x0000000180657CA0
	private void OnFollowOnlineStatusUpdated(RelationshipFollowOnlineStatusUpdateResponse inMessage); // 0x0000000180657900-0x0000000180657A40
	[AsyncStateMachine] // 0x000000018026B390-0x000000018026B3E0
	private void OnUserBlocked(UserBlockedMessage inMessage); // 0x0000000180657CA0-0x0000000180657D50
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <RequestAdditionalFollowers>b__34_0(); // 0x0000000180657FF0-0x0000000180658000
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <ClearFollowersCache>b__35_0(); // 0x0000000180657F90-0x0000000180657FA0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <ClearFollowersCache>b__35_1(); // 0x0000000180657FA0-0x0000000180657FF0
}

