/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyItemList_SeasonPassTier : UI_LazyItemList<ISeasonPassTier> // TypeDefIndex: 12121
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyListItem_SeasonPassTier _itemPrefabReference; // 0xE8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _scrollToCurrentTier; // 0xF0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _scrollToOffset; // 0xF4
	private List<ISeasonPassTier> _dataItems; // 0xF8

	// Constructors
	public UI_LazyItemList_SeasonPassTier(); // 0x0000000180E5DF50-0x0000000180E5DF90

	// Methods
	public void Setup(List<ISeasonPassTier> inTiers); // 0x0000000180E5DE50-0x0000000180E5DE70
	protected override void Setup(); // 0x0000000180E5DCD0-0x0000000180E5DE50
	protected override List<ISeasonPassTier> GetDataItems(); // 0x00000001803BD310-0x00000001803BD320
	protected override UI_LazyListItemDetailPanel<ISeasonPassTier> GetDetailPanelReference(); // 0x000000018035FCC0-0x000000018035FCD0
	protected override UI_LazyListItem<ISeasonPassTier> GetListItemPrefab(); // 0x000000018037A250-0x000000018037A260
	protected override void SortData(); // 0x00000001803581E0-0x00000001803581F0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Setup>b__5_0(); // 0x0000000180E5DE70-0x0000000180E5DF50
}

