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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class RelationshipManager : SingletonManagerBase<RelationshipManager> // TypeDefIndex: 10750
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private List<Follower> _followers; // 0x60
	private const int FOLLOWER_PAGE_SIZE = 10; // Metadata: 0x00782021
	private const float FOLLOWERS_ALL_CACHED_COOLDOWN = 10f; // Metadata: 0x00782025
	private bool _requestingFollowers; // 0x68
	private bool _allFollowersCached; // 0x69
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private List<Follow> _follows; // 0x70
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private List<Block> _blocks; // 0x78
	private Dictionary<string, bool> _blockChecks; // 0x80
	private List<string> _blockChecksInProgress; // 0x88
	public const float ONLINE_CACHE_LIFETIME = 30f; // Metadata: 0x00782029
	private Dictionary<string, CachedOnlineStatus> _onlineStatuses; // 0x90
	public string userToJoin; // 0x98

	// Properties
	public List<Follower> Followers { get; } // 0x0000000180369B40-0x0000000180369B50 
	public List<Follow> Follows { get; } // 0x0000000180369B50-0x0000000180369B60 
	public List<Block> Blocks { get; } // 0x0000000180369C70-0x0000000180369C80 

	// Nested types
	[Serializable]
	public class Follower // TypeDefIndex: 10751
	{
		// Fields
		public string userUUID; // 0x10
		public bool isFavorite; // 0x18

		// Constructors
		public Follower(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	[Serializable]
	public class Follow // TypeDefIndex: 10752
	{
		// Fields
		public string userUUID; // 0x10
		public bool isFavorite; // 0x18
		public DateTime followedAt; // 0x20

		// Constructors
		public Follow(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	[Serializable]
	public class Block // TypeDefIndex: 10753
	{
		// Fields
		public string userUUID; // 0x10
		public DateTime blockedAtTime; // 0x18

		// Constructors
		public Block(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	public struct CachedOnlineStatus // TypeDefIndex: 10754
	{
		// Fields
		public OnlineStatus status; // 0x00
		public float cachedAtTime; // 0x04

		// Properties
		public bool IsExpired { get; } // 0x00000001801F7090-0x00000001801F7260 

		// Constructors
		public CachedOnlineStatus(OnlineStatus inOnlineStatus); // 0x00000001801F7070-0x00000001801F7090
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <FollowUser>d__23 : IAsyncStateMachine // TypeDefIndex: 10755
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
		private void MoveNext(); // 0x00000001801F7390-0x00000001801F73A0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass24_0 // TypeDefIndex: 10756
	{
		// Fields
		public string inUserToUnfollowUUID; // 0x10

		// Constructors
		public <>c__DisplayClass24_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <UnfollowUser>b__0(Follow follow); // 0x0000000180EB3C90-0x0000000180EB3CC0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <UnfollowUser>d__24 : IAsyncStateMachine // TypeDefIndex: 10757
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public string inUserToUnfollowUUID; // 0x28
		public RelationshipManager <>4__this; // 0x30
		private <>c__DisplayClass24_0 <>8__1; // 0x38
		private TaskAwaiter<WWWResponse<RelationshipSrvHandler.UnfollowUserResponse>> <>u__1; // 0x40

		// Methods
		private void MoveNext(); // 0x00000001801F75A0-0x00000001801F75B0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass25_0 // TypeDefIndex: 10758
	{
		// Fields
		public string inUserToFavoriteUUID; // 0x10

		// Constructors
		public <>c__DisplayClass25_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <FavoriteUser>b__0(Follow follow); // 0x0000000180EB3C90-0x0000000180EB3CC0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <FavoriteUser>d__25 : IAsyncStateMachine // TypeDefIndex: 10759
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public string inUserToFavoriteUUID; // 0x28
		public RelationshipManager <>4__this; // 0x30
		private <>c__DisplayClass25_0 <>8__1; // 0x38
		private TaskAwaiter<WWWResponse<RelationshipSrvHandler.FavoriteUserResponse>> <>u__1; // 0x40

		// Methods
		private void MoveNext(); // 0x00000001801F7380-0x00000001801F7390
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass26_0 // TypeDefIndex: 10760
	{
		// Fields
		public string inUserToUnfavoriteUUID; // 0x10

		// Constructors
		public <>c__DisplayClass26_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <UnfavoriteUser>b__0(Follow follow); // 0x0000000180EB3C90-0x0000000180EB3CC0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <UnfavoriteUser>d__26 : IAsyncStateMachine // TypeDefIndex: 10761
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public string inUserToUnfavoriteUUID; // 0x28
		public RelationshipManager <>4__this; // 0x30
		private <>c__DisplayClass26_0 <>8__1; // 0x38
		private TaskAwaiter<WWWResponse<RelationshipSrvHandler.UnfavoriteUserResponse>> <>u__1; // 0x40

		// Methods
		private void MoveNext(); // 0x00000001801F7590-0x00000001801F75A0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <BlockUser>d__27 : IAsyncStateMachine // TypeDefIndex: 10762
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public string inUserToBlockUUID; // 0x28
		public RelationshipManager <>4__this; // 0x30
		private TaskAwaiter<WWWResponse<RelationshipSrvHandler.BlockUserResponse>> <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F7370-0x00000001801F7380
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass28_0 // TypeDefIndex: 10763
	{
		// Fields
		public string inUserToUnblockUUID; // 0x10

		// Constructors
		public <>c__DisplayClass28_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <UnblockUser>b__0(Block block); // 0x0000000180EB3C90-0x0000000180EB3CC0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <UnblockUser>d__28 : IAsyncStateMachine // TypeDefIndex: 10764
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public string inUserToUnblockUUID; // 0x28
		public RelationshipManager <>4__this; // 0x30
		private <>c__DisplayClass28_0 <>8__1; // 0x38
		private TaskAwaiter<WWWResponse<RelationshipSrvHandler.UnblockUserResponse>> <>u__1; // 0x40

		// Methods
		private void MoveNext(); // 0x00000001801F7580-0x00000001801F7590
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass29_0 // TypeDefIndex: 10765
	{
		// Fields
		public RelationshipManager <>4__this; // 0x10
		public string inUserToCheckUUID; // 0x18

		// Constructors
		public <>c__DisplayClass29_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <UserIsBlocked>b__0(); // 0x000000018101B7F0-0x000000018101B860
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <UserIsBlocked>d__29 : IAsyncStateMachine // TypeDefIndex: 10766
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
		private void MoveNext(); // 0x00000001801F75B0-0x00000001801F75C0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F75C0-0x00000001801F7610
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <UserIsOnline>d__30 : IAsyncStateMachine // TypeDefIndex: 10767
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<bool> <>t__builder; // 0x08
		public string inUserToCheckUUID; // 0x20
		public RelationshipManager <>4__this; // 0x28
		private TaskAwaiter<OnlineStatusResponse> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F7610-0x00000001801F7620
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F7620-0x00000001801F7780
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass32_0 // TypeDefIndex: 10768
	{
		// Fields
		public string inUserToCheckUUID; // 0x10

		// Constructors
		public <>c__DisplayClass32_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <UserIsFollowed>b__0(Follow follow); // 0x0000000180EB3C90-0x0000000180EB3CC0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass33_0 // TypeDefIndex: 10769
	{
		// Fields
		public string inUserToCheckUUID; // 0x10

		// Constructors
		public <>c__DisplayClass33_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <GetFollow>b__0(Follow follow); // 0x0000000180EB3C90-0x0000000180EB3CC0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestAdditionalFollowers>d__34 : IAsyncStateMachine // TypeDefIndex: 10770
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public RelationshipManager <>4__this; // 0x28
		private int <alreadyReceivedCount>5__2; // 0x30
		private TaskAwaiter<WWWResponse<RelationshipSrvHandler.ListFollowersResponse>> <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F73D0-0x00000001801F73E0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass36_0 // TypeDefIndex: 10771
	{
		// Fields
		public RelationshipManager <>4__this; // 0x10
		public string inUUID; // 0x18
		public List<string> eventNames; // 0x20
		public List<Action<IMessage>> callbacks; // 0x28

		// Nested types
		private struct <<GoToPlayer>b__1>d : IAsyncStateMachine // TypeDefIndex: 10772
		{
			// Fields
			public int <>1__state; // 0x00
			public AsyncVoidMethodBuilder <>t__builder; // 0x08
			public <>c__DisplayClass36_0 <>4__this; // 0x28
			private UniTask<UserInfo> <>u__1; // 0x30

			// Methods
			private void MoveNext(); // 0x00000001801F7550-0x00000001801F7560
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
		}

		private struct <<GoToPlayer>b__2>d : IAsyncStateMachine // TypeDefIndex: 10773
		{
			// Fields
			public int <>1__state; // 0x00
			public AsyncVoidMethodBuilder <>t__builder; // 0x08
			public IMessage inJumpToPlayerResponse; // 0x28
			public <>c__DisplayClass36_0 <>4__this; // 0x30
			private UniTask<UserInfo> <>u__1; // 0x38

			// Methods
			private void MoveNext(); // 0x00000001801F7560-0x00000001801F7570
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
		}

		private struct <<GoToPlayer>b__3>d : IAsyncStateMachine // TypeDefIndex: 10774
		{
			// Fields
			public int <>1__state; // 0x00
			public AsyncTaskMethodBuilder <>t__builder; // 0x08
			public <>c__DisplayClass36_0 <>4__this; // 0x20
			private TaskAwaiter <>u__1; // 0x28

			// Methods
			private void MoveNext(); // 0x00000001801F7570-0x00000001801F7580
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018000DC90-0x000000018000DCA0
		}

		// Constructors
		public <>c__DisplayClass36_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <GoToPlayer>b__0(IMessage inRoomJoinSuccessMessage); // 0x000000018101B860-0x000000018101B890
		[AsyncStateMachine] // 0x00000001800D4420-0x00000001800D4470
		internal void <GoToPlayer>b__1(IMessage inRoomJoinFailedMessage); // 0x000000018101B890-0x000000018101B940
		[AsyncStateMachine] // 0x00000001800D4650-0x00000001800D46A0
		internal void <GoToPlayer>b__2(IMessage inJumpToPlayerResponse); // 0x000000018101B940-0x000000018101BA00
		[AsyncStateMachine] // 0x00000001800D4930-0x00000001800D4980
		internal Task <GoToPlayer>b__3(); // 0x000000018101BA00-0x000000018101BAD0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <GoToPlayer>d__36 : IAsyncStateMachine // TypeDefIndex: 10775
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
		private void MoveNext(); // 0x00000001801F73A0-0x00000001801F73B0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <TeleportToPlayer>d__37 : IAsyncStateMachine // TypeDefIndex: 10776
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public WorldObject inPlayerWorldObject; // 0x28
		private TaskAwaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F7540-0x00000001801F7550
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <SearchForPlayer>d__38 : IAsyncStateMachine // TypeDefIndex: 10777
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<string> <>t__builder; // 0x08
		public string inDisplayName; // 0x20
		private TaskAwaiter<RelationshipFollowingFindPlayerUUIDResponse> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x00000001801F74E0-0x00000001801F74F0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F74F0-0x00000001801F7540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RefreshFollows>d__39 : IAsyncStateMachine // TypeDefIndex: 10778
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public RelationshipManager <>4__this; // 0x28
		private TaskAwaiter<WWWResponse<RelationshipSrvHandler.ListFollowsResponse>> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F73C0-0x00000001801F73D0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <OnUserBlocked>d__43 : IAsyncStateMachine // TypeDefIndex: 10779
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UserBlockedMessage inMessage; // 0x28
		private UniTask<UserInfo> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F73B0-0x00000001801F73C0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	// Constructors
	public RelationshipManager(); // 0x0000000181013550-0x0000000181013670

	// Methods
	public override void Init(); // 0x0000000181012740-0x00000001810128A0
	public override void Deinit(); // 0x00000001810122D0-0x0000000181012430
	[AsyncStateMachine] // 0x00000001800CC570-0x00000001800CC610
	[DebugButton] // 0x00000001800CC570-0x00000001800CC610
	public void FollowUser(string inUserToFollowUUID); // 0x00000001810124F0-0x00000001810125C0
	[AsyncStateMachine] // 0x00000001800CC930-0x00000001800CC9D0
	[DebugButton] // 0x00000001800CC930-0x00000001800CC9D0
	public void UnfollowUser(string inUserToUnfollowUUID); // 0x0000000181013140-0x0000000181013200
	[AsyncStateMachine] // 0x00000001800CCDE0-0x00000001800CCE80
	[DebugButton] // 0x00000001800CCDE0-0x00000001800CCE80
	public void FavoriteUser(string inUserToFavoriteUUID); // 0x0000000181012430-0x00000001810124F0
	[AsyncStateMachine] // 0x00000001800CD300-0x00000001800CD3A0
	[DebugButton] // 0x00000001800CD300-0x00000001800CD3A0
	public void UnfavoriteUser(string inUserToUnfavoriteUUID); // 0x0000000181013080-0x0000000181013140
	[AsyncStateMachine] // 0x00000001800CD7B0-0x00000001800CD850
	[DebugButton] // 0x00000001800CD7B0-0x00000001800CD850
	public void BlockUser(string inUserToBlockUUID); // 0x0000000181012170-0x0000000181012230
	[AsyncStateMachine] // 0x00000001800CDD50-0x00000001800CDDF0
	[DebugButton] // 0x00000001800CDD50-0x00000001800CDDF0
	public void UnblockUser(string inUserToUnblockUUID); // 0x0000000181012FC0-0x0000000181013080
	[AsyncStateMachine] // 0x00000001800CE200-0x00000001800CE250
	public UniTask<bool> UserIsBlocked(string inUserToCheckUUID); // 0x0000000181013200-0x0000000181013300
	[AsyncStateMachine] // 0x00000001800CE680-0x00000001800CE6D0
	public Task<bool> UserIsOnline(string inUserToCheckUUID); // 0x0000000181013460-0x0000000181013550
	public bool UserIsOnlineImmediate(string inUserToCheckUUID); // 0x00000001810133C0-0x0000000181013460
	public bool UserIsFollowed(string inUserToCheckUUID); // 0x0000000181013300-0x00000001810133C0
	public Follow GetFollow(string inUserToCheckUUID); // 0x00000001810125C0-0x0000000181012680
	[AsyncStateMachine] // 0x00000001800CE9E0-0x00000001800CEA30
	public void RequestAdditionalFollowers(); // 0x0000000181012D10-0x0000000181012DC0
	public void ClearFollowersCache(); // 0x0000000181012230-0x00000001810122D0
	[AsyncStateMachine] // 0x00000001800CEDB0-0x00000001800CEE50
	[DebugButton] // 0x00000001800CEDB0-0x00000001800CEE50
	public void GoToPlayer(string inUUID); // 0x0000000181012680-0x0000000181012740
	[AsyncStateMachine] // 0x00000001800CF5E0-0x00000001800CF630
	public void TeleportToPlayer(WorldObject inPlayerWorldObject); // 0x0000000181012EA0-0x0000000181012F50
	[AsyncStateMachine] // 0x00000001800CF870-0x00000001800CF8C0
	public Task<string> SearchForPlayer(string inDisplayName); // 0x0000000181012DC0-0x0000000181012EA0
	[AsyncStateMachine] // 0x00000001800CFC60-0x00000001800CFCB0
	private void RefreshFollows(); // 0x00000001810129F0-0x0000000181012AA0
	private void OnLoginComplete(LoginCompleteResponse inMessage); // 0x00000001810129F0-0x0000000181012AA0
	private void OnRelationshipFollowingListResponse(RelationshipFollowingListResponse inMessage); // 0x0000000181012AA0-0x0000000181012C60
	private void OnFollowOnlineStatusUpdated(RelationshipFollowOnlineStatusUpdateResponse inMessage); // 0x00000001810128A0-0x00000001810129F0
	[AsyncStateMachine] // 0x00000001800D0160-0x00000001800D01B0
	private void OnUserBlocked(UserBlockedMessage inMessage); // 0x0000000181012C60-0x0000000181012D10
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <RequestAdditionalFollowers>b__34_0(); // 0x0000000181012FB0-0x0000000181012FC0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <ClearFollowersCache>b__35_0(); // 0x0000000181012F50-0x0000000181012F60
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <ClearFollowersCache>b__35_1(); // 0x0000000181012F60-0x0000000181012FB0
}

