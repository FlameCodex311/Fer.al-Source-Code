/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyItemList_House : UI_LazyItemList<SanctuaryLookItemComponent> // TypeDefIndex: 13593
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyListItem_House _itemPrefabReference; // 0xE8
	private List<SanctuaryLookItemComponent> _dataItems; // 0xF0

	// Constructors
	public UI_LazyItemList_House(); // 0x0000000180387550-0x0000000180387590

	// Methods
	public void ManualSetup(); // 0x000000018037F800-0x000000018037F820
	public void RefreshAll(); // 0x00000001803871A0-0x00000001803872D0
	protected override void Setup(); // 0x00000001803872D0-0x0000000180387510
	protected override List<SanctuaryLookItemComponent> GetDataItems(); // 0x000000018037DDB0-0x000000018037DDC0
	protected override UI_LazyListItem<SanctuaryLookItemComponent> GetListItemPrefab(); // 0x000000018037DDD0-0x000000018037DDE0
	protected override void SortData(); // 0x0000000180387510-0x0000000180387550
	protected override UI_LazyListItemDetailPanel<SanctuaryLookItemComponent> GetDetailPanelReference(); // 0x000000018037DDC0-0x000000018037DDD0
}

