/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyListItem_ClothingInfo : UI_LazyListItem<ColorableItemComponent>, ISelectHandler // TypeDefIndex: 12080
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_ItemImage _itemImage; // 0x68
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CanvasGroup _canvasGroup; // 0x70
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _nameText; // 0x78
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _equippedBadge; // 0x80
	[Header] // 0x00000001800D9B70-0x00000001800D9BC0
	[SerializeField] // 0x00000001800D9B70-0x00000001800D9BC0
	private UI_RarityBadge _rarityBadge; // 0x88
	[Header] // 0x00000001800D9D80-0x00000001800D9DD0
	[SerializeField] // 0x00000001800D9D80-0x00000001800D9DD0
	private GameObject _memberGroup; // 0x90
	[Header] // 0x00000001800DA180-0x00000001800DA1D0
	[SerializeField] // 0x00000001800DA180-0x00000001800DA1D0
	private FeralAudioInfo _equipAudioInfo; // 0x98
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralAudioInfo _removeAudioInfo; // 0xA0
	[Header] // 0x00000001800DA560-0x00000001800DA5B0
	[SerializeField] // 0x00000001800DA560-0x00000001800DA5B0
	private FeralButton _editButton; // 0xA8
	private ActorInfo _actorInfo; // 0xB0
	private bool _isEquipped; // 0xB8
	private UI_Window_CreatureCustomization _window; // 0xC0

	// Constructors
	public UI_LazyListItem_ClothingInfo(); // 0x0000000180E70700-0x0000000180E70740

	// Methods
	public override void Setup(Action<UI_LazyListItem<ColorableItemComponent>> inOnClicked, Action<UI_LazyListItem<ColorableItemComponent>> inOnSelected, ColorableItemComponent inData, UI_LazyItemList<ColorableItemComponent> inItemList); // 0x0000000180E70260-0x0000000180E70680
	private void OnDestroy(); // 0x0000000180E70040-0x0000000180E70110
	private void OnEnable(); // 0x0000000180E70110-0x0000000180E70160
	private void OnClothingItemEquip(ActorInfoClothingItem inInfo, bool inIsEquipped); // 0x0000000180E6FF60-0x0000000180E70040
	private void RefreshIsEquipped(); // 0x0000000180E70160-0x0000000180E70260
	protected override void OnClicked(); // 0x0000000180E6FEA0-0x0000000180E6FF60
	public override void MarkAsSelected(bool inIsSelected); // 0x00000001803581E0-0x00000001803581F0
	public void BtnClicked_Designer_EditItem(); // 0x0000000180E6FDD0-0x0000000180E6FEA0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <BtnClicked_Designer_EditItem>b__19_0(ActorInfoClothingItem item); // 0x0000000180E70680-0x0000000180E70700
}

