/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using WW.Debug;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_Shop_BlackMarket : UI_Window_Shop_CraftableItem // TypeDefIndex: 12223
{
	// Fields
	[Header] // 0x00000001801155B0-0x0000000180115600
	[SerializeField] // 0x00000001801155B0-0x0000000180115600
	private UI_AvatarPositioner _avatarPositioner; // 0x150
	private UI_Stage_Avatar _avatarStage; // 0x158
	private List<ActorInfoClothingItem> _removedItems; // 0x160
	private ActorInfoClothingItem _attachedItem; // 0x168

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 12224
	{
		// Fields
		public ShopContentDefComponent inShopDef; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0(UI_Window_Shop_BlackMarket window); // 0x0000000180E9D8F0-0x0000000180E9D920
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass2_0 // TypeDefIndex: 12225
	{
		// Fields
		public ShopContentDefComponent inShopDef; // 0x10

		// Constructors
		public <>c__DisplayClass2_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x0000000180E9E9D0-0x0000000180E9EAA0
	}

	// Constructors
	public UI_Window_Shop_BlackMarket(); // 0x0000000180EAE820-0x0000000180EAE8B0

	// Methods
	[DebugButton] // 0x0000000180115820-0x0000000180115880
	public static void OpenWindow(); // 0x0000000180EAE690-0x0000000180EAE750
	public static new void OpenWindow(ShopContentDefComponent inShopDef = null); // 0x0000000180EAE5D0-0x0000000180EAE690
	public static new void QueueWindow(ShopContentDefComponent inShopDef = null); // 0x0000000180EAE750-0x0000000180EAE810
	public static new void CloseWindow(); // 0x0000000180EADE40-0x0000000180EADE90
	public override void Setup(ShopContentDefComponent inShopDef = null); // 0x0000000180EAE810-0x0000000180EAE820
	protected override void OnOpen(); // 0x0000000180EAE460-0x0000000180EAE5D0
	protected override void OnClose(bool inAnimate); // 0x0000000180EADF40-0x0000000180EAE0B0
	private void OnAvatarStageLoaded(UIAvatarStageLoadedMessage inMessage); // 0x0000000180EADEF0-0x0000000180EADF40
	private void OnAvatarStageInitialized(UIAvatarStageInitializedMessage inMessage); // 0x0000000180EADE90-0x0000000180EADEF0
	private void OnClothingItemSelected(BaseDef inDef); // 0x0000000180EAE0B0-0x0000000180EAE460
}

