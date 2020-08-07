/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyItemList_SanctuaryLookSaving : UI_LazyItemList<SanctuaryLookItemComponent> // TypeDefIndex: 13596
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyListItem_SanctuaryLookSaving _itemPrefabReference; // 0xE8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyListItemDetailPanel_SanctuaryLookSaving _detailPanelReference; // 0xF0
	private List<SanctuaryLookItemComponent> _dataItems; // 0xF8

	// Constructors
	public UI_LazyItemList_SanctuaryLookSaving(); // 0x000000018038EC70-0x000000018038ECB0

	// Methods
	public void Setup(string inSanctuaryClassDefId); // 0x000000018038E820-0x000000018038EAB0
	protected override List<SanctuaryLookItemComponent> GetDataItems(); // 0x000000018037E230-0x000000018037E240
	protected override UI_LazyListItemDetailPanel<SanctuaryLookItemComponent> GetDetailPanelReference(); // 0x000000018037DDB0-0x000000018037DDC0
	protected override UI_LazyListItem<SanctuaryLookItemComponent> GetListItemPrefab(); // 0x000000018037DDD0-0x000000018037DDE0
	protected override void SortData(); // 0x000000018038EAB0-0x000000018038EB40
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private int <SortData>b__7_0(LazyListItem<SanctuaryLookItemComponent> a, LazyListItem<SanctuaryLookItemComponent> b); // 0x000000018038EB40-0x000000018038EC70
}

