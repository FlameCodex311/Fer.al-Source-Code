/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyItemList_TradeLobbyInventory : UI_LazyItemList<Item> // TypeDefIndex: 13700
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyListItem_TradeLobbyInventory _itemPrefabReference; // 0xE8
	private List<Item> _dataItems; // 0xF0

	// Constructors
	public UI_LazyItemList_TradeLobbyInventory(); // 0x0000000180390180-0x00000001803901C0

	// Methods
	protected override void Setup(); // 0x000000018038FEE0-0x0000000180390100
	protected override List<Item> GetDataItems(); // 0x000000018037DDB0-0x000000018037DDC0
	protected override UI_LazyListItemDetailPanel<Item> GetDetailPanelReference(); // 0x000000018037DDC0-0x000000018037DDD0
	protected override UI_LazyListItem<Item> GetListItemPrefab(); // 0x000000018037DDD0-0x000000018037DDE0
	protected override string GetDataItemName(Item inData); // 0x000000018038FB80-0x000000018038FC00
	protected override int GetDataItemRarity(Item inData); // 0x000000018038FC00-0x000000018038FC60
	protected override List<string> GetDataItemFilters(Item inData); // 0x000000018038FB00-0x000000018038FB80
	protected override List<string> GetDataItemTags(Item inData); // 0x000000018038FC60-0x000000018038FCE0
	protected override bool ItemMatchesCategory(LazyListItem<Item> inItem); // 0x000000018038FCE0-0x000000018038FEE0
	protected override void SortData(); // 0x0000000180390100-0x0000000180390180
}

