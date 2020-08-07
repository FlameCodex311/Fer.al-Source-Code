/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Server;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[MessageRouteHandler] // 0x00000001801CDAD0-0x00000001801CDAE0
public static class SanctuaryXtHandler // TypeDefIndex: 12765
{
	// Fields
	public static string sanctuaryJoinOwnerUUID; // 0x00

	// Nested types
	public class DenStateUpdateResponse : ServerMessage // TypeDefIndex: 12766
	{
		// Fields
		public readonly bool status; // 0x30
		public readonly string[] AddedItemIds; // 0x38
		public readonly string[] RemovedItemIds; // 0x40

		// Constructors
		public DenStateUpdateResponse(INetMessageReader data); // 0x00000001803F38E0-0x00000001803F3980
	}

	[RoutedMessage] // 0x00000001802214C0-0x00000001802214E0
	public class HandleSanctuaryUpgradeStart : ServerMessage // TypeDefIndex: 12767
	{
		// Fields
		public readonly bool status; // 0x30

		// Constructors
		public HandleSanctuaryUpgradeStart(INetMessageReader data); // 0x00000001803F45B0-0x00000001803F4620
	}

	[RoutedMessage] // 0x00000001802216B0-0x00000001802216D0
	public class HandleSanctuaryUpgradeComplete : ServerMessage // TypeDefIndex: 12768
	{
		// Fields
		public readonly bool status; // 0x30

		// Constructors
		public HandleSanctuaryUpgradeComplete(INetMessageReader data); // 0x00000001803F4540-0x00000001803F45B0
	}

	[RoutedMessage] // 0x0000000180221950-0x0000000180221970
	public class SanctuaryPurchaseResponse : ServerMessage // TypeDefIndex: 12769
	{
		// Fields
		public readonly bool Success; // 0x30

		// Constructors
		public SanctuaryPurchaseResponse(INetMessageReader data); // 0x00000001803F7750-0x00000001803F77C0
	}

	[RoutedMessage] // 0x0000000180221A40-0x0000000180221A60
	public class SanctuarySwitchResponse : ServerMessage // TypeDefIndex: 12770
	{
		// Fields
		public readonly bool Success; // 0x30

		// Constructors
		public SanctuarySwitchResponse(INetMessageReader data); // 0x00000001803F8420-0x00000001803F8510
	}

	[RoutedMessage] // 0x0000000180221B10-0x0000000180221B30
	public class SanctuaryLookSaveResponse : ServerMessage // TypeDefIndex: 12771
	{
		// Fields
		public readonly string ItemId; // 0x30

		// Properties
		public bool Success { get; } // 0x00000001803F73F0-0x00000001803F7410 

		// Constructors
		public SanctuaryLookSaveResponse(INetMessageReader data); // 0x00000001803F7410-0x00000001803F7480
	}

	[RoutedMessage] // 0x0000000180221C50-0x0000000180221C70
	public class SanctuaryLookLoadResponse : ServerMessage // TypeDefIndex: 12772
	{
		// Fields
		public readonly string ItemId; // 0x30

		// Properties
		public bool Success { get; } // 0x00000001803F73F0-0x00000001803F7410 

		// Constructors
		public SanctuaryLookLoadResponse(INetMessageReader data); // 0x00000001803F7380-0x00000001803F73F0
	}

	[MessageRouteHandler] // 0x00000001801CDAD0-0x00000001801CDAE0
	private static class DefaultHandlers // TypeDefIndex: 12773
	{
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestJoinMySanctuary>d__1 : IAsyncStateMachine // TypeDefIndex: 12774
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<bool> <>t__builder; // 0x08
		private TaskAwaiter<bool> <>u__1; // 0x20

