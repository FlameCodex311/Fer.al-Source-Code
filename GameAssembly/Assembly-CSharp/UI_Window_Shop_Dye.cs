/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using WW.Debug;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_Shop_Dye : UI_Window_Shop_CraftableItem // TypeDefIndex: 13786
{
	// Fields
	private UI_Stage_DyeShop _stage; // 0x150

	// Properties
	public UI_Stage_DyeShop Stage { get; } // 0x0000000180449A60-0x0000000180449A70 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 13787
	{
		// Fields
		public ShopContentDefComponent inShopDef; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0(UI_Window_Shop_Dye window); // 0x00000001803B3060-0x00000001803B3090
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass2_0 // TypeDefIndex: 13788
	{
		// Fields
		public ShopContentDefComponent inShopDef; // 0x10

		// Constructors
		public <>c__DisplayClass2_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x00000001804481D0-0x00000001804482A0
	}

	// Constructors
	public UI_Window_Shop_Dye(); // 0x00000001804494C0-0x0000000180449510

	// Methods
	[DebugButton] // 0x0000000180200B70-0x0000000180200BD0
	public static void OpenWindow(); // 0x00000001804498E0-0x00000001804499A0
	public static new void OpenWindow(ShopContentDefComponent inShopDef = null); // 0x0000000180449820-0x00000001804498E0
	public static new void QueueWindow(ShopContentDefComponent inShopDef = null); // 0x00000001804499A0-0x0000000180449A60
	public static new void CloseWindow(); // 0x0000000180449510-0x0000000180449560
	public override void Setup(ShopContentDefComponent inShopDef = null); // 0x00000001803C4BB0-0x00000001803C4BC0
	protected override void OnOpen(); // 0x00000001804496C0-0x00000001804497F0
	protected override void OnClose(bool inAnimate); // 0x0000000180449560-0x0000000180449690
	private void OnStageLoaded(UIDyeShopStageLoadedMessage inMessage); // 0x00000001804497F0-0x0000000180449820
	private void OnItemSelected(BaseDef inDef); // 0x0000000180449690-0x00000001804496C0
	protected override void OnItemCraftInitiated(BaseDef inDef, int inQuantity); // 0x0000000180448AF0-0x0000000180448B70
	protected override void OnItemCrafted(BuyItemResponse inMessage); // 0x0000000180448B70-0x0000000180448CB0
}

