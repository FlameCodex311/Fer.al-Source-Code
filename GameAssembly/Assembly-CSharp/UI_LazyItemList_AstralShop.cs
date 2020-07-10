/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyItemList_AstralShop : UI_LazyItemList<BaseDef> // TypeDefIndex: 12126
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyListItem_AstralShop _itemPrefabReference; // 0xE8
	private List<BaseDef> _dataItems; // 0xF0

	// Constructors
	public UI_LazyItemList_AstralShop(); // 0x0000000180E462F0-0x0000000180E46330

	// Methods
	public void Setup(string[] inShopContent); // 0x0000000180E461C0-0x0000000180E462F0
	protected override void Setup(); // 0x0000000180E46180-0x0000000180E461C0
	protected override List<BaseDef> GetDataItems(); // 0x00000001803BD320-0x00000001803BD330
	protected override UI_LazyListItemDetailPanel<BaseDef> GetDetailPanelReference(); // 0x000000018035FCC0-0x000000018035FCD0
	protected override UI_LazyListItem<BaseDef> GetListItemPrefab(); // 0x000000018037A250-0x000000018037A260
	protected override void SortData(); // 0x00000001803581E0-0x00000001803581F0
}

