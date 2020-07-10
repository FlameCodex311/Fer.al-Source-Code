/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyItemList_BodyPart : UI_LazyItemList<ActorBodyPartDefComponent> // TypeDefIndex: 12023
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyListItem_BodyPart _itemPrefabReference; // 0xE8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyListItemDetailPanel_BodyPart _detailPanelReference; // 0xF0
	[RootSelector] // 0x00000001800C6ED0-0x00000001800C6F50
	[SerializeField] // 0x00000001800C6ED0-0x00000001800C6F50
	private string _bodyPartNodeDefId; // 0xF8
	private List<ActorBodyPartDefComponent> _dataItems; // 0x100

	// Properties
	private ActorInfo ActorInfo { get; } // 0x0000000180E47890-0x0000000180E478E0 
	private bool DesignerMode { get; } // 0x0000000180E478E0-0x0000000180E47940 

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12024
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Predicate<ActorBodyPartDefComponent> <>9__9_0; // 0x08

		// Constructors
		static <>c(); // 0x0000000180E3EDA0-0x0000000180E3EE00
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <Setup>b__9_0(ActorBodyPartDefComponent item); // 0x0000000180E3DB90-0x0000000180E3DBB0
	}

	// Constructors
	public UI_LazyItemList_BodyPart(); // 0x0000000180E47840-0x0000000180E47890

	// Methods
	private void OnDisable(); // 0x0000000180E47330-0x0000000180E473F0
	protected override void Setup(); // 0x0000000180E473F0-0x0000000180E47840
	private void OnBodyPartSelected(ActorBodyPartDefComponent inBodyPart); // 0x0000000180E47170-0x0000000180E47330
	protected override List<ActorBodyPartDefComponent> GetDataItems(); // 0x00000001803BD370-0x00000001803BD380
	protected override UI_LazyListItemDetailPanel<ActorBodyPartDefComponent> GetDetailPanelReference(); // 0x00000001803BD320-0x00000001803BD330
	protected override UI_LazyListItem<ActorBodyPartDefComponent> GetListItemPrefab(); // 0x000000018037A250-0x000000018037A260
}

