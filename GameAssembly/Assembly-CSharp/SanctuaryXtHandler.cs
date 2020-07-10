/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Server;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[MessageRouteHandler] // 0x00000001800B36B0-0x00000001800B36C0
public static class SanctuaryXtHandler // TypeDefIndex: 11239
{
	// Fields
	public static string sanctuaryJoinOwnerUUID; // 0x00

	// Nested types
	public class DenStateUpdateResponse : ServerMessage // TypeDefIndex: 11240
	{
		// Fields
		public readonly bool status; // 0x30
		public readonly string[] AddedItemIds; // 0x38
		public readonly string[] RemovedItemIds; // 0x40

		// Constructors
		public DenStateUpdateResponse(INetMessageReader data); // 0x00000001813616F0-0x0000000181361790
	}

	[RoutedMessage] // 0x0000000180139AE0-0x0000000180139B00
	public class HandleSanctuaryUpgradeStart : ServerMessage // TypeDefIndex: 11241
	{
		// Fields
		public readonly bool status; // 0x30

		// Constructors
		public HandleSanctuaryUpgradeStart(INetMessageReader data); // 0x00000001813618C0-0x0000000181361930
	}

	[RoutedMessage] // 0x0000000180139C80-0x0000000180139CA0
	public class HandleSanctuaryUpgradeComplete : ServerMessage // TypeDefIndex: 11242
	{
		// Fields
		public readonly bool status; // 0x30

		// Constructors
		public HandleSanctuaryUpgradeComplete(INetMessageReader data); // 0x0000000181361850-0x00000001813618C0
	}

	[RoutedMessage] // 0x0000000180139DA0-0x0000000180139DC0
	public class SanctuaryPurchaseResponse : ServerMessage // TypeDefIndex: 11243
	{
		// Fields
		public readonly bool Success; // 0x30

		// Constructors
		public SanctuaryPurchaseResponse(INetMessageReader data); // 0x000000018136EB60-0x000000018136EBD0
	}

	[RoutedMessage] // 0x0000000180139E90-0x0000000180139EB0
	public class SanctuarySwitchResponse : ServerMessage // TypeDefIndex: 11244
	{
		// Fields
		public readonly bool Success; // 0x30

		// Constructors
		public SanctuarySwitchResponse(INetMessageReader data); // 0x000000018136F700-0x000000018136F800
	}

	[RoutedMessage] // 0x0000000180139FB0-0x0000000180139FD0
	public class SanctuaryLookSaveResponse : ServerMessage // TypeDefIndex: 11245
	{
		// Fields
		public readonly string ItemId; // 0x30

		// Properties
		public bool Success { get; } // 0x000000018103EBA0-0x000000018103EBC0 

		// Constructors
		public SanctuaryLookSaveResponse(INetMessageReader data); // 0x0000000181363050-0x00000001813630C0
	}

	[RoutedMessage] // 0x000000018013A0F0-0x000000018013A110
	public class SanctuaryLookLoadResponse : ServerMessage // TypeDefIndex: 11246
	{
		// Fields
		public readonly string ItemId; // 0x30

		// Properties
		public bool Success { get; } // 0x000000018103EBA0-0x000000018103EBC0 

		// Constructors
		public SanctuaryLookLoadResponse(INetMessageReader data); // 0x0000000181362FE0-0x0000000181363050
	}

	[MessageRouteHandler] // 0x00000001800B36B0-0x00000001800B36C0
	private static class DefaultHandlers // TypeDefIndex: 11247
	{
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestJoinMySanctuary>d__1 : IAsyncStateMachine // TypeDefIndex: 11248
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		private TaskAwaiter <>u__1; // 0x20

