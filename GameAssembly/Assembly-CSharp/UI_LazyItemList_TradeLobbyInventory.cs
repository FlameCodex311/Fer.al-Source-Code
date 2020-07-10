/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyItemList_TradeLobbyInventory : UI_LazyItemList<Item> // TypeDefIndex: 12153
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyListItem_TradeLobbyInventory _itemPrefabReference; // 0xE8
	private List<Item> _dataItems; // 0xF0

	// Constructors
	public UI_LazyItemList_TradeLobbyInventory(); // 0x0000000180E5E5E0-0x0000000180E5E620

	// Methods
	protected override void Setup(); // 0x0000000180E5E330-0x0000000180E5E560
	protected override List<Item> GetDataItems(); // 0x00000001803BD320-0x00000001803BD330
	protected override UI_LazyListItemDetailPanel<Item> GetDetailPanelReference(); // 0x000000018035FCC0-0x000000018035FCD0
	protected override UI_LazyListItem<Item> GetListItemPrefab(); // 0x000000018037A250-0x000000018037A260
	protected override string GetDataItemName(Item inData); // 0x0000000180E5E010-0x0000000180E5E090
	protected override List<string> GetDataItemFilters(Item inData); // 0x0000000180E5DF90-0x0000000180E5E010
	protected override List<string> GetDataItemTags(Item inData); // 0x0000000180E5E090-0x0000000180E5E110
	protected override bool ItemMatchesCategory(LazyListItem<Item> inItem); // 0x0000000180E5E110-0x0000000180E5E330
	protected override void SortData(); // 0x0000000180E5E560-0x0000000180E5E5E0
}

