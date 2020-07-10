/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyItemList_SanctuaryDecoration : UI_LazyItemList<Item> // TypeDefIndex: 12114
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyListItem_SanctuaryDecoration _itemPrefab; // 0xE8
	private List<Item> _inventoryItems; // 0xF0
	private string _equippedCategory; // 0xF8

	// Properties
	private string EquippedCategory { get; } // 0x0000000180E5C5B0-0x0000000180E5C680 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass19_0 // TypeDefIndex: 12115
	{
		// Fields
		public string itemId; // 0x10

		// Constructors
		public <>c__DisplayClass19_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <OnInventoryListRemoved>b__0(Item item); // 0x0000000180E3BE80-0x0000000180E3BEB0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass20_0 // TypeDefIndex: 12116
	{
		// Fields
		public Item item; // 0x10

		// Constructors
		public <>c__DisplayClass20_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <OnInventoryList>b__0(UI_LazyItemList<Item> itemToCheck); // 0x0000000180E3E810-0x0000000180E3E860
	}

	// Constructors
	public UI_LazyItemList_SanctuaryDecoration(); // 0x0000000180E5C570-0x0000000180E5C5B0

	// Methods
	public void Setup(List<Item> inItems); // 0x0000000180E5C0B0-0x0000000180E5C130
	public void SetupDefault(); // 0x00000001806A3950-0x00000001806A3970
	protected override void Setup(); // 0x0000000180E5C130-0x0000000180E5C530
	protected virtual void OnDestroy(); // 0x0000000180E5B5F0-0x0000000180E5B8F0
	protected override long GetDataItemAge(Item inData); // 0x0000000180E5AFE0-0x0000000180E5B100
	protected override bool GetDataItemFav(Item inData); // 0x00000001803C28F0-0x00000001803C2900
	protected override string GetDataItemName(Item inData); // 0x0000000180E5B100-0x0000000180E5B170
	protected override int GetDataItemRarity(Item inData); // 0x0000000180E5B170-0x0000000180E5B1D0
	protected override void SortData(); // 0x0000000180E5C530-0x0000000180E5C570
	protected override UI_LazyListItemDetailPanel<Item> GetDetailPanelReference(); // 0x000000018035FCC0-0x000000018035FCD0
	protected override List<Item> GetDataItems(); // 0x00000001803BD320-0x00000001803BD330
	protected override UI_LazyListItem<Item> GetListItemPrefab(); // 0x000000018037A250-0x000000018037A260
	protected override bool ItemMatchesCategory(LazyListItem<Item> inItem); // 0x0000000180E5B1D0-0x0000000180E5B330
	protected override bool ItemMatchesFilter(LazyListItem<Item> inItem, string inFilterCategory); // 0x0000000180E5B330-0x0000000180E5B550
	private void OnInventoryListRemoved(InventoryListRemovedResponse inMessage); // 0x0000000180E5B8F0-0x0000000180E5BA40
	private void OnInventoryList(InventoryListResponse inMessage); // 0x0000000180E5BA40-0x0000000180E5BCC0
	private void ItemSelected(Item inSelectedItem); // 0x0000000180E5B550-0x0000000180E5B5F0
	private void RefreshAll(); // 0x0000000180E5BF70-0x0000000180E5C0B0
	private void OnSanctuaryObjectRemoved(SanctuaryObjectBase inSanctuaryObject); // 0x0000000180E5BE60-0x0000000180E5BF70
	private void OnSanctuaryObjectAdded(SanctuaryObjectBase inSanctuaryObject); // 0x0000000180E5BD70-0x0000000180E5BE60
	private void OnSanctuaryItemAdded(SanctuaryAddMessage inMessage); // 0x0000000180E5BCD0-0x0000000180E5BD20
	private void OnSanctuaryItemRemoved(SanctuaryRemoveMessage inMessage); // 0x0000000180E5BD20-0x0000000180E5BD70
	private void OnSanctuaryIndoorRoom(SanctuaryIndoorRoomMessage inMessage); // 0x0000000180E5BCC0-0x0000000180E5BCD0
	private void OnSanctuaryInteriorExteriorChange(SanctuaryInteriorExteriorChange inMessage); // 0x0000000180E5BCC0-0x0000000180E5BCD0
}