		// Methods
		private void MoveNext(); // 0x0000000180213580-0x0000000180213590
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018000DC90-0x000000018000DCA0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass2_0 // TypeDefIndex: 11249
	{
		// Fields
		public bool result; // 0x10

		// Constructors
		public <>c__DisplayClass2_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <GoToSanctuary>b__0(RoomJoinSuccessMessage sucessMessage); // 0x0000000180976970-0x0000000180976980
		internal void <GoToSanctuary>b__1(RoomJoinFailedMessage failureMessage); // 0x000000018137A490-0x000000018137A570
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <GoToSanctuary>d__2 : IAsyncStateMachine // TypeDefIndex: 11250
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<bool> <>t__builder; // 0x08
		public string uuid; // 0x20
		private <>c__DisplayClass2_0 <>8__1; // 0x28
		private TaskAwaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x0000000180213520-0x0000000180213530
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180213530-0x0000000180213580
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass3_0 // TypeDefIndex: 11251
	{
		// Fields
		public string ownerUUIDStr; // 0x10
		public Action<RoomJoinSuccessMessage> onSuccess; // 0x18
		public Action<RoomJoinFailedMessage> onFailed; // 0x20
		public Action<RoomJoinSuccessMessage> <>9__2; // 0x28
		public Action<RoomJoinFailedMessage> <>9__3; // 0x30

		// Nested types
		private struct <<RequestJoinSanctuary>b__0>d : IAsyncStateMachine // TypeDefIndex: 11252
		{
			// Fields
			public int <>1__state; // 0x00
			public AsyncTaskMethodBuilder <>t__builder; // 0x08
			public <>c__DisplayClass3_0 <>4__this; // 0x20
			private TaskAwaiter <>u__1; // 0x28

			// Methods
			private void MoveNext(); // 0x0000000180213740-0x0000000180213B80
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018000DC90-0x000000018000DCA0
		}

		// Constructors
		public <>c__DisplayClass3_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		[AsyncStateMachine] // 0x000000018013AA40-0x000000018013AA90
		internal Task <RequestJoinSanctuary>b__0(); // 0x000000018137A570-0x000000018137A640
		internal void <RequestJoinSanctuary>b__2(RoomJoinSuccessMessage s); // 0x000000018137A640-0x000000018137A690
		internal void <RequestJoinSanctuary>b__3(RoomJoinFailedMessage f); // 0x000000018137A690-0x000000018137A6E0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestJoinSanctuary>d__3 : IAsyncStateMachine // TypeDefIndex: 11253
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
		private void MoveNext(); // 0x0000000180213590-0x00000001802135A0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018000DC90-0x000000018000DCA0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestUpdateDenState>d__4 : IAsyncStateMachine // TypeDefIndex: 11254
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder <>t__builder; // 0x08
		public UpdateItem[] itemsToUpdate; // 0x20
		public RemoveItem[] itemsToRemove; // 0x28
		public List<RoomData> roomData; // 0x30
		private TaskAwaiter<DenStateUpdateResponse> <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x0000000180213720-0x0000000180213730
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018000DC90-0x000000018000DCA0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass5_0 // TypeDefIndex: 11255
	{
		// Fields
		public Action<SanctuaryUpgradeStartSuccessMessage> onSuccess; // 0x10
		public Action<SanctuaryUpgradeStartFailedMessage> onFailed; // 0x18

		// Constructors
		public <>c__DisplayClass5_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <RequestSanctuaryUpgradeStart>b__0(SanctuaryUpgradeStartSuccessMessage s); // 0x000000018137A6E0-0x000000018137A730
		internal void <RequestSanctuaryUpgradeStart>b__1(SanctuaryUpgradeStartFailedMessage f); // 0x000000018137A730-0x000000018137A780
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass6_0 // TypeDefIndex: 11256
	{
		// Fields
		public Action<SanctuaryUpgradeCompleteSuccessMessage> onSuccess; // 0x10
		public Action<SanctuaryUpgradeCompleteFailedMessage> onFailed; // 0x18

		// Constructors
		public <>c__DisplayClass6_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <RequestSanctuaryUpgradeComplete>b__0(SanctuaryUpgradeCompleteSuccessMessage s); // 0x000000018137A780-0x000000018137A7D0
		internal void <RequestSanctuaryUpgradeComplete>b__1(SanctuaryUpgradeCompleteFailedMessage f); // 0x000000018137A7D0-0x000000018137A820
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestSanctuaryPurchase>d__7 : IAsyncStateMachine // TypeDefIndex: 11257
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<SanctuaryPurchaseResponse> <>t__builder; // 0x08
		public string purchaseableDefId; // 0x20
		private TaskAwaiter<SanctuaryPurchaseResponse> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x0000000180213660-0x0000000180213670
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180213670-0x00000001802136C0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestSanctuarySwitch>d__8 : IAsyncStateMachine // TypeDefIndex: 11258
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<SanctuarySwitchResponse> <>t__builder; // 0x08
		public string lookId; // 0x20
		private TaskAwaiter<SanctuarySwitchResponse> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x00000001802136C0-0x00000001802136D0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001802136D0-0x0000000180213720
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestSanctuaryLookSave>d__9 : IAsyncStateMachine // TypeDefIndex: 11259
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<SanctuaryLookSaveResponse> <>t__builder; // 0x08
		public SanctuaryLookItemComponent inLook; // 0x20
		private TaskAwaiter<SanctuaryLookSaveResponse> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x0000000180213600-0x0000000180213610
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180213610-0x0000000180213660
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestSanctuaryLookLoad>d__10 : IAsyncStateMachine // TypeDefIndex: 11260
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<SanctuaryLookLoadResponse> <>t__builder; // 0x08
		public string lookId; // 0x20
		private TaskAwaiter<SanctuaryLookLoadResponse> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x00000001802135A0-0x00000001802135B0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001802135B0-0x0000000180213600
	}

	// Methods
	[AsyncStateMachine] // 0x0000000180137900-0x0000000180137950
	public static Task RequestJoinMySanctuary(); // 0x0000000181370770-0x0000000181370830
	[AsyncStateMachine] // 0x0000000180137B30-0x0000000180137B80
	public static Task<bool> GoToSanctuary(string uuid); // 0x0000000181370630-0x0000000181370710
	[AsyncStateMachine] // 0x0000000180137CC0-0x0000000180137D30
	[MessageSender] // 0x0000000180137CC0-0x0000000180137D30
	public static Task RequestJoinSanctuary(string ownerUUIDStr, Action<RoomJoinSuccessMessage> onSuccess = null, Action<RoomJoinFailedMessage> onFailed = null); // 0x0000000181370830-0x0000000181370930
	[AsyncStateMachine] // 0x0000000180137E20-0x0000000180137E90
	[MessageSender] // 0x0000000180137E20-0x0000000180137E90
	public static Task RequestUpdateDenState(UpdateItem[] itemsToUpdate, RemoveItem[] itemsToRemove, List<RoomData> roomData); // 0x00000001813710C0-0x00000001813711C0
	public static void RequestSanctuaryUpgradeStart(int stage, int[] enlargedAreaIndexes, Action<SanctuaryUpgradeStartSuccessMessage> onSuccess = null, Action<SanctuaryUpgradeStartFailedMessage> onFailed = null); // 0x0000000181370E50-0x00000001813710C0
	public static void RequestSanctuaryUpgradeComplete(string twiggleId, Action<SanctuaryUpgradeCompleteSuccessMessage> onSuccess = null, Action<SanctuaryUpgradeCompleteFailedMessage> onFailed = null); // 0x0000000181370CB0-0x0000000181370E50
	[AsyncStateMachine] // 0x0000000180137EC0-0x0000000180137F10
	public static Task<SanctuaryPurchaseResponse> RequestSanctuaryPurchase(string purchaseableDefId); // 0x0000000181370AF0-0x0000000181370BD0
	[AsyncStateMachine] // 0x0000000180137FE0-0x0000000180138030
	public static Task<SanctuarySwitchResponse> RequestSanctuarySwitch(string lookId); // 0x0000000181370BD0-0x0000000181370CB0
	[AsyncStateMachine] // 0x0000000180138220-0x0000000180138270
	public static Task<SanctuaryLookSaveResponse> RequestSanctuaryLookSave(SanctuaryLookItemComponent inLook); // 0x0000000181370A10-0x0000000181370AF0
	[AsyncStateMachine] // 0x00000001801383C0-0x0000000180138410
	public static Task<SanctuaryLookLoadResponse> RequestSanctuaryLookLoad(string lookId); // 0x0000000181370930-0x0000000181370A10
	[MessageRoute] // 0x0000000180138610-0x0000000180138630
	private static void HandleSanctuaryStateUpdateRequest(DenStateUpdateResponse response); // 0x0000000181370710-0x0000000181370770
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	internal static void <RequestJoinSanctuary>g__handleEitherMessage|3_1(); // 0x00000001803581E0-0x00000001803581F0
}

