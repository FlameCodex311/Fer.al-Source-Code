/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using WW.Debug;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_Shop_Uncrafting : UI_Window // TypeDefIndex: 14208
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_TabGroup _tabGroup; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyItemList_UncraftingShop[] _itemLists; // 0x110
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_StageSubjectPositioner _stagePositioner; // 0x118
	private UI_Stage_UncraftingShop _stage; // 0x120
	private Item _itemBeingUncrafted; // 0x128
	private int _quantityBeingUncrafted; // 0x130

	// Properties
	public UI_Stage_UncraftingShop Stage { get; } // 0x00000001803EF220-0x00000001803EF230 

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 14209
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_Shop_Uncrafting> <>9__0_0; // 0x08
		public static Action<UI_Window> <>9__1_0; // 0x10

		// Constructors
		static <>c(); // 0x0000000180448620-0x0000000180448680
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0_0(UI_Window_Shop_Uncrafting window); // 0x00000001803B24A0-0x00000001803B24C0
		internal void <QueueWindow>b__1_0(UI_Window inWindow); // 0x00000001804467A0-0x0000000180446820
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass14_0 // TypeDefIndex: 14210
	{
		// Fields
		public int frameCount; // 0x10
		public UI_Window_Shop_Uncrafting <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass14_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <DoDelayedOpenAnimation>b__0(); // 0x0000000180446FD0-0x0000000180447090
		internal void <DoDelayedOpenAnimation>b__1(); // 0x0000000180447090-0x0000000180447100
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <OnItemSelected>d__21 : IAsyncStateMachine // TypeDefIndex: 14211
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_Shop_Uncrafting <>4__this; // 0x28
		public Item inItem; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001800046F0-0x0000000180004700
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Constructors
	public UI_Window_Shop_Uncrafting(); // 0x00000001803B50E0-0x00000001803B50F0

	// Methods
	[DebugButton] // 0x00000001801E42A0-0x00000001801E4300
	public static void OpenWindow(); // 0x000000018044CA30-0x000000018044CB30
	public static void QueueWindow(); // 0x000000018044CB30-0x000000018044CC30
	public static void CloseWindow(); // 0x000000018044BE20-0x000000018044BE70
	private void Setup(); // 0x00000001803774A0-0x00000001803774B0
	protected override void OnOpen(); // 0x000000018044C620-0x000000018044C990
	protected override void OnClose(bool inAnimate); // 0x000000018044BF50-0x000000018044C260
	protected override void DoDelayedOpenAnimation(); // 0x000000018044BE70-0x000000018044BF50
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
	private void OnCategoryTabSelected(int inTabIndex); // 0x00000001803774A0-0x00000001803774B0
	private void OnStageLoaded(UIUncraftingShopStageLoadedMessage inMessage); // 0x000000018044C9F0-0x000000018044CA30
	private void OnStageInitialized(UIUncraftingShopStageInitializedMessage inMessage); // 0x000000018044C990-0x000000018044C9F0
	protected virtual void OnItemCraftInitiated(Item inItem, int inQuantity); // 0x000000018044C260-0x000000018044C2A0
	protected virtual void OnItemUncrafted(ItemUncraftResponse inResponse); // 0x000000018044C360-0x000000018044C620
	[AsyncStateMachine] // 0x00000001801E4570-0x00000001801E45C0
	private void OnItemSelected(Item inItem); // 0x000000018044C2A0-0x000000018044C360
}

