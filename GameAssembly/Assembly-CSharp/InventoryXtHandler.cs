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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[MessageRouteHandler] // 0x00000001801CDAD0-0x00000001801CDAE0
public static class InventoryXtHandler // TypeDefIndex: 12729
{
	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestItemsOfCategory>d__4 : IAsyncStateMachine // TypeDefIndex: 12730
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<InventoryListResponse> <>t__builder; // 0x08
		public ItemType category; // 0x20
		private TaskAwaiter<InventoryListResponse> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x000000018001C870-0x000000018001C880
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018001C880-0x000000018001C980
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestItemsWithComponent>d__5<T> : IAsyncStateMachine // TypeDefIndex: 12731
		where T : ItemComponent
	{
		// Fields
		public int <>1__state;
		public AsyncTaskMethodBuilder<InventoryListResponse> <>t__builder;
		private TaskAwaiter<InventoryListResponse> <>u__1;

		// Methods
		private void MoveNext();
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine);
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestItemById>d__6 : IAsyncStateMachine // TypeDefIndex: 12732
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<InventoryListResponse> <>t__builder; // 0x08
		public string itemId; // 0x20
		private TaskAwaiter<InventoryListResponse> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x000000018001C810-0x000000018001C820
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018001C820-0x000000018001C870
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestInspirationCombine>d__9 : IAsyncStateMachine // TypeDefIndex: 12733
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncUniTaskMethodBuilder<InspirationCombineResponse> <>t__builder; // 0x08
		public List<InspirationItemComponent> inInspirations; // 0x20
		private TaskAwaiter<InspirationCombineResponse> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x000000018001C7B0-0x000000018001C7C0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018001C7C0-0x000000018001C810
	}

	// Methods
	public static void AddItem(string defId); // 0x000000018086F240-0x000000018086F3D0
	public static void AddEnigmaItem(string defId); // 0x000000018086F0B0-0x000000018086F240
	[MessageSender] // 0x000000018020E280-0x000000018020E2A0
	public static void RequestAddItem(BaseDef craftableDef, int amount = 1 /* Metadata: 0x007B9FA3 */); // 0x000000018086FB90-0x000000018086FC50
	[MessageSender] // 0x000000018020E4B0-0x000000018020E4D0
	public static void RequestAddEnigmaItem(BaseDef craftableDef, int amount = 1 /* Metadata: 0x007B9FA7 */); // 0x000000018086FAD0-0x000000018086FB90
	[AsyncStateMachine] // 0x000000018020E6A0-0x000000018020E710
	[MessageSender] // 0x000000018020E6A0-0x000000018020E710
	public static Task<InventoryListResponse> RequestItemsOfCategory(ItemType category); // 0x0000000180870000-0x00000001808700D0
	[AsyncStateMachine] // 0x000000018020FD30-0x000000018020FDA0
	[MessageSender] // 0x000000018020FD30-0x000000018020FDA0
	public static Task<InventoryListResponse> RequestItemsWithComponent<T>()
		where T : ItemComponent;
	[AsyncStateMachine] // 0x00000001802102B0-0x0000000180210320
	[MessageSender] // 0x00000001802102B0-0x0000000180210320
	public static Task<InventoryListResponse> RequestItemById(string itemId); // 0x000000018086FF20-0x0000000180870000
	[MessageSender] // 0x0000000180210740-0x0000000180210760
	public static void RequestDyeItem(string itemId, string[] dyeItemIds, int[] channelIndexes, int[] undyedChannelIndexes); // 0x000000018086FC50-0x000000018086FE40
	[MessageSender] // 0x00000001802109C0-0x00000001802109E0
	public static void RequestUncraftItem(string itemId, int count); // 0x00000001808700D0-0x0000000180870180
	[AsyncStateMachine] // 0x0000000180210AD0-0x0000000180210B40
	[MessageSender] // 0x0000000180210AD0-0x0000000180210B40
	public static UniTask<InspirationCombineResponse> RequestInspirationCombine(List<InspirationItemComponent> inInspirations); // 0x000000018086FE40-0x000000018086FF20
	[MessageRoute] // 0x0000000180210DE0-0x0000000180210E00
	private static void HandleInventoryList(InventoryListResponse res); // 0x000000018086F770-0x000000018086FAD0
	[MessageRoute] // 0x0000000180210EC0-0x0000000180210EE0
	private static void HandleInventoryListRemoved(InventoryListRemovedResponse res); // 0x000000018086F3D0-0x000000018086F770
}

