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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyListItem_ClothingInfo : UI_LazyListItem<ColorableItemComponent>, ISelectHandler // TypeDefIndex: 13630
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_ItemImage _itemImage; // 0x68
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CanvasGroup _canvasGroup; // 0x70
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _nameText; // 0x78
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _equippedBadge; // 0x80
	[Header] // 0x00000001801DB2C0-0x00000001801DB310
	[SerializeField] // 0x00000001801DB2C0-0x00000001801DB310
	private UI_RarityBadge _rarityBadge; // 0x88
	[Header] // 0x00000001801DAF30-0x00000001801DAF80
	[SerializeField] // 0x00000001801DAF30-0x00000001801DAF80
	private GameObject _memberGroup; // 0x90
	[Header] // 0x00000001801D2A20-0x00000001801D2A70
	[SerializeField] // 0x00000001801D2A20-0x00000001801D2A70
	private FeralAudioInfo _equipAudioInfo; // 0x98
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralAudioInfo _removeAudioInfo; // 0xA0
	[Header] // 0x0000000180281420-0x0000000180281470
	[SerializeField] // 0x0000000180281420-0x0000000180281470
	private FeralButton _editButton; // 0xA8
	private ActorInfo _actorInfo; // 0xB0
	private bool _isEquipped; // 0xB8
	private UI_Window_CreatureCustomization _window; // 0xC0

	// Constructors
	public UI_LazyListItem_ClothingInfo(); // 0x00000001803A3EC0-0x00000001803A3F00

	// Methods
	public override void Setup(Action<UI_LazyListItem<ColorableItemComponent>> inOnClicked, Action<UI_LazyListItem<ColorableItemComponent>> inOnSelected, ColorableItemComponent inData, UI_LazyItemList<ColorableItemComponent> inItemList); // 0x00000001803A3A40-0x00000001803A3E50
	private void OnDestroy(); // 0x00000001803A3820-0x00000001803A38F0
	private void OnEnable(); // 0x00000001803A38F0-0x00000001803A3940
	private void OnClothingItemEquip(ActorInfoClothingItem inInfo, bool inIsEquipped); // 0x00000001803A3740-0x00000001803A3820
	private void RefreshIsEquipped(); // 0x00000001803A3940-0x00000001803A3A40
	protected override void OnClicked(); // 0x00000001803A3680-0x00000001803A3740
	public override void MarkAsSelected(bool inIsSelected); // 0x00000001803774A0-0x00000001803774B0
	public void BtnClicked_Designer_EditItem(); // 0x00000001803A35B0-0x00000001803A3680
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <BtnClicked_Designer_EditItem>b__19_0(ActorInfoClothingItem item); // 0x00000001803A3E50-0x00000001803A3EC0
}