		// Methods
		private void MoveNext(); // 0x0000000180002CD0-0x0000000180002CE0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002CE0-0x0000000180002D30
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass2_0 // TypeDefIndex: 12775
	{
		// Fields
		public bool result; // 0x10

		// Constructors
		public <>c__DisplayClass2_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <GoToSanctuary>b__0(RoomJoinSuccessMessage sucessMessage); // 0x00000001804059F0-0x0000000180405A00
		internal void <GoToSanctuary>b__1(RoomJoinFailedMessage failureMessage); // 0x0000000180405A00-0x0000000180405AE0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <GoToSanctuary>d__2 : IAsyncStateMachine // TypeDefIndex: 12776
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<bool> <>t__builder; // 0x08
		public string uuid; // 0x20
		private <>c__DisplayClass2_0 <>8__1; // 0x28
		private TaskAwaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x0000000180002A50-0x0000000180002A60
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002A60-0x0000000180002AB0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass3_0 // TypeDefIndex: 12777
	{
		// Fields
		public string ownerUUIDStr; // 0x10
		public Action<RoomJoinSuccessMessage> onSuccess; // 0x18
		public Action<RoomJoinFailedMessage> onFailed; // 0x20
		public Action<RoomJoinSuccessMessage> <>9__2; // 0x28
		public Action<RoomJoinFailedMessage> <>9__3; // 0x30

		// Nested types
		private struct <<RequestJoinSanctuary>b__0>d : IAsyncStateMachine // TypeDefIndex: 12778
		{
			// Fields
			public int <>1__state; // 0x00
			public AsyncTaskMethodBuilder <>t__builder; // 0x08
			public <>c__DisplayClass3_0 <>4__this; // 0x20
			private TaskAwaiter <>u__1; // 0x28

			// Methods
			private void MoveNext(); // 0x0000000180002F30-0x0000000180002F40
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002500-0x0000000180002510
		}

		// Constructors
		public <>c__DisplayClass3_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		[AsyncStateMachine] // 0x0000000180222A40-0x0000000180222A90
		internal Task <RequestJoinSanctuary>b__0(); // 0x0000000180405D10-0x0000000180405DE0
		internal void <RequestJoinSanctuary>b__2(RoomJoinSuccessMessage s); // 0x0000000180405DE0-0x0000000180405E30
		internal void <RequestJoinSanctuary>b__3(RoomJoinFailedMessage f); // 0x0000000180405E30-0x0000000180405E80
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestJoinSanctuary>d__3 : IAsyncStateMachine // TypeDefIndex: 12779
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public string ownerUUIDStr; // 0x20
		public Action<RoomJoinSuccessMessage> onSuccess; // 0x28
		public Action<RoomJoinFailedMessage> onFailed; // 0x30
		private <>c__DisplayClass3_0 <>8__1; // 0x38
		private TaskAwaiter<bool> <>u__1; // 0x40
		private TaskAwaiter <>u__2; // 0x48

		// Methods
		private void MoveNext(); // 0x0000000180002D30-0x0000000180002D40
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002500-0x0000000180002510
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestUpdateDenState>d__4 : IAsyncStateMachine // TypeDefIndex: 12780
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public UpdateItem[] itemsToUpdate; // 0x20
		public RemoveItem[] itemsToRemove; // 0x28
		public List<RoomData> roomData; // 0x30
		private TaskAwaiter<DenStateUpdateResponse> <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x0000000180002F20-0x0000000180002F30
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002500-0x0000000180002510
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass5_0 // TypeDefIndex: 12781
	{
		// Fields
		public Action<SanctuaryUpgradeStartSuccessMessage> onSuccess; // 0x10
		public Action<SanctuaryUpgradeStartFailedMessage> onFailed; // 0x18

		// Constructors
		public <>c__DisplayClass5_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <RequestSanctuaryUpgradeStart>b__0(SanctuaryUpgradeStartSuccessMessage s); // 0x0000000180405E80-0x0000000180405ED0
		internal void <RequestSanctuaryUpgradeStart>b__1(SanctuaryUpgradeStartFailedMessage f); // 0x0000000180405ED0-0x0000000180405F20
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass6_0 // TypeDefIndex: 12782
	{
		// Fields
		public Action<SanctuaryUpgradeCompleteSuccessMessage> onSuccess; // 0x10
		public Action<SanctuaryUpgradeCompleteFailedMessage> onFailed; // 0x18

		// Constructors
		public <>c__DisplayClass6_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <RequestSanctuaryUpgradeComplete>b__0(SanctuaryUpgradeCompleteSuccessMessage s); // 0x0000000180405F20-0x0000000180405F70
		internal void <RequestSanctuaryUpgradeComplete>b__1(SanctuaryUpgradeCompleteFailedMessage f); // 0x0000000180405F70-0x0000000180405FC0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestSanctuaryPurchase>d__7 : IAsyncStateMachine // TypeDefIndex: 12783
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<SanctuaryPurchaseResponse> <>t__builder; // 0x08
		public string purchaseableDefId; // 0x20
		private TaskAwaiter<SanctuaryPurchaseResponse> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x0000000180002E00-0x0000000180002E10
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002E10-0x0000000180002E60
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestSanctuarySwitch>d__8 : IAsyncStateMachine // TypeDefIndex: 12784
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<SanctuarySwitchResponse> <>t__builder; // 0x08
		public string lookId; // 0x20
		private TaskAwaiter<SanctuarySwitchResponse> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x0000000180002E60-0x0000000180002E70
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002E70-0x0000000180002EC0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestSanctuaryLookSave>d__9 : IAsyncStateMachine // TypeDefIndex: 12785
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<SanctuaryLookSaveResponse> <>t__builder; // 0x08
		public SanctuaryLookItemComponent inLook; // 0x20
		private TaskAwaiter<SanctuaryLookSaveResponse> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x0000000180002DA0-0x0000000180002DB0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002DB0-0x0000000180002E00
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestSanctuaryLookLoad>d__10 : IAsyncStateMachine // TypeDefIndex: 12786
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<SanctuaryLookLoadResponse> <>t__builder; // 0x08
		public string lookId; // 0x20
		private TaskAwaiter<SanctuaryLookLoadResponse> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x0000000180002D40-0x0000000180002D50
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002D50-0x0000000180002DA0
	}

	// Methods
	[AsyncStateMachine] // 0x000000018021F940-0x000000018021F990
	public static Task<bool> RequestJoinMySanctuary(); // 0x00000001803F94F0-0x00000001803F95C0
	[AsyncStateMachine] // 0x000000018021FCA0-0x000000018021FCF0
	public static Task<bool> GoToSanctuary(string uuid); // 0x00000001803F93B0-0x00000001803F9490
	[AsyncStateMachine] // 0x000000018021FEF0-0x000000018021FF60
	[MessageSender] // 0x000000018021FEF0-0x000000018021FF60
	public static Task RequestJoinSanctuary(string ownerUUIDStr, Action<RoomJoinSuccessMessage> onSuccess = null, Action<RoomJoinFailedMessage> onFailed = null); // 0x00000001803F95C0-0x00000001803F96C0
	[AsyncStateMachine] // 0x0000000180220310-0x0000000180220380
	[MessageSender] // 0x0000000180220310-0x0000000180220380
	public static Task RequestUpdateDenState(UpdateItem[] itemsToUpdate, RemoveItem[] itemsToRemove, List<RoomData> roomData); // 0x00000001803F9E40-0x00000001803F9F40
	public static void RequestSanctuaryUpgradeStart(int stage, int[] enlargedAreaIndexes, Action<SanctuaryUpgradeStartSuccessMessage> onSuccess = null, Action<SanctuaryUpgradeStartFailedMessage> onFailed = null); // 0x00000001803F9BD0-0x00000001803F9E40
	public static void RequestSanctuaryUpgradeComplete(string twiggleId, Action<SanctuaryUpgradeCompleteSuccessMessage> onSuccess = null, Action<SanctuaryUpgradeCompleteFailedMessage> onFailed = null); // 0x00000001803F9A40-0x00000001803F9BD0
	[AsyncStateMachine] // 0x0000000180220780-0x00000001802207D0
	public static Task<SanctuaryPurchaseResponse> RequestSanctuaryPurchase(string purchaseableDefId); // 0x00000001803F9880-0x00000001803F9960
	[AsyncStateMachine] // 0x0000000180220AA0-0x0000000180220AF0
	public static Task<SanctuarySwitchResponse> RequestSanctuarySwitch(string lookId); // 0x00000001803F9960-0x00000001803F9A40
	[AsyncStateMachine] // 0x0000000180220CA0-0x0000000180220CF0
	public static Task<SanctuaryLookSaveResponse> RequestSanctuaryLookSave(SanctuaryLookItemComponent inLook); // 0x00000001803F97A0-0x00000001803F9880
	[AsyncStateMachine] // 0x0000000180220F20-0x0000000180220F70
	public static Task<SanctuaryLookLoadResponse> RequestSanctuaryLookLoad(string lookId); // 0x00000001803F96C0-0x00000001803F97A0
	[MessageRoute] // 0x0000000180221270-0x0000000180221290
	private static void HandleSanctuaryStateUpdateRequest(DenStateUpdateResponse response); // 0x00000001803F9490-0x00000001803F94F0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	internal static void <RequestJoinSanctuary>g__handleEitherMessage|3_1(); // 0x00000001803774A0-0x00000001803774B0
}

