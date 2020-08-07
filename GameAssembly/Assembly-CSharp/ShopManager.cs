/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using WW.Debug;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class ShopManager // TypeDefIndex: 12291
{
	// Fields
	private static ShopManager _instance; // 0x00

	// Properties
	public static ShopManager Instance { get; } // 0x000000018076BD90-0x000000018076BDF0 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <_BuyItem>d__11 : IEnumerator<object> // TypeDefIndex: 12292
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ShopManager <>4__this; // 0x20
		public string inPurchasableDefId; // 0x28
		public string inShopDefId; // 0x30
		public int inQuantity; // 0x38

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <_BuyItem>d__11(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180777CD0-0x0000000180777DE0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180777DE0-0x0000000180777E30
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestServerBuyItem>d__12 : IAsyncStateMachine // TypeDefIndex: 12293
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public string inPurchasableDefId; // 0x28
		public string inShopDefId; // 0x30
		public int inQuantity; // 0x38
		private TaskAwaiter<BuyItemResponse> <>u__1; // 0x40

		// Methods
		private void MoveNext(); // 0x000000018001B340-0x000000018001B350
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Constructors
	static ShopManager(); // 0x000000018076BD30-0x000000018076BD90
	private ShopManager(); // 0x0000000180373240-0x0000000180373250

	// Methods
	[DebugButton] // 0x00000001802766B0-0x0000000180276710
	public static void BuyItem_DEBUG(string defId, string shopDefId); // 0x000000018076B660-0x000000018076B820
	public static void BuyItem(BaseDef inPurchasableDef, string inShopDefId, int inQuantity = 1 /* Metadata: 0x007B96EC */); // 0x000000018076B9E0-0x000000018076BAD0
	public static void BuyItem(PurchaseableDefComponent inPurchasableDef, ShopContentDefComponent inShopDef, int inQuantity = 1 /* Metadata: 0x007B96F0 */); // 0x000000018076B930-0x000000018076B9E0
	public static void BuyItem(string inPurchasableDefId, ShopContentDefComponent inShopDef, int inQuantity = 1 /* Metadata: 0x007B96F4 */); // 0x000000018076B8A0-0x000000018076B930
	public static void BuyItem(PurchaseableDefComponent inPurchasableDef, string inShopDefId, int inQuantity = 1 /* Metadata: 0x007B96F8 */); // 0x000000018076B820-0x000000018076B8A0
	public static void BuyItem(string inPurchasableDefId, string inShopDefId, int inQuantity = 1 /* Metadata: 0x007B96FC */); // 0x000000018076BAD0-0x000000018076BBD0
	[IteratorStateMachine] // 0x00000001802768E0-0x0000000180276930
	private IEnumerator _BuyItem(string inPurchasableDefId, string inShopDefId, int inQuantity = 1 /* Metadata: 0x007B9700 */); // 0x000000018076BCA0-0x000000018076BD30
	[AsyncStateMachine] // 0x0000000180276CB0-0x0000000180276D00
	private void RequestServerBuyItem(string inPurchasableDefId, string inShopDefId, int inQuantity = 1 /* Metadata: 0x007B9704 */); // 0x000000018076BBD0-0x000000018076BCA0
}

