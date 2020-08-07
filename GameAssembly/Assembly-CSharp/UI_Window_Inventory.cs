/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_Inventory : UI_Window // TypeDefIndex: 14107
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_TabGroup _categoryTabGroup; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<UI_LazyItemList_ItemInventory> _itemLists; // 0x110
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyItemList_MiscItemInventory _miscItemList; // 0x118
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyListItemDetailPanel_ItemInventory _detailPanel; // 0x120
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_StageSubjectPositioner _stagePositioner; // 0x128
	private ActorInfo _currentActorInfoDraft; // 0x130
	private UI_Stage_3DItem _itemStage; // 0x138
	private bool _stageIsInitialized; // 0x140

	// Properties
	public ActorInfo CurrentActorInfoDraft { get; } // 0x0000000180383C00-0x0000000180383C10 

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 14108
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_Inventory> <>9__0_0; // 0x08
		public static Action<UI_Window> <>9__1_0; // 0x10

		// Constructors
		static <>c(); // 0x00000001803E2A30-0x00000001803E2A90
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0_0(UI_Window_Inventory window); // 0x00000001803B24A0-0x00000001803B24C0
		internal void <QueueWindow>b__1_0(UI_Window inWindow); // 0x00000001803E1120-0x00000001803E11A0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <OnItemSelected>d__23 : IAsyncStateMachine // TypeDefIndex: 14109
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_Inventory <>4__this; // 0x28
		public Item inItem; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x0000000180002680-0x0000000180002690
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Constructors
	public UI_Window_Inventory(); // 0x00000001803EB3D0-0x00000001803EB440

	// Methods
	public static void OpenWindow(); // 0x00000001803EB150-0x00000001803EB250
	public static void QueueWindow(); // 0x00000001803EB250-0x00000001803EB350
	public static void CloseWindow(); // 0x00000001803EA530-0x00000001803EA580
	private void Setup(); // 0x00000001803774A0-0x00000001803774B0
	protected override void OnOpen(); // 0x00000001803EAB10-0x00000001803EAF90
	protected override void DoDelayedOpenAnimation(); // 0x00000001803EA580-0x00000001803EA620
	protected override void OnClose(bool inAnimate); // 0x00000001803EA6F0-0x00000001803EA9B0
	protected override void OnHide(); // 0x00000001803EA9B0-0x00000001803EA9F0
	protected override void OnShow(); // 0x00000001803EAF90-0x00000001803EAFD0
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
	private void OnStageLoaded(UI3DItemStageLoadedMessage inMessage); // 0x00000001803EB0A0-0x00000001803EB150
	private void OnStageInitialized(UI3DItemStageInitializedMessage inMessage); // 0x00000001803EAFD0-0x00000001803EB0A0
	private void OnItemDyeResponse(ItemDyeResponse message); // 0x00000001803EA9F0-0x00000001803EAA50
	[AsyncStateMachine] // 0x0000000180284060-0x00000001802840B0
	private void OnItemSelected(Item inItem); // 0x00000001803EAA50-0x00000001803EAB10
	private void OnCategoryTabSelected(int inTabIndex); // 0x00000001803EA620-0x00000001803EA6F0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <DoDelayedOpenAnimation>b__15_0(); // 0x00000001803EB350-0x00000001803EB3D0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <DoDelayedOpenAnimation>b__15_1(); // 0x00000001803B6890-0x00000001803B68B0
}

