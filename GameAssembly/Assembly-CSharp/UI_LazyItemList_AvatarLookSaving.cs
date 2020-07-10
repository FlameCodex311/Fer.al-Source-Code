/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyItemList_AvatarLookSaving : UI_LazyItemList<AvatarLookItemComponent> // TypeDefIndex: 12022
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyListItem_AvatarLookSaving _itemPrefabReference; // 0xE8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyListItemDetailPanel_AvatarLookSaving _detailPanelReference; // 0xF0
	private List<AvatarLookItemComponent> _dataItems; // 0xF8

	// Constructors
	public UI_LazyItemList_AvatarLookSaving(); // 0x0000000180E467C0-0x0000000180E46800

	// Methods
	public void Setup(string inActorClassDefId); // 0x0000000180E46330-0x0000000180E465F0
	protected override List<AvatarLookItemComponent> GetDataItems(); // 0x00000001803BD310-0x00000001803BD320
	protected override UI_LazyListItemDetailPanel<AvatarLookItemComponent> GetDetailPanelReference(); // 0x00000001803BD320-0x00000001803BD330
	protected override UI_LazyListItem<AvatarLookItemComponent> GetListItemPrefab(); // 0x000000018037A250-0x000000018037A260
	protected override void SortData(); // 0x0000000180E465F0-0x0000000180E46680
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private int <SortData>b__7_0(LazyListItem<AvatarLookItemComponent> a, LazyListItem<AvatarLookItemComponent> b); // 0x0000000180E46680-0x0000000180E467C0
}

