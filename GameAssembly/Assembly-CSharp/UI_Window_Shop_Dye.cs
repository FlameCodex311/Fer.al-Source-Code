/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using WW.Debug;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_Shop_Dye : UI_Window_Shop_CraftableItem // TypeDefIndex: 12236
{
	// Fields
	private UI_Stage_DyeShop _stage; // 0x150

	// Properties
	public UI_Stage_DyeShop Stage { get; } // 0x00000001803BD340-0x00000001803BD350 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 12237
	{
		// Fields
		public ShopContentDefComponent inShopDef; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0(UI_Window_Shop_Dye window); // 0x0000000180E9D8F0-0x0000000180E9D920
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass2_0 // TypeDefIndex: 12238
	{
		// Fields
		public ShopContentDefComponent inShopDef; // 0x10

		// Constructors
		public <>c__DisplayClass2_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x0000000180E9EDE0-0x0000000180E9EEB0
	}

	// Constructors
	public UI_Window_Shop_Dye(); // 0x0000000180EB0020-0x0000000180EB0070

	// Methods
	[DebugButton] // 0x000000018011A810-0x000000018011A870
	public static void OpenWindow(); // 0x0000000180EB0440-0x0000000180EB0500
	public static new void OpenWindow(ShopContentDefComponent inShopDef = null); // 0x0000000180EB0380-0x0000000180EB0440
	public static new void QueueWindow(ShopContentDefComponent inShopDef = null); // 0x0000000180EB0500-0x0000000180EB05C0
	public static new void CloseWindow(); // 0x0000000180EB0070-0x0000000180EB00C0
	public override void Setup(ShopContentDefComponent inShopDef = null); // 0x0000000180EAE810-0x0000000180EAE820
	protected override void OnOpen(); // 0x0000000180EB0220-0x0000000180EB0350
	protected override void OnClose(bool inAnimate); // 0x0000000180EB00C0-0x0000000180EB01F0
	private void OnStageLoaded(UIDyeShopStageLoadedMessage inMessage); // 0x0000000180EB0350-0x0000000180EB0380
	private void OnItemSelected(BaseDef inDef); // 0x0000000180EB01F0-0x0000000180EB0220
	protected override void OnItemCraftInitiated(BaseDef inDef, int inQuantity); // 0x0000000180EAF610-0x0000000180EAF690
	protected override void OnItemCrafted(BuyItemResponse inMessage); // 0x0000000180EAF690-0x0000000180EAF7E0
}

