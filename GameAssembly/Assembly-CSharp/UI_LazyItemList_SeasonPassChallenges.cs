/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyItemList_SeasonPassChallenges : UI_LazyItemList<ISeasonPassChallenge> // TypeDefIndex: 12120
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyListItem_SeasonPassChallenges _itemPrefabReference; // 0xE8
	private List<ISeasonPassChallenge> _dataItems; // 0xF0
	private List<ISeasonPassChallenge> _availableChallenges; // 0xF8

	// Constructors
	public UI_LazyItemList_SeasonPassChallenges(); // 0x0000000180E5DC90-0x0000000180E5DCD0

	// Methods
	protected override void Setup(); // 0x0000000180E5DB80-0x0000000180E5DC90
	protected override List<ISeasonPassChallenge> GetDataItems(); // 0x00000001803BD320-0x00000001803BD330
	protected override UI_LazyListItemDetailPanel<ISeasonPassChallenge> GetDetailPanelReference(); // 0x000000018035FCC0-0x000000018035FCD0
	protected override UI_LazyListItem<ISeasonPassChallenge> GetListItemPrefab(); // 0x000000018037A250-0x000000018037A260
	protected override void SortData(); // 0x00000001803581E0-0x00000001803581F0
	protected override bool ItemMatchesCategory(LazyListItem<ISeasonPassChallenge> inItem); // 0x0000000180E5DAA0-0x0000000180E5DB80
}

