/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyItemList_House : UI_LazyItemList<SanctuaryLookItemComponent> // TypeDefIndex: 12047
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyListItem_House _itemPrefabReference; // 0xE8
	private List<SanctuaryLookItemComponent> _dataItems; // 0xF0

	// Constructors
	public UI_LazyItemList_House(); // 0x0000000180E4F160-0x0000000180E4F1A0

	// Methods
	public void ManualSetup(); // 0x00000001806A3950-0x00000001806A3970
	public void RefreshAll(); // 0x0000000180E4EDA0-0x0000000180E4EEE0
	protected override void Setup(); // 0x0000000180E4EEE0-0x0000000180E4F120
	protected override List<SanctuaryLookItemComponent> GetDataItems(); // 0x00000001803BD320-0x00000001803BD330
	protected override UI_LazyListItem<SanctuaryLookItemComponent> GetListItemPrefab(); // 0x000000018037A250-0x000000018037A260
	protected override void SortData(); // 0x0000000180E4F120-0x0000000180E4F160
	protected override UI_LazyListItemDetailPanel<SanctuaryLookItemComponent> GetDetailPanelReference(); // 0x000000018035FCC0-0x000000018035FCD0
}

