/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyItemList_EditItemDye : UI_LazyItemList<Item> // TypeDefIndex: 12070
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyListItem_EditItemDye _listItemPrefab; // 0xE8
	private List<Item> _dataItems; // 0xF0

	// Constructors
	public UI_LazyItemList_EditItemDye(); // 0x0000000180E4D540-0x0000000180E4D580

	// Methods
	protected override void Setup(); // 0x0000000180E4D440-0x0000000180E4D4F0
	protected override List<Item> GetDataItems(); // 0x00000001803BD320-0x00000001803BD330
	protected override UI_LazyListItemDetailPanel<Item> GetDetailPanelReference(); // 0x000000018035FCC0-0x000000018035FCD0
	protected override UI_LazyListItem<Item> GetListItemPrefab(); // 0x000000018037A250-0x000000018037A260
	protected override long GetDataItemAge(Item inData); // 0x0000000180E4CFC0-0x0000000180E4D0E0
	protected override bool GetDataItemFav(Item inData); // 0x00000001803C28F0-0x00000001803C2900
	protected override string GetDataItemName(Item inData); // 0x0000000180E4D160-0x0000000180E4D1D0
	protected override List<string> GetDataItemFilters(Item inData); // 0x0000000180E4D0E0-0x0000000180E4D160
	protected override List<string> GetDataItemTags(Item inData); // 0x0000000180E4D230-0x0000000180E4D2B0
	protected override int GetDataItemRarity(Item inData); // 0x0000000180E4D1D0-0x0000000180E4D230
	protected override void SortData(); // 0x0000000180E4D4F0-0x0000000180E4D540
	public void Refresh(); // 0x0000000180E4D2B0-0x0000000180E4D440
}

