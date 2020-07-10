/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyItemList_Inspiration : UI_LazyItemList<InspirationItemComponent> // TypeDefIndex: 12061
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyListItem_Inspiration _itemPrefabReference; // 0xE8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyListItemDetailPanel_Inspiration _detailPanelReference; // 0xF0
	private List<InspirationItemComponent> _dataItems; // 0xF8

	// Constructors
	public UI_LazyItemList_Inspiration(); // 0x0000000180E4F430-0x0000000180E4F470

	// Methods
	protected override void Setup(); // 0x0000000180E4F340-0x0000000180E4F3F0
	protected override List<InspirationItemComponent> GetDataItems(); // 0x00000001803BD310-0x00000001803BD320
	protected override UI_LazyListItemDetailPanel<InspirationItemComponent> GetDetailPanelReference(); // 0x00000001803BD320-0x00000001803BD330
	protected override UI_LazyListItem<InspirationItemComponent> GetListItemPrefab(); // 0x000000018037A250-0x000000018037A260
	protected override string GetDataItemName(InspirationItemComponent inData); // 0x0000000180E4F230-0x0000000180E4F2B0
	protected override List<string> GetDataItemFilters(InspirationItemComponent inData); // 0x0000000180E4F1A0-0x0000000180E4F230
	protected override List<string> GetDataItemTags(InspirationItemComponent inData); // 0x0000000180E4F2B0-0x0000000180E4F340
	protected override void SortData(); // 0x0000000180E4F3F0-0x0000000180E4F430
}

