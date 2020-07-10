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
public static class QuestXtHandler // TypeDefIndex: 11228
{
	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestQuestOpen>d__0 : IAsyncStateMachine // TypeDefIndex: 11229
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public QuestDefComponent inQuestDef; // 0x20
		public Action<RequestQuestOpenSuccessMessage> onSuccess; // 0x28
		public Action<RequestQuestGenericFailedMessage> onFailed; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F74B0-0x00000001801F74C0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018000DC90-0x000000018000DCA0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 11230
	{
		// Fields
		public Action<RequestQuestOpenSuccessMessage> onSuccess; // 0x10
		public Action<RequestQuestGenericFailedMessage> onFailed; // 0x18

		// Constructors
		public <>c__DisplayClass1_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <RequestQuestOpen>b__0(RequestQuestOpenSuccessMessage s); // 0x000000018101B710-0x000000018101B760
		internal void <RequestQuestOpen>b__1(RequestQuestGenericFailedMessage f); // 0x000000018101B760-0x000000018101B7B0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestQuestOpen>d__1 : IAsyncStateMachine // TypeDefIndex: 11231
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public Action<RequestQuestOpenSuccessMessage> onSuccess; // 0x20
		public Action<RequestQuestGenericFailedMessage> onFailed; // 0x28
		public string inQuestDefID; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F74C0-0x00000001801F74D0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018000DC90-0x000000018000DCA0
	}

	// Methods
	[AsyncStateMachine] // 0x0000000180133820-0x0000000180133870
	internal static Task RequestQuestOpen(QuestDefComponent inQuestDef, Action<RequestQuestOpenSuccessMessage> onSuccess = null, Action<RequestQuestGenericFailedMessage> onFailed = null); // 0x0000000181010380-0x0000000181010480
	[AsyncStateMachine] // 0x0000000180133A50-0x0000000180133AC0
	[MessageSender] // 0x0000000180133A50-0x0000000180133AC0
	private static Task RequestQuestOpen(string inQuestDefID, Action<RequestQuestOpenSuccessMessage> onSuccess = null, Action<RequestQuestGenericFailedMessage> onFailed = null); // 0x0000000181010480-0x0000000181010580
	internal static void RequestResetSocialExpanseCompletion(string inSocialExpanseDefIdToReset); // 0x0000000181010580-0x0000000181010640
	[MessageSender] // 0x0000000180133D30-0x0000000180133D50
	private static void SendRequestResetSocialExpanseCompletion(string inSocialExpanseDefIdToReset); // 0x0000000181010580-0x0000000181010640
	[MessageRoute] // 0x0000000180133E50-0x0000000180133E70
	private static void HandleQuestCommand(RecievedQuestCommandMessage message); // 0x00000001803581E0-0x00000001803581F0
	[MessageRoute] // 0x0000000180133F60-0x0000000180133F80
	private static void HandleQuestCommandVT(RecievedQuestCommandMessage message); // 0x00000001803581E0-0x00000001803581F0
	[MessageRoute] // 0x0000000180134090-0x00000001801340B0
	private static void HandleQuestStart(RecievedQuestStartMessage message); // 0x00000001803581E0-0x00000001803581F0
	[MessageRoute] // 0x0000000180134170-0x0000000180134190
	private static void HandleQuestOpen(RecievedQuestOpenMessage message); // 0x00000001803581E0-0x00000001803581F0
}

