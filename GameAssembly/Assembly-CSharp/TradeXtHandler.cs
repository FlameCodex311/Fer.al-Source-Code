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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[MessageRouteHandler] // 0x00000001801CDAD0-0x00000001801CDAE0
public static class TradeXtHandler // TypeDefIndex: 12792
{
	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestDebugTradeRequest>d__0 : IAsyncStateMachine // TypeDefIndex: 12793
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		private TaskAwaiter <>u__1; // 0x20

		// Methods
		private void MoveNext(); // 0x00000001800062E0-0x00000001800062F0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002500-0x0000000180002510
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <AddItemRequest>d__1 : IAsyncStateMachine // TypeDefIndex: 12794
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		private IEnumerator<Item> <>7__wrap1; // 0x20
		private TaskAwaiter<TradeAddRemoveItemResponse> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x0000000180006260-0x0000000180006270
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002500-0x0000000180002510
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RemoveItemRequest>d__2 : IAsyncStateMachine // TypeDefIndex: 12795
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		private IEnumerator<Item> <>7__wrap1; // 0x20
		private TaskAwaiter<TradeAddRemoveItemResponse> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x00000001800062D0-0x00000001800062E0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002500-0x0000000180002510
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass3_0 // TypeDefIndex: 12796
	{
		// Fields
		public Action<TradeInitiateResponse> onSuccess; // 0x10
		public Action<TradeFailResponse> onFailed; // 0x18

		// Constructors
		public <>c__DisplayClass3_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <RequestTradeRequest>b__0(TradeInitiateResponse s); // 0x00000001805174C0-0x0000000180517510
		internal void <RequestTradeRequest>b__1(TradeFailResponse f); // 0x0000000180517510-0x0000000180517560
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestTradeRequest>d__3 : IAsyncStateMachine // TypeDefIndex: 12797
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public Action<TradeInitiateResponse> onSuccess; // 0x20
		public Action<TradeFailResponse> onFailed; // 0x28
		public string userToTradeWithId; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001800062F0-0x0000000180006300
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002500-0x0000000180002510
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <TradeAddRemoveItemRequest>d__7 : IAsyncStateMachine // TypeDefIndex: 12798
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<TradeAddRemoveItemResponse> <>t__builder; // 0x08
		public Item i; // 0x20
		public bool isAdding; // 0x28
		private TaskAwaiter<TradeAddRemoveItemResponse> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x0000000180006310-0x0000000180006320
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180006320-0x0000000180006370
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <TradeReadyRequest>d__8 : IAsyncStateMachine // TypeDefIndex: 12799
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<TradeReadyResponse> <>t__builder; // 0x08
		public bool inIsReady; // 0x20
		private TaskAwaiter<TradeReadyResponse> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x0000000180006440-0x0000000180006450
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180006450-0x00000001800064E0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass9_0 // TypeDefIndex: 12800
	{
		// Fields
		public Action<TradeReadyAcceptResponse> onSuccess; // 0x10
		public Action<TradeFailResponse> onFailed; // 0x18

		// Constructors
		public <>c__DisplayClass9_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <TradeReadyAcceptRequest>b__0(TradeReadyAcceptResponse s); // 0x0000000180517870-0x00000001805178C0
		internal void <TradeReadyAcceptRequest>b__1(TradeFailResponse f); // 0x00000001805178C0-0x0000000180517910
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <TradeReadyAcceptRequest>d__9 : IAsyncStateMachine // TypeDefIndex: 12801
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public Action<TradeReadyAcceptResponse> onSuccess; // 0x20
		public Action<TradeFailResponse> onFailed; // 0x28
		private TaskAwaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001800063D0-0x00000001800063E0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002500-0x0000000180002510
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <TradeReadyRejectRequest>d__10 : IAsyncStateMachine // TypeDefIndex: 12802
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<TradeReadyRejectResponse> <>t__builder; // 0x08
		private TaskAwaiter<TradeReadyRejectResponse> <>u__1; // 0x20

		// Methods
		private void MoveNext(); // 0x00000001800063E0-0x00000001800063F0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001800063F0-0x0000000180006440
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <TradeListRequest>d__12 : IAsyncStateMachine // TypeDefIndex: 12803
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<TradeListResponse> <>t__builder; // 0x08
		public string inUserUUID; // 0x20
		private TaskAwaiter<TradeListResponse> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x0000000180006370-0x0000000180006380
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180006380-0x00000001800063D0
	}

	// Methods
	[AsyncStateMachine] // 0x0000000180226B80-0x0000000180226C20
	[DebugButton] // 0x0000000180226B80-0x0000000180226C20
	public static Task RequestDebugTradeRequest(); // 0x000000018050CFB0-0x000000018050D070
	[AsyncStateMachine] // 0x0000000180226F10-0x0000000180226FB0
	[DebugButton] // 0x0000000180226F10-0x0000000180226FB0
	public static Task AddItemRequest(); // 0x000000018050C830-0x000000018050C8F0
	[AsyncStateMachine] // 0x0000000180227210-0x00000001802272B0
	[DebugButton] // 0x0000000180227210-0x00000001802272B0
	public static Task RemoveItemRequest(); // 0x000000018050CEF0-0x000000018050CFB0
	[AsyncStateMachine] // 0x0000000180228920-0x0000000180228990
	[MessageSender] // 0x0000000180228920-0x0000000180228990
	public static Task RequestTradeRequest(string userToTradeWithId, Action<TradeInitiateResponse> onSuccess = null, Action<TradeFailResponse> onFailed = null); // 0x000000018050D070-0x000000018050D170
	[MessageSender] // 0x0000000180228C30-0x0000000180228C50
	public static void TradeRequestAcceptRequest(); // 0x000000018050D6D0-0x000000018050D730
	[MessageSender] // 0x0000000180228E10-0x0000000180228E30
	public static void TradeRequestRejectRequest(); // 0x000000018050D790-0x000000018050D7F0
	[MessageSender] // 0x0000000180228FF0-0x0000000180229010
	public static void TradeRequestCancelRequest(); // 0x000000018050D730-0x000000018050D790
	[AsyncStateMachine] // 0x00000001802292A0-0x0000000180229310
	[MessageSender] // 0x00000001802292A0-0x0000000180229310
	public static Task<TradeAddRemoveItemResponse> TradeAddRemoveItemRequest(Item i, bool isAdding); // 0x000000018050D170-0x000000018050D260
	[AsyncStateMachine] // 0x0000000180229650-0x00000001802296C0
	[MessageSender] // 0x0000000180229650-0x00000001802296C0
	public static Task<TradeReadyResponse> TradeReadyRequest(bool inIsReady); // 0x000000018050D600-0x000000018050D6D0
	[AsyncStateMachine] // 0x00000001802299E0-0x0000000180229A50
	[MessageSender] // 0x00000001802299E0-0x0000000180229A50
	public static Task TradeReadyAcceptRequest(Action<TradeReadyAcceptResponse> onSuccess = null, Action<TradeFailResponse> onFailed = null); // 0x000000018050D450-0x000000018050D530
	[AsyncStateMachine] // 0x0000000180229F70-0x0000000180229FE0
	[MessageSender] // 0x0000000180229F70-0x0000000180229FE0
	public static Task<TradeReadyRejectResponse> TradeReadyRejectRequest(); // 0x000000018050D530-0x000000018050D600
	[MessageSender] // 0x000000018022A2D0-0x000000018022A2F0
	public static void TradeExitRequest(); // 0x000000018050D260-0x000000018050D2C0
	[AsyncStateMachine] // 0x000000018022A390-0x000000018022A440
	[DebugButton] // 0x000000018022A390-0x000000018022A440
	[MessageSender] // 0x000000018022A390-0x000000018022A440
	public static Task<TradeListResponse> TradeListRequest(string inUserUUID); // 0x000000018050D2C0-0x000000018050D3A0
	[MessageSender] // 0x000000018022A6F0-0x000000018022A710
	public static void TradeListUpdateRequest(string inItemInvID, bool inIsInTradeList); // 0x000000018050D3A0-0x000000018050D450
	[MessageRoute] // 0x000000018022A8C0-0x000000018022A8E0
	private static void HandleTradeRequest(TradeInitiateResponse response); // 0x000000018050CE90-0x000000018050CEF0
	[MessageRoute] // 0x000000018022AAB0-0x000000018022AAD0
	private static void HandleTradeFailure(TradeFailResponse response); // 0x000000018050CA70-0x000000018050CAD0
	[MessageRoute] // 0x000000018022AC50-0x000000018022AC70
	private static void HandleTradeAcceptRequest(TradeInitiateAcceptResponse response); // 0x000000018050C8F0-0x000000018050C950
	[MessageRoute] // 0x000000018022ADD0-0x000000018022ADF0
	private static void HandleTradeRejectRequest(TradeInitiateRejectResponse response); // 0x000000018050CE30-0x000000018050CE90
	[MessageRoute] // 0x000000018022AEE0-0x000000018022AF00
	private static void HandleTradeCancelRequest(TradeInitiateCancelResponse response); // 0x000000018050C9B0-0x000000018050CA10
	[MessageRoute] // 0x000000018022B000-0x000000018022B020
	private static void HandleTradeAddRemoveItemRequest(TradeAddRemoveItemResponse response); // 0x000000018050C950-0x000000018050C9B0
	[MessageRoute] // 0x000000018022B110-0x000000018022B130
	private static void HandleTradeReadyRequest(TradeReadyResponse response); // 0x000000018050CDD0-0x000000018050CE30
	[MessageRoute] // 0x000000018022B2A0-0x000000018022B2C0
	private static void HandleTradeReadyAcceptRequest(TradeReadyAcceptResponse response); // 0x000000018050CD10-0x000000018050CD70
	[MessageRoute] // 0x000000018022B3E0-0x000000018022B400
	private static void HandleTradeReadyRejectRequest(TradeReadyRejectResponse response); // 0x000000018050CD70-0x000000018050CDD0
	[MessageRoute] // 0x000000018022B560-0x000000018022B580
	private static void HandleTradeExitRequest(TradeExitResponse response); // 0x000000018050CA10-0x000000018050CA70
	[MessageRoute] // 0x000000018022B6B0-0x000000018022B6D0
	private static void HandleTradeListRequest(TradeListResponse response); // 0x000000018050CAD0-0x000000018050CC20
	[MessageRoute] // 0x000000018022B7A0-0x000000018022B7C0
	private static void HandleTradeListUpdateRequest(TradeListUpdateResponse response); // 0x000000018050CC20-0x000000018050CD10
}

