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
public static class LobbyXtHandler // TypeDefIndex: 11208
{
	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestLobbyCreate>d__0 : IAsyncStateMachine // TypeDefIndex: 11209
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public LobbyManager.ELobbyType inType; // 0x20
		public string inAssocDefID; // 0x28
		public Action<RequestLobbyJoinSuccessMessage> onSuccess; // 0x30
		public Action<RequestLobbyCreateFailedMessage> onFailed; // 0x38
		private TaskAwaiter <>u__1; // 0x40

		// Methods
		private void MoveNext(); // 0x000000018020E8C0-0x000000018020E8D0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018000DC90-0x000000018000DCA0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 11210
	{
		// Fields
		public Action<RequestLobbyJoinSuccessMessage> onSuccess; // 0x10
		public Action<RequestLobbyCreateFailedMessage> onFailed; // 0x18

		// Constructors
		public <>c__DisplayClass1_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <RequestLobbyCreate>b__0(RequestLobbyJoinSuccessMessage s); // 0x00000001811F6430-0x00000001811F6480
		internal void <RequestLobbyCreate>b__1(RequestLobbyCreateFailedMessage f); // 0x00000001811F6480-0x00000001811F64D0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestLobbyCreate>d__1 : IAsyncStateMachine // TypeDefIndex: 11211
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public Action<RequestLobbyJoinSuccessMessage> onSuccess; // 0x20
		public Action<RequestLobbyCreateFailedMessage> onFailed; // 0x28
		public string inType; // 0x30
		public string inAssocDefID; // 0x38
		private TaskAwaiter <>u__1; // 0x40

		// Methods
		private void MoveNext(); // 0x000000018020E8D0-0x000000018020E8E0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018000DC90-0x000000018000DCA0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestLobbyJoin>d__2 : IAsyncStateMachine // TypeDefIndex: 11212
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public LobbyManager.ELobbyType inType; // 0x20
		public string inHostUUID; // 0x28
		public Action<RequestLobbyJoinSuccessMessage> onSuccess; // 0x30
		public Action<RequestLobbyJoinFailedMessage> onFailed; // 0x38
		private TaskAwaiter <>u__1; // 0x40

		// Methods
		private void MoveNext(); // 0x000000018020E8E0-0x000000018020E8F0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018000DC90-0x000000018000DCA0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass3_0 // TypeDefIndex: 11213
	{
		// Fields
		public Action<RequestLobbyJoinSuccessMessage> onSuccess; // 0x10
		public Action<RequestLobbyJoinFailedMessage> onFailed; // 0x18

		// Constructors
		public <>c__DisplayClass3_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <RequestLobbyJoin>b__0(RequestLobbyJoinSuccessMessage s); // 0x00000001811F64D0-0x00000001811F6520
		internal void <RequestLobbyJoin>b__1(RequestLobbyJoinFailedMessage f); // 0x00000001811F6520-0x00000001811F6570
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestLobbyJoin>d__3 : IAsyncStateMachine // TypeDefIndex: 11214
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public Action<RequestLobbyJoinSuccessMessage> onSuccess; // 0x20
		public Action<RequestLobbyJoinFailedMessage> onFailed; // 0x28
		public string inHostUUID; // 0x30
		public string inType; // 0x38
		private TaskAwaiter <>u__1; // 0x40

		// Methods
		private void MoveNext(); // 0x000000018020E8F0-0x000000018020E900
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018000DC90-0x000000018000DCA0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestLobbyLeave>d__4 : IAsyncStateMachine // TypeDefIndex: 11215
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public LobbyManager.ELobbyType inType; // 0x20
		public Action<RequestLobbyLeaveSuccessMessage> onSuccess; // 0x28
		public Action<RequestLobbyLeaveFailedMessage> onFailed; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x000000018020E900-0x000000018020E910
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018000DC90-0x000000018000DCA0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass5_0 // TypeDefIndex: 11216
	{
		// Fields
		public Action<RequestLobbyLeaveSuccessMessage> onSuccess; // 0x10
		public Action<RequestLobbyLeaveFailedMessage> onFailed; // 0x18

		// Constructors
		public <>c__DisplayClass5_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <RequestLobbyLeave>b__0(RequestLobbyLeaveSuccessMessage s); // 0x00000001811F6570-0x00000001811F65C0
		internal void <RequestLobbyLeave>b__1(RequestLobbyLeaveFailedMessage f); // 0x00000001811F65C0-0x00000001811F6610
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestLobbyLeave>d__5 : IAsyncStateMachine // TypeDefIndex: 11217
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public Action<RequestLobbyLeaveSuccessMessage> onSuccess; // 0x20
		public Action<RequestLobbyLeaveFailedMessage> onFailed; // 0x28
		public string inType; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x000000018020E910-0x000000018020E920
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018000DC90-0x000000018000DCA0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestLobbyStart>d__6 : IAsyncStateMachine // TypeDefIndex: 11218
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public LobbyManager.ELobbyType inType; // 0x20
		public Action<RequestLobbyStartSuccessMessage> onSuccess; // 0x28
		public Action<RequestLobbyStartFailedMessage> onFailed; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x000000018020E920-0x000000018020E930
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018000DC90-0x000000018000DCA0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass7_0 // TypeDefIndex: 11219
	{
		// Fields
		public Action<RequestLobbyStartSuccessMessage> onSuccess; // 0x10
		public Action<RequestLobbyStartFailedMessage> onFailed; // 0x18

		// Constructors
		public <>c__DisplayClass7_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <RequestLobbyStart>b__0(RequestLobbyStartSuccessMessage s); // 0x00000001811F6610-0x00000001811F6660
		internal void <RequestLobbyStart>b__1(RequestLobbyStartFailedMessage f); // 0x00000001811F6660-0x00000001811F66B0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestLobbyStart>d__7 : IAsyncStateMachine // TypeDefIndex: 11220
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public Action<RequestLobbyStartSuccessMessage> onSuccess; // 0x20
		public Action<RequestLobbyStartFailedMessage> onFailed; // 0x28
		public string inType; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x000000018020E930-0x000000018020E940
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018000DC90-0x000000018000DCA0
	}

	// Methods
	[AsyncStateMachine] // 0x000000018012D4B0-0x000000018012D500
	internal static Task RequestLobbyCreate(LobbyManager.ELobbyType inType, string inAssocDefID, Action<RequestLobbyJoinSuccessMessage> onSuccess = null, Action<RequestLobbyCreateFailedMessage> onFailed = null); // 0x00000001811E6120-0x00000001811E6230
	[AsyncStateMachine] // 0x000000018012D7A0-0x000000018012D810
	[MessageSender] // 0x000000018012D7A0-0x000000018012D810
	private static Task RequestLobbyCreate(string inType, string inAssocDefID, Action<RequestLobbyJoinSuccessMessage> onSuccess = null, Action<RequestLobbyCreateFailedMessage> onFailed = null); // 0x00000001811E6230-0x00000001811E6340
	[AsyncStateMachine] // 0x000000018012DA50-0x000000018012DAA0
	internal static Task RequestLobbyJoin(LobbyManager.ELobbyType inType, string inHostUUID, Action<RequestLobbyJoinSuccessMessage> onSuccess = null, Action<RequestLobbyJoinFailedMessage> onFailed = null); // 0x00000001811E6340-0x00000001811E6450
	[AsyncStateMachine] // 0x000000018012DDB0-0x000000018012DE20
	[MessageSender] // 0x000000018012DDB0-0x000000018012DE20
	private static Task RequestLobbyJoin(string inType, string inHostUUID, Action<RequestLobbyJoinSuccessMessage> onSuccess = null, Action<RequestLobbyJoinFailedMessage> onFailed = null); // 0x00000001811E6450-0x00000001811E6560
	[AsyncStateMachine] // 0x000000018012E050-0x000000018012E0A0
	internal static Task RequestLobbyLeave(LobbyManager.ELobbyType inType, Action<RequestLobbyLeaveSuccessMessage> onSuccess = null, Action<RequestLobbyLeaveFailedMessage> onFailed = null); // 0x00000001811E6660-0x00000001811E6760
	[AsyncStateMachine] // 0x000000018012E2E0-0x000000018012E350
	[MessageSender] // 0x000000018012E2E0-0x000000018012E350
	private static Task RequestLobbyLeave(string inType, Action<RequestLobbyLeaveSuccessMessage> onSuccess = null, Action<RequestLobbyLeaveFailedMessage> onFailed = null); // 0x00000001811E6560-0x00000001811E6660
	[AsyncStateMachine] // 0x000000018012E600-0x000000018012E650
	internal static Task RequestLobbyStart(LobbyManager.ELobbyType inType, Action<RequestLobbyStartSuccessMessage> onSuccess = null, Action<RequestLobbyStartFailedMessage> onFailed = null); // 0x00000001811E6860-0x00000001811E6960
	[AsyncStateMachine] // 0x000000018012E870-0x000000018012E8E0
	[MessageSender] // 0x000000018012E870-0x000000018012E8E0
	private static Task RequestLobbyStart(string inType, Action<RequestLobbyStartSuccessMessage> onSuccess = null, Action<RequestLobbyStartFailedMessage> onFailed = null); // 0x00000001811E6760-0x00000001811E6860
	[MessageRoute] // 0x000000018012EC50-0x000000018012EC70
	private static void HandleLobbyJoin(ReceivedLobbyJoinMessage message); // 0x00000001803581E0-0x00000001803581F0
}

