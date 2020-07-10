/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyItemList_PrimaryAvatarLook : UI_LazyItemList<AvatarLookItemComponent> // TypeDefIndex: 12030
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyListItem_PrimaryAvatarLook _itemPrefabReference; // 0xE8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyListItemDetailPanel_PrimaryAvatarLook _detailPanelReference; // 0xF0
	private List<AvatarLookItemComponent> _dataItems; // 0xF8

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12031
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<bool> <>9__4_0; // 0x08

		// Constructors
		static <>c(); // 0x0000000180E5ABB0-0x0000000180E5AC10
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <Start>b__4_0(); // 0x0000000180E5A780-0x0000000180E5A7F0
	}

	// Constructors
	public UI_LazyItemList_PrimaryAvatarLook(); // 0x0000000180E536A0-0x0000000180E536E0

	// Methods
	public void RefreshAll(); // 0x0000000180E530C0-0x0000000180E53200
	protected override void Start(); // 0x0000000180E534A0-0x0000000180E535C0
	private void OnDestroy(); // 0x0000000180E52EF0-0x0000000180E53000
	protected override void OnEnable(); // 0x0000000180E53040-0x0000000180E530C0
	private void OnDisable(); // 0x0000000180E53000-0x0000000180E53040
	protected override void Setup(); // 0x0000000180E53200-0x0000000180E53460
	protected override List<AvatarLookItemComponent> GetDataItems(); // 0x00000001803BD310-0x00000001803BD320
	protected override UI_LazyListItemDetailPanel<AvatarLookItemComponent> GetDetailPanelReference(); // 0x00000001803BD320-0x00000001803BD330
	protected override UI_LazyListItem<AvatarLookItemComponent> GetListItemPrefab(); // 0x000000018037A250-0x000000018037A260
	protected override string GetDataItemName(AvatarLookItemComponent inData); // 0x0000000180E52E40-0x0000000180E52EE0
	protected override void SortData(); // 0x0000000180E53460-0x0000000180E534A0
	private void OnCurrentLookChanged(CreatureCustomizationTarget inTarget); // 0x0000000180E52EE0-0x0000000180E52EF0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Start>b__4_1(); // 0x0000000180E535C0-0x0000000180E536A0
}

