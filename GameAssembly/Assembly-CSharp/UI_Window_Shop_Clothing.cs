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

public class UI_Window_Shop_Clothing : UI_Window_Shop_CraftableItem // TypeDefIndex: 13776
{
	// Fields
	[Header] // 0x00000001801FE680-0x00000001801FE6D0
	[SerializeField] // 0x00000001801FE680-0x00000001801FE6D0
	private UI_AvatarPositioner _avatarPositioner; // 0x150
	private UI_Stage_Avatar _avatarStage; // 0x158
	private List<ActorInfoClothingItem> _removedItems; // 0x160
	private ActorInfoClothingItem _attachedItem; // 0x168

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 13777
	{
		// Fields
		public ShopContentDefComponent inShopDef; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0(UI_Window_Shop_Clothing window); // 0x00000001803B3060-0x00000001803B3090
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass2_0 // TypeDefIndex: 13778
	{
		// Fields
		public ShopContentDefComponent inShopDef; // 0x10

		// Constructors
		public <>c__DisplayClass2_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x0000000180448030-0x0000000180448100
	}

	// Constructors
	public UI_Window_Shop_Clothing(); // 0x00000001803C5540-0x00000001803C55B0

	// Methods
	[DebugButton] // 0x00000001801FE940-0x00000001801FE9A0
	public static void OpenWindow(); // 0x00000001803C53C0-0x00000001803C5480
	public static new void OpenWindow(ShopContentDefComponent inShopDef); // 0x00000001803C5300-0x00000001803C53C0
	public static new void QueueWindow(ShopContentDefComponent inShopDef = null); // 0x00000001803C5480-0x00000001803C5540
	public static new void CloseWindow(); // 0x00000001803C4C30-0x00000001803C4C80
	public override void Setup(ShopContentDefComponent inShopDef = null); // 0x00000001803C4BB0-0x00000001803C4BC0
	protected override void OnOpen(); // 0x00000001803C5190-0x00000001803C5300
	protected override void OnClose(bool inAnimate); // 0x00000001803C4C80-0x00000001803C4DF0
	private void OnAvatarStageLoaded(UIAvatarStageLoadedMessage inMessage); // 0x00000001803C42A0-0x00000001803C42F0
	private void OnAvatarStageInitialized(UIAvatarStageInitializedMessage inMessage); // 0x00000001803C4240-0x00000001803C42A0
	private void OnClothingItemSelected(BaseDef inDef); // 0x00000001803C4DF0-0x00000001803C5190
}

