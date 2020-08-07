/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyItemList_EyeDecal : UI_LazyItemList<BaseDef> // TypeDefIndex: 13573
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyListItem_EyeDecal _itemPrefabReference; // 0xE8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyListItemDetailPanel_EyeDecal _detailPanelReference; // 0xF0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private EyeDecalType _eyeDecalType; // 0xF8
	private List<BaseDef> _dataItems; // 0x100

	// Properties
	private ActorInfo ActorInfo { get; } // 0x0000000180386130-0x0000000180386180 
	private bool DesignerMode { get; } // 0x0000000180386180-0x00000001803861E0 

	// Nested types
	private enum EyeDecalType // TypeDefIndex: 13574
	{
		Eye = 1,
		Pupil = 2
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 13575
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Predicate<BaseDef> <>9__9_0; // 0x08

		// Constructors
		static <>c(); // 0x0000000180373B90-0x0000000180373BF0
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <Setup>b__9_0(BaseDef item); // 0x0000000180372D70-0x0000000180372DC0
	}

	// Constructors
	public UI_LazyItemList_EyeDecal(); // 0x00000001803860E0-0x0000000180386130

	// Methods
	private void OnDisable(); // 0x0000000180385BB0-0x0000000180385BF0
	protected override void Setup(); // 0x0000000180385BF0-0x00000001803860E0
	private void OnDecalSelected(BaseDef inDecal); // 0x00000001803859A0-0x0000000180385BB0
	protected override List<BaseDef> GetDataItems(); // 0x000000018037F030-0x000000018037F040
	protected override UI_LazyListItemDetailPanel<BaseDef> GetDetailPanelReference(); // 0x000000018037DDB0-0x000000018037DDC0
	protected override UI_LazyListItem<BaseDef> GetListItemPrefab(); // 0x000000018037DDD0-0x000000018037DDE0
	protected override void SortData(); // 0x00000001803774A0-0x00000001803774B0
}

