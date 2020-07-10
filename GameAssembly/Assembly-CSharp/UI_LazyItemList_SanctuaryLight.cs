/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyItemList_SanctuaryLight : UI_LazyItemList<SanctuaryLightDefComponent> // TypeDefIndex: 12117
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyListItem_SanctuaryLight _itemPrefabReference; // 0xE8
	private List<SanctuaryLightDefComponent> _dataItems; // 0xF0

	// Constructors
	public UI_LazyItemList_SanctuaryLight(); // 0x0000000180E5CE80-0x0000000180E5CEC0

	// Methods
	protected override void Setup(); // 0x0000000180E5CBA0-0x0000000180E5CE80
	private void OnDisable(); // 0x0000000180E5C680-0x0000000180E5C790
	protected override List<SanctuaryLightDefComponent> GetDataItems(); // 0x00000001803BD320-0x00000001803BD330
	protected override UI_LazyListItemDetailPanel<SanctuaryLightDefComponent> GetDetailPanelReference(); // 0x000000018035FCC0-0x000000018035FCD0
	protected override UI_LazyListItem<SanctuaryLightDefComponent> GetListItemPrefab(); // 0x000000018037A250-0x000000018037A260
	private void OnLightSelected(SanctuaryLightDefComponent inLight); // 0x0000000180E5C790-0x0000000180E5C970
	private void OnSanctuaryIndoorRoom(SanctuaryIndoorRoomMessage inMessage); // 0x0000000180E5C970-0x0000000180E5CBA0
	protected override void SortData(); // 0x00000001803581E0-0x00000001803581F0
}

