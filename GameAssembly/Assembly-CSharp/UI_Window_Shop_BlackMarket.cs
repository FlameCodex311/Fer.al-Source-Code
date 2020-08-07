/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using WW.Debug;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_Shop_BlackMarket : UI_Window_Shop_CraftableItem // TypeDefIndex: 13773
{
	// Fields
	[Header] // 0x00000001801FDDA0-0x00000001801FDDF0
	[SerializeField] // 0x00000001801FDDA0-0x00000001801FDDF0
	private UI_AvatarPositioner _avatarPositioner; // 0x150
	private UI_Stage_Avatar _avatarStage; // 0x158
	private List<ActorInfoClothingItem> _removedItems; // 0x160
	private ActorInfoClothingItem _attachedItem; // 0x168

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 13774
	{
		// Fields
		public ShopContentDefComponent inShopDef; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0(UI_Window_Shop_BlackMarket window); // 0x00000001803B3060-0x00000001803B3090
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass2_0 // TypeDefIndex: 13775
	{
		// Fields
		public ShopContentDefComponent inShopDef; // 0x10

		// Constructors
		public <>c__DisplayClass2_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x00000001803B3C00-0x00000001803B3CD0
	}

	// Constructors
	public UI_Window_Shop_BlackMarket(); // 0x00000001803C4BC0-0x00000001803C4C30

	// Methods
	[DebugButton] // 0x00000001801FE000-0x00000001801FE060
	public static void OpenWindow(); // 0x00000001803C4A30-0x00000001803C4AF0
	public static new void OpenWindow(ShopContentDefComponent inShopDef = null); // 0x00000001803C4970-0x00000001803C4A30
	public static new void QueueWindow(ShopContentDefComponent inShopDef = null); // 0x00000001803C4AF0-0x00000001803C4BB0
	public static new void CloseWindow(); // 0x00000001803C41F0-0x00000001803C4240
	public override void Setup(ShopContentDefComponent inShopDef = null); // 0x00000001803C4BB0-0x00000001803C4BC0
	protected override void OnOpen(); // 0x00000001803C4800-0x00000001803C4970
	protected override void OnClose(bool inAnimate); // 0x00000001803C42F0-0x00000001803C4460
	private void OnAvatarStageLoaded(UIAvatarStageLoadedMessage inMessage); // 0x00000001803C42A0-0x00000001803C42F0
	private void OnAvatarStageInitialized(UIAvatarStageInitializedMessage inMessage); // 0x00000001803C4240-0x00000001803C42A0
	private void OnClothingItemSelected(BaseDef inDef); // 0x00000001803C4460-0x00000001803C4800
}

