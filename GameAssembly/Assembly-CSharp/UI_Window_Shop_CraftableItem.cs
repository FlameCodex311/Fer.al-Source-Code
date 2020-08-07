/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.DeInspektor.Attributes;
using TMPro;
using UniRx.Async;
using UnityEngine;
using WW.Debug;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_Shop_CraftableItem : UI_Window // TypeDefIndex: 13779
{
	// Fields
	[Header] // 0x00000001801FED50-0x00000001801FEDE0
	[RootSelector] // 0x00000001801FED50-0x00000001801FEDE0
	[SerializeField] // 0x00000001801FED50-0x00000001801FEDE0
	protected string _shopDefId; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	protected UI_LazyItemList_CraftableItemShop _itemList; // 0x110
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	protected UI_TabGroup _tabGroup; // 0x118
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	protected WWTextMeshProUGUI _sectionLabelText; // 0x120
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	protected Transform _secretCraftingParent; // 0x128
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	protected UI_ShopDialoguePanel _dialoguePanel; // 0x130
	protected UI_Stage _uiStage; // 0x138
	protected ShopContentDefComponent _shopDef; // 0x140
	protected bool _stageError; // 0x148

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 13780
	{
		// Fields
		public ShopContentDefComponent inShopDef; // 0x10

		// Constructors
		public <>c__DisplayClass0_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0(UI_Window_Shop_CraftableItem window); // 0x00000001803B3060-0x00000001803B3090
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 13781
	{
		// Fields
		public ShopContentDefComponent inShopDef; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x00000001804479B0-0x0000000180447A80
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass16_0 // TypeDefIndex: 13782
	{
		// Fields
		public int frameCount; // 0x10
		public UI_Window_Shop_CraftableItem <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass16_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <DoDelayedOpenAnimation>b__0(); // 0x0000000180447100-0x00000001804471F0
		internal void <DoDelayedOpenAnimation>b__1(); // 0x00000001804471F0-0x00000001804472F0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass19_0 // TypeDefIndex: 13783
	{
		// Fields
		public UI_Window_Shop_CraftableItem <>4__this; // 0x10
		public BaseDef commonItem; // 0x18
		public BaseDef rareItem; // 0x20
		public BuyItemResponse inMessage; // 0x28
		public Action <>9__1; // 0x30

		// Constructors
		public <>c__DisplayClass19_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OnSecretCraft>b__0(UI_Window window); // 0x0000000180447660-0x00000001804477D0
		internal void <OnSecretCraft>b__1(); // 0x00000001804477D0-0x0000000180447800
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <OnSecretCraft>d__19 : IAsyncStateMachine // TypeDefIndex: 13784
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_Shop_CraftableItem <>4__this; // 0x28
		public BuyItemResponse inMessage; // 0x30
		private <>c__DisplayClass19_0 <>8__1; // 0x38
		private UniTask.Awaiter <>u__1; // 0x40

		// Methods
		private void MoveNext(); // 0x0000000180004700-0x0000000180004710
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <SetupShopContent>d__21 : IAsyncStateMachine // TypeDefIndex: 13785
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_Shop_CraftableItem <>4__this; // 0x28
		private TaskAwaiter<ShopListResponse> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x0000000180004710-0x0000000180004720
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Constructors
	public UI_Window_Shop_CraftableItem(); // 0x00000001804494C0-0x0000000180449510

	// Methods
	[DebugButton] // 0x00000001801FF850-0x00000001801FF8B0
	public static void OpenWindow(ShopContentDefComponent inShopDef = null); // 0x0000000180448F90-0x0000000180449050
	public static void QueueWindow(ShopContentDefComponent inShopDef = null); // 0x0000000180449050-0x0000000180449110
	public static void CloseWindow(); // 0x0000000180448740-0x0000000180448790
	public virtual void Setup(ShopContentDefComponent inShopDef = null); // 0x00000001804491C0-0x00000001804493E0
	protected override void OnOpen(); // 0x0000000180448D40-0x0000000180448ED0
	protected override void OnOpenComplete(); // 0x0000000180448CB0-0x0000000180448D40
	protected override void OnClose(bool inAnimate); // 0x0000000180448870-0x0000000180448AF0
	protected override void DoDelayedOpenAnimation(); // 0x0000000180448790-0x0000000180448870
	protected virtual void OnItemCraftInitiated(BaseDef inDef, int inQuantity); // 0x0000000180448AF0-0x0000000180448B70
	protected virtual void OnItemCrafted(BuyItemResponse inMessage); // 0x0000000180448B70-0x0000000180448CB0
	[AsyncStateMachine] // 0x00000001801FF9E0-0x00000001801FFA60
	[DeMethodButton] // 0x00000001801FF9E0-0x00000001801FFA60
	protected virtual void OnSecretCraft(BuyItemResponse inMessage); // 0x0000000180448ED0-0x0000000180448F90
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
	[AsyncStateMachine] // 0x00000001801FFBC0-0x00000001801FFC10
	private void SetupShopContent(); // 0x0000000180449110-0x00000001804491C0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <OnOpen>b__13_0(int tabIndex); // 0x00000001804493E0-0x00000001804494C0
}

