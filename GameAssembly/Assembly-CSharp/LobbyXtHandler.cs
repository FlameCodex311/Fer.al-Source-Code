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
public static class LobbyXtHandler // TypeDefIndex: 12734
{
	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestLobbyCreate>d__0 : IAsyncStateMachine // TypeDefIndex: 12735
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
		private void MoveNext(); // 0x00000001800640F0-0x0000000180064100
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002500-0x0000000180002510
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 12736
	{
		// Fields
		public Action<RequestLobbyJoinSuccessMessage> onSuccess; // 0x10
		public Action<RequestLobbyCreateFailedMessage> onFailed; // 0x18

		// Constructors
		public <>c__DisplayClass1_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <RequestLobbyCreate>b__0(RequestLobbyJoinSuccessMessage s); // 0x0000000180C5D6A0-0x0000000180C5D6F0
		internal void <RequestLobbyCreate>b__1(RequestLobbyCreateFailedMessage f); // 0x0000000180C5D6F0-0x0000000180C5D740
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestLobbyCreate>d__1 : IAsyncStateMachine // TypeDefIndex: 12737
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
		private void MoveNext(); // 0x0000000180064100-0x0000000180064110
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002500-0x0000000180002510
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestLobbyJoin>d__2 : IAsyncStateMachine // TypeDefIndex: 12738
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
		private void MoveNext(); // 0x0000000180064110-0x0000000180064120
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002500-0x0000000180002510
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass3_0 // TypeDefIndex: 12739
	{
		// Fields
		public Action<RequestLobbyJoinSuccessMessage> onSuccess; // 0x10
		public Action<RequestLobbyJoinFailedMessage> onFailed; // 0x18

		// Constructors
		public <>c__DisplayClass3_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <RequestLobbyJoin>b__0(RequestLobbyJoinSuccessMessage s); // 0x0000000180C5D740-0x0000000180C5D790
		internal void <RequestLobbyJoin>b__1(RequestLobbyJoinFailedMessage f); // 0x0000000180C5D790-0x0000000180C5D7E0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestLobbyJoin>d__3 : IAsyncStateMachine // TypeDefIndex: 12740
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
		private void MoveNext(); // 0x0000000180064120-0x0000000180064130
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002500-0x0000000180002510
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestLobbyLeave>d__4 : IAsyncStateMachine // TypeDefIndex: 12741
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public LobbyManager.ELobbyType inType; // 0x20
		public Action<RequestLobbyLeaveSuccessMessage> onSuccess; // 0x28
		public Action<RequestLobbyLeaveFailedMessage> onFailed; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x0000000180064130-0x0000000180064140
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002500-0x0000000180002510
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass5_0 // TypeDefIndex: 12742
	{
		// Fields
		public Action<RequestLobbyLeaveSuccessMessage> onSuccess; // 0x10
		public Action<RequestLobbyLeaveFailedMessage> onFailed; // 0x18

		// Constructors
		public <>c__DisplayClass5_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <RequestLobbyLeave>b__0(RequestLobbyLeaveSuccessMessage s); // 0x0000000180C5D7E0-0x0000000180C5D830
		internal void <RequestLobbyLeave>b__1(RequestLobbyLeaveFailedMessage f); // 0x0000000180C5D830-0x0000000180C5D880
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestLobbyLeave>d__5 : IAsyncStateMachine // TypeDefIndex: 12743
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public Action<RequestLobbyLeaveSuccessMessage> onSuccess; // 0x20
		public Action<RequestLobbyLeaveFailedMessage> onFailed; // 0x28
		public string inType; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001800061E0-0x00000001800061F0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002500-0x0000000180002510
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestLobbyStart>d__6 : IAsyncStateMachine // TypeDefIndex: 12744
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public LobbyManager.ELobbyType inType; // 0x20
		public Action<RequestLobbyStartSuccessMessage> onSuccess; // 0x28
		public Action<RequestLobbyStartFailedMessage> onFailed; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001800061F0-0x0000000180006200
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002500-0x0000000180002510
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass7_0 // TypeDefIndex: 12745
	{
		// Fields
		public Action<RequestLobbyStartSuccessMessage> onSuccess; // 0x10
		public Action<RequestLobbyStartFailedMessage> onFailed; // 0x18

		// Constructors
		public <>c__DisplayClass7_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <RequestLobbyStart>b__0(RequestLobbyStartSuccessMessage s); // 0x0000000180C5D880-0x0000000180C5D8D0
		internal void <RequestLobbyStart>b__1(RequestLobbyStartFailedMessage f); // 0x0000000180C5D8D0-0x0000000180C5D920
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestLobbyStart>d__7 : IAsyncStateMachine // TypeDefIndex: 12746
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public Action<RequestLobbyStartSuccessMessage> onSuccess; // 0x20
		public Action<RequestLobbyStartFailedMessage> onFailed; // 0x28
		public string inType; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x0000000180006200-0x0000000180006210
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002500-0x0000000180002510
	}

	// Methods
	[AsyncStateMachine] // 0x0000000180212F40-0x0000000180212F90
	internal static Task RequestLobbyCreate(LobbyManager.ELobbyType inType, string inAssocDefID, Action<RequestLobbyJoinSuccessMessage> onSuccess = null, Action<RequestLobbyCreateFailedMessage> onFailed = null); // 0x0000000180C59980-0x0000000180C59A90
	[AsyncStateMachine] // 0x0000000180213200-0x0000000180213270
	[MessageSender] // 0x0000000180213200-0x0000000180213270
	private static Task RequestLobbyCreate(string inType, string inAssocDefID, Action<RequestLobbyJoinSuccessMessage> onSuccess = null, Action<RequestLobbyCreateFailedMessage> onFailed = null); // 0x0000000180C59A90-0x0000000180C59BA0
	[AsyncStateMachine] // 0x0000000180213600-0x0000000180213650
	internal static Task RequestLobbyJoin(LobbyManager.ELobbyType inType, string inHostUUID, Action<RequestLobbyJoinSuccessMessage> onSuccess = null, Action<RequestLobbyJoinFailedMessage> onFailed = null); // 0x0000000180C59BA0-0x0000000180C59CB0
	[AsyncStateMachine] // 0x0000000180213960-0x00000001802139D0
	[MessageSender] // 0x0000000180213960-0x00000001802139D0
	private static Task RequestLobbyJoin(string inType, string inHostUUID, Action<RequestLobbyJoinSuccessMessage> onSuccess = null, Action<RequestLobbyJoinFailedMessage> onFailed = null); // 0x0000000180C59CB0-0x0000000180C59DC0
	[AsyncStateMachine] // 0x0000000180213C90-0x0000000180213CE0
	internal static Task RequestLobbyLeave(LobbyManager.ELobbyType inType, Action<RequestLobbyLeaveSuccessMessage> onSuccess = null, Action<RequestLobbyLeaveFailedMessage> onFailed = null); // 0x0000000180C59EC0-0x0000000180C59FC0
	[AsyncStateMachine] // 0x0000000180214020-0x0000000180214090
	[MessageSender] // 0x0000000180214020-0x0000000180214090
	private static Task RequestLobbyLeave(string inType, Action<RequestLobbyLeaveSuccessMessage> onSuccess = null, Action<RequestLobbyLeaveFailedMessage> onFailed = null); // 0x0000000180C59DC0-0x0000000180C59EC0
	[AsyncStateMachine] // 0x00000001802142E0-0x0000000180214330
	internal static Task RequestLobbyStart(LobbyManager.ELobbyType inType, Action<RequestLobbyStartSuccessMessage> onSuccess = null, Action<RequestLobbyStartFailedMessage> onFailed = null); // 0x0000000180C5A0C0-0x0000000180C5A270
	[AsyncStateMachine] // 0x0000000180214530-0x00000001802145A0
	[MessageSender] // 0x0000000180214530-0x00000001802145A0
	private static Task RequestLobbyStart(string inType, Action<RequestLobbyStartSuccessMessage> onSuccess = null, Action<RequestLobbyStartFailedMessage> onFailed = null); // 0x0000000180C59FC0-0x0000000180C5A0C0
	[MessageRoute] // 0x0000000180214990-0x00000001802149B0
	private static void HandleLobbyJoin(ReceivedLobbyJoinMessage message); // 0x00000001803774A0-0x00000001803774B0
}

