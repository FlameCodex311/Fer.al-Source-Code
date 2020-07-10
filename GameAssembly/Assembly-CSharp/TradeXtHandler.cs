/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Server;
using WW.Debug;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[MessageRouteHandler] // 0x00000001800B36B0-0x00000001800B36C0
public static class TradeXtHandler // TypeDefIndex: 11264
{
	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestDebugTradeRequest>d__0 : IAsyncStateMachine // TypeDefIndex: 11265
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		private TaskAwaiter <>u__1; // 0x20

		// Methods
		private void MoveNext(); // 0x00000001801F1A40-0x00000001801F1A50
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018000DC90-0x000000018000DCA0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <AddItemRequest>d__1 : IAsyncStateMachine // TypeDefIndex: 11266
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		private IEnumerator<Item> <>7__wrap1; // 0x20
		private TaskAwaiter<TradeAddRemoveItemResponse> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x00000001801F19C0-0x00000001801F19D0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018000DC90-0x000000018000DCA0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RemoveItemRequest>d__2 : IAsyncStateMachine // TypeDefIndex: 11267
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		private IEnumerator<Item> <>7__wrap1; // 0x20
		private TaskAwaiter<TradeAddRemoveItemResponse> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x00000001801F1A30-0x00000001801F1A40
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018000DC90-0x000000018000DCA0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass3_0 // TypeDefIndex: 11268
	{
		// Fields
		public Action<TradeInitiateResponse> onSuccess; // 0x10
		public Action<TradeFailResponse> onFailed; // 0x18

		// Constructors
		public <>c__DisplayClass3_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <RequestTradeRequest>b__0(TradeInitiateResponse s); // 0x0000000180FB24E0-0x0000000180FB2530
		internal void <RequestTradeRequest>b__1(TradeFailResponse f); // 0x0000000180FB2530-0x0000000180FB2580
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestTradeRequest>d__3 : IAsyncStateMachine // TypeDefIndex: 11269
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public Action<TradeInitiateResponse> onSuccess; // 0x20
		public Action<TradeFailResponse> onFailed; // 0x28
		public string userToTradeWithId; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F1A50-0x00000001801F1A60
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018000DC90-0x000000018000DCA0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <TradeAddRemoveItemRequest>d__7 : IAsyncStateMachine // TypeDefIndex: 11270
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<TradeAddRemoveItemResponse> <>t__builder; // 0x08
		public Item i; // 0x20
		public bool isAdding; // 0x28
		private TaskAwaiter<TradeAddRemoveItemResponse> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F1A70-0x00000001801F1A80
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F1A80-0x00000001801F1AD0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <TradeReadyRequest>d__8 : IAsyncStateMachine // TypeDefIndex: 11271
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<TradeReadyResponse> <>t__builder; // 0x08
		public bool inIsReady; // 0x20
		private TaskAwaiter<TradeReadyResponse> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x00000001801F1BA0-0x00000001801F1BB0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F1BB0-0x00000001801F1C00
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass9_0 // TypeDefIndex: 11272
	{
		// Fields
		public Action<TradeReadyAcceptResponse> onSuccess; // 0x10
		public Action<TradeFailResponse> onFailed; // 0x18

		// Constructors
		public <>c__DisplayClass9_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <TradeReadyAcceptRequest>b__0(TradeReadyAcceptResponse s); // 0x0000000180FB28B0-0x0000000180FB2900
		internal void <TradeReadyAcceptRequest>b__1(TradeFailResponse f); // 0x0000000180FB2900-0x0000000180FB2950
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <TradeReadyAcceptRequest>d__9 : IAsyncStateMachine // TypeDefIndex: 11273
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public Action<TradeReadyAcceptResponse> onSuccess; // 0x20
		public Action<TradeFailResponse> onFailed; // 0x28
		private TaskAwaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F1B30-0x00000001801F1B40
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018000DC90-0x000000018000DCA0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <TradeReadyRejectRequest>d__10 : IAsyncStateMachine // TypeDefIndex: 11274
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<TradeReadyRejectResponse> <>t__builder; // 0x08
		private TaskAwaiter<TradeReadyRejectResponse> <>u__1; // 0x20

		// Methods
		private void MoveNext(); // 0x00000001801F1B40-0x00000001801F1B50
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F1B50-0x00000001801F1BA0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <TradeListRequest>d__12 : IAsyncStateMachine // TypeDefIndex: 11275
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<TradeListResponse> <>t__builder; // 0x08
		public string inUserUUID; // 0x20
		private TaskAwaiter<TradeListResponse> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x00000001801F1AD0-0x00000001801F1AE0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F1AE0-0x00000001801F1B30
	}

	// Methods
	[AsyncStateMachine] // 0x000000018013E980-0x000000018013EA20
	[DebugButton] // 0x000000018013E980-0x000000018013EA20
	public static Task RequestDebugTradeRequest(); // 0x0000000180FA7AA0-0x0000000180FA7B60
	[AsyncStateMachine] // 0x000000018013ED50-0x000000018013EDF0
	[DebugButton] // 0x000000018013ED50-0x000000018013EDF0
	public static Task AddItemRequest(); // 0x0000000180FA7310-0x0000000180FA73D0
	[AsyncStateMachine] // 0x000000018013EE90-0x000000018013EF30
	[DebugButton] // 0x000000018013EE90-0x000000018013EF30
	public static Task RemoveItemRequest(); // 0x0000000180FA79E0-0x0000000180FA7AA0
	[AsyncStateMachine] // 0x000000018013F050-0x000000018013F0C0
	[MessageSender] // 0x000000018013F050-0x000000018013F0C0
	public static Task RequestTradeRequest(string userToTradeWithId, Action<TradeInitiateResponse> onSuccess = null, Action<TradeFailResponse> onFailed = null); // 0x0000000180FA7B60-0x0000000180FA7C60
	[MessageSender] // 0x000000018013F470-0x000000018013F490
	public static void TradeRequestAcceptRequest(); // 0x0000000180FA81C0-0x0000000180FA8220
	[MessageSender] // 0x000000018013F600-0x000000018013F620
	public static void TradeRequestRejectRequest(); // 0x0000000180FA8280-0x0000000180FA82E0
	[MessageSender] // 0x000000018013F7B0-0x000000018013F7D0
	public static void TradeRequestCancelRequest(); // 0x0000000180FA8220-0x0000000180FA8280
	[AsyncStateMachine] // 0x000000018013F840-0x000000018013F8B0
	[MessageSender] // 0x000000018013F840-0x000000018013F8B0
	public static Task<TradeAddRemoveItemResponse> TradeAddRemoveItemRequest(Item i, bool isAdding); // 0x0000000180FA7C60-0x0000000180FA7D50
	[AsyncStateMachine] // 0x000000018013FA50-0x000000018013FAC0
	[MessageSender] // 0x000000018013FA50-0x000000018013FAC0
	public static Task<TradeReadyResponse> TradeReadyRequest(bool inIsReady); // 0x0000000180FA80F0-0x0000000180FA81C0
	[AsyncStateMachine] // 0x000000018013FB10-0x000000018013FB80
	[MessageSender] // 0x000000018013FB10-0x000000018013FB80
	public static Task TradeReadyAcceptRequest(Action<TradeReadyAcceptResponse> onSuccess = null, Action<TradeFailResponse> onFailed = null); // 0x0000000180FA7F40-0x0000000180FA8020
	[AsyncStateMachine] // 0x000000018013FCF0-0x000000018013FD60
	[MessageSender] // 0x000000018013FCF0-0x000000018013FD60
	public static Task<TradeReadyRejectResponse> TradeReadyRejectRequest(); // 0x0000000180FA8020-0x0000000180FA80F0
	[MessageSender] // 0x000000018013FF00-0x000000018013FF20
	public static void TradeExitRequest(); // 0x0000000180FA7D50-0x0000000180FA7DB0
	[AsyncStateMachine] // 0x000000018013FFA0-0x0000000180140050
	[DebugButton] // 0x000000018013FFA0-0x0000000180140050
	[MessageSender] // 0x000000018013FFA0-0x0000000180140050
	public static Task<TradeListResponse> TradeListRequest(string inUserUUID); // 0x0000000180FA7DB0-0x0000000180FA7E90
	[MessageSender] // 0x00000001801402E0-0x0000000180140300
	public static void TradeListUpdateRequest(string inItemInvID, bool inIsInTradeList); // 0x0000000180FA7E90-0x0000000180FA7F40
	[MessageRoute] // 0x0000000180140490-0x00000001801404B0
	private static void HandleTradeRequest(TradeInitiateResponse response); // 0x0000000180FA7980-0x0000000180FA79E0
	[MessageRoute] // 0x0000000180140690-0x00000001801406B0
	private static void HandleTradeFailure(TradeFailResponse response); // 0x0000000180FA7550-0x0000000180FA75B0
	[MessageRoute] // 0x0000000180140830-0x0000000180140850
	private static void HandleTradeAcceptRequest(TradeInitiateAcceptResponse response); // 0x0000000180FA73D0-0x0000000180FA7430
	[MessageRoute] // 0x0000000180140910-0x0000000180140930
	private static void HandleTradeRejectRequest(TradeInitiateRejectResponse response); // 0x0000000180FA7920-0x0000000180FA7980
	[MessageRoute] // 0x00000001801409C0-0x00000001801409E0
	private static void HandleTradeCancelRequest(TradeInitiateCancelResponse response); // 0x0000000180FA7490-0x0000000180FA74F0
	[MessageRoute] // 0x0000000180140A90-0x0000000180140AB0
	private static void HandleTradeAddRemoveItemRequest(TradeAddRemoveItemResponse response); // 0x0000000180FA7430-0x0000000180FA7490
	[MessageRoute] // 0x0000000180140BC0-0x0000000180140BE0
	private static void HandleTradeReadyRequest(TradeReadyResponse response); // 0x0000000180FA78C0-0x0000000180FA7920
	[MessageRoute] // 0x0000000180140D50-0x0000000180140D70
	private static void HandleTradeReadyAcceptRequest(TradeReadyAcceptResponse response); // 0x0000000180FA7800-0x0000000180FA7860
	[MessageRoute] // 0x0000000180140ED0-0x0000000180140EF0
	private static void HandleTradeReadyRejectRequest(TradeReadyRejectResponse response); // 0x0000000180FA7860-0x0000000180FA78C0
	[MessageRoute] // 0x0000000180141000-0x0000000180141020
	private static void HandleTradeExitRequest(TradeExitResponse response); // 0x0000000180FA74F0-0x0000000180FA7550
	[MessageRoute] // 0x00000001801411C0-0x00000001801411E0
	private static void HandleTradeListRequest(TradeListResponse response); // 0x0000000180FA75B0-0x0000000180FA7710
	[MessageRoute] // 0x0000000180142530-0x0000000180142550
	private static void HandleTradeListUpdateRequest(TradeListUpdateResponse response); // 0x0000000180FA7710-0x0000000180FA7800
}

