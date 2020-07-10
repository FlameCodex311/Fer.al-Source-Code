/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyItemList_SanctuaryLookSaving : UI_LazyItemList<SanctuaryLookItemComponent> // TypeDefIndex: 12050
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyListItem_SanctuaryLookSaving _itemPrefabReference; // 0xE8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyListItemDetailPanel_SanctuaryLookSaving _detailPanelReference; // 0xF0
	private List<SanctuaryLookItemComponent> _dataItems; // 0xF8

	// Constructors
	public UI_LazyItemList_SanctuaryLookSaving(); // 0x0000000180E5D330-0x0000000180E5D370

	// Methods
	public void Setup(string inSanctuaryClassDefId); // 0x0000000180E5CEC0-0x0000000180E5D160
	protected override List<SanctuaryLookItemComponent> GetDataItems(); // 0x00000001803BD310-0x00000001803BD320
	protected override UI_LazyListItemDetailPanel<SanctuaryLookItemComponent> GetDetailPanelReference(); // 0x00000001803BD320-0x00000001803BD330
	protected override UI_LazyListItem<SanctuaryLookItemComponent> GetListItemPrefab(); // 0x000000018037A250-0x000000018037A260
	protected override void SortData(); // 0x0000000180E5D160-0x0000000180E5D1F0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private int <SortData>b__7_0(LazyListItem<SanctuaryLookItemComponent> a, LazyListItem<SanctuaryLookItemComponent> b); // 0x0000000180E5D1F0-0x0000000180E5D330
}

