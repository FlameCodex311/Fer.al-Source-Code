/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyItemList_ItemInventory : UI_LazyItemList<Item> // TypeDefIndex: 13619
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private ItemType _itemType; // 0xE8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyListItemDetailPanel_Item _detailPanelPrefab; // 0xF0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyListItem_ItemInventory _itemPrefab; // 0xF8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RectTransform _categoryDescription; // 0x100
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _categorySpacer; // 0x108
	private List<Item> _inventoryItems; // 0x110
	private string _equippedCategory; // 0x118

	// Properties
	private string EquippedCategory { get; } // 0x000000018038A090-0x000000018038A160 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass29_0 // TypeDefIndex: 13620
	{
		// Fields
		public string itemId; // 0x10

		// Constructors
		public <>c__DisplayClass29_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <OnInventoryListRemoved>b__0(Item item); // 0x0000000180387C90-0x0000000180387CC0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass30_0 // TypeDefIndex: 13621
	{
		// Fields
		public Item item; // 0x10

		// Constructors
		public <>c__DisplayClass30_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <OnInventoryList>b__0(UI_LazyItemList<Item> itemToCheck); // 0x0000000180387CC0-0x0000000180387D10
	}

	// Constructors
	public UI_LazyItemList_ItemInventory(); // 0x000000018038A050-0x000000018038A090

	// Methods
	public void Setup(List<Item> inItems); // 0x0000000180389CF0-0x0000000180389D70
	protected void OnDisable(); // 0x0000000180389380-0x00000001803893E0
	public void SetupDefault(); // 0x000000018037F800-0x000000018037F820
	protected override void Setup(); // 0x0000000180389870-0x0000000180389CF0
	protected override void Start(); // 0x0000000180389E00-0x0000000180389EE0
	protected virtual void OnDestroy(); // 0x00000001803892B0-0x0000000180389380
	protected override void PostListFilter(int inShownItemsCount); // 0x0000000180389790-0x0000000180389870
	protected override long GetDataItemAge(Item inData); // 0x0000000180388C50-0x0000000180388D70
	protected override bool GetDataItemFav(Item inData); // 0x0000000180380950-0x0000000180380960
	protected override string GetDataItemName(Item inData); // 0x0000000180388DF0-0x0000000180388E60
	protected override List<string> GetDataItemFilters(Item inData); // 0x0000000180388D70-0x0000000180388DF0
	protected override List<string> GetDataItemTags(Item inData); // 0x0000000180388EC0-0x0000000180388F40
	protected override int GetDataItemRarity(Item inData); // 0x0000000180388E60-0x0000000180388EC0
	protected override void SortNewToOld(); // 0x0000000180389D70-0x0000000180389E00
	protected override void SortData(); // 0x0000000180385910-0x0000000180385960
	protected override UI_LazyListItemDetailPanel<Item> GetDetailPanelReference(); // 0x000000018037DDB0-0x000000018037DDC0
	protected override List<Item> GetDataItems(); // 0x0000000180385320-0x0000000180385330
	protected override UI_LazyListItem<Item> GetListItemPrefab(); // 0x000000018037E230-0x000000018037E240
	protected override bool ItemMatchesCategory(LazyListItem<Item> inItem); // 0x0000000180388F40-0x0000000180389000
	protected override bool ItemMatchesFilter(LazyListItem<Item> inItem, string inFilterCategory); // 0x0000000180389000-0x0000000180389210
	private void OnInventoryListRemoved(InventoryListRemovedResponse inMessage); // 0x00000001803893E0-0x0000000180389520
	private void OnInventoryList(InventoryListResponse inMessage); // 0x0000000180389520-0x0000000180389790
	private void ItemSelected(Item inSelectedItem); // 0x0000000180389210-0x00000001803892B0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private int <SortNewToOld>b__19_0(LazyListItem<Item> a, LazyListItem<Item> b); // 0x0000000180389EE0-0x000000018038A050
}

