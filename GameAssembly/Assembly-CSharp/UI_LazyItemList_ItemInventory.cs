/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyItemList_ItemInventory : UI_LazyItemList<Item> // TypeDefIndex: 12073
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private ItemType _itemType; // 0xE8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyListItemDetailPanel_Item _detailPanelPrefab; // 0xF0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyListItem_ItemInventory _itemPrefab; // 0xF8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private RectTransform _categoryDescription; // 0x100
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _categorySpacer; // 0x108
	private List<Item> _inventoryItems; // 0x110
	private string _equippedCategory; // 0x118

	// Properties
	private string EquippedCategory { get; } // 0x0000000180E511A0-0x0000000180E51270 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass29_0 // TypeDefIndex: 12074
	{
		// Fields
		public string itemId; // 0x10

		// Constructors
		public <>c__DisplayClass29_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <OnInventoryListRemoved>b__0(Item item); // 0x0000000180E3BE80-0x0000000180E3BEB0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass30_0 // TypeDefIndex: 12075
	{
		// Fields
		public Item item; // 0x10

		// Constructors
		public <>c__DisplayClass30_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <OnInventoryList>b__0(UI_LazyItemList<Item> itemToCheck); // 0x0000000180E3E810-0x0000000180E3E860
	}

	// Constructors
	public UI_LazyItemList_ItemInventory(); // 0x0000000180E51160-0x0000000180E511A0

	// Methods
	public void Setup(List<Item> inItems); // 0x0000000180E50DF0-0x0000000180E50E70
	protected void OnDisable(); // 0x0000000180E50440-0x0000000180E504A0
	public void SetupDefault(); // 0x00000001806A3950-0x00000001806A3970
	protected override void Setup(); // 0x0000000180E50950-0x0000000180E50DF0
	protected override void Start(); // 0x0000000180E50F00-0x0000000180E50FE0
	protected virtual void OnDestroy(); // 0x0000000180E50370-0x0000000180E50440
	protected override void PostListFilter(int inShownItemsCount); // 0x0000000180E50870-0x0000000180E50950
	protected override long GetDataItemAge(Item inData); // 0x0000000180E4FCF0-0x0000000180E4FE10
	protected override bool GetDataItemFav(Item inData); // 0x00000001803C28F0-0x00000001803C2900
	protected override string GetDataItemName(Item inData); // 0x0000000180E4FE90-0x0000000180E4FF00
	protected override List<string> GetDataItemFilters(Item inData); // 0x0000000180E4FE10-0x0000000180E4FE90
	protected override List<string> GetDataItemTags(Item inData); // 0x0000000180E4FF60-0x0000000180E4FFE0
	protected override int GetDataItemRarity(Item inData); // 0x0000000180E4FF00-0x0000000180E4FF60
	protected override void SortNewToOld(); // 0x0000000180E50E70-0x0000000180E50F00
	protected override void SortData(); // 0x0000000180E4D4F0-0x0000000180E4D540
	protected override UI_LazyListItemDetailPanel<Item> GetDetailPanelReference(); // 0x00000001803BD320-0x00000001803BD330
	protected override List<Item> GetDataItems(); // 0x00000001803BD380-0x00000001803BD390
	protected override UI_LazyListItem<Item> GetListItemPrefab(); // 0x00000001803BD310-0x00000001803BD320
	protected override bool ItemMatchesCategory(LazyListItem<Item> inItem); // 0x0000000180E4FFE0-0x0000000180E500B0
	protected override bool ItemMatchesFilter(LazyListItem<Item> inItem, string inFilterCategory); // 0x0000000180E500B0-0x0000000180E502D0
	private void OnInventoryListRemoved(InventoryListRemovedResponse inMessage); // 0x0000000180E504A0-0x0000000180E505F0
	private void OnInventoryList(InventoryListResponse inMessage); // 0x0000000180E505F0-0x0000000180E50870
	private void ItemSelected(Item inSelectedItem); // 0x0000000180E502D0-0x0000000180E50370
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private int <SortNewToOld>b__19_0(LazyListItem<Item> a, LazyListItem<Item> b); // 0x0000000180E50FE0-0x0000000180E51160
}

