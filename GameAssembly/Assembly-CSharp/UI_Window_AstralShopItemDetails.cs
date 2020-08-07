/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_AstralShopItemDetails : UI_Window // TypeDefIndex: 13990
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _costText; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_RarityBadge _rarityBadge; // 0x110
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_TimeRemainingBadge _timeRemainingBadge; // 0x118
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _nameText; // 0x120
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _descriptionText; // 0x128
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_ItemImage _itemImage; // 0x130
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _detailButton; // 0x138
	[Header] // 0x00000001801D1670-0x00000001801D16C0
	[SerializeField] // 0x00000001801D1670-0x00000001801D16C0
	private WWImage _backgroundImage; // 0x140
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Sprite _backgroundSpriteRegular; // 0x148
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Sprite _backgroundSpriteSeasonPass; // 0x150
	private BaseDef _def; // 0x158
	private BundlePackDefComponent _bundlePack; // 0x160
	private PurchaseableDefComponent _purchaseable; // 0x168

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 13991
	{
		// Fields
		public BaseDef inDef; // 0x10

		// Constructors
		public <>c__DisplayClass0_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0(UI_Window_AstralShopItemDetails window); // 0x0000000180634CE0-0x0000000180634D10
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 13992
	{
		// Fields
		public BaseDef inDef; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x0000000180634D10-0x0000000180634DE0
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 13993
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Predicate<PurchaseableDefComponent.CostEntry> <>9__20_1; // 0x08

		// Constructors
		static <>c(); // 0x00000001806354C0-0x0000000180635520
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <BtnClicked_Buy>b__20_1(PurchaseableDefComponent.CostEntry costItem); // 0x0000000180634A10-0x0000000180634A60
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <DoPurchase>d__22 : IAsyncStateMachine // TypeDefIndex: 13994
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_AstralShopItemDetails <>4__this; // 0x28
		private TaskAwaiter<BuyItemResponse> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x0000000180009F90-0x0000000180009FA0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Constructors
	public UI_Window_AstralShopItemDetails(); // 0x00000001803B50E0-0x00000001803B50F0

	// Methods
	public static void OpenWindow(BaseDef inDef); // 0x0000000180640BF0-0x0000000180640CB0
	public static void QueueWindow(BaseDef inDef); // 0x0000000180640CB0-0x0000000180640D70
	public static void CloseWindow(); // 0x00000001806409C0-0x0000000180640A10
	private void Setup(BaseDef inDef); // 0x0000000180640D70-0x00000001806411E0
	protected override void OnOpen(); // 0x0000000180640B60-0x0000000180640BF0
	protected override void OnClose(bool inAnimate); // 0x0000000180640AC0-0x0000000180640B60
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
	public void BtnClicked_Buy(); // 0x0000000180640670-0x00000001806409A0
	public void BtnClicked_Details(); // 0x00000001806409A0-0x00000001806409C0
	[AsyncStateMachine] // 0x0000000180257A10-0x0000000180257A60
	private void DoPurchase(); // 0x0000000180640A10-0x0000000180640AC0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <BtnClicked_Buy>b__20_2(bool inResponse); // 0x0000000180641290-0x0000000180641340
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <BtnClicked_Buy>b__20_0(bool inResponse); // 0x00000001806411E0-0x0000000180641290
}

