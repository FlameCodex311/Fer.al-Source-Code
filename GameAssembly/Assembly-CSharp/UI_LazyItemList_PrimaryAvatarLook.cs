/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyItemList_PrimaryAvatarLook : UI_LazyItemList<AvatarLookItemComponent> // TypeDefIndex: 13576
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyListItem_PrimaryAvatarLook _itemPrefabReference; // 0xE8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyListItemDetailPanel_PrimaryAvatarLook _detailPanelReference; // 0xF0
	private List<AvatarLookItemComponent> _dataItems; // 0xF8

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 13577
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<bool> <>9__4_0; // 0x08

		// Constructors
		static <>c(); // 0x00000001803880C0-0x0000000180388120
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <Start>b__4_0(); // 0x0000000180387A50-0x0000000180387AC0
	}

	// Constructors
	public UI_LazyItemList_PrimaryAvatarLook(); // 0x000000018038C500-0x000000018038C540

	// Methods
	public void RefreshAll(); // 0x000000018038BF30-0x000000018038C060
	protected override void Start(); // 0x000000018038C300-0x000000018038C420
	private void OnDestroy(); // 0x000000018038BD60-0x000000018038BE70
	protected override void OnEnable(); // 0x000000018038BEB0-0x000000018038BF30
	private void OnDisable(); // 0x000000018038BE70-0x000000018038BEB0
	protected override void Setup(); // 0x000000018038C060-0x000000018038C2C0
	protected override List<AvatarLookItemComponent> GetDataItems(); // 0x000000018037E230-0x000000018037E240
	protected override UI_LazyListItemDetailPanel<AvatarLookItemComponent> GetDetailPanelReference(); // 0x000000018037DDB0-0x000000018037DDC0
	protected override UI_LazyListItem<AvatarLookItemComponent> GetListItemPrefab(); // 0x000000018037DDD0-0x000000018037DDE0
	protected override string GetDataItemName(AvatarLookItemComponent inData); // 0x000000018038BCC0-0x000000018038BD50
	protected override void SortData(); // 0x000000018038C2C0-0x000000018038C300
	private void OnCurrentLookChanged(CreatureCustomizationTarget inTarget); // 0x000000018038BD50-0x000000018038BD60
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Start>b__4_1(); // 0x000000018038C420-0x000000018038C500
}

