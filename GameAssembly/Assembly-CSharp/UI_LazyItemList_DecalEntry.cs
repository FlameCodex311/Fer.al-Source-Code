/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyItemList_DecalEntry : UI_LazyItemList<ActorInfoDecalEntry> // TypeDefIndex: 13571
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyListItem_DecalEntry _listItemPrefab; // 0xE8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyListItemDetailPanel_DecalEntry _detailPanelReference; // 0xF0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _addDecalBtn; // 0xF8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_AvatarPositioner _avatarPositioner; // 0x100
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_CustomizationPageNavigationController _navigationController; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_CustomizationPageInfo _editDecalPageInfo; // 0x110
	[Header] // 0x000000018026AD40-0x000000018026AD90
	[SerializeField] // 0x000000018026AD40-0x000000018026AD90
	private Color _redDecalCountColor; // 0x118
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _decalCountText; // 0x128
	private List<ActorInfoDecalEntry> _dataItems; // 0x130
	private UI_Window_CreatureCustomization _window; // 0x138

	// Properties
	public UI_AvatarPositioner AvatarPositioner { get; } // 0x000000018037F030-0x000000018037F040 
	public UI_CustomizationPageNavigationController NavigationController { get; } // 0x0000000180380B50-0x0000000180380B60 
	public UI_CustomizationPageInfo EditDecalPageInfo { get; } // 0x0000000180385320-0x0000000180385330 
	private ActorInfo ActorInfo { get; } // 0x00000001803852D0-0x0000000180385320 
	private UI_Window_CreatureCustomization Window { get; } // 0x0000000180385330-0x00000001803853E0 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass33_0 // TypeDefIndex: 13572
	{
		// Fields
		public ActorInfoDecalEntry entry; // 0x10
		public UI_LazyItemList_DecalEntry <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass33_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <BtnClicked_AddDecal>b__2(); // 0x00000001803739A0-0x0000000180373A30
		internal void <BtnClicked_AddDecal>b__3(); // 0x0000000180373A30-0x0000000180373A80
	}

	// Constructors
	public UI_LazyItemList_DecalEntry(); // 0x0000000180385280-0x00000001803852D0

	// Methods
	protected override void Setup(); // 0x0000000180384540-0x0000000180384AF0
	protected override void OnEnable(); // 0x0000000180384320-0x00000001803844A0
	private void OnDisable(); // 0x0000000180383F80-0x0000000180384320
	private void OnDecalCountChanged(int inDecalCount); // 0x0000000180383C90-0x0000000180383E50
	private void OnDecalSelected(ActorInfoDecalEntry inSelectedDecal); // 0x0000000180383ED0-0x0000000180383F80
	private void OnDecalAdded(ActorInfoDecalEntry inDecal); // 0x0000000180383C10-0x0000000180383C90
	private void OnDecalRemoved(ActorInfoDecalEntry inDecal); // 0x0000000180383E50-0x0000000180383ED0
	protected override List<ActorInfoDecalEntry> GetDataItems(); // 0x0000000180383C00-0x0000000180383C10
	protected override UI_LazyListItemDetailPanel<ActorInfoDecalEntry> GetDetailPanelReference(); // 0x000000018037DDB0-0x000000018037DDC0
	protected override UI_LazyListItem<ActorInfoDecalEntry> GetListItemPrefab(); // 0x000000018037DDD0-0x000000018037DDE0
	protected override void SortData(); // 0x0000000180384AF0-0x0000000180384B90
	protected override bool ItemMatchesCategory(LazyListItem<ActorInfoDecalEntry> inItem); // 0x0000000180380B60-0x0000000180380B70
	protected override void PostListFilter(int inShownItemsCount); // 0x00000001803844A0-0x0000000180384540
	public void BtnClicked_AddDecal(); // 0x0000000180383A40-0x0000000180383AD0
	public void BtnClicked_RemoveAllDecals(); // 0x0000000180383AD0-0x0000000180383C00
	public void ToggleBtnClicked_ShowDefaultDecals(bool inIsOn); // 0x0000000180384B90-0x0000000180384C00
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <OnEnable>b__21_0(); // 0x0000000180384EB0-0x00000001803851C0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private int <SortData>b__30_0(LazyListItem<ActorInfoDecalEntry> a, LazyListItem<ActorInfoDecalEntry> b); // 0x00000001803851C0-0x0000000180385280
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <BtnClicked_AddDecal>b__33_0(UI_Window_SelectDecal window); // 0x0000000180384C00-0x0000000180384C80
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <BtnClicked_AddDecal>b__33_1(BaseDef inSelectedDecalDef); // 0x0000000180384C80-0x0000000180384E40
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <BtnClicked_RemoveAllDecals>b__34_0(bool inResponse); // 0x0000000180384E40-0x0000000180384EB0
}

