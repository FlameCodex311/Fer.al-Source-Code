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
public static class FacilitatorXtHandler // TypeDefIndex: 12693
{
	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestReportUser>d__0 : IAsyncStateMachine // TypeDefIndex: 12694
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<FacilitatorReportUserMessage> <>t__builder; // 0x08
		public string reportedUserId; // 0x20
		public UI_Window_ReportPlayer.ReportCategory reportCategory; // 0x28
		public string reasonText; // 0x30
		private TaskAwaiter<FacilitatorReportUserMessage> <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x000000018001C400-0x000000018001C410
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018001C410-0x000000018001C460
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestNotificationUpdate>d__1 : IAsyncStateMachine // TypeDefIndex: 12695
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<FacilitatorSetBusyMessage> <>t__builder; // 0x08
		public NotificationStatus notificationStatus; // 0x20
		private TaskAwaiter<FacilitatorSetBusyMessage> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x000000018001C3A0-0x000000018001C3B0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018001C3B0-0x000000018001C400
	}

	// Methods
	[AsyncStateMachine] // 0x0000000180200040-0x00000001802000B0
	[MessageSender] // 0x0000000180200040-0x00000001802000B0
	public static Task<FacilitatorReportUserMessage> RequestReportUser(string reportedUserId, UI_Window_ReportPlayer.ReportCategory reportCategory, string reasonText); // 0x0000000180867C20-0x0000000180867D20
	[AsyncStateMachine] // 0x0000000180200410-0x0000000180200480
	[MessageSender] // 0x0000000180200410-0x0000000180200480
	public static Task<FacilitatorSetBusyMessage> RequestNotificationUpdate(NotificationStatus notificationStatus); // 0x0000000180867B50-0x0000000180867C20
}

