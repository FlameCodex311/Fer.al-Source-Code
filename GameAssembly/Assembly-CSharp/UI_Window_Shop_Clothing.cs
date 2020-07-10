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

public class UI_Window_Shop_Clothing : UI_Window_Shop_CraftableItem // TypeDefIndex: 12226
{
	// Fields
	[Header] // 0x0000000180115C60-0x0000000180115CB0
	[SerializeField] // 0x0000000180115C60-0x0000000180115CB0
	private UI_AvatarPositioner _avatarPositioner; // 0x150
	private UI_Stage_Avatar _avatarStage; // 0x158
	private List<ActorInfoClothingItem> _removedItems; // 0x160
	private ActorInfoClothingItem _attachedItem; // 0x168

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 12227
	{
		// Fields
		public ShopContentDefComponent inShopDef; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0(UI_Window_Shop_Clothing window); // 0x0000000180E9D8F0-0x0000000180E9D920
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass2_0 // TypeDefIndex: 12228
	{
		// Fields
		public ShopContentDefComponent inShopDef; // 0x10

		// Constructors
		public <>c__DisplayClass2_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x0000000180E9ED10-0x0000000180E9EDE0
	}

	// Constructors
	public UI_Window_Shop_Clothing(); // 0x0000000180EAF1D0-0x0000000180EAF260

	// Methods
	[DebugButton] // 0x0000000180117110-0x0000000180117170
	public static void OpenWindow(); // 0x0000000180EAF050-0x0000000180EAF110
	public static new void OpenWindow(ShopContentDefComponent inShopDef); // 0x0000000180EAEF90-0x0000000180EAF050
	public static new void QueueWindow(ShopContentDefComponent inShopDef = null); // 0x0000000180EAF110-0x0000000180EAF1D0
	public static new void CloseWindow(); // 0x0000000180EAE8B0-0x0000000180EAE900
	public override void Setup(ShopContentDefComponent inShopDef = null); // 0x0000000180EAE810-0x0000000180EAE820
	protected override void OnOpen(); // 0x0000000180EAEE20-0x0000000180EAEF90
	protected override void OnClose(bool inAnimate); // 0x0000000180EAE900-0x0000000180EAEA70
	private void OnAvatarStageLoaded(UIAvatarStageLoadedMessage inMessage); // 0x0000000180EADEF0-0x0000000180EADF40
	private void OnAvatarStageInitialized(UIAvatarStageInitializedMessage inMessage); // 0x0000000180EADE90-0x0000000180EADEF0
	private void OnClothingItemSelected(BaseDef inDef); // 0x0000000180EAEA70-0x0000000180EAEE20
}

