/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyItemList_SeasonPassChallenges : UI_LazyItemList<ISeasonPassChallenge> // TypeDefIndex: 13666
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyListItem_SeasonPassChallenges _itemPrefabReference; // 0xE8
	private List<ISeasonPassChallenge> _dataItems; // 0xF0
	private List<ISeasonPassChallenge> _availableChallenges; // 0xF8

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass11_0 // TypeDefIndex: 13667
	{
		// Fields
		public SeasonPassChallengeCompleteResponse inMessage; // 0x10

		// Constructors
		public <>c__DisplayClass11_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <OnChallengeCompleted>b__0(ISeasonPassChallenge item); // 0x0000000180387BC0-0x0000000180387C90
	}

	// Constructors
	public UI_LazyItemList_SeasonPassChallenges(); // 0x000000018038F800-0x000000018038F840

	// Methods
	protected override void Start(); // 0x000000018038F760-0x000000018038F800
	private void OnDestroy(); // 0x000000018038F5D0-0x000000018038F660
	protected override void Setup(); // 0x000000018038F660-0x000000018038F760
	protected override List<ISeasonPassChallenge> GetDataItems(); // 0x000000018037DDB0-0x000000018037DDC0
	protected override UI_LazyListItemDetailPanel<ISeasonPassChallenge> GetDetailPanelReference(); // 0x000000018037DDC0-0x000000018037DDD0
	protected override UI_LazyListItem<ISeasonPassChallenge> GetListItemPrefab(); // 0x000000018037DDD0-0x000000018037DDE0
	protected override void SortData(); // 0x00000001803774A0-0x00000001803774B0
	protected override bool ItemMatchesCategory(LazyListItem<ISeasonPassChallenge> inItem); // 0x000000018038F3B0-0x000000018038F490
	private void OnChallengeCompleted(SeasonPassChallengeCompleteResponse inMessage); // 0x000000018038F490-0x000000018038F5D0
}

