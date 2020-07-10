/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyItemList_ReadonlyItemList : UI_LazyItemList<Item> // TypeDefIndex: 12175
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyListItem_ReadonlyItemList _itemPrefabReference; // 0xE8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyListItemDetailPanel_ReadonlyItemList _detailPanelReference; // 0xF0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _maxListHeight; // 0xF8
	private List<Item> _dataItems; // 0x100

	// Constructors
	public UI_LazyItemList_ReadonlyItemList(); // 0x0000000180E5AF90-0x0000000180E5AFE0

	// Methods
	public void Setup(List<Item> inItems, int inCountToUseForSize = -1 /* Metadata: 0x00782DF4 */); // 0x0000000180E5AC10-0x0000000180E5AF50
	protected override void Setup(); // 0x0000000180E5AF50-0x0000000180E5AF90
	protected override List<Item> GetDataItems(); // 0x00000001803BD370-0x00000001803BD380
	protected override UI_LazyListItemDetailPanel<Item> GetDetailPanelReference(); // 0x00000001803BD320-0x00000001803BD330
	protected override UI_LazyListItem<Item> GetListItemPrefab(); // 0x000000018037A250-0x000000018037A260
}

