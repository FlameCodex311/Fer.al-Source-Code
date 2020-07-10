/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Server;
using WW.Debug;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[MessageRouteHandler] // 0x00000001800B36B0-0x00000001800B36C0
public static class ShopXtHandler // TypeDefIndex: 11261
{
	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestBuyItem>d__0 : IAsyncStateMachine // TypeDefIndex: 11262
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<BuyItemResponse> <>t__builder; // 0x08
		public string purchaseableDefId; // 0x20
		public string shopDefId; // 0x28
		public int inQuantity; // 0x30
		private TaskAwaiter<BuyItemResponse> <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F0A90-0x00000001801F0AA0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0AA0-0x00000001801F0AF0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestShopList>d__1 : IAsyncStateMachine // TypeDefIndex: 11263
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<ShopListResponse> <>t__builder; // 0x08
		public string shopDefId; // 0x20
		private TaskAwaiter<ShopListResponse> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x00000001801F0E60-0x00000001801F0E70
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0E70-0x00000001801F0EC0
	}

	// Methods
	[AsyncStateMachine] // 0x000000018013E100-0x000000018013E170
	[MessageSender] // 0x000000018013E100-0x000000018013E170
	public static Task<BuyItemResponse> RequestBuyItem(string purchaseableDefId, string shopDefId, int inQuantity = 1 /* Metadata: 0x00782849 */); // 0x0000000180EC23E0-0x0000000180EC24E0
	[AsyncStateMachine] // 0x000000018013E2C0-0x000000018013E380
	[DebugButton] // 0x000000018013E2C0-0x000000018013E380
	[MessageSender] // 0x000000018013E2C0-0x000000018013E380
	public static Task<ShopListResponse> RequestShopList(string shopDefId); // 0x0000000180EC24E0-0x0000000180EC25C0
}

