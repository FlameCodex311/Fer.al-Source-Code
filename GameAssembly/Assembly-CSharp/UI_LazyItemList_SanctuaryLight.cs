/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyItemList_SanctuaryLight : UI_LazyItemList<SanctuaryLightDefComponent> // TypeDefIndex: 13663
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyListItem_SanctuaryLight _itemPrefabReference; // 0xE8
	private List<SanctuaryLightDefComponent> _dataItems; // 0xF0

	// Constructors
	public UI_LazyItemList_SanctuaryLight(); // 0x000000018038E7E0-0x000000018038E820

	// Methods
	protected override void Setup(); // 0x000000018038E500-0x000000018038E7E0
	private void OnDisable(); // 0x000000018038DFF0-0x000000018038E100
	protected override List<SanctuaryLightDefComponent> GetDataItems(); // 0x000000018037DDB0-0x000000018037DDC0
	protected override UI_LazyListItemDetailPanel<SanctuaryLightDefComponent> GetDetailPanelReference(); // 0x000000018037DDC0-0x000000018037DDD0
	protected override UI_LazyListItem<SanctuaryLightDefComponent> GetListItemPrefab(); // 0x000000018037DDD0-0x000000018037DDE0
	private void OnLightSelected(SanctuaryLightDefComponent inLight); // 0x000000018038E100-0x000000018038E2E0
	private void OnSanctuaryIndoorRoom(SanctuaryIndoorRoomMessage inMessage); // 0x000000018038E2E0-0x000000018038E500
	protected override void SortData(); // 0x00000001803774A0-0x00000001803774B0
}

