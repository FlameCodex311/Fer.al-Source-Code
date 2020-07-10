/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyItemList_Follower : UI_LazyItemList<RelationshipManager.Follower> // TypeDefIndex: 12138
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyListItem_Follower _itemPrefabReference; // 0xE8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyListItemDetailPanel_Follower _detailPanelReference; // 0xF0
	private List<RelationshipManager.Follower> _dataItems; // 0xF8
	private float _lastVerticalNormalizedPosition; // 0x100

	// Constructors
	public UI_LazyItemList_Follower(); // 0x0000000180E4ED60-0x0000000180E4EDA0

	// Methods
	public void ClearData(); // 0x0000000180E4E780-0x0000000180E4E810
	protected override void Setup(); // 0x0000000180E4EAF0-0x0000000180E4ED60
	private void OnScrollRectMoved(Vector2 inContentPosition); // 0x0000000180E4EA40-0x0000000180E4EAF0
	private void OnDestroy(); // 0x0000000180E4E810-0x0000000180E4E8A0
	private void OnDisable(); // 0x0000000180E4E8A0-0x0000000180E4E8E0
	protected override long GetDataItemAge(RelationshipManager.Follower inData); // 0x000000018035FCC0-0x000000018035FCD0
	protected override bool GetDataItemFav(RelationshipManager.Follower inData); // 0x0000000180E4DE90-0x0000000180E4DEB0
	protected override string GetDataItemName(RelationshipManager.Follower inData); // 0x000000018059C9F0-0x000000018059CA10
	protected override int GetDataItemRarity(RelationshipManager.Follower inData); // 0x000000018035FCC0-0x000000018035FCD0
	protected override List<RelationshipManager.Follower> GetDataItems(); // 0x00000001803BD310-0x00000001803BD320
	protected override UI_LazyListItemDetailPanel<RelationshipManager.Follower> GetDetailPanelReference(); // 0x00000001803BD320-0x00000001803BD330
	protected override UI_LazyListItem<RelationshipManager.Follower> GetListItemPrefab(); // 0x000000018037A250-0x000000018037A260
	protected override bool ItemMatchesCategory(LazyListItem<RelationshipManager.Follower> inItem); // 0x00000001803C29F0-0x00000001803C2A00
	private void OnFollowersAdded(FollowersAddedMessage inMessage); // 0x0000000180E4E8E0-0x0000000180E4EA40
}

