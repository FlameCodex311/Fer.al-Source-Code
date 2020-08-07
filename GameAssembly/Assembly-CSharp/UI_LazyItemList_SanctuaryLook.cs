/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyItemList_SanctuaryLook : UI_LazyItemList<SanctuaryLookItemComponent> // TypeDefIndex: 13594
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyListItem_SanctuaryLook _itemPrefabReference; // 0xE8
	private List<SanctuaryLookItemComponent> _dataItems; // 0xF0

	// Properties
	private SanctuaryLookItemComponent CurrentPrimaryLook { get; } // 0x000000018038F390-0x000000018038F3B0 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass10_0 // TypeDefIndex: 13595
	{
		// Fields
		public SanctuaryLookItemComponent inLookItem; // 0x10
		public UI_LazyItemList_SanctuaryLook <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass10_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <ItemSelected>b__0(bool inResponse); // 0x0000000180387AC0-0x0000000180387BC0
	}

	// Constructors
	public UI_LazyItemList_SanctuaryLook(); // 0x000000018038F350-0x000000018038F390

	// Methods
	protected override void Setup(); // 0x000000018038EE50-0x000000018038F190
	private void OnDisable(); // 0x000000018038ED90-0x000000018038EE50
	protected override List<SanctuaryLookItemComponent> GetDataItems(); // 0x000000018037DDB0-0x000000018037DDC0
	protected override UI_LazyListItemDetailPanel<SanctuaryLookItemComponent> GetDetailPanelReference(); // 0x000000018037DDC0-0x000000018037DDD0
	protected override UI_LazyListItem<SanctuaryLookItemComponent> GetListItemPrefab(); // 0x000000018037DDD0-0x000000018037DDE0
	protected override void SortData(); // 0x000000018038F190-0x000000018038F220
	private void ItemSelected(SanctuaryLookItemComponent inLookItem); // 0x000000018038ECB0-0x000000018038ED90
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private int <SortData>b__9_0(LazyListItem<SanctuaryLookItemComponent> a, LazyListItem<SanctuaryLookItemComponent> b); // 0x000000018038F220-0x000000018038F350
}

