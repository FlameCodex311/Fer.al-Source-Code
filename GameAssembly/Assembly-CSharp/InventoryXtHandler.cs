/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Server;
using UniRx.Async;
using UniRx.Async.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[MessageRouteHandler] // 0x00000001800B36B0-0x00000001800B36C0
public static class InventoryXtHandler // TypeDefIndex: 11203
{
	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestItemsOfCategory>d__4 : IAsyncStateMachine // TypeDefIndex: 11204
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<InventoryListResponse> <>t__builder; // 0x08
		public ItemType category; // 0x20
		private TaskAwaiter<InventoryListResponse> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x00000001801F1760-0x00000001801F1770
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F1770-0x00000001801F17C0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestItemsWithComponent>d__5<T> : IAsyncStateMachine // TypeDefIndex: 11205
		where T : ItemComponent
	{
		// Fields
		public int <>1__state;
		public AsyncTaskMethodBuilder<InventoryListResponse> <>t__builder;
		private TaskAwaiter<InventoryListResponse> <>u__1;

		// Methods
		private void MoveNext();
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine);
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestItemById>d__6 : IAsyncStateMachine // TypeDefIndex: 11206
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<InventoryListResponse> <>t__builder; // 0x08
		public string itemId; // 0x20
		private TaskAwaiter<InventoryListResponse> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x00000001801F1700-0x00000001801F1710
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F1710-0x00000001801F1760
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestInspirationCombine>d__9 : IAsyncStateMachine // TypeDefIndex: 11207
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncUniTaskMethodBuilder<InspirationCombineResponse> <>t__builder; // 0x08
		public List<InspirationItemComponent> inInspirations; // 0x20
		private TaskAwaiter<InspirationCombineResponse> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x00000001801F16A0-0x00000001801F16B0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F16B0-0x00000001801F1700
	}

	// Methods
	public static void AddItem(string defId); // 0x0000000180F63070-0x0000000180F63200
	public static void AddEnigmaItem(string defId); // 0x0000000180F62EE0-0x0000000180F63070
	[MessageSender] // 0x0000000180129D10-0x0000000180129D30
	public static void RequestAddItem(BaseDef craftableDef, int amount = 1 /* Metadata: 0x0078281D */); // 0x0000000180F63A00-0x0000000180F63AC0
	[MessageSender] // 0x0000000180129DC0-0x0000000180129DE0
	public static void RequestAddEnigmaItem(BaseDef craftableDef, int amount = 1 /* Metadata: 0x00782821 */); // 0x0000000180F63940-0x0000000180F63A00
	[AsyncStateMachine] // 0x0000000180129EB0-0x0000000180129F20
	[MessageSender] // 0x0000000180129EB0-0x0000000180129F20
	public static Task<InventoryListResponse> RequestItemsOfCategory(ItemType category); // 0x0000000180F63E80-0x0000000180F63F50
	[AsyncStateMachine] // 0x000000018012A2B0-0x000000018012A320
	[MessageSender] // 0x000000018012A2B0-0x000000018012A320
	public static Task<InventoryListResponse> RequestItemsWithComponent<T>()
		where T : ItemComponent;
	[AsyncStateMachine] // 0x000000018012A610-0x000000018012A680
	[MessageSender] // 0x000000018012A610-0x000000018012A680
	public static Task<InventoryListResponse> RequestItemById(string itemId); // 0x0000000180F63DA0-0x0000000180F63E80
	[MessageSender] // 0x000000018012A930-0x000000018012A950
	public static void RequestDyeItem(string itemId, string[] dyeItemIds, int[] channelIndexes, int[] undyedChannelIndexes); // 0x0000000180F63AC0-0x0000000180F63CC0
	[MessageSender] // 0x000000018012ABA0-0x000000018012ABC0
	public static void RequestUncraftItem(string itemId, int count); // 0x0000000180F63F50-0x0000000180F64000
	[AsyncStateMachine] // 0x000000018012BF80-0x000000018012BFF0
	[MessageSender] // 0x000000018012BF80-0x000000018012BFF0
	public static UniTask<InspirationCombineResponse> RequestInspirationCombine(List<InspirationItemComponent> inInspirations); // 0x0000000180F63CC0-0x0000000180F63DA0
	[MessageRoute] // 0x000000018012C4D0-0x000000018012C4F0
	private static void HandleInventoryList(InventoryListResponse res); // 0x0000000180F635C0-0x0000000180F63940
	[MessageRoute] // 0x000000018012C6B0-0x000000018012C6D0
	private static void HandleInventoryListRemoved(InventoryListRemovedResponse res); // 0x0000000180F63200-0x0000000180F635C0
}

