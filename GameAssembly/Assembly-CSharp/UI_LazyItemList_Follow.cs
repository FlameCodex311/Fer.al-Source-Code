/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyItemList_Follow : UI_LazyItemList<RelationshipManager.Follow> // TypeDefIndex: 12135
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyListItem_Follow _itemPrefabReference; // 0xE8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyListItemDetailPanel_Follow _detailPanelReference; // 0xF0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _followCountText; // 0xF8
	private List<RelationshipManager.Follow> _dataItems; // 0x100

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass8_0 // TypeDefIndex: 12136
	{
		// Fields
		public UserUnfollowedMessage inMessage; // 0x10

		// Constructors
		public <>c__DisplayClass8_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <OnUserUnfollowed>b__0(RelationshipManager.Follow follow); // 0x0000000180E3EB20-0x0000000180E3EB60
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12137
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Comparison<UI_LazyItemList<RelationshipManager.Follow>> <>9__17_0; // 0x08

		// Constructors
		static <>c(); // 0x0000000180E3EBC0-0x0000000180E3EC20
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal int <SortByDefault>b__17_0(UI_LazyItemList<RelationshipManager.Follow> a, UI_LazyItemList<RelationshipManager.Follow> b); // 0x0000000180E3DBB0-0x0000000180E3DD00
	}

	// Constructors
	public UI_LazyItemList_Follow(); // 0x0000000180E4E740-0x0000000180E4E780

	// Methods
	protected override void Setup(); // 0x0000000180E4E1A0-0x0000000180E4E3F0
	private void OnDestroy(); // 0x0000000180E4DF10-0x0000000180E4DFE0
	private void OnDisable(); // 0x0000000180E4DFE0-0x0000000180E4E020
	private void OnUserFollowed(UserFollowedMessage inMessage); // 0x0000000180E4E020-0x0000000180E4E0A0
	private void OnUserUnfollowed(UserUnfollowedMessage inMessage); // 0x0000000180E4E0A0-0x0000000180E4E1A0
	private void UpdateFollowCountText(); // 0x0000000180E4E670-0x0000000180E4E740
	protected override List<RelationshipManager.Follow> GetDataItems(); // 0x00000001803BD370-0x00000001803BD380
	protected override UI_LazyListItemDetailPanel<RelationshipManager.Follow> GetDetailPanelReference(); // 0x00000001803BD320-0x00000001803BD330
	protected override UI_LazyListItem<RelationshipManager.Follow> GetListItemPrefab(); // 0x000000018037A250-0x000000018037A260
	protected override string GetDataItemName(RelationshipManager.Follow inData); // 0x0000000180E4DEB0-0x0000000180E4DF10
	protected override long GetDataItemAge(RelationshipManager.Follow inData); // 0x0000000180E4DDF0-0x0000000180E4DE90
	protected override bool GetDataItemFav(RelationshipManager.Follow inData); // 0x0000000180E4DE90-0x0000000180E4DEB0
	protected override void SortData(); // 0x0000000180E4E4F0-0x0000000180E4E670
	private void SortByDefault(); // 0x0000000180E4E3F0-0x0000000180E4E4F0
	public void BtnClicked_FindPlayer(); // 0x0000000180E4DDE0-0x0000000180E4DDF0
}

