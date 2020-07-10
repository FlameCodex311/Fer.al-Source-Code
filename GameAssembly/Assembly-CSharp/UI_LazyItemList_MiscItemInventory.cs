/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyItemList_MiscItemInventory : UI_LazyItemList<Item> // TypeDefIndex: 12077
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyListItemDetailPanel_Item _detailPanelPrefab; // 0xE8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyListItem_ItemInventory _itemPrefab; // 0xF0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private RectTransform _categoryDescription; // 0xF8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _categorySpacer; // 0x100
	private List<Item> _inventoryItems; // 0x108

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass22_0 // TypeDefIndex: 12078
	{
		// Fields
		public string itemId; // 0x10

		// Constructors
		public <>c__DisplayClass22_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <OnInventoryListRemoved>b__0(Item item); // 0x0000000180E3BE80-0x0000000180E3BEB0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass23_0 // TypeDefIndex: 12079
	{
		// Fields
		public Item item; // 0x10

		// Constructors
		public <>c__DisplayClass23_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <OnInventoryList>b__0(UI_LazyItemList<Item> itemToCheck); // 0x0000000180E3E810-0x0000000180E3E860
	}

	// Constructors
	public UI_LazyItemList_MiscItemInventory(); // 0x0000000180E51E60-0x0000000180E51EA0

	// Methods
	public void Setup(List<Item> inItems); // 0x0000000180E51DE0-0x0000000180E51E60
	protected void OnDisable(); // 0x0000000180E516D0-0x0000000180E51730
	public void SetupDefault(); // 0x00000001806A3950-0x00000001806A3970
	protected override void Setup(); // 0x0000000180E51B60-0x0000000180E51DE0
	protected virtual void OnDestroy(); // 0x0000000180E51600-0x0000000180E516D0
	protected override void PostListFilter(int inShownItemsCount); // 0x0000000180E51A80-0x0000000180E51B60
	protected override long GetDataItemAge(Item inData); // 0x0000000180E51270-0x0000000180E51390
	protected override bool GetDataItemFav(Item inData); // 0x00000001803C28F0-0x00000001803C2900
	protected override string GetDataItemName(Item inData); // 0x0000000180E51410-0x0000000180E51480
	protected override List<string> GetDataItemFilters(Item inData); // 0x0000000180E51390-0x0000000180E51410
	protected override List<string> GetDataItemTags(Item inData); // 0x0000000180E514E0-0x0000000180E51560
	protected override int GetDataItemRarity(Item inData); // 0x0000000180E51480-0x0000000180E514E0
	protected override void SortData(); // 0x0000000180E4D4F0-0x0000000180E4D540
	protected override UI_LazyListItemDetailPanel<Item> GetDetailPanelReference(); // 0x000000018037A250-0x000000018037A260
	protected override List<Item> GetDataItems(); // 0x00000001803BD3C0-0x00000001803BD3D0
	protected override UI_LazyListItem<Item> GetListItemPrefab(); // 0x00000001803BD320-0x00000001803BD330
	protected override bool ItemMatchesCategory(LazyListItem<Item> inItem); // 0x00000001803C29F0-0x00000001803C2A00
	private void OnInventoryListRemoved(InventoryListRemovedResponse inMessage); // 0x0000000180E51730-0x0000000180E51880
	private void OnInventoryList(InventoryListResponse inMessage); // 0x0000000180E51880-0x0000000180E51A80
	private void ItemSelected(Item inSelectedItem); // 0x0000000180E51560-0x0000000180E51600
}

