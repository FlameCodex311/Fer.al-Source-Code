/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyItemList_TradeLobbyItem : UI_LazyItemList<Item> // TypeDefIndex: 13701
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyListItem_TradeLobbyItem _itemPrefabReference; // 0xE8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyListItemDetailPanel_TradeLobbyItem _detailPanelReference; // 0xF0
	private List<Item> _dataItems; // 0xF8

	// Constructors
	public UI_LazyItemList_TradeLobbyItem(); // 0x0000000180390570-0x00000001803905B0

	// Methods
	protected override void Setup(); // 0x0000000180390340-0x0000000180390570
	protected override List<Item> GetDataItems(); // 0x000000018037E230-0x000000018037E240
	protected override UI_LazyListItemDetailPanel<Item> GetDetailPanelReference(); // 0x000000018037DDB0-0x000000018037DDC0
	protected override UI_LazyListItem<Item> GetListItemPrefab(); // 0x000000018037DDD0-0x000000018037DDE0
	protected override string GetDataItemName(Item inData); // 0x0000000180390240-0x00000001803902C0
	protected override List<string> GetDataItemFilters(Item inData); // 0x00000001803901C0-0x0000000180390240
	protected override List<string> GetDataItemTags(Item inData); // 0x00000001803902C0-0x0000000180390340
}

