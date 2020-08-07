/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyItemList_ClothingPicker : UI_LazyItemList<ActorClothingDefComponent> // TypeDefIndex: 13457
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyListItem_ClothingPicker _itemPrefabReference; // 0xE8
	private List<ActorClothingDefComponent> _dataItems; // 0xF0

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 13458
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Comparison<UI_LazyItemList<ActorClothingDefComponent>> <>9__12_0; // 0x08

		// Constructors
		static <>c(); // 0x0000000180373D10-0x0000000180373D70
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal int <SortData>b__12_0(UI_LazyItemList<ActorClothingDefComponent> a, UI_LazyItemList<ActorClothingDefComponent> b); // 0x0000000180373020-0x00000001803730B0
	}

	// Constructors
	public UI_LazyItemList_ClothingPicker(); // 0x0000000180382330-0x0000000180382370

	// Methods
	private void OnDisable(); // 0x0000000180382020-0x0000000180382060
	protected override void Setup(); // 0x0000000180382060-0x0000000180382230
	protected override List<ActorClothingDefComponent> GetDataItems(); // 0x000000018037DDB0-0x000000018037DDC0
	protected override UI_LazyListItemDetailPanel<ActorClothingDefComponent> GetDetailPanelReference(); // 0x000000018037DDC0-0x000000018037DDD0
	protected override UI_LazyListItem<ActorClothingDefComponent> GetListItemPrefab(); // 0x000000018037DDD0-0x000000018037DDE0
	protected override bool ItemMatchesSearch(LazyListItem<ActorClothingDefComponent> inItem); // 0x0000000180381FD0-0x0000000180382020
	protected override string GetDataItemName(ActorClothingDefComponent inData); // 0x0000000180381DC0-0x0000000180381EF0
	protected override List<string> GetDataItemFilters(ActorClothingDefComponent inData); // 0x0000000180381D40-0x0000000180381DC0
	protected override List<string> GetDataItemTags(ActorClothingDefComponent inData); // 0x0000000180381F50-0x0000000180381FD0
	protected override int GetDataItemRarity(ActorClothingDefComponent inData); // 0x0000000180381EF0-0x0000000180381F50
	protected override void SortData(); // 0x0000000180382230-0x0000000180382330
}

