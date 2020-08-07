/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyItemList_EditItemDye : UI_LazyItemList<Item> // TypeDefIndex: 13616
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyListItem_EditItemDye _listItemPrefab; // 0xE8
	private List<Item> _dataItems; // 0xF0

	// Constructors
	public UI_LazyItemList_EditItemDye(); // 0x0000000180385960-0x00000001803859A0

	// Methods
	protected override void Setup(); // 0x0000000180385860-0x0000000180385910
	protected override List<Item> GetDataItems(); // 0x000000018037DDB0-0x000000018037DDC0
	protected override UI_LazyListItemDetailPanel<Item> GetDetailPanelReference(); // 0x000000018037DDC0-0x000000018037DDD0
	protected override UI_LazyListItem<Item> GetListItemPrefab(); // 0x000000018037DDD0-0x000000018037DDE0
	protected override long GetDataItemAge(Item inData); // 0x00000001803853E0-0x0000000180385500
	protected override bool GetDataItemFav(Item inData); // 0x0000000180380950-0x0000000180380960
	protected override string GetDataItemName(Item inData); // 0x0000000180385580-0x00000001803855F0
	protected override List<string> GetDataItemFilters(Item inData); // 0x0000000180385500-0x0000000180385580
	protected override List<string> GetDataItemTags(Item inData); // 0x0000000180385650-0x00000001803856D0
	protected override int GetDataItemRarity(Item inData); // 0x00000001803855F0-0x0000000180385650
	protected override void SortData(); // 0x0000000180385910-0x0000000180385960
	public void Refresh(); // 0x00000001803856D0-0x0000000180385860
}

