/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyItemList_AvatarLook : UI_LazyItemList<AvatarLookItemComponent> // TypeDefIndex: 13566
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyListItem_AvatarLook _itemPrefabReference; // 0xE8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyListItemDetailPanel_AvatarLook _detailPanelReference; // 0xF0
	private List<AvatarLookItemComponent> _dataItems; // 0xF8

	// Properties
	private ActorInfo ActorInfo { get; } // 0x000000018037EFE0-0x000000018037F030 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass13_0 // TypeDefIndex: 13567
	{
		// Fields
		public AvatarLookItemComponent inLookItem; // 0x10
		public UI_LazyItemList_AvatarLook <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass13_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <ItemSelected>b__0(bool inResponse); // 0x00000001803732F0-0x0000000180373480
	}

	// Constructors
	public UI_LazyItemList_AvatarLook(); // 0x000000018037EFA0-0x000000018037EFE0

	// Methods
	protected override void OnEnable(); // 0x000000018037EA00-0x000000018037EA80
	private void OnDisable(); // 0x000000018037E940-0x000000018037EA00
	protected override void Setup(); // 0x000000018037EA80-0x000000018037EDE0
	protected override List<AvatarLookItemComponent> GetDataItems(); // 0x000000018037E230-0x000000018037E240
	protected override UI_LazyListItemDetailPanel<AvatarLookItemComponent> GetDetailPanelReference(); // 0x000000018037DDB0-0x000000018037DDC0
	protected override UI_LazyListItem<AvatarLookItemComponent> GetListItemPrefab(); // 0x000000018037DDD0-0x000000018037DDE0
	protected override string GetDataItemName(AvatarLookItemComponent inData); // 0x000000018037E6F0-0x000000018037E750
	protected override void SortData(); // 0x000000018037EDE0-0x000000018037EE70
	private void ItemSelected(AvatarLookItemComponent inLookItem); // 0x000000018037E750-0x000000018037E940
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private int <SortData>b__12_0(LazyListItem<AvatarLookItemComponent> a, LazyListItem<AvatarLookItemComponent> b); // 0x000000018037EE70-0x000000018037EFA0
}

