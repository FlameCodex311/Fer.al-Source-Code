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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_Shop_CraftableItem : UI_Window // TypeDefIndex: 12229
{
	// Fields
	[Header] // 0x0000000180117630-0x00000001801176C0
	[RootSelector] // 0x0000000180117630-0x00000001801176C0
	[SerializeField] // 0x0000000180117630-0x00000001801176C0
	protected string _shopDefId; // 0x108
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	protected UI_LazyItemList_CraftableItemShop _itemList; // 0x110
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	protected UI_TabGroup _tabGroup; // 0x118
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	protected WWTextMeshProUGUI _sectionLabelText; // 0x120
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	protected Transform _secretCraftingParent; // 0x128
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	protected UI_ShopDialoguePanel _dialoguePanel; // 0x130
	protected UI_Stage _uiStage; // 0x138
	protected ShopContentDefComponent _shopDef; // 0x140
	protected bool _stageError; // 0x148

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 12230
	{
		// Fields
		public ShopContentDefComponent inShopDef; // 0x10

		// Constructors
		public <>c__DisplayClass0_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0(UI_Window_Shop_CraftableItem window); // 0x0000000180E9D8F0-0x0000000180E9D920
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 12231
	{
		// Fields
		public ShopContentDefComponent inShopDef; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x0000000180E9E740-0x0000000180E9E810
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass16_0 // TypeDefIndex: 12232
	{
		// Fields
		public int frameCount; // 0x10
		public UI_Window_Shop_CraftableItem <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass16_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <DoDelayedOpenAnimation>b__0(); // 0x0000000180E9DBF0-0x0000000180E9DCE0
		internal void <DoDelayedOpenAnimation>b__1(); // 0x0000000180E9DCE0-0x0000000180E9DDE0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass19_0 // TypeDefIndex: 12233
	{
		// Fields
		public UI_Window_Shop_CraftableItem <>4__this; // 0x10
		public BaseDef commonItem; // 0x18
		public BaseDef rareItem; // 0x20
		public BuyItemResponse inMessage; // 0x28
		public Action <>9__1; // 0x30

		// Constructors
		public <>c__DisplayClass19_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OnSecretCraft>b__0(UI_Window window); // 0x0000000180E9DE20-0x0000000180E9DFA0
		internal void <OnSecretCraft>b__1(); // 0x0000000180E9DFA0-0x0000000180E9DFD0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <OnSecretCraft>d__19 : IAsyncStateMachine // TypeDefIndex: 12234
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_Shop_CraftableItem <>4__this; // 0x28
		public BuyItemResponse inMessage; // 0x30
		private <>c__DisplayClass19_0 <>8__1; // 0x38
		private UniTask.Awaiter <>u__1; // 0x40

		// Methods
		private void MoveNext(); // 0x00000001801F07B0-0x00000001801F07C0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <SetupShopContent>d__21 : IAsyncStateMachine // TypeDefIndex: 12235
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_Shop_CraftableItem <>4__this; // 0x28
		private TaskAwaiter<ShopListResponse> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F07E0-0x00000001801F07F0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	// Constructors
	public UI_Window_Shop_CraftableItem(); // 0x0000000180EB0020-0x0000000180EB0070

	// Methods
	[DebugButton] // 0x00000001801192A0-0x0000000180119300
	public static void OpenWindow(ShopContentDefComponent inShopDef = null); // 0x0000000180EAFAD0-0x0000000180EAFB90
	public static void QueueWindow(ShopContentDefComponent inShopDef = null); // 0x0000000180EAFB90-0x0000000180EAFC50
	public static void CloseWindow(); // 0x0000000180EAF260-0x0000000180EAF2B0
	public virtual void Setup(ShopContentDefComponent inShopDef = null); // 0x0000000180EAFD00-0x0000000180EAFF30
	protected override void OnOpen(); // 0x0000000180EAF870-0x0000000180EAFA10
	protected override void OnOpenComplete(); // 0x0000000180EAF7E0-0x0000000180EAF870
	protected override void OnClose(bool inAnimate); // 0x0000000180EAF390-0x0000000180EAF610
	protected override void DoDelayedOpenAnimation(); // 0x0000000180EAF2B0-0x0000000180EAF390
	protected virtual void OnItemCraftInitiated(BaseDef inDef, int inQuantity); // 0x0000000180EAF610-0x0000000180EAF690
	protected virtual void OnItemCrafted(BuyItemResponse inMessage); // 0x0000000180EAF690-0x0000000180EAF7E0
	[AsyncStateMachine] // 0x0000000180119410-0x0000000180119490
	[DeMethodButton] // 0x0000000180119410-0x0000000180119490
	protected virtual void OnSecretCraft(BuyItemResponse inMessage); // 0x0000000180EAFA10-0x0000000180EAFAD0
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
	[AsyncStateMachine] // 0x00000001801196F0-0x0000000180119740
	private void SetupShopContent(); // 0x0000000180EAFC50-0x0000000180EAFD00
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <OnOpen>b__13_0(int tabIndex); // 0x0000000180EAFF30-0x0000000180EB0020
}

