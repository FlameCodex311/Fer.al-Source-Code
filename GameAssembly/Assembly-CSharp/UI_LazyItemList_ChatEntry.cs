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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyItemList_ChatEntry : UI_LazyItemList<ChatEntry> // TypeDefIndex: 13503
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyListItem_ChatEntry _itemPrefabReference; // 0xE8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyListItemDetailPanel_ChatEntry _detailPanelReference; // 0xF0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _sizeCalculationTarget; // 0xF8
	private List<ChatEntry> _dataItems; // 0x100

	// Constructors
	public UI_LazyItemList_ChatEntry(); // 0x0000000180380730-0x0000000180380770

	// Methods
	public void Setup(List<ChatEntry> inChatItems); // 0x0000000180380670-0x00000001803806F0
	protected override void OnEnable(); // 0x00000001803801D0-0x0000000180380220
	public void SetTextSize(int inTextSize); // 0x00000001803803F0-0x0000000180380670
	public void RefreshItemSizes(); // 0x0000000180380220-0x00000001803803F0
	protected override void Setup(); // 0x00000001803806F0-0x0000000180380730
	protected override List<ChatEntry> GetDataItems(); // 0x000000018037F030-0x000000018037F040
	protected override UI_LazyListItemDetailPanel<ChatEntry> GetDetailPanelReference(); // 0x000000018037DDB0-0x000000018037DDC0
	protected override UI_LazyListItem<ChatEntry> GetListItemPrefab(); // 0x000000018037DDD0-0x000000018037DDE0
	protected override LazyLayoutInfo CreateLayoutInfo(ChatEntry inItem); // 0x000000018037FF30-0x0000000180380020
	private Vector2 GetItemSize(ChatEntry inItem); // 0x0000000180380020-0x00000001803801D0
	protected override void SortData(); // 0x00000001803774A0-0x00000001803774B0
}

