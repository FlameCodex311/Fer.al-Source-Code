/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyListItem_SeasonPassTier : UI_LazyListItem<ISeasonPassTier> // TypeDefIndex: 13672
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _tierNumberText; // 0x68
	[Header] // 0x00000001801DB1B0-0x00000001801DB200
	[SerializeField] // 0x00000001801DB1B0-0x00000001801DB200
	private UI_ItemImage _rewardItemImage; // 0x70
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _rewardCountGroup; // 0x78
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _rewardCountText; // 0x80
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _rewardName; // 0x88
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_RarityBadge _rarityBadge; // 0x90
	[Header] // 0x00000001801DBBF0-0x00000001801DBC40
	[SerializeField] // 0x00000001801DBBF0-0x00000001801DBC40
	private GameObject _statusActiveGroup; // 0x98
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _statusCompleteGroup; // 0xA0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _statusCompleteUnearnedGroup; // 0xA8
	[Header] // 0x00000001801DD140-0x00000001801DD190
	[SerializeField] // 0x00000001801DD140-0x00000001801DD190
	private GameObject _freeGroup; // 0xB0
	[Header] // 0x000000018023F220-0x000000018023F270
	[SerializeField] // 0x000000018023F220-0x000000018023F270
	private WWTextMeshProUGUI _progressText; // 0xB8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Color _progressColorIncomplete; // 0xC0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Color _progressColorComplete; // 0xD0
	[Header] // 0x00000001801CDD40-0x00000001801CDD90
	[SerializeField] // 0x00000001801CDD40-0x00000001801CDD90
	private Transform _offsetTarget; // 0xE0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _maxYPos; // 0xE8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _minYPos; // 0xEC
	private LazyLayoutElement _layoutElement; // 0xF0
	private bool _visible; // 0xF8

	// Constructors
	public UI_LazyListItem_SeasonPassTier(); // 0x00000001803ADF80-0x00000001803ADFF0

	// Methods
	public override void Setup(Action<UI_LazyListItem<ISeasonPassTier>> inOnClicked, Action<UI_LazyListItem<ISeasonPassTier>> inOnSelected, ISeasonPassTier inData, UI_LazyItemList<ISeasonPassTier> inItemList); // 0x00000001803AD3F0-0x00000001803AD8E0
	public override void Refresh(); // 0x00000001803AD010-0x00000001803AD3F0
	protected override void Start(); // 0x00000001803AD8E0-0x00000001803AD9C0
	private void OnDestroy(); // 0x00000001803ACDA0-0x00000001803ACE70
	private void OnTierCompleted(SeasonPassTierCompletedMessage inMessage); // 0x00000001803ACF90-0x00000001803AD010
	private void OnInventoryChanged(InventoryItemChangedEvent inMessage); // 0x00000001803ACE70-0x00000001803ACF90
	public override void MarkAsSelected(bool inIsSelected); // 0x00000001803774A0-0x00000001803774B0
	protected override void OnClicked(); // 0x00000001803ACD50-0x00000001803ACDA0
	private void Update(); // 0x00000001803AD9C0-0x00000001803ADF80
}

