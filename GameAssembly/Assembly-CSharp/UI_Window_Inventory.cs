/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_Inventory : UI_Window // TypeDefIndex: 12508
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_TabGroup _categoryTabGroup; // 0x108
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private List<UI_LazyItemList_ItemInventory> _itemLists; // 0x110
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyItemList_MiscItemInventory _miscItemList; // 0x118
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyListItemDetailPanel_ItemInventory _detailPanel; // 0x120
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_StageSubjectPositioner _stagePositioner; // 0x128
	private ActorInfo _currentActorInfoDraft; // 0x130
	private UI_Stage_3DItem _itemStage; // 0x138
	private bool _stageIsInitialized; // 0x140

	// Properties
	public ActorInfo CurrentActorInfoDraft { get; } // 0x00000001803BD390-0x00000001803BD3A0 

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12509
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_Inventory> <>9__0_0; // 0x08
		public static Action<UI_Window> <>9__1_0; // 0x10

		// Constructors
		static <>c(); // 0x0000000180ECF6F0-0x0000000180ECF750
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0_0(UI_Window_Inventory window); // 0x0000000180E9D080-0x0000000180E9D0A0
		internal void <QueueWindow>b__1_0(UI_Window inWindow); // 0x0000000180ECDBD0-0x0000000180ECDC50
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <OnItemSelected>d__23 : IAsyncStateMachine // TypeDefIndex: 12510
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_Inventory <>4__this; // 0x28
		public Item inItem; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F0FE0-0x00000001801F0FF0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	// Constructors
	public UI_Window_Inventory(); // 0x0000000180ED81C0-0x0000000180ED8230

	// Methods
	public static void OpenWindow(); // 0x0000000180ED7F40-0x0000000180ED8040
	public static void QueueWindow(); // 0x0000000180ED8040-0x0000000180ED8140
	public static void CloseWindow(); // 0x0000000180ED7300-0x0000000180ED7350
	private void Setup(); // 0x00000001803581E0-0x00000001803581F0
	protected override void OnOpen(); // 0x0000000180ED78F0-0x0000000180ED7D80
	protected override void DoDelayedOpenAnimation(); // 0x0000000180ED7350-0x0000000180ED73F0
	protected override void OnClose(bool inAnimate); // 0x0000000180ED74C0-0x0000000180ED7780
	protected override void OnHide(); // 0x0000000180ED7780-0x0000000180ED77C0
	protected override void OnShow(); // 0x0000000180ED7D80-0x0000000180ED7DC0
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
	private void OnStageLoaded(UI3DItemStageLoadedMessage inMessage); // 0x0000000180ED7E90-0x0000000180ED7F40
	private void OnStageInitialized(UI3DItemStageInitializedMessage inMessage); // 0x0000000180ED7DC0-0x0000000180ED7E90
	private void OnItemDyeResponse(ItemDyeResponse message); // 0x0000000180ED77C0-0x0000000180ED7830
	[AsyncStateMachine] // 0x00000001800CC8E0-0x00000001800CC930
	private void OnItemSelected(Item inItem); // 0x0000000180ED7830-0x0000000180ED78F0
	private void OnCategoryTabSelected(int inTabIndex); // 0x0000000180ED73F0-0x0000000180ED74C0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <DoDelayedOpenAnimation>b__15_0(); // 0x0000000180ED8140-0x0000000180ED81C0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <DoDelayedOpenAnimation>b__15_1(); // 0x00000001809E8060-0x00000001809E8080
}

