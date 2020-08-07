/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyItemList_Follower : UI_LazyItemList<RelationshipManager.Follower> // TypeDefIndex: 13685
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyListItem_Follower _itemPrefabReference; // 0xE8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyListItemDetailPanel_Follower _detailPanelReference; // 0xF0
	private List<RelationshipManager.Follower> _dataItems; // 0xF8
	private float _lastVerticalNormalizedPosition; // 0x100

	// Constructors
	public UI_LazyItemList_Follower(); // 0x0000000180387160-0x00000001803871A0

	// Methods
	public void ClearData(); // 0x0000000180386B80-0x0000000180386C00
	protected override void Setup(); // 0x0000000180386F00-0x0000000180387160
	private void OnScrollRectMoved(Vector2 inContentPosition); // 0x0000000180386E50-0x0000000180386F00
	private void OnDestroy(); // 0x0000000180386C20-0x0000000180386CB0
	private void OnDisable(); // 0x0000000180386CB0-0x0000000180386CF0
	protected override long GetDataItemAge(RelationshipManager.Follower inData); // 0x000000018037DDC0-0x000000018037DDD0
	protected override bool GetDataItemFav(RelationshipManager.Follower inData); // 0x0000000180386290-0x00000001803862B0
	protected override string GetDataItemName(RelationshipManager.Follower inData); // 0x0000000180386C00-0x0000000180386C20
	protected override int GetDataItemRarity(RelationshipManager.Follower inData); // 0x000000018037DDC0-0x000000018037DDD0
	protected override List<RelationshipManager.Follower> GetDataItems(); // 0x000000018037E230-0x000000018037E240
	protected override UI_LazyListItemDetailPanel<RelationshipManager.Follower> GetDetailPanelReference(); // 0x000000018037DDB0-0x000000018037DDC0
	protected override UI_LazyListItem<RelationshipManager.Follower> GetListItemPrefab(); // 0x000000018037DDD0-0x000000018037DDE0
	protected override bool ItemMatchesCategory(LazyListItem<RelationshipManager.Follower> inItem); // 0x0000000180380B60-0x0000000180380B70
	private void OnFollowersAdded(FollowersAddedMessage inMessage); // 0x0000000180386CF0-0x0000000180386E50
}

