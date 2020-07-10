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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UserManager : SingletonManagerBase<UserManager> // TypeDefIndex: 10797
{
	// Fields
	[TextArea] // 0x00000001800DD430-0x00000001800DD450
	public string testJsonInventory; // 0x60
	private MyUserInfo _me; // 0x68
	private UserCollection _users; // 0x70
	private List<BatchedDisplayNameRequest> _displayNameRequestsPending; // 0x78
	private List<BatchedDisplayNameRequest> _displayNameRequestsInProgress; // 0x80
	private List<BatchedDisplayNameResult> _displayNameResults; // 0x88
	private const float BATCH_REQUEST_COOLDOWN = 0.25f; // Metadata: 0x00782049
	private float _lastBatchRequestTime; // 0x90

	// Properties
	public static MyUserInfo Me { get; set; } // 0x000000018121FBC0-0x000000018121FC10 0x000000018121FC10-0x000000018121FCB0

	// Nested types
	private class UserCollection // TypeDefIndex: 10798
	{
		// Fields
		private Dictionary<string, UserInfo> _usersByUUID; // 0x10
		private Dictionary<string, UserInfo> _usersByName; // 0x18

		// Constructors
		public UserCollection(); // 0x000000018121F190-0x000000018121F210

		// Methods
		public UserInfo GetByName(string name); // 0x000000018121EE70-0x000000018121EEE0
		public UserInfo GetByUUID(string uuid); // 0x000000018121EEE0-0x000000018121EF50
		public void Add(UserInfo u); // 0x000000018121EDE0-0x000000018121EE70
		public UserInfo AddOrReplace(string uuid, string displayName); // 0x000000018121EC40-0x000000018121EDE0
		public void Remove(UserInfo u); // 0x000000018121F110-0x000000018121F190
		public void RemoveByUUID(string uuid); // 0x000000018121F030-0x000000018121F110
		public void RemoveByName(string name); // 0x000000018121EF50-0x000000018121F030
	}

	private class BatchedDisplayNameRequest // TypeDefIndex: 10799
	{
		// Fields
		public string uuid; // 0x10
		public int count; // 0x18

		// Constructors
		public BatchedDisplayNameRequest(string inUUID, int inCount); // 0x0000000180367610-0x0000000180367650
	}

	private class BatchedDisplayNameResult // TypeDefIndex: 10800
	{
		// Fields
		public string uuid; // 0x10
		public int count; // 0x18
		public string displayName; // 0x20

		// Constructors
		public BatchedDisplayNameResult(string inUUID, int inCount, string inDisplayName); // 0x0000000180588CA0-0x0000000180588CF0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <GetUserInfoAsync>d__18 : IAsyncStateMachine // TypeDefIndex: 10801
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncUniTaskMethodBuilder<UserInfo> <>t__builder; // 0x08
		public string uuid; // 0x20
		private UserInfo <u>5__2; // 0x28
		private TaskAwaiter<string> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x000000018020EC70-0x000000018020EC80
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018020EC80-0x000000018020ECD0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <GetDisplayNamesAsync>d__20 : IAsyncStateMachine // TypeDefIndex: 10802
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<IdentityDisplayNamesResponse.Identity[]> <>t__builder; // 0x08
		public List<string> uuids; // 0x20
		private TaskAwaiter<WWWResponse<IdentityDisplayNamesResponse>> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x000000018020EC10-0x000000018020EC20
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018020EC20-0x000000018020EC70
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass22_0 // TypeDefIndex: 10803
	{
		// Fields
		public string inUUID; // 0x10
		public UserManager <>4__this; // 0x18
		public Predicate<BatchedDisplayNameResult> <>9__4; // 0x20

		// Constructors
		public <>c__DisplayClass22_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <GetDisplayNameBatched>b__0(BatchedDisplayNameRequest item); // 0x0000000180EB3C90-0x0000000180EB3CC0
		internal bool <GetDisplayNameBatched>b__1(BatchedDisplayNameRequest item); // 0x0000000180EB3C90-0x0000000180EB3CC0
		internal bool <GetDisplayNameBatched>b__2(); // 0x000000018121E820-0x000000018121E8D0
		internal bool <GetDisplayNameBatched>b__4(BatchedDisplayNameResult result); // 0x0000000180EB3C90-0x0000000180EB3CC0
		internal bool <GetDisplayNameBatched>b__3(BatchedDisplayNameResult result); // 0x0000000180EB3C90-0x0000000180EB3CC0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <GetDisplayNameBatched>d__22 : IAsyncStateMachine // TypeDefIndex: 10804
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<string> <>t__builder; // 0x08
		public string inUUID; // 0x20
		public UserManager <>4__this; // 0x28
		private <>c__DisplayClass22_0 <>8__1; // 0x30
		private UniTask.Awaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x000000018020EBB0-0x000000018020EBC0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018020EBC0-0x000000018020EC10
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass23_0 // TypeDefIndex: 10805
	{
		// Fields
		public IdentityDisplayNamesResponse.Identity identity; // 0x10

		// Constructors
		public <>c__DisplayClass23_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <RequestBatchedDisplayNames>b__0(BatchedDisplayNameRequest item); // 0x0000000180EB3C90-0x0000000180EB3CC0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass23_1 // TypeDefIndex: 10806
	{
		// Fields
		public string uuid; // 0x10

		// Constructors
		public <>c__DisplayClass23_1(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <RequestBatchedDisplayNames>b__1(BatchedDisplayNameRequest item); // 0x0000000180EB3C90-0x0000000180EB3CC0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestBatchedDisplayNames>d__23 : IAsyncStateMachine // TypeDefIndex: 10807
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UserManager <>4__this; // 0x28
		private TaskAwaiter<WWWResponse<IdentityDisplayNamesResponse>> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x000000018020ED30-0x000000018020ED40
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	// Constructors
	public UserManager(); // 0x000000018121FA80-0x000000018121FBC0

	// Methods
	public override void Init(); // 0x000000018121F800-0x000000018121F8A0
	public override void Deinit(); // 0x000000018121F400-0x000000018121F4A0
	private void OnLogin(LoginMessage message); // 0x000000018121F9A0-0x000000018121F9D0
	public static UserInfo AddOrReplaceUserInfo(string uuid, string displayName); // 0x000000018121F220-0x000000018121F400
	[AsyncStateMachine] // 0x00000001800DD600-0x00000001800DD650
	public static UniTask<UserInfo> GetUserInfoAsync(string uuid); // 0x000000018121F670-0x000000018121F750
	public static UserInfo GetUserInfoImmediate(string uuid); // 0x000000018121F750-0x000000018121F800
	[AsyncStateMachine] // 0x00000001800DDA90-0x00000001800DDAE0
	public static Task<IdentityDisplayNamesResponse.Identity[]> GetDisplayNamesAsync(List<string> uuids); // 0x000000018121F590-0x000000018121F670
	private void LateUpdate(); // 0x000000018121F8A0-0x000000018121F9A0
	[AsyncStateMachine] // 0x00000001800DDCA0-0x00000001800DDCF0
	private Task<string> GetDisplayNameBatched(string inUUID); // 0x000000018121F4A0-0x000000018121F590
	[AsyncStateMachine] // 0x00000001800DE100-0x00000001800DE150
	private void RequestBatchedDisplayNames(); // 0x000000018121F9D0-0x000000018121FA80
	public override void MOnDestroy(); // 0x000000018036B6C0-0x000000018036B6D0
}

