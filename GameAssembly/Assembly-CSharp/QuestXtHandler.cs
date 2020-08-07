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
public static class QuestXtHandler // TypeDefIndex: 12754
{
	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestQuestOpen>d__0 : IAsyncStateMachine // TypeDefIndex: 12755
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public QuestDefComponent inQuestDef; // 0x20
		public Action<RequestQuestOpenSuccessMessage> onSuccess; // 0x28
		public Action<RequestQuestGenericFailedMessage> onFailed; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x000000018000A2A0-0x000000018000A2B0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002500-0x0000000180002510
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 12756
	{
		// Fields
		public Action<RequestQuestOpenSuccessMessage> onSuccess; // 0x10
		public Action<RequestQuestGenericFailedMessage> onFailed; // 0x18

		// Constructors
		public <>c__DisplayClass1_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <RequestQuestOpen>b__0(RequestQuestOpenSuccessMessage s); // 0x000000018065F230-0x000000018065F280
		internal void <RequestQuestOpen>b__1(RequestQuestGenericFailedMessage f); // 0x000000018065F280-0x000000018065F2D0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestQuestOpen>d__1 : IAsyncStateMachine // TypeDefIndex: 12757
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public Action<RequestQuestOpenSuccessMessage> onSuccess; // 0x20
		public Action<RequestQuestGenericFailedMessage> onFailed; // 0x28
		public string inQuestDefID; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x000000018000A2B0-0x000000018000A2C0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002500-0x0000000180002510
	}

	// Methods
	[AsyncStateMachine] // 0x000000018021AF30-0x000000018021AF80
	internal static Task RequestQuestOpen(QuestDefComponent inQuestDef, Action<RequestQuestOpenSuccessMessage> onSuccess = null, Action<RequestQuestGenericFailedMessage> onFailed = null); // 0x0000000180655390-0x0000000180655490
	[AsyncStateMachine] // 0x000000018021B210-0x000000018021B280
	[MessageSender] // 0x000000018021B210-0x000000018021B280
	private static Task RequestQuestOpen(string inQuestDefID, Action<RequestQuestOpenSuccessMessage> onSuccess = null, Action<RequestQuestGenericFailedMessage> onFailed = null); // 0x0000000180655490-0x0000000180655590
	internal static void RequestResetSocialExpanseCompletion(string inSocialExpanseDefIdToReset); // 0x0000000180655590-0x0000000180655650
	[MessageSender] // 0x000000018021B710-0x000000018021B730
	private static void SendRequestResetSocialExpanseCompletion(string inSocialExpanseDefIdToReset); // 0x0000000180655590-0x0000000180655650
	[MessageRoute] // 0x000000018021B9E0-0x000000018021BA00
	private static void HandleQuestCommand(RecievedQuestCommandMessage message); // 0x00000001803774A0-0x00000001803774B0
	[MessageRoute] // 0x000000018021BB50-0x000000018021BB70
	private static void HandleQuestCommandVT(RecievedQuestCommandMessage message); // 0x00000001803774A0-0x00000001803774B0
	[MessageRoute] // 0x000000018021BDF0-0x000000018021BE10
	private static void HandleQuestStart(RecievedQuestStartMessage message); // 0x00000001803774A0-0x00000001803774B0
	[MessageRoute] // 0x000000018021BFC0-0x000000018021BFE0
	private static void HandleQuestOpen(RecievedQuestOpenMessage message); // 0x00000001803774A0-0x00000001803774B0
}

