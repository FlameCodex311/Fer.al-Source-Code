/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyItemList_ActorClassPicker : UI_LazyItemList<ActorClassDefComponent> // TypeDefIndex: 13456
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyListItem_ActorClassPicker _itemPrefabReference; // 0xE8
	private List<ActorClassDefComponent> _dataItems; // 0xF0

	// Constructors
	public UI_LazyItemList_ActorClassPicker(); // 0x000000018037E040-0x000000018037E080

	// Methods
	private void OnDisable(); // 0x000000018037DE30-0x000000018037DE70
	protected override void Setup(); // 0x000000018037DE70-0x000000018037E040
	protected override List<ActorClassDefComponent> GetDataItems(); // 0x000000018037DDB0-0x000000018037DDC0
	protected override UI_LazyListItemDetailPanel<ActorClassDefComponent> GetDetailPanelReference(); // 0x000000018037DDC0-0x000000018037DDD0
	protected override UI_LazyListItem<ActorClassDefComponent> GetListItemPrefab(); // 0x000000018037DDD0-0x000000018037DDE0
	protected override bool ItemMatchesSearch(LazyListItem<ActorClassDefComponent> inItem); // 0x000000018037DDE0-0x000000018037DE30
	protected override string GetDataItemName(ActorClassDefComponent inData); // 0x000000018037DCC0-0x000000018037DD30
	protected override List<string> GetDataItemFilters(ActorClassDefComponent inData); // 0x000000018037DC40-0x000000018037DCC0
	protected override List<string> GetDataItemTags(ActorClassDefComponent inData); // 0x000000018037DD30-0x000000018037DDB0
}

