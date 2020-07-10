/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x000000018012C770-0x000000018012C7D0
	[Description] // 0x000000018012C770-0x000000018012C7D0
	public class UpdateItemInInventory : NetworkActionTask // TypeDefIndex: 14465
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
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<bool> anyUnlocked; // 0xB0
	
		// Properties
		protected override string info { get; } // 0x00000001812688C0-0x00000001812689C0 
	
		// Nested types
		public enum EUpdateType // TypeDefIndex: 14466
		{
			Unlock = 1,
			Increment = 2,
			Decrement = 3
		}
	
		public enum EItemType // TypeDefIndex: 14467
		{
			Enigma = 1,
			SocialExpanseLockpick = 2,
			SocialExpanseChest = 3,
			Inspiration = 4
		}
	
		// Constructors
		public UpdateItemInInventory(); // 0x00000001812688A0-0x00000001812688C0
	
		// Methods
		protected override void OnExecute(); // 0x0000000181268650-0x0000000181268700
		private void OnInventoryShopUnlock(ShopUnlockItemResponse inMessage); // 0x0000000181268700-0x0000000181268800
		private void OnInventoryUpdated(InventoryListResponse inMessage); // 0x0000000181268800-0x00000001812688A0
	}
}
