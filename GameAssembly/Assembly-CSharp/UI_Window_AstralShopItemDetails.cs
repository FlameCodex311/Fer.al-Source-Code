/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_AstralShopItemDetails : UI_Window // TypeDefIndex: 12402
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _costText; // 0x108
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_RarityBadge _rarityBadge; // 0x110
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_TimeRemainingBadge _timeRemainingBadge; // 0x118
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _nameText; // 0x120
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _descriptionText; // 0x128
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_ItemImage _itemImage; // 0x130
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _detailButton; // 0x138
	[Header] // 0x00000001800E17E0-0x00000001800E1830
	[SerializeField] // 0x00000001800E17E0-0x00000001800E1830
	private WWImage _backgroundImage; // 0x140
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Sprite _backgroundSpriteRegular; // 0x148
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Sprite _backgroundSpriteSeasonPass; // 0x150
	private BaseDef _def; // 0x158
	private BundlePackDefComponent _bundlePack; // 0x160
	private PurchaseableDefComponent _purchaseable; // 0x168

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 12403
	{
		// Fields
		public BaseDef inDef; // 0x10

		// Constructors
		public <>c__DisplayClass0_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0(UI_Window_AstralShopItemDetails window); // 0x0000000180EFEF50-0x0000000180EFEF80
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 12404
	{
		// Fields
		public BaseDef inDef; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x0000000180EFF490-0x0000000180EFF560
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12405
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Predicate<PurchaseableDefComponent.CostEntry> <>9__20_1; // 0x08

		// Constructors
		static <>c(); // 0x0000000180EFFC80-0x0000000180EFFCE0
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <BtnClicked_Buy>b__20_1(PurchaseableDefComponent.CostEntry costItem); // 0x0000000180EFE600-0x0000000180EFE650
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <DoPurchase>d__22 : IAsyncStateMachine // TypeDefIndex: 12406
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_AstralShopItemDetails <>4__this; // 0x28
		private TaskAwaiter<BuyItemResponse> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F12B0-0x00000001801F12C0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	// Constructors
	public UI_Window_AstralShopItemDetails(); // 0x0000000180E9F830-0x0000000180E9F840

	// Methods
	public static void OpenWindow(BaseDef inDef); // 0x0000000180F00690-0x0000000180F00750
	public static void QueueWindow(BaseDef inDef); // 0x0000000180F00750-0x0000000180F00810
	public static void CloseWindow(); // 0x0000000180F00460-0x0000000180F004B0
	private void Setup(BaseDef inDef); // 0x0000000180F00810-0x0000000180F00C80
	protected override void OnOpen(); // 0x0000000180F00600-0x0000000180F00690
	protected override void OnClose(bool inAnimate); // 0x0000000180F00560-0x0000000180F00600
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
	public void BtnClicked_Buy(); // 0x0000000180F00100-0x0000000180F00440
	public void BtnClicked_Details(); // 0x0000000180F00440-0x0000000180F00460
	[AsyncStateMachine] // 0x00000001801625B0-0x0000000180162600
	private void DoPurchase(); // 0x0000000180F004B0-0x0000000180F00560
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <BtnClicked_Buy>b__20_2(bool inResponse); // 0x0000000180F00D30-0x0000000180F00DD0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <BtnClicked_Buy>b__20_0(bool inResponse); // 0x0000000180F00C80-0x0000000180F00D30
}

