/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyItemList_AvatarLook : UI_LazyItemList<AvatarLookItemComponent> // TypeDefIndex: 12020
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyListItem_AvatarLook _itemPrefabReference; // 0xE8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyListItemDetailPanel_AvatarLook _detailPanelReference; // 0xF0
	private List<AvatarLookItemComponent> _dataItems; // 0xF8

	// Properties
	private ActorInfo ActorInfo { get; } // 0x0000000180E47120-0x0000000180E47170 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass13_0 // TypeDefIndex: 12021
	{
		// Fields
		public AvatarLookItemComponent inLookItem; // 0x10
		public UI_LazyItemList_AvatarLook <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass13_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <ItemSelected>b__0(bool inResponse); // 0x0000000180E3E120-0x0000000180E3E2C0
	}

	// Constructors
	public UI_LazyItemList_AvatarLook(); // 0x0000000180E470E0-0x0000000180E47120

	// Methods
	protected override void OnEnable(); // 0x0000000180E46B20-0x0000000180E46BA0
	private void OnDisable(); // 0x0000000180E46A60-0x0000000180E46B20
	protected override void Setup(); // 0x0000000180E46BA0-0x0000000180E46F10
	protected override List<AvatarLookItemComponent> GetDataItems(); // 0x00000001803BD310-0x00000001803BD320
	protected override UI_LazyListItemDetailPanel<AvatarLookItemComponent> GetDetailPanelReference(); // 0x00000001803BD320-0x00000001803BD330
	protected override UI_LazyListItem<AvatarLookItemComponent> GetListItemPrefab(); // 0x000000018037A250-0x000000018037A260
	protected override string GetDataItemName(AvatarLookItemComponent inData); // 0x0000000180E46800-0x0000000180E46860
	protected override void SortData(); // 0x0000000180E46F10-0x0000000180E46FA0
	private void ItemSelected(AvatarLookItemComponent inLookItem); // 0x0000000180E46860-0x0000000180E46A60
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private int <SortData>b__12_0(LazyListItem<AvatarLookItemComponent> a, LazyListItem<AvatarLookItemComponent> b); // 0x0000000180E46FA0-0x0000000180E470E0
}

