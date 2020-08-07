/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyItemList_AstralShop : UI_LazyItemList<BaseDef> // TypeDefIndex: 13673
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyListItem_AstralShop _itemPrefabReference; // 0xE8
	private List<BaseDef> _dataItems; // 0xF0

	// Constructors
	public UI_LazyItemList_AstralShop(); // 0x000000018037E1F0-0x000000018037E230

	// Methods
	public void Setup(string[] inShopContent); // 0x000000018037E0C0-0x000000018037E1F0
	protected override void Setup(); // 0x000000018037E080-0x000000018037E0C0
	protected override List<BaseDef> GetDataItems(); // 0x000000018037DDB0-0x000000018037DDC0
	protected override UI_LazyListItemDetailPanel<BaseDef> GetDetailPanelReference(); // 0x000000018037DDC0-0x000000018037DDD0
	protected override UI_LazyListItem<BaseDef> GetListItemPrefab(); // 0x000000018037DDD0-0x000000018037DDE0
	protected override void SortData(); // 0x00000001803774A0-0x00000001803774B0
}

