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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UserManager : SingletonManagerBase<UserManager> // TypeDefIndex: 12307
{
	// Fields
	[TextArea] // 0x000000018027BB30-0x000000018027BB50
	public string testJsonInventory; // 0x60
	private MyUserInfo _me; // 0x68
	private UserCollection _users; // 0x70
	private List<BatchedDisplayNameRequest> _displayNameRequestsPending; // 0x78
	private List<BatchedDisplayNameRequest> _displayNameRequestsInProgress; // 0x80
	private List<BatchedDisplayNameResult> _displayNameResults; // 0x88
	private const float BATCH_REQUEST_COOLDOWN = 0.25f; // Metadata: 0x007B9708
	private float _lastBatchRequestTime; // 0x90

	// Properties
	public static MyUserInfo Me { get; set; } // 0x000000018066BA20-0x000000018066BA70 0x000000018066BA70-0x000000018066BB00

	// Nested types
	private class UserCollection // TypeDefIndex: 12308
	{
		// Fields
		private Dictionary<string, UserInfo> _usersByUUID; // 0x10
		private Dictionary<string, UserInfo> _usersByName; // 0x18

		// Constructors
		public UserCollection(); // 0x000000018066AF70-0x000000018066AFF0

		// Methods
		public UserInfo GetByName(string name); // 0x000000018066AC70-0x000000018066ACE0
		public UserInfo GetByUUID(string uuid); // 0x000000018066ACE0-0x000000018066AD50
		public void Add(UserInfo u); // 0x000000018066ABE0-0x000000018066AC70
		public UserInfo AddOrReplace(string uuid, string displayName); // 0x000000018066AA40-0x000000018066ABE0
		public void Remove(UserInfo u); // 0x000000018066AEF0-0x000000018066AF70
		public void RemoveByUUID(string uuid); // 0x000000018066AE20-0x000000018066AEF0
		public void RemoveByName(string name); // 0x000000018066AD50-0x000000018066AE20
	}

	private class BatchedDisplayNameRequest // TypeDefIndex: 12309
	{
		// Fields
		public string uuid; // 0x10
		public int count; // 0x18

		// Constructors
		public BatchedDisplayNameRequest(string inUUID, int inCount); // 0x00000001804164D0-0x0000000180416510
	}

	private class BatchedDisplayNameResult // TypeDefIndex: 12310
	{
		// Fields
		public string uuid; // 0x10
		public int count; // 0x18
		public string displayName; // 0x20

		// Constructors
		public BatchedDisplayNameResult(string inUUID, int inCount, string inDisplayName); // 0x000000018065F880-0x000000018065F8D0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <GetUserInfoAsync>d__18 : IAsyncStateMachine // TypeDefIndex: 12311
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncUniTaskMethodBuilder<UserInfo> <>t__builder; // 0x08
		public string uuid; // 0x20
		private UserInfo <u>5__2; // 0x28
		private TaskAwaiter<string> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x000000018000A3C0-0x000000018000A3D0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018000A3D0-0x000000018000A420
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <GetDisplayNamesAsync>d__20 : IAsyncStateMachine // TypeDefIndex: 12312
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<IdentityDisplayNamesResponse.Identity[]> <>t__builder; // 0x08
		public List<string> uuids; // 0x20
		private TaskAwaiter<WWWResponse<IdentityDisplayNamesResponse>> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x000000018000A360-0x000000018000A370
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018000A370-0x000000018000A3C0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass22_0 // TypeDefIndex: 12313
	{
		// Fields
		public string inUUID; // 0x10
		public UserManager <>4__this; // 0x18
		public Predicate<BatchedDisplayNameResult> <>9__4; // 0x20

		// Constructors
		public <>c__DisplayClass22_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <GetDisplayNameBatched>b__0(BatchedDisplayNameRequest item); // 0x00000001803E2140-0x00000001803E2170
		internal bool <GetDisplayNameBatched>b__1(BatchedDisplayNameRequest item); // 0x00000001803E2140-0x00000001803E2170
		internal bool <GetDisplayNameBatched>b__2(); // 0x000000018066A620-0x000000018066A6D0
		internal bool <GetDisplayNameBatched>b__4(BatchedDisplayNameResult result); // 0x00000001803E2140-0x00000001803E2170
		internal bool <GetDisplayNameBatched>b__3(BatchedDisplayNameResult result); // 0x00000001803E2140-0x00000001803E2170
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <GetDisplayNameBatched>d__22 : IAsyncStateMachine // TypeDefIndex: 12314
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<string> <>t__builder; // 0x08
		public string inUUID; // 0x20
		public UserManager <>4__this; // 0x28
		private <>c__DisplayClass22_0 <>8__1; // 0x30
		private UniTask.Awaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x000000018000A300-0x000000018000A310
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018000A310-0x000000018000A360
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass23_0 // TypeDefIndex: 12315
	{
		// Fields
		public IdentityDisplayNamesResponse.Identity identity; // 0x10

		// Constructors
		public <>c__DisplayClass23_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <RequestBatchedDisplayNames>b__0(BatchedDisplayNameRequest item); // 0x00000001803E2140-0x00000001803E2170
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass23_1 // TypeDefIndex: 12316
	{
		// Fields
		public string uuid; // 0x10

		// Constructors
		public <>c__DisplayClass23_1(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <RequestBatchedDisplayNames>b__1(BatchedDisplayNameRequest item); // 0x00000001803E2140-0x00000001803E2170
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestBatchedDisplayNames>d__23 : IAsyncStateMachine // TypeDefIndex: 12317
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UserManager <>4__this; // 0x28
		private TaskAwaiter<WWWResponse<IdentityDisplayNamesResponse>> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x000000018000A480-0x000000018000A490
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Constructors
	public UserManager(); // 0x000000018066B8E0-0x000000018066BA20

	// Methods
	public override void Init(); // 0x000000018066B670-0x000000018066B710
	public override void Deinit(); // 0x000000018066B270-0x000000018066B310
	private void OnLogin(LoginMessage message); // 0x000000018066B810-0x000000018066B830
	public static UserInfo AddOrReplaceUserInfo(string uuid, string displayName); // 0x000000018066B090-0x000000018066B270
	[AsyncStateMachine] // 0x000000018027BC70-0x000000018027BCC0
	public static UniTask<UserInfo> GetUserInfoAsync(string uuid); // 0x000000018066B4E0-0x000000018066B5C0
	public static UserInfo GetUserInfoImmediate(string uuid); // 0x000000018066B5C0-0x000000018066B670
	[AsyncStateMachine] // 0x000000018027BE30-0x000000018027BE80
	public static Task<IdentityDisplayNamesResponse.Identity[]> GetDisplayNamesAsync(List<string> uuids); // 0x000000018066B400-0x000000018066B4E0
	private void LateUpdate(); // 0x000000018066B710-0x000000018066B810
	[AsyncStateMachine] // 0x000000018027C0F0-0x000000018027C140
	private Task<string> GetDisplayNameBatched(string inUUID); // 0x000000018066B310-0x000000018066B400
	[AsyncStateMachine] // 0x000000018027C3E0-0x000000018027C430
	private void RequestBatchedDisplayNames(); // 0x000000018066B830-0x000000018066B8E0
	public override void MOnDestroy(); // 0x0000000180373240-0x0000000180373250
}

