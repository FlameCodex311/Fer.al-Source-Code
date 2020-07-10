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
public static class AvatarXtHandler // TypeDefIndex: 11163
{
	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestAvatarLookGet>d__0 : IAsyncStateMachine // TypeDefIndex: 11164
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<AvatarLookGetResponse> <>t__builder; // 0x08
		public string requestedUUID; // 0x20
		private TaskAwaiter<AvatarLookGetResponse> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x00000001801F80B0-0x00000001801F80C0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F80C0-0x00000001801F8110
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestAvatarLookSwitch>d__1 : IAsyncStateMachine // TypeDefIndex: 11165
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<AvatarLookSwitchResponse> <>t__builder; // 0x08
		public string itemId; // 0x20
		private TaskAwaiter<AvatarLookSwitchResponse> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x00000001801F8110-0x00000001801F8120
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F8120-0x00000001801F8170
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestAvatarLookCustomize>d__2 : IAsyncStateMachine // TypeDefIndex: 11166
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<AvatarLookCustomizeResponse> <>t__builder; // 0x08
		public AvatarLookItemComponent inLook; // 0x20
		private TaskAwaiter<AvatarLookCustomizeResponse> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x00000001801F8050-0x00000001801F8060
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F8060-0x00000001801F80B0
	}

	// Methods
	[AsyncStateMachine] // 0x000000018011B2B0-0x000000018011B320
	[MessageSender] // 0x000000018011B2B0-0x000000018011B320
	public static Task<AvatarLookGetResponse> RequestAvatarLookGet(string requestedUUID); // 0x000000018103F540-0x000000018103F620
	[AsyncStateMachine] // 0x000000018011B4A0-0x000000018011B510
	[MessageSender] // 0x000000018011B4A0-0x000000018011B510
	public static Task<AvatarLookSwitchResponse> RequestAvatarLookSwitch(string itemId); // 0x000000018103F620-0x000000018103F700
	[AsyncStateMachine] // 0x000000018011B5A0-0x000000018011B610
	[MessageSender] // 0x000000018011B5A0-0x000000018011B610
	public static Task<AvatarLookCustomizeResponse> RequestAvatarLookCustomize(AvatarLookItemComponent inLook); // 0x000000018103F460-0x000000018103F540
	[MessageSender] // 0x000000018011B860-0x000000018011B880
	public static void RequestAvatarAction(AvatarActionDefComponent inAction); // 0x000000018103F390-0x000000018103F460
	[MessageRoute] // 0x000000018011B950-0x000000018011B970
	private static void HandleAvatarLookSwitch(AvatarLookSwitchResponse response); // 0x000000018103F220-0x000000018103F390
}

