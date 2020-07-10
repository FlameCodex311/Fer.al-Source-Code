/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using WW.Debug;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_Shop_Furniture : UI_Window_Shop_CraftableItem // TypeDefIndex: 12239
{
	// Fields
	[Header] // 0x000000018011AC90-0x000000018011ACE0
	[SerializeField] // 0x000000018011AC90-0x000000018011ACE0
	private UI_StageSubjectPositioner _stagePositioner; // 0x150
	private UI_Stage_3DItem _itemStage; // 0x158

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 12240
	{
		// Fields
		public ShopContentDefComponent inShopDef; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0(UI_Window_Shop_Furniture window); // 0x0000000180E9D8F0-0x0000000180E9D920
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass2_0 // TypeDefIndex: 12241
	{
		// Fields
		public ShopContentDefComponent inShopDef; // 0x10

		// Constructors
		public <>c__DisplayClass2_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x0000000180E9EAA0-0x0000000180E9EB70
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <OnItemSelected>d__11 : IAsyncStateMachine // TypeDefIndex: 12242
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_Shop_Furniture <>4__this; // 0x28
		public BaseDef inDef; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F0790-0x00000001801F07A0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	// Constructors
	public UI_Window_Shop_Furniture(); // 0x0000000180EB0020-0x0000000180EB0070

	// Methods
	[DebugButton] // 0x000000018011AE20-0x000000018011AE80
	public static void OpenWindow(); // 0x0000000180EB0B20-0x0000000180EB0BE0
	public static new void OpenWindow(ShopContentDefComponent inShopDef = null); // 0x0000000180EB0A60-0x0000000180EB0B20
	public static new void QueueWindow(ShopContentDefComponent inShopDef = null); // 0x0000000180EB0BE0-0x0000000180EB0CA0
	public static new void CloseWindow(); // 0x0000000180EB05C0-0x0000000180EB0610
	public override void Setup(ShopContentDefComponent inShopDef = null); // 0x0000000180EAE810-0x0000000180EAE820
	protected override void OnOpen(); // 0x0000000180EB0840-0x0000000180EB09B0
	protected override void OnClose(bool inAnimate); // 0x0000000180EB0610-0x0000000180EB0780
	private void OnStageLoaded(UI3DItemStageLoadedMessage inMessage); // 0x0000000180EB0A10-0x0000000180EB0A60
	private void OnStageInitialized(UI3DItemStageInitializedMessage inMessage); // 0x0000000180EB09B0-0x0000000180EB0A10
	[AsyncStateMachine] // 0x000000018011B060-0x000000018011B0B0
	private void OnItemSelected(BaseDef inDef); // 0x0000000180EB0780-0x0000000180EB0840
}

