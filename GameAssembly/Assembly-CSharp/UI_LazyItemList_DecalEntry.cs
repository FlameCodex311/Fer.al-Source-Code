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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyItemList_DecalEntry : UI_LazyItemList<ActorInfoDecalEntry> // TypeDefIndex: 12025
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyListItem_DecalEntry _listItemPrefab; // 0xE8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyListItemDetailPanel_DecalEntry _detailPanelReference; // 0xF0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _addDecalBtn; // 0xF8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_AvatarPositioner _avatarPositioner; // 0x100
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_CustomizationPageNavigationController _navigationController; // 0x108
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_CustomizationPageInfo _editDecalPageInfo; // 0x110
	[Header] // 0x00000001800C82F0-0x00000001800C8340
	[SerializeField] // 0x00000001800C82F0-0x00000001800C8340
	private Color _redDecalCountColor; // 0x118
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _decalCountText; // 0x128
	private List<ActorInfoDecalEntry> _dataItems; // 0x130
	private UI_Window_CreatureCustomization _window; // 0x138

	// Properties
	public UI_AvatarPositioner AvatarPositioner { get; } // 0x00000001803BD370-0x00000001803BD380 
	public UI_CustomizationPageNavigationController NavigationController { get; } // 0x00000001803BD3C0-0x00000001803BD3D0 
	public UI_CustomizationPageInfo EditDecalPageInfo { get; } // 0x00000001803BD380-0x00000001803BD390 
	private ActorInfo ActorInfo { get; } // 0x0000000180E4CEC0-0x0000000180E4CF10 
	private UI_Window_CreatureCustomization Window { get; } // 0x0000000180E4CF10-0x0000000180E4CFC0 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass33_0 // TypeDefIndex: 12026
	{
		// Fields
		public ActorInfoDecalEntry entry; // 0x10
		public UI_LazyItemList_DecalEntry <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass33_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <BtnClicked_AddDecal>b__2(); // 0x0000000180E3E860-0x0000000180E3E8F0
		internal void <BtnClicked_AddDecal>b__3(); // 0x0000000180E3E8F0-0x0000000180E3E940
	}

	// Constructors
	public UI_LazyItemList_DecalEntry(); // 0x0000000180E4CE70-0x0000000180E4CEC0

	// Methods
	protected override void Setup(); // 0x0000000180E4C100-0x0000000180E4C6C0
	protected override void OnEnable(); // 0x0000000180E4BED0-0x0000000180E4C060
	private void OnDisable(); // 0x0000000180E4BB20-0x0000000180E4BED0
	private void OnDecalCountChanged(int inDecalCount); // 0x0000000180E4B820-0x0000000180E4B9F0
	private void OnDecalSelected(ActorInfoDecalEntry inSelectedDecal); // 0x0000000180E4BA70-0x0000000180E4BB20
	private void OnDecalAdded(ActorInfoDecalEntry inDecal); // 0x0000000180E4B7A0-0x0000000180E4B820
	private void OnDecalRemoved(ActorInfoDecalEntry inDecal); // 0x0000000180E4B9F0-0x0000000180E4BA70
	protected override List<ActorInfoDecalEntry> GetDataItems(); // 0x00000001803BD390-0x00000001803BD3A0
	protected override UI_LazyListItemDetailPanel<ActorInfoDecalEntry> GetDetailPanelReference(); // 0x00000001803BD320-0x00000001803BD330
	protected override UI_LazyListItem<ActorInfoDecalEntry> GetListItemPrefab(); // 0x000000018037A250-0x000000018037A260
	protected override void SortData(); // 0x0000000180E4C6C0-0x0000000180E4C760
	protected override bool ItemMatchesCategory(LazyListItem<ActorInfoDecalEntry> inItem); // 0x00000001803C29F0-0x00000001803C2A00
	protected override void PostListFilter(int inShownItemsCount); // 0x0000000180E4C060-0x0000000180E4C100
	public void BtnClicked_AddDecal(); // 0x0000000180E4B5E0-0x0000000180E4B670
	public void BtnClicked_RemoveAllDecals(); // 0x0000000180E4B670-0x0000000180E4B7A0
	public void ToggleBtnClicked_ShowDefaultDecals(bool inIsOn); // 0x0000000180E4C760-0x0000000180E4C7D0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <OnEnable>b__21_0(); // 0x0000000180E4CA90-0x0000000180E4CDB0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private int <SortData>b__30_0(LazyListItem<ActorInfoDecalEntry> a, LazyListItem<ActorInfoDecalEntry> b); // 0x0000000180E4CDB0-0x0000000180E4CE70
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <BtnClicked_AddDecal>b__33_0(UI_Window_SelectDecal window); // 0x0000000180E4C7D0-0x0000000180E4C860
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <BtnClicked_AddDecal>b__33_1(BaseDef inSelectedDecalDef); // 0x0000000180E4C860-0x0000000180E4CA20
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <BtnClicked_RemoveAllDecals>b__34_0(bool inResponse); // 0x0000000180E4CA20-0x0000000180E4CA90
}

