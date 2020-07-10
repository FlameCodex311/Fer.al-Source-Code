/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyItemList_InventoryTradeList : UI_LazyItemList<Item> // TypeDefIndex: 12071
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyListItem_InventoryTradeList _itemPrefabReference; // 0xE8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyListItemDetailPanel_InventoryTradeList _detailPanelReference; // 0xF0
	private List<Item> _dataItems; // 0xF8

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass7_0 // TypeDefIndex: 12072
	{
		// Fields
		public ItemAddedOrRemovedFromTradeList inMessage; // 0x10

		// Constructors
		public <>c__DisplayClass7_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <OnTradeListUpdated>b__0(Item dataItem); // 0x0000000180E3EA70-0x0000000180E3EAB0
	}

	// Constructors
	public UI_LazyItemList_InventoryTradeList(); // 0x0000000180E4FCB0-0x0000000180E4FCF0

	// Methods
	protected override void Setup(); // 0x0000000180E4F9D0-0x0000000180E4FC10
	private void OnDisable(); // 0x0000000180E4F7F0-0x0000000180E4F830
	protected override void Start(); // 0x0000000180E4FC10-0x0000000180E4FCB0
	private void OnDestroy(); // 0x0000000180E4F760-0x0000000180E4F7F0
	private void OnTradeListUpdated(ItemAddedOrRemovedFromTradeList inMessage); // 0x0000000180E4F830-0x0000000180E4F9D0
	protected override List<Item> GetDataItems(); // 0x00000001803BD310-0x00000001803BD320
	protected override UI_LazyListItemDetailPanel<Item> GetDetailPanelReference(); // 0x00000001803BD320-0x00000001803BD330
	protected override UI_LazyListItem<Item> GetListItemPrefab(); // 0x000000018037A250-0x000000018037A260
	protected override long GetDataItemAge(Item inData); // 0x0000000180E4F470-0x0000000180E4F590
	protected override string GetDataItemName(Item inData); // 0x0000000180E4F610-0x0000000180E4F680
	protected override List<string> GetDataItemFilters(Item inData); // 0x0000000180E4F590-0x0000000180E4F610
	protected override List<string> GetDataItemTags(Item inData); // 0x0000000180E4F6E0-0x0000000180E4F760
	protected override int GetDataItemRarity(Item inData); // 0x0000000180E4F680-0x0000000180E4F6E0
	protected override void SortData(); // 0x0000000180E4D4F0-0x0000000180E4D540
}

