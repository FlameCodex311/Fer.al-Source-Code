/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Services.Chat;
using TMPro;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyItemList_ChatEntry : UI_LazyItemList<ChatEntry> // TypeDefIndex: 11957
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyListItem_ChatEntry _itemPrefabReference; // 0xE8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyListItemDetailPanel_ChatEntry _detailPanelReference; // 0xF0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _sizeCalculationTarget; // 0xF8
	private List<ChatEntry> _dataItems; // 0x100

	// Constructors
	public UI_LazyItemList_ChatEntry(); // 0x0000000180E48860-0x0000000180E488A0

	// Methods
	public void Setup(List<ChatEntry> inChatItems); // 0x0000000180E487A0-0x0000000180E48820
	protected override void OnEnable(); // 0x0000000180E48300-0x0000000180E48350
	public void SetTextSize(int inTextSize); // 0x0000000180E48520-0x0000000180E487A0
	public void RefreshItemSizes(); // 0x0000000180E48350-0x0000000180E48520
	protected override void Setup(); // 0x0000000180E48820-0x0000000180E48860
	protected override List<ChatEntry> GetDataItems(); // 0x00000001803BD370-0x00000001803BD380
	protected override UI_LazyListItemDetailPanel<ChatEntry> GetDetailPanelReference(); // 0x00000001803BD320-0x00000001803BD330
	protected override UI_LazyListItem<ChatEntry> GetListItemPrefab(); // 0x000000018037A250-0x000000018037A260
	protected override LazyLayoutInfo CreateLayoutInfo(ChatEntry inItem); // 0x0000000180E48060-0x0000000180E48150
	private Vector2 GetItemSize(ChatEntry inItem); // 0x0000000180E48150-0x0000000180E48300
	protected override void SortData(); // 0x00000001803581E0-0x00000001803581F0
}

