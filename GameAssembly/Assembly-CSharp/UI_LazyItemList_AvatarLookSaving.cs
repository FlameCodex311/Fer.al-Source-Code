/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyItemList_AvatarLookSaving : UI_LazyItemList<AvatarLookItemComponent> // TypeDefIndex: 13568
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyListItem_AvatarLookSaving _itemPrefabReference; // 0xE8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyListItemDetailPanel_AvatarLookSaving _detailPanelReference; // 0xF0
	private List<AvatarLookItemComponent> _dataItems; // 0xF8

	// Constructors
	public UI_LazyItemList_AvatarLookSaving(); // 0x000000018037E6B0-0x000000018037E6F0

	// Methods
	public void Setup(string inActorClassDefId); // 0x000000018037E240-0x000000018037E4F0
	protected override List<AvatarLookItemComponent> GetDataItems(); // 0x000000018037E230-0x000000018037E240
	protected override UI_LazyListItemDetailPanel<AvatarLookItemComponent> GetDetailPanelReference(); // 0x000000018037DDB0-0x000000018037DDC0
	protected override UI_LazyListItem<AvatarLookItemComponent> GetListItemPrefab(); // 0x000000018037DDD0-0x000000018037DDE0
	protected override void SortData(); // 0x000000018037E4F0-0x000000018037E580
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private int <SortData>b__7_0(LazyListItem<AvatarLookItemComponent> a, LazyListItem<AvatarLookItemComponent> b); // 0x000000018037E580-0x000000018037E6B0
}

