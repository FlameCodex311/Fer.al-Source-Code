/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyItemList_NPCDef : UI_LazyItemList<BaseDef> // TypeDefIndex: 13639
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyListItem_NPCDef _itemPrefabReference; // 0xE8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyListItemDetailPanel_NPCDef _detailPanelReference; // 0xF0
	private List<BaseDef> _dataItems; // 0xF8

	// Constructors
	public UI_LazyItemList_NPCDef(); // 0x000000018038AFA0-0x000000018038AFE0

	// Methods
	protected override void Setup(); // 0x000000018038AD80-0x000000018038AFA0
	protected override List<BaseDef> GetDataItems(); // 0x000000018037E230-0x000000018037E240
	protected override UI_LazyListItemDetailPanel<BaseDef> GetDetailPanelReference(); // 0x000000018037DDB0-0x000000018037DDC0
	protected override UI_LazyListItem<BaseDef> GetListItemPrefab(); // 0x000000018037DDD0-0x000000018037DDE0
	protected override string GetDataItemName(BaseDef inData); // 0x000000018038AD60-0x000000018038AD80
}

