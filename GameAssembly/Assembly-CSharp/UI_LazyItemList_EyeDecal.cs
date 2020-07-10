/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyItemList_EyeDecal : UI_LazyItemList<BaseDef> // TypeDefIndex: 12027
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyListItem_EyeDecal _itemPrefabReference; // 0xE8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyListItemDetailPanel_EyeDecal _detailPanelReference; // 0xF0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private EyeDecalType _eyeDecalType; // 0xF8
	private List<BaseDef> _dataItems; // 0x100

	// Properties
	private ActorInfo ActorInfo { get; } // 0x0000000180E4DD30-0x0000000180E4DD80 
	private bool DesignerMode { get; } // 0x0000000180E4DD80-0x0000000180E4DDE0 

	// Nested types
	private enum EyeDecalType // TypeDefIndex: 12028
	{
		Eye = 1,
		Pupil = 2
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12029
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Predicate<BaseDef> <>9__9_0; // 0x08

		// Constructors
		static <>c(); // 0x0000000180E3EB60-0x0000000180E3EBC0
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <Setup>b__9_0(BaseDef item); // 0x0000000180E3DB40-0x0000000180E3DB90
	}

	// Constructors
	public UI_LazyItemList_EyeDecal(); // 0x0000000180E4DCE0-0x0000000180E4DD30

	// Methods
	private void OnDisable(); // 0x0000000180E4D7A0-0x0000000180E4D7E0
	protected override void Setup(); // 0x0000000180E4D7E0-0x0000000180E4DCE0
	private void OnDecalSelected(BaseDef inDecal); // 0x0000000180E4D580-0x0000000180E4D7A0
	protected override List<BaseDef> GetDataItems(); // 0x00000001803BD370-0x00000001803BD380
	protected override UI_LazyListItemDetailPanel<BaseDef> GetDetailPanelReference(); // 0x00000001803BD320-0x00000001803BD330
	protected override UI_LazyListItem<BaseDef> GetListItemPrefab(); // 0x000000018037A250-0x000000018037A260
	protected override void SortData(); // 0x00000001803581E0-0x00000001803581F0
}

