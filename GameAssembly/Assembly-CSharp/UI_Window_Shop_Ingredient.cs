/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using WW.Debug;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_Shop_Ingredient : UI_Window_Shop_CraftableItem // TypeDefIndex: 12243
{
	// Fields
	[Header] // 0x000000018011AC90-0x000000018011ACE0
	[SerializeField] // 0x000000018011AC90-0x000000018011ACE0
	private UI_StageSubjectPositioner _stagePositioner; // 0x150
	private UI_Stage_3DItem _itemStage; // 0x158

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 12244
	{
		// Fields
		public ShopContentDefComponent inShopDef; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0(UI_Window_Shop_Ingredient window); // 0x0000000180E9D8F0-0x0000000180E9D920
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass2_0 // TypeDefIndex: 12245
	{
		// Fields
		public ShopContentDefComponent inShopDef; // 0x10

		// Constructors
		public <>c__DisplayClass2_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x0000000180E9EB70-0x0000000180E9EC40
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <OnItemSelected>d__11 : IAsyncStateMachine // TypeDefIndex: 12246
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_Shop_Ingredient <>4__this; // 0x28
		public BaseDef inDef; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F07A0-0x00000001801F07B0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	// Constructors
	public UI_Window_Shop_Ingredient(); // 0x0000000180EB0020-0x0000000180EB0070

	// Methods
	[DebugButton] // 0x000000018011B6B0-0x000000018011B710
	public static void OpenWindow(); // 0x0000000180EB1150-0x0000000180EB1210
	public static new void OpenWindow(ShopContentDefComponent inShopDef = null); // 0x0000000180EB1090-0x0000000180EB1150
	public static new void QueueWindow(ShopContentDefComponent inShopDef = null); // 0x0000000180EB1210-0x0000000180EB12D0
	public static new void CloseWindow(); // 0x0000000180EB0CA0-0x0000000180EB0CF0
	public override void Setup(ShopContentDefComponent inShopDef = null); // 0x0000000180EAE810-0x0000000180EAE820
	protected override void OnOpen(); // 0x0000000180EB0F20-0x0000000180EB1090
	protected override void OnClose(bool inAnimate); // 0x0000000180EB0CF0-0x0000000180EB0E60
	private void OnStageLoaded(UI3DItemStageLoadedMessage inMessage); // 0x0000000180EB0A10-0x0000000180EB0A60
	private void OnStageInitialized(UI3DItemStageInitializedMessage inMessage); // 0x0000000180EB09B0-0x0000000180EB0A10
	[AsyncStateMachine] // 0x000000018011B810-0x000000018011B860
	private void OnItemSelected(BaseDef inDef); // 0x0000000180EB0E60-0x0000000180EB0F20
}

