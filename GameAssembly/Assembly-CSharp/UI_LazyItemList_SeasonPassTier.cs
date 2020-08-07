/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyItemList_SeasonPassTier : UI_LazyItemList<ISeasonPassTier> // TypeDefIndex: 13668
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyListItem_SeasonPassTier _itemPrefabReference; // 0xE8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _scrollToCurrentTier; // 0xF0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _scrollToOffset; // 0xF4
	private List<ISeasonPassTier> _dataItems; // 0xF8

	// Constructors
	public UI_LazyItemList_SeasonPassTier(); // 0x000000018038FAC0-0x000000018038FB00

	// Methods
	public void Setup(List<ISeasonPassTier> inTiers); // 0x000000018038F9C0-0x000000018038F9E0
	protected override void Setup(); // 0x000000018038F840-0x000000018038F9C0
	protected override List<ISeasonPassTier> GetDataItems(); // 0x000000018037E230-0x000000018037E240
	protected override UI_LazyListItemDetailPanel<ISeasonPassTier> GetDetailPanelReference(); // 0x000000018037DDC0-0x000000018037DDD0
	protected override UI_LazyListItem<ISeasonPassTier> GetListItemPrefab(); // 0x000000018037DDD0-0x000000018037DDE0
	protected override void SortData(); // 0x00000001803774A0-0x00000001803774B0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Setup>b__5_0(); // 0x000000018038F9E0-0x000000018038FAC0
}

