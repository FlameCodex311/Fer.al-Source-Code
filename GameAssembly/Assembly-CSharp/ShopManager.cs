/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using WW.Debug;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class ShopManager // TypeDefIndex: 10781
{
	// Fields
	private static ShopManager _instance; // 0x00

	// Properties
	public static ShopManager Instance { get; } // 0x0000000180EC2280-0x0000000180EC22E0 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <_BuyItem>d__11 : IEnumerator<object> // TypeDefIndex: 10782
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public ShopManager <>4__this; // 0x20
		public string inPurchasableDefId; // 0x28
		public string inShopDefId; // 0x30
		public int inQuantity; // 0x38

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <_BuyItem>d__11(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180EC9220-0x0000000180EC9330
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180EC9330-0x0000000180EC9380
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestServerBuyItem>d__12 : IAsyncStateMachine // TypeDefIndex: 10783
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public string inPurchasableDefId; // 0x28
		public string inShopDefId; // 0x30
		public int inQuantity; // 0x38
		private TaskAwaiter<BuyItemResponse> <>u__1; // 0x40

		// Methods
		private void MoveNext(); // 0x00000001801F0E50-0x00000001801F0E60
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	// Constructors
	static ShopManager(); // 0x0000000180EC2220-0x0000000180EC2280
	private ShopManager(); // 0x000000018036B6C0-0x000000018036B6D0

	// Methods
	[DebugButton] // 0x00000001800D8320-0x00000001800D8380
	public static void BuyItem_DEBUG(string defId, string shopDefId); // 0x0000000180EC1B50-0x0000000180EC1D10
	public static void BuyItem(BaseDef inPurchasableDef, string inShopDefId, int inQuantity = 1 /* Metadata: 0x0078202D */); // 0x0000000180EC1ED0-0x0000000180EC1FC0
	public static void BuyItem(PurchaseableDefComponent inPurchasableDef, ShopContentDefComponent inShopDef, int inQuantity = 1 /* Metadata: 0x00782031 */); // 0x0000000180EC1E20-0x0000000180EC1ED0
	public static void BuyItem(string inPurchasableDefId, ShopContentDefComponent inShopDef, int inQuantity = 1 /* Metadata: 0x00782035 */); // 0x0000000180EC1D90-0x0000000180EC1E20
	public static void BuyItem(PurchaseableDefComponent inPurchasableDef, string inShopDefId, int inQuantity = 1 /* Metadata: 0x00782039 */); // 0x0000000180EC1D10-0x0000000180EC1D90
	public static void BuyItem(string inPurchasableDefId, string inShopDefId, int inQuantity = 1 /* Metadata: 0x0078203D */); // 0x0000000180EC1FC0-0x0000000180EC20C0
	[IteratorStateMachine] // 0x00000001800D8630-0x00000001800D8680
	private IEnumerator _BuyItem(string inPurchasableDefId, string inShopDefId, int inQuantity = 1 /* Metadata: 0x00782041 */); // 0x0000000180EC2190-0x0000000180EC2220
	[AsyncStateMachine] // 0x00000001800D8890-0x00000001800D88E0
	private void RequestServerBuyItem(string inPurchasableDefId, string inShopDefId, int inQuantity = 1 /* Metadata: 0x00782045 */); // 0x0000000180EC20C0-0x0000000180EC2190
}

