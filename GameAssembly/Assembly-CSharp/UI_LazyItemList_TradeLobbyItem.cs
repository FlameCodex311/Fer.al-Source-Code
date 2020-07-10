/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyItemList_TradeLobbyItem : UI_LazyItemList<Item> // TypeDefIndex: 12154
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyListItem_TradeLobbyItem _itemPrefabReference; // 0xE8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyListItemDetailPanel_TradeLobbyItem _detailPanelReference; // 0xF0
	private List<Item> _dataItems; // 0xF8

	// Constructors
	public UI_LazyItemList_TradeLobbyItem(); // 0x0000000180E5E9E0-0x0000000180E5EA20

	// Methods
	protected override void Setup(); // 0x0000000180E5E7A0-0x0000000180E5E9E0
	protected override List<Item> GetDataItems(); // 0x00000001803BD310-0x00000001803BD320
	protected override UI_LazyListItemDetailPanel<Item> GetDetailPanelReference(); // 0x00000001803BD320-0x00000001803BD330
	protected override UI_LazyListItem<Item> GetListItemPrefab(); // 0x000000018037A250-0x000000018037A260
	protected override string GetDataItemName(Item inData); // 0x0000000180E5E6A0-0x0000000180E5E720
	protected override List<string> GetDataItemFilters(Item inData); // 0x0000000180E5E620-0x0000000180E5E6A0
	protected override List<string> GetDataItemTags(Item inData); // 0x0000000180E5E720-0x0000000180E5E7A0
}

