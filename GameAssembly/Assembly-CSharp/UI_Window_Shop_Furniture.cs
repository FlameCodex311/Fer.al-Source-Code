/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using WW.Debug;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_Shop_Furniture : UI_Window_Shop_CraftableItem // TypeDefIndex: 13789
{
	// Fields
	[Header] // 0x0000000180201050-0x00000001802010A0
	[SerializeField] // 0x0000000180201050-0x00000001802010A0
	private UI_StageSubjectPositioner _stagePositioner; // 0x150
	private UI_Stage_3DItem _itemStage; // 0x158

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 13790
	{
		// Fields
		public ShopContentDefComponent inShopDef; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0(UI_Window_Shop_Furniture window); // 0x00000001803B3060-0x00000001803B3090
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass2_0 // TypeDefIndex: 13791
	{
		// Fields
		public ShopContentDefComponent inShopDef; // 0x10

		// Constructors
		public <>c__DisplayClass2_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x0000000180447CF0-0x0000000180447DC0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <OnItemSelected>d__11 : IAsyncStateMachine // TypeDefIndex: 13792
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_Shop_Furniture <>4__this; // 0x28
		public BaseDef inDef; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001800046D0-0x00000001800046E0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Constructors
	public UI_Window_Shop_Furniture(); // 0x00000001804494C0-0x0000000180449510

	// Methods
	[DebugButton] // 0x0000000180202550-0x00000001802025B0
	public static void OpenWindow(); // 0x0000000180449FD0-0x000000018044A090
	public static new void OpenWindow(ShopContentDefComponent inShopDef = null); // 0x0000000180449F10-0x0000000180449FD0
	public static new void QueueWindow(ShopContentDefComponent inShopDef = null); // 0x000000018044A090-0x000000018044A150
	public static new void CloseWindow(); // 0x0000000180449A70-0x0000000180449AC0
	public override void Setup(ShopContentDefComponent inShopDef = null); // 0x00000001803C4BB0-0x00000001803C4BC0
	protected override void OnOpen(); // 0x0000000180449CF0-0x0000000180449E60
	protected override void OnClose(bool inAnimate); // 0x0000000180449AC0-0x0000000180449C30
	private void OnStageLoaded(UI3DItemStageLoadedMessage inMessage); // 0x0000000180449EC0-0x0000000180449F10
	private void OnStageInitialized(UI3DItemStageInitializedMessage inMessage); // 0x0000000180449E60-0x0000000180449EC0
	[AsyncStateMachine] // 0x0000000180202740-0x0000000180202790
	private void OnItemSelected(BaseDef inDef); // 0x0000000180449C30-0x0000000180449CF0
}

