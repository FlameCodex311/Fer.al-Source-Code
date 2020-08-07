/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyItemList_MiscItemInventory : UI_LazyItemList<Item> // TypeDefIndex: 13623
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyListItemDetailPanel_Item _detailPanelPrefab; // 0xE8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyListItem_ItemInventory _itemPrefab; // 0xF0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RectTransform _categoryDescription; // 0xF8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _categorySpacer; // 0x100
	private List<Item> _inventoryItems; // 0x108

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass22_0 // TypeDefIndex: 13624
	{
		// Fields
		public string itemId; // 0x10

		// Constructors
		public <>c__DisplayClass22_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <OnInventoryListRemoved>b__0(Item item); // 0x0000000180387C90-0x0000000180387CC0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass23_0 // TypeDefIndex: 13625
	{
		// Fields
		public Item item; // 0x10

		// Constructors
		public <>c__DisplayClass23_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <OnInventoryList>b__0(UI_LazyItemList<Item> itemToCheck); // 0x0000000180387CC0-0x0000000180387D10
	}

	// Constructors
	public UI_LazyItemList_MiscItemInventory(); // 0x000000018038AD20-0x000000018038AD60

	// Methods
	public void Setup(List<Item> inItems); // 0x000000018038ACA0-0x000000018038AD20
	protected void OnDisable(); // 0x000000018038A5C0-0x000000018038A620
	public void SetupDefault(); // 0x000000018037F800-0x000000018037F820
	protected override void Setup(); // 0x000000018038AA30-0x000000018038ACA0
	protected virtual void OnDestroy(); // 0x000000018038A4F0-0x000000018038A5C0
	protected override void PostListFilter(int inShownItemsCount); // 0x000000018038A950-0x000000018038AA30
	protected override long GetDataItemAge(Item inData); // 0x000000018038A160-0x000000018038A280
	protected override bool GetDataItemFav(Item inData); // 0x0000000180380950-0x0000000180380960
	protected override string GetDataItemName(Item inData); // 0x000000018038A300-0x000000018038A370
	protected override List<string> GetDataItemFilters(Item inData); // 0x000000018038A280-0x000000018038A300
	protected override List<string> GetDataItemTags(Item inData); // 0x000000018038A3D0-0x000000018038A450
	protected override int GetDataItemRarity(Item inData); // 0x000000018038A370-0x000000018038A3D0
	protected override void SortData(); // 0x0000000180385910-0x0000000180385960
	protected override UI_LazyListItemDetailPanel<Item> GetDetailPanelReference(); // 0x000000018037DDD0-0x000000018037DDE0
	protected override List<Item> GetDataItems(); // 0x0000000180380B50-0x0000000180380B60
	protected override UI_LazyListItem<Item> GetListItemPrefab(); // 0x000000018037DDB0-0x000000018037DDC0
	protected override bool ItemMatchesCategory(LazyListItem<Item> inItem); // 0x0000000180380B60-0x0000000180380B70
	private void OnInventoryListRemoved(InventoryListRemovedResponse inMessage); // 0x000000018038A620-0x000000018038A760
	private void OnInventoryList(InventoryListResponse inMessage); // 0x000000018038A760-0x000000018038A950
	private void ItemSelected(Item inSelectedItem); // 0x000000018038A450-0x000000018038A4F0
}

