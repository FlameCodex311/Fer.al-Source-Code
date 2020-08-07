/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyItemList_BodyPart : UI_LazyItemList<ActorBodyPartDefComponent> // TypeDefIndex: 13569
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyListItem_BodyPart _itemPrefabReference; // 0xE8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyListItemDetailPanel_BodyPart _detailPanelReference; // 0xF0
	[RootSelector] // 0x0000000180269FB0-0x000000018026A030
	[SerializeField] // 0x0000000180269FB0-0x000000018026A030
	private string _bodyPartNodeDefId; // 0xF8
	private List<ActorBodyPartDefComponent> _dataItems; // 0x100

	// Properties
	private ActorInfo ActorInfo { get; } // 0x000000018037F750-0x000000018037F7A0 
	private bool DesignerMode { get; } // 0x000000018037F7A0-0x000000018037F800 

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 13570
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Predicate<ActorBodyPartDefComponent> <>9__9_0; // 0x08

		// Constructors
		static <>c(); // 0x0000000180373DD0-0x0000000180373E30
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <Setup>b__9_0(ActorBodyPartDefComponent item); // 0x0000000180372DC0-0x0000000180372DE0
	}

	// Constructors
	public UI_LazyItemList_BodyPart(); // 0x000000018037F700-0x000000018037F750

	// Methods
	private void OnDisable(); // 0x000000018037F200-0x000000018037F2C0
	protected override void Setup(); // 0x000000018037F2C0-0x000000018037F700
	private void OnBodyPartSelected(ActorBodyPartDefComponent inBodyPart); // 0x000000018037F040-0x000000018037F200
	protected override List<ActorBodyPartDefComponent> GetDataItems(); // 0x000000018037F030-0x000000018037F040
	protected override UI_LazyListItemDetailPanel<ActorBodyPartDefComponent> GetDetailPanelReference(); // 0x000000018037DDB0-0x000000018037DDC0
	protected override UI_LazyListItem<ActorBodyPartDefComponent> GetListItemPrefab(); // 0x000000018037DDD0-0x000000018037DDE0
}

