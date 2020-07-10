/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Async;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class TradeManager : SingletonManagerBase<TradeManager> // TypeDefIndex: 10784
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Trade _currentTrade; // 0x60

	// Properties
	public Trade CurrentTrade { get; } // 0x0000000180369B40-0x0000000180369B50 

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 10785
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<TradeFailResponse> <>9__5_1; // 0x08

		// Constructors
		static <>c(); // 0x0000000180FB2950-0x0000000180FB29B0
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <InviteUserToTrade>b__5_1(TradeFailResponse inFailureMessage); // 0x0000000180FB22B0-0x0000000180FB2340
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <InviteUserToTrade>d__5 : IAsyncStateMachine // TypeDefIndex: 10786
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public string inTargetUserUUID; // 0x28
		public TradeManager <>4__this; // 0x30
		private UniTask<UserInfo> <>u__1; // 0x38
		private TaskAwaiter <>u__2; // 0x48

		// Methods
		private void MoveNext(); // 0x00000001801F19E0-0x00000001801F19F0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass9_0 // TypeDefIndex: 10787
	{
		// Fields
		public Item inItem; // 0x10

		// Constructors
		public <>c__DisplayClass9_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <AddItemToTrade>b__0(Item item); // 0x0000000180FB2340-0x0000000180FB2380
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <AddItemToTrade>d__9 : IAsyncStateMachine // TypeDefIndex: 10788
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
		private void MoveNext(); // 0x00000001801F19D0-0x00000001801F19E0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass10_0 // TypeDefIndex: 10789
	{
		// Fields
		public Item inItem; // 0x10

		// Constructors
		public <>c__DisplayClass10_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <RemoveItemFromTrade>b__0(Item item); // 0x0000000180FB2340-0x0000000180FB2380
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RemoveItemFromTrade>d__10 : IAsyncStateMachine // TypeDefIndex: 10790
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public Item inItem; // 0x28
		public TradeManager <>4__this; // 0x30
		private Item <itemToRemove>5__2; // 0x38
		private TaskAwaiter<TradeAddRemoveItemResponse> <>u__1; // 0x40

		// Methods
		private void MoveNext(); // 0x00000001801F1A20-0x00000001801F1A30
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <SetReadyState>d__11 : IAsyncStateMachine // TypeDefIndex: 10791
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public TradeManager <>4__this; // 0x28
		public bool inIsReady; // 0x30
		private TaskAwaiter<TradeReadyResponse> <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F1A60-0x00000001801F1A70
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <AcceptTrade>d__12 : IAsyncStateMachine // TypeDefIndex: 10792
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public TradeManager <>4__this; // 0x28
		private TaskAwaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F19B0-0x00000001801F19C0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RejectTrade>d__13 : IAsyncStateMachine // TypeDefIndex: 10793
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public TradeManager <>4__this; // 0x28
		private TaskAwaiter<TradeReadyRejectResponse> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F1A10-0x00000001801F1A20
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <OnTradeRequestInitiated>d__16 : IAsyncStateMachine // TypeDefIndex: 10794
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public TradeInitiateResponse inMessage; // 0x28
		public TradeManager <>4__this; // 0x30
		private UniTask<UserInfo> <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F1A00-0x00000001801F1A10
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass21_0 // TypeDefIndex: 10795
	{
		// Fields
		public TradeAddRemoveItemResponse inMessage; // 0x10

		// Constructors
		public <>c__DisplayClass21_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <OnTradeAddRemoveItem>b__0(Item item); // 0x0000000180FB2380-0x0000000180FB23D0
		internal bool <OnTradeAddRemoveItem>b__1(Item item); // 0x0000000180FB23D0-0x0000000180FB2430
	}

	// Constructors
	public TradeManager(); // 0x0000000180FA7130-0x0000000180FA7170

	// Methods
	public override bool HasFinishCoroutine(); // 0x00000001803C29F0-0x00000001803C2A00
	public override IEnumerator FinishCoroutine(); // 0x0000000180FA5140-0x0000000180FA5450
	[AsyncStateMachine] // 0x00000001800D9FD0-0x00000001800DA020
	public void InviteUserToTrade(string inTargetUserUUID); // 0x0000000180FA5450-0x0000000180FA5510
	public void CancelTradeRequest(); // 0x0000000180FA4FF0-0x0000000180FA5060
	public void AcceptTradeRequest(); // 0x0000000180FA4D80-0x0000000180FA4E70
	public void RejectTradeRequest(); // 0x0000000180FA6C80-0x0000000180FA6CF0
	[AsyncStateMachine] // 0x00000001800DA2A0-0x00000001800DA2F0
	public void AddItemToTrade(Item inItem, int inQuantity); // 0x0000000180FA4F20-0x0000000180FA4FF0
	[AsyncStateMachine] // 0x00000001800DA470-0x00000001800DA4C0
	public void RemoveItemFromTrade(Item inItem); // 0x0000000180FA6DA0-0x0000000180FA6E60
	[AsyncStateMachine] // 0x00000001800DA880-0x00000001800DA8D0
	public void SetReadyState(bool inIsReady); // 0x0000000180FA6E60-0x0000000180FA6F20
	[AsyncStateMachine] // 0x00000001800DAA60-0x00000001800DAAB0
	public void AcceptTrade(); // 0x0000000180FA4E70-0x0000000180FA4F20
	[AsyncStateMachine] // 0x00000001800DAC20-0x00000001800DAC70
	public void RejectTrade(); // 0x0000000180FA6CF0-0x0000000180FA6DA0
	public void ExitTrade(); // 0x0000000180FA5060-0x0000000180FA5140
	private void OnTradeFailed(TradeFailResponse inMessage); // 0x0000000180FA5C00-0x0000000180FA6200
	[AsyncStateMachine] // 0x00000001800DAF00-0x00000001800DAF50
	private void OnTradeRequestInitiated(TradeInitiateResponse inMessage); // 0x0000000180FA6A40-0x0000000180FA6B00
	private void OnTradeRequestCancelled(TradeInitiateCancelResponse inMessage); // 0x0000000180FA68C0-0x0000000180FA6A40
	private void OnTradeRequestRejected(TradeInitiateRejectResponse inMessage); // 0x0000000180FA6B00-0x0000000180FA6C80
	private void OnTradeRequestAccepted(TradeInitiateAcceptResponse inMessage); // 0x0000000180FA6830-0x0000000180FA68C0
	private void OnTradeReady(TradeReadyResponse inMessage); // 0x0000000180FA6650-0x0000000180FA6830
	private void OnTradeAddRemoveItem(TradeAddRemoveItemResponse inMessage); // 0x0000000180FA55C0-0x0000000180FA5A90
	private void UnreadyUsers(); // 0x0000000180FA6FA0-0x0000000180FA7130
	private void OnTradeReadyAccept(TradeReadyAcceptResponse inMessage); // 0x0000000180FA6200-0x0000000180FA6430
	private void OnTradeReadyReject(TradeReadyRejectResponse inMessage); // 0x0000000180FA6430-0x0000000180FA6650
	private void OnTradeExited(TradeExitResponse inMessage); // 0x0000000180FA5A90-0x0000000180FA5C00
	private void OnChatConversationJoined(ChatConversationCreateResponse inMessage); // 0x0000000180FA5510-0x0000000180FA55C0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <InviteUserToTrade>b__5_0(TradeInitiateResponse inSuccessMessage); // 0x0000000180FA6F20-0x0000000180FA6FA0
}

