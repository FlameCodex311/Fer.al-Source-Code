/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using WW.Debug;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_Shop_Uncrafting : UI_Window // TypeDefIndex: 12606
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_TabGroup _tabGroup; // 0x108
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyItemList_UncraftingShop _itemList; // 0x110
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_StageSubjectPositioner _stagePositioner; // 0x118
	private UI_Stage_UncraftingShop _stage; // 0x120
	private Item _itemBeingUncrafted; // 0x128
	private int _quantityBeingUncrafted; // 0x130

	// Properties
	public UI_Stage_UncraftingShop Stage { get; } // 0x00000001803BD3D0-0x00000001803BD3E0 

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12607
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_Shop_Uncrafting> <>9__0_0; // 0x08
		public static Action<UI_Window> <>9__1_0; // 0x10

		// Constructors
		static <>c(); // 0x0000000180F7B5B0-0x0000000180F7B610
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0_0(UI_Window_Shop_Uncrafting window); // 0x0000000180E9D080-0x0000000180E9D0A0
		internal void <QueueWindow>b__1_0(UI_Window inWindow); // 0x0000000180F79F00-0x0000000180F79F80
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass14_0 // TypeDefIndex: 12608
	{
		// Fields
		public int frameCount; // 0x10
		public UI_Window_Shop_Uncrafting <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass14_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <DoDelayedOpenAnimation>b__0(); // 0x0000000180F7A740-0x0000000180F7A800
		internal void <DoDelayedOpenAnimation>b__1(); // 0x0000000180F7A800-0x0000000180F7A870
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <OnItemSelected>d__21 : IAsyncStateMachine // TypeDefIndex: 12609
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_Shop_Uncrafting <>4__this; // 0x28
		public Item inItem; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F17D0-0x00000001801F17E0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	// Constructors
	public UI_Window_Shop_Uncrafting(); // 0x0000000180E9F830-0x0000000180E9F840

	// Methods
	[DebugButton] // 0x00000001800F2B70-0x00000001800F2BD0
	public static void OpenWindow(); // 0x0000000180F80B40-0x0000000180F80C40
	public static void QueueWindow(); // 0x0000000180F80C40-0x0000000180F80D40
	public static void CloseWindow(); // 0x0000000180F7FF40-0x0000000180F7FF90
	private void Setup(); // 0x00000001803581E0-0x00000001803581F0
	protected override void OnOpen(); // 0x0000000180F80770-0x0000000180F80AA0
	protected override void OnClose(bool inAnimate); // 0x0000000180F800D0-0x0000000180F803A0
	protected override void DoDelayedOpenAnimation(); // 0x0000000180F7FF90-0x0000000180F80070
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
	private void OnCategoryTabSelected(int inTabIndex); // 0x0000000180F80070-0x0000000180F800D0
	private void OnStageLoaded(UIUncraftingShopStageLoadedMessage inMessage); // 0x0000000180F80B00-0x0000000180F80B40
	private void OnStageInitialized(UIUncraftingShopStageInitializedMessage inMessage); // 0x0000000180F80AA0-0x0000000180F80B00
	protected virtual void OnItemCraftInitiated(Item inItem, int inQuantity); // 0x0000000180F803A0-0x0000000180F803E0
	protected virtual void OnItemUncrafted(ItemUncraftResponse inResponse); // 0x0000000180F804A0-0x0000000180F80770
	[AsyncStateMachine] // 0x00000001800F2D60-0x00000001800F2DB0
	private void OnItemSelected(Item inItem); // 0x0000000180F803E0-0x0000000180F804A0
}

