/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyItemList_Inspiration : UI_LazyItemList<InspirationItemComponent> // TypeDefIndex: 13607
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyListItem_Inspiration _itemPrefabReference; // 0xE8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyListItemDetailPanel_Inspiration _detailPanelReference; // 0xF0
	private List<InspirationItemComponent> _dataItems; // 0xF8

	// Constructors
	public UI_LazyItemList_Inspiration(); // 0x00000001803883B0-0x00000001803883F0

	// Methods
	protected override void Setup(); // 0x00000001803882C0-0x0000000180388370
	protected override List<InspirationItemComponent> GetDataItems(); // 0x000000018037E230-0x000000018037E240
	protected override UI_LazyListItemDetailPanel<InspirationItemComponent> GetDetailPanelReference(); // 0x000000018037DDB0-0x000000018037DDC0
	protected override UI_LazyListItem<InspirationItemComponent> GetListItemPrefab(); // 0x000000018037DDD0-0x000000018037DDE0
	protected override string GetDataItemName(InspirationItemComponent inData); // 0x00000001803881B0-0x0000000180388230
	protected override List<string> GetDataItemFilters(InspirationItemComponent inData); // 0x0000000180388120-0x00000001803881B0
	protected override List<string> GetDataItemTags(InspirationItemComponent inData); // 0x0000000180388230-0x00000001803882C0
	protected override void SortData(); // 0x0000000180388370-0x00000001803883B0
}

