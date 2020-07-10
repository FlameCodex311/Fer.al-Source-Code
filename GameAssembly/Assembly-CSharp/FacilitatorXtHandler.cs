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
public static class FacilitatorXtHandler // TypeDefIndex: 11167
{
	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestReportUser>d__0 : IAsyncStateMachine // TypeDefIndex: 11168
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<FacilitatorReportUserMessage> <>t__builder; // 0x08
		public string reportedUserId; // 0x20
		public UI_Window_ReportPlayer.ReportCategory reportCategory; // 0x28
		public string reasonText; // 0x30
		private TaskAwaiter<FacilitatorReportUserMessage> <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001802296E0-0x00000001802296F0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001802296F0-0x00000001802297B0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestNotificationUpdate>d__1 : IAsyncStateMachine // TypeDefIndex: 11169
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<FacilitatorSetBusyMessage> <>t__builder; // 0x08
		public NotificationStatus notificationStatus; // 0x20
		private TaskAwaiter<FacilitatorSetBusyMessage> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x0000000180229680-0x0000000180229690
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180229690-0x00000001802296E0
	}

	// Methods
	[AsyncStateMachine] // 0x000000018011D4E0-0x000000018011D550
	[MessageSender] // 0x000000018011D4E0-0x000000018011D550
	public static Task<FacilitatorReportUserMessage> RequestReportUser(string reportedUserId, UI_Window_ReportPlayer.ReportCategory reportCategory, string reasonText); // 0x0000000181490280-0x0000000181490380
	[AsyncStateMachine] // 0x000000018011D6E0-0x000000018011D750
	[MessageSender] // 0x000000018011D6E0-0x000000018011D750
	public static Task<FacilitatorSetBusyMessage> RequestNotificationUpdate(NotificationStatus notificationStatus); // 0x00000001814901B0-0x0000000181490280
}

