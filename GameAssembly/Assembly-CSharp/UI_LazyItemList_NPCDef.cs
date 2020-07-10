/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyItemList_NPCDef : UI_LazyItemList<BaseDef> // TypeDefIndex: 12098
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyListItem_NPCDef _itemPrefabReference; // 0xE8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyListItemDetailPanel_NPCDef _detailPanelReference; // 0xF0
	private List<BaseDef> _dataItems; // 0xF8

	// Constructors
	public UI_LazyItemList_NPCDef(); // 0x0000000180E520E0-0x0000000180E52120

	// Methods
	protected override void Setup(); // 0x0000000180E51EC0-0x0000000180E520E0
	protected override List<BaseDef> GetDataItems(); // 0x00000001803BD310-0x00000001803BD320
	protected override UI_LazyListItemDetailPanel<BaseDef> GetDetailPanelReference(); // 0x00000001803BD320-0x00000001803BD330
	protected override UI_LazyListItem<BaseDef> GetListItemPrefab(); // 0x000000018037A250-0x000000018037A260
	protected override string GetDataItemName(BaseDef inData); // 0x0000000180E51EA0-0x0000000180E51EC0
}

