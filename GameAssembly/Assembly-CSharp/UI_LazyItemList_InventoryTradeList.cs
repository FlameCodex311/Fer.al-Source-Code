/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyItemList_InventoryTradeList : UI_LazyItemList<Item> // TypeDefIndex: 13617
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyListItem_InventoryTradeList _itemPrefabReference; // 0xE8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyListItemDetailPanel_InventoryTradeList _detailPanelReference; // 0xF0
	private List<Item> _dataItems; // 0xF8

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass7_0 // TypeDefIndex: 13618
	{
		// Fields
		public ItemAddedOrRemovedFromTradeList inMessage; // 0x10

		// Constructors
		public <>c__DisplayClass7_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <OnTradeListUpdated>b__0(Item dataItem); // 0x0000000180387F80-0x0000000180387FB0
	}

	// Constructors
	public UI_LazyItemList_InventoryTradeList(); // 0x0000000180388C10-0x0000000180388C50

	// Methods
	protected override void Setup(); // 0x0000000180388940-0x0000000180388B70
	private void OnDisable(); // 0x0000000180388770-0x00000001803887B0
	protected override void Start(); // 0x0000000180388B70-0x0000000180388C10
	private void OnDestroy(); // 0x00000001803886E0-0x0000000180388770
	private void OnTradeListUpdated(ItemAddedOrRemovedFromTradeList inMessage); // 0x00000001803887B0-0x0000000180388940
	protected override List<Item> GetDataItems(); // 0x000000018037E230-0x000000018037E240
	protected override UI_LazyListItemDetailPanel<Item> GetDetailPanelReference(); // 0x000000018037DDB0-0x000000018037DDC0
	protected override UI_LazyListItem<Item> GetListItemPrefab(); // 0x000000018037DDD0-0x000000018037DDE0
	protected override long GetDataItemAge(Item inData); // 0x00000001803883F0-0x0000000180388510
	protected override string GetDataItemName(Item inData); // 0x0000000180388590-0x0000000180388600
	protected override List<string> GetDataItemFilters(Item inData); // 0x0000000180388510-0x0000000180388590
	protected override List<string> GetDataItemTags(Item inData); // 0x0000000180388660-0x00000001803886E0
	protected override int GetDataItemRarity(Item inData); // 0x0000000180388600-0x0000000180388660
	protected override void SortData(); // 0x0000000180385910-0x0000000180385960
}

