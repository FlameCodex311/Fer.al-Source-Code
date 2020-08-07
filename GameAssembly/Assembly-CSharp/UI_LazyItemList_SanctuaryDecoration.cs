/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyItemList_SanctuaryDecoration : UI_LazyItemList<Item> // TypeDefIndex: 13660
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyListItem_SanctuaryDecoration _itemPrefab; // 0xE8
	private List<Item> _inventoryItems; // 0xF0
	private string _equippedCategory; // 0xF8

	// Properties
	private string EquippedCategory { get; } // 0x000000018038DF20-0x000000018038DFF0 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass21_0 // TypeDefIndex: 13661
	{
		// Fields
		public string itemId; // 0x10

		// Constructors
		public <>c__DisplayClass21_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <OnInventoryListRemoved>b__0(Item item); // 0x0000000180387C90-0x0000000180387CC0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass22_0 // TypeDefIndex: 13662
	{
		// Fields
		public Item item; // 0x10

		// Constructors
		public <>c__DisplayClass22_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <OnInventoryList>b__0(UI_LazyItemList<Item> itemToCheck); // 0x0000000180387CC0-0x0000000180387D10
	}

	// Constructors
	public UI_LazyItemList_SanctuaryDecoration(); // 0x000000018038DEE0-0x000000018038DF20

	// Methods
	public void Setup(List<Item> inItems); // 0x000000018038DA20-0x000000018038DAA0
	public void SetupDefault(); // 0x000000018037F800-0x000000018037F820
	protected override void Setup(); // 0x000000018038DAA0-0x000000018038DEA0
	protected virtual void OnDestroy(); // 0x000000018038CF90-0x000000018038D290
	protected override List<string> GetDataItemFilters(Item inData); // 0x000000018038CA20-0x000000018038CAA0
	protected override long GetDataItemAge(Item inData); // 0x000000018038C900-0x000000018038CA20
	protected override bool GetDataItemFav(Item inData); // 0x0000000180380950-0x0000000180380960
	protected override string GetDataItemName(Item inData); // 0x000000018038CAC0-0x000000018038CB30
	protected override int GetDataItemRarity(Item inData); // 0x000000018038CB30-0x000000018038CB90
	protected override string GetDataItemId(Item inData); // 0x000000018038CAA0-0x000000018038CAC0
	protected override void SortData(); // 0x000000018038DEA0-0x000000018038DEE0
	protected override UI_LazyListItemDetailPanel<Item> GetDetailPanelReference(); // 0x000000018037DDC0-0x000000018037DDD0
	protected override List<Item> GetDataItems(); // 0x000000018037DDB0-0x000000018037DDC0
	protected override UI_LazyListItem<Item> GetListItemPrefab(); // 0x000000018037DDD0-0x000000018037DDE0
	protected override bool ItemMatchesCategory(LazyListItem<Item> inItem); // 0x000000018038CB90-0x000000018038CCE0
	protected override bool ItemMatchesFilter(LazyListItem<Item> inItem, string inFilterCategory); // 0x000000018038CCE0-0x000000018038CEF0
	private void OnInventoryListRemoved(InventoryListRemovedResponse inMessage); // 0x000000018038D290-0x000000018038D3D0
	private void OnInventoryList(InventoryListResponse inMessage); // 0x000000018038D3D0-0x000000018038D640
	private void ItemSelected(Item inSelectedItem); // 0x000000018038CEF0-0x000000018038CF90
	private void RefreshAll(); // 0x000000018038D8F0-0x000000018038DA20
	private void OnSanctuaryObjectRemoved(SanctuaryObjectBase inSanctuaryObject); // 0x000000018038D7E0-0x000000018038D8F0
	private void OnSanctuaryObjectAdded(SanctuaryObjectBase inSanctuaryObject); // 0x000000018038D6F0-0x000000018038D7E0
	private void OnSanctuaryItemAdded(SanctuaryAddMessage inMessage); // 0x000000018038D650-0x000000018038D6A0
	private void OnSanctuaryItemRemoved(SanctuaryRemoveMessage inMessage); // 0x000000018038D6A0-0x000000018038D6F0
	private void OnSanctuaryIndoorRoom(SanctuaryIndoorRoomMessage inMessage); // 0x000000018038D640-0x000000018038D650
	private void OnSanctuaryInteriorExteriorChange(SanctuaryInteriorExteriorChange inMessage); // 0x000000018038D640-0x000000018038D650
}

