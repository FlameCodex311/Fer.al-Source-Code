/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyItemList_SanctuaryLook : UI_LazyItemList<SanctuaryLookItemComponent> // TypeDefIndex: 12048
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyListItem_SanctuaryLook _itemPrefabReference; // 0xE8
	private List<SanctuaryLookItemComponent> _dataItems; // 0xF0

	// Properties
	private SanctuaryLookItemComponent CurrentPrimaryLook { get; } // 0x0000000180E5DA70-0x0000000180E5DAA0 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass10_0 // TypeDefIndex: 12049
	{
		// Fields
		public SanctuaryLookItemComponent inLookItem; // 0x10
		public UI_LazyItemList_SanctuaryLook <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass10_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <ItemSelected>b__0(bool inResponse); // 0x0000000180E5A7F0-0x0000000180E5A8F0
	}

	// Constructors
	public UI_LazyItemList_SanctuaryLook(); // 0x0000000180E5DA30-0x0000000180E5DA70

	// Methods
	protected override void Setup(); // 0x0000000180E5D510-0x0000000180E5D860
	private void OnDisable(); // 0x0000000180E5D450-0x0000000180E5D510
	protected override List<SanctuaryLookItemComponent> GetDataItems(); // 0x00000001803BD320-0x00000001803BD330
	protected override UI_LazyListItemDetailPanel<SanctuaryLookItemComponent> GetDetailPanelReference(); // 0x000000018035FCC0-0x000000018035FCD0
	protected override UI_LazyListItem<SanctuaryLookItemComponent> GetListItemPrefab(); // 0x000000018037A250-0x000000018037A260
	protected override void SortData(); // 0x0000000180E5D860-0x0000000180E5D8F0
	private void ItemSelected(SanctuaryLookItemComponent inLookItem); // 0x0000000180E5D370-0x0000000180E5D450
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private int <SortData>b__9_0(LazyListItem<SanctuaryLookItemComponent> a, LazyListItem<SanctuaryLookItemComponent> b); // 0x0000000180E5D8F0-0x0000000180E5DA30
}

