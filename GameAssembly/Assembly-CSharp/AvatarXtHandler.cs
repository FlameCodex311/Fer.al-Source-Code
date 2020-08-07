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
public static class AvatarXtHandler // TypeDefIndex: 12689
{
	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestAvatarLookGet>d__0 : IAsyncStateMachine // TypeDefIndex: 12690
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<AvatarLookGetResponse> <>t__builder; // 0x08
		public string requestedUUID; // 0x20
		private TaskAwaiter<AvatarLookGetResponse> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x000000018031D0D0-0x000000018031D0E0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018031D0E0-0x000000018031D130
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestAvatarLookSwitch>d__1 : IAsyncStateMachine // TypeDefIndex: 12691
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<AvatarLookSwitchResponse> <>t__builder; // 0x08
		public string itemId; // 0x20
		private TaskAwaiter<AvatarLookSwitchResponse> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x000000018031D130-0x000000018031D140
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018031D140-0x000000018031D190
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestAvatarLookCustomize>d__2 : IAsyncStateMachine // TypeDefIndex: 12692
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<AvatarLookCustomizeResponse> <>t__builder; // 0x08
		public AvatarLookItemComponent inLook; // 0x20
		private TaskAwaiter<AvatarLookCustomizeResponse> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x000000018031D070-0x000000018031D080
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018031D080-0x000000018031D0D0
	}

	// Methods
	[AsyncStateMachine] // 0x00000001801FECE0-0x00000001801FED50
	[MessageSender] // 0x00000001801FECE0-0x00000001801FED50
	public static Task<AvatarLookGetResponse> RequestAvatarLookGet(string requestedUUID); // 0x0000000182158550-0x0000000182158630
	[AsyncStateMachine] // 0x00000001801FF020-0x00000001801FF090
	[MessageSender] // 0x00000001801FF020-0x00000001801FF090
	public static Task<AvatarLookSwitchResponse> RequestAvatarLookSwitch(string itemId); // 0x0000000182158630-0x0000000182158710
	[AsyncStateMachine] // 0x00000001801FF290-0x00000001801FF300
	[MessageSender] // 0x00000001801FF290-0x00000001801FF300
	public static Task<AvatarLookCustomizeResponse> RequestAvatarLookCustomize(AvatarLookItemComponent inLook); // 0x0000000182158470-0x0000000182158550
	[MessageSender] // 0x00000001801FF6A0-0x00000001801FF6C0
	public static void RequestAvatarAction(AvatarActionDefComponent inAction); // 0x00000001821583A0-0x0000000182158470
	[MessageRoute] // 0x00000001801FF7B0-0x00000001801FF7D0
	private static void HandleAvatarLookSwitch(AvatarLookSwitchResponse response); // 0x0000000182158240-0x00000001821583A0
}

