/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyItemList_ReadonlyItemList : UI_LazyItemList<Item> // TypeDefIndex: 13722
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyListItem_ReadonlyItemList _itemPrefabReference; // 0xE8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyListItemDetailPanel_ReadonlyItemList _detailPanelReference; // 0xF0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _maxListHeight; // 0xF8
	private List<Item> _dataItems; // 0x100

	// Constructors
	public UI_LazyItemList_ReadonlyItemList(); // 0x000000018038C8B0-0x000000018038C900

	// Methods
	public void Setup(List<Item> inItems, int inCountToUseForSize = -1 /* Metadata: 0x007BA502 */); // 0x000000018038C540-0x000000018038C870
	protected override void Setup(); // 0x000000018038C870-0x000000018038C8B0
	protected override List<Item> GetDataItems(); // 0x000000018037F030-0x000000018037F040
	protected override UI_LazyListItemDetailPanel<Item> GetDetailPanelReference(); // 0x000000018037DDB0-0x000000018037DDC0
	protected override UI_LazyListItem<Item> GetListItemPrefab(); // 0x000000018037DDD0-0x000000018037DDE0
}

