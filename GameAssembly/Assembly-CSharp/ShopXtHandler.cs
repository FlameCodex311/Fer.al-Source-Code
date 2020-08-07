/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Server;
using WW.Debug;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[MessageRouteHandler] // 0x00000001801CDAD0-0x00000001801CDAE0
public static class ShopXtHandler // TypeDefIndex: 12789
{
	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestBuyItem>d__0 : IAsyncStateMachine // TypeDefIndex: 12790
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<BuyItemResponse> <>t__builder; // 0x08
		public string purchaseableDefId; // 0x20
		public string shopDefId; // 0x28
		public int inQuantity; // 0x30
		private TaskAwaiter<BuyItemResponse> <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x000000018001B0A0-0x000000018001B0B0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018001B0B0-0x000000018001B100
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestShopList>d__1 : IAsyncStateMachine // TypeDefIndex: 12791
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<ShopListResponse> <>t__builder; // 0x08
		public string shopDefId; // 0x20
		private TaskAwaiter<ShopListResponse> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x000000018001B350-0x000000018001B360
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x000000018001B360-0x000000018001B3B0
	}

	// Methods
	[AsyncStateMachine] // 0x0000000180225AC0-0x0000000180225B30
	[MessageSender] // 0x0000000180225AC0-0x0000000180225B30
	public static Task<BuyItemResponse> RequestBuyItem(string purchaseableDefId, string shopDefId, int inQuantity = 1 /* Metadata: 0x007B9FCF */); // 0x000000018076BEF0-0x000000018076BFF0
	[AsyncStateMachine] // 0x0000000180225E20-0x0000000180225EE0
	[DebugButton] // 0x0000000180225E20-0x0000000180225EE0
	[MessageSender] // 0x0000000180225E20-0x0000000180225EE0
	public static Task<ShopListResponse> RequestShopList(string shopDefId); // 0x000000018076BFF0-0x000000018076C0D0
}

