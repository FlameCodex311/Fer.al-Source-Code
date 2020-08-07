/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x00000001801CE830-0x00000001801CE890
	[Description] // 0x00000001801CE830-0x00000001801CE890
	public class UpdateItemInInventory : NetworkActionTask // TypeDefIndex: 15571
	{
		// Fields
		public EUpdateType updateType; // 0x68
		public EItemType itemType; // 0x6C
		public string listName; // 0x70
		public string listDefID; // 0x78
		public string shopName; // 0x80
		public string shopDefID; // 0x88
		public string inspirationName; // 0x90
		public string inspirationDefId; // 0x98
		public NetworkedObjectInfo socialExpanseAcquiredLockpick; // 0xA0
		public NetworkedObjectInfo socialExpanseUnlockedChest; // 0xA8
		public NetworkedObjectInfo socialExpanseRockFlip; // 0xB0
		public NetworkedObjectInfo socialExpanseDigSpot; // 0xB8
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<bool> anyUnlocked; // 0xC0
	
		// Properties
		protected override string info { get; } // 0x00000001807ACC00-0x00000001807ACD00 
	
		// Nested types
		public enum EUpdateType // TypeDefIndex: 15572
		{
			Unlock = 1,
			Increment = 2,
			Decrement = 3
		}
	
		public enum EItemType // TypeDefIndex: 15573
		{
			Enigma = 1,
			SocialExpanseLockpick = 2,
			SocialExpanseChest = 3,
			Inspiration = 4,
			RockFlip = 5,
			DigSpot = 6
		}
	
		// Constructors
		public UpdateItemInInventory(); // 0x00000001807ACBE0-0x00000001807ACC00
	
		// Methods
		protected override void OnExecute(); // 0x00000001807AC990-0x00000001807ACA40
		private void OnInventoryShopUnlock(ShopUnlockItemResponse inMessage); // 0x00000001807ACA40-0x00000001807ACB40
		private void OnInventoryUpdated(InventoryListResponse inMessage); // 0x00000001807ACB40-0x00000001807ACBE0
	}
}
