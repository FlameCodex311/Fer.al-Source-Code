/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyItemList_Follow : UI_LazyItemList<RelationshipManager.Follow> // TypeDefIndex: 13682
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyListItem_Follow _itemPrefabReference; // 0xE8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyListItemDetailPanel_Follow _detailPanelReference; // 0xF0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _followCountText; // 0xF8
	private List<RelationshipManager.Follow> _dataItems; // 0x100

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass8_0 // TypeDefIndex: 13683
	{
		// Fields
		public UserUnfollowedMessage inMessage; // 0x10

		// Constructors
		public <>c__DisplayClass8_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <OnUserUnfollowed>b__0(RelationshipManager.Follow follow); // 0x0000000180373B50-0x0000000180373B90
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 13684
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Comparison<UI_LazyItemList<RelationshipManager.Follow>> <>9__17_0; // 0x08

		// Constructors
		static <>c(); // 0x0000000180373BF0-0x0000000180373C50
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal int <SortByDefault>b__17_0(UI_LazyItemList<RelationshipManager.Follow> a, UI_LazyItemList<RelationshipManager.Follow> b); // 0x0000000180372DE0-0x0000000180372F20
	}

	// Constructors
	public UI_LazyItemList_Follow(); // 0x0000000180386B40-0x0000000180386B80

	// Methods
	protected override void Setup(); // 0x00000001803865A0-0x00000001803867F0
	private void OnDestroy(); // 0x0000000180386310-0x00000001803863E0
	private void OnDisable(); // 0x00000001803863E0-0x0000000180386420
	private void OnUserFollowed(UserFollowedMessage inMessage); // 0x0000000180386420-0x00000001803864A0
	private void OnUserUnfollowed(UserUnfollowedMessage inMessage); // 0x00000001803864A0-0x00000001803865A0
	private void UpdateFollowCountText(); // 0x0000000180386A70-0x0000000180386B40
	protected override List<RelationshipManager.Follow> GetDataItems(); // 0x000000018037F030-0x000000018037F040
	protected override UI_LazyListItemDetailPanel<RelationshipManager.Follow> GetDetailPanelReference(); // 0x000000018037DDB0-0x000000018037DDC0
	protected override UI_LazyListItem<RelationshipManager.Follow> GetListItemPrefab(); // 0x000000018037DDD0-0x000000018037DDE0
	protected override string GetDataItemName(RelationshipManager.Follow inData); // 0x00000001803862B0-0x0000000180386310
	protected override long GetDataItemAge(RelationshipManager.Follow inData); // 0x00000001803861F0-0x0000000180386290
	protected override bool GetDataItemFav(RelationshipManager.Follow inData); // 0x0000000180386290-0x00000001803862B0
	protected override void SortData(); // 0x00000001803868F0-0x0000000180386A70
	private void SortByDefault(); // 0x00000001803867F0-0x00000001803868F0
	public void BtnClicked_FindPlayer(); // 0x00000001803861E0-0x00000001803861F0
}

