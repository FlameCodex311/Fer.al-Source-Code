/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Async;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class TradeManager : SingletonManagerBase<TradeManager> // TypeDefIndex: 12294
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Trade _currentTrade; // 0x60

	// Properties
	public Trade CurrentTrade { get; } // 0x0000000180418970-0x0000000180418980 

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 12295
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<TradeFailResponse> <>9__5_1; // 0x08

		// Constructors
		static <>c(); // 0x0000000180517910-0x0000000180517970
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <InviteUserToTrade>b__5_1(TradeFailResponse inFailureMessage); // 0x00000001805172B0-0x0000000180517340
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <InviteUserToTrade>d__5 : IAsyncStateMachine // TypeDefIndex: 12296
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public string inTargetUserUUID; // 0x28
		public TradeManager <>4__this; // 0x30
		private UniTask<UserInfo> <>u__1; // 0x38
		private TaskAwaiter <>u__2; // 0x48

		// Methods
		private void MoveNext(); // 0x0000000180006280-0x0000000180006290
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass9_0 // TypeDefIndex: 12297
	{
		// Fields
		public Item inItem; // 0x10

		// Constructors
		public <>c__DisplayClass9_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <AddItemToTrade>b__0(Item item); // 0x0000000180517340-0x0000000180517380
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <AddItemToTrade>d__9 : IAsyncStateMachine // TypeDefIndex: 12298
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public Item inItem; // 0x28
		public TradeManager <>4__this; // 0x30
		public int inQuantity; // 0x38
		private Item <clonedItem>5__2; // 0x40
		private TaskAwaiter<TradeAddRemoveItemResponse> <>u__1; // 0x48

		// Methods
		private void MoveNext(); // 0x0000000180006270-0x0000000180006280
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass10_0 // TypeDefIndex: 12299
	{
		// Fields
		public Item inItem; // 0x10

		// Constructors
		public <>c__DisplayClass10_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <RemoveItemFromTrade>b__0(Item item); // 0x0000000180517340-0x0000000180517380
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RemoveItemFromTrade>d__10 : IAsyncStateMachine // TypeDefIndex: 12300
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public Item inItem; // 0x28
		public TradeManager <>4__this; // 0x30
		private Item <itemToRemove>5__2; // 0x38
		private TaskAwaiter<TradeAddRemoveItemResponse> <>u__1; // 0x40

		// Methods
		private void MoveNext(); // 0x00000001800062C0-0x00000001800062D0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <SetReadyState>d__11 : IAsyncStateMachine // TypeDefIndex: 12301
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public TradeManager <>4__this; // 0x28
		public bool inIsReady; // 0x30
		private TaskAwaiter<TradeReadyResponse> <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x0000000180006300-0x0000000180006310
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <AcceptTrade>d__12 : IAsyncStateMachine // TypeDefIndex: 12302
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public TradeManager <>4__this; // 0x28
		private TaskAwaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x0000000180006250-0x0000000180006260
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RejectTrade>d__13 : IAsyncStateMachine // TypeDefIndex: 12303
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public TradeManager <>4__this; // 0x28
		private TaskAwaiter<TradeReadyRejectResponse> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001800062B0-0x00000001800062C0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <OnTradeRequestInitiated>d__16 : IAsyncStateMachine // TypeDefIndex: 12304
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public TradeInitiateResponse inMessage; // 0x28
		public TradeManager <>4__this; // 0x30
		private UniTask<UserInfo> <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001800062A0-0x00000001800062B0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass21_0 // TypeDefIndex: 12305
	{
		// Fields
		public TradeAddRemoveItemResponse inMessage; // 0x10

		// Constructors
		public <>c__DisplayClass21_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <OnTradeAddRemoveItem>b__0(Item item); // 0x0000000180517380-0x00000001805173D0
		internal bool <OnTradeAddRemoveItem>b__1(Item item); // 0x00000001805173D0-0x0000000180517420
	}

	// Constructors
	public TradeManager(); // 0x000000018050C610-0x000000018050C650

	// Methods
	public override bool HasFinishCoroutine(); // 0x0000000180380B60-0x0000000180380B70
	public override IEnumerator FinishCoroutine(); // 0x000000018050A530-0x000000018050A840
	[AsyncStateMachine] // 0x0000000180278030-0x0000000180278080
	public void InviteUserToTrade(string inTargetUserUUID); // 0x000000018050A840-0x000000018050A900
	public void CancelTradeRequest(); // 0x000000018050A3E0-0x000000018050A450
	public void AcceptTradeRequest(); // 0x000000018050A170-0x000000018050A260
	public void RejectTradeRequest(); // 0x000000018050C160-0x000000018050C1D0
	[AsyncStateMachine] // 0x0000000180278210-0x0000000180278260
	public void AddItemToTrade(Item inItem, int inQuantity); // 0x000000018050A310-0x000000018050A3E0
	[AsyncStateMachine] // 0x00000001802783F0-0x0000000180278440
	public void RemoveItemFromTrade(Item inItem); // 0x000000018050C280-0x000000018050C340
	[AsyncStateMachine] // 0x0000000180278660-0x00000001802786B0
	public void SetReadyState(bool inIsReady); // 0x000000018050C340-0x000000018050C400
	[AsyncStateMachine] // 0x0000000180278900-0x0000000180278950
	public void AcceptTrade(); // 0x000000018050A260-0x000000018050A310
	[AsyncStateMachine] // 0x0000000180278BE0-0x0000000180278C30
	public void RejectTrade(); // 0x000000018050C1D0-0x000000018050C280
	public void ExitTrade(); // 0x000000018050A450-0x000000018050A530
	private void OnTradeFailed(TradeFailResponse inMessage); // 0x000000018050AFC0-0x000000018050B710
	[AsyncStateMachine] // 0x0000000180278E30-0x0000000180278E80
	private void OnTradeRequestInitiated(TradeInitiateResponse inMessage); // 0x000000018050BF30-0x000000018050BFF0
	private void OnTradeRequestCancelled(TradeInitiateCancelResponse inMessage); // 0x000000018050BDB0-0x000000018050BF30
	private void OnTradeRequestRejected(TradeInitiateRejectResponse inMessage); // 0x000000018050BFF0-0x000000018050C160
	private void OnTradeRequestAccepted(TradeInitiateAcceptResponse inMessage); // 0x000000018050BD20-0x000000018050BDB0
	private void OnTradeReady(TradeReadyResponse inMessage); // 0x000000018050BB50-0x000000018050BD20
	private void OnTradeAddRemoveItem(TradeAddRemoveItemResponse inMessage); // 0x000000018050A9A0-0x000000018050AE50
	private void UnreadyUsers(); // 0x000000018050C480-0x000000018050C610
	private void OnTradeReadyAccept(TradeReadyAcceptResponse inMessage); // 0x000000018050B710-0x000000018050B930
	private void OnTradeReadyReject(TradeReadyRejectResponse inMessage); // 0x000000018050B930-0x000000018050BB50
	private void OnTradeExited(TradeExitResponse inMessage); // 0x000000018050AE50-0x000000018050AFC0
	private void OnChatConversationJoined(ChatConversationCreateResponse inMessage); // 0x000000018050A900-0x000000018050A9A0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <InviteUserToTrade>b__5_0(TradeInitiateResponse inSuccessMessage); // 0x000000018050C400-0x000000018050C480
}

