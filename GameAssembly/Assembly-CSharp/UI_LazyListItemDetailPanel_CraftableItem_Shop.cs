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

public class UI_LazyListItemDetailPanel_CraftableItem_Shop : UI_LazyListItemDetailPanel<BaseDef> // TypeDefIndex: 12133
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _nameText; // 0x38
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Transform _arrow; // 0x40
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_ItemCraftRequirement _requirementPrefab; // 0x48
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Transform _requirementParent; // 0x50
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private TMP_InputField _quantityInputField; // 0x58
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWButton _craftBtn; // 0x60
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralAudioInfo _craftSound; // 0x68
	private List<UI_ItemCraftRequirement> _requirementItems; // 0x70
	private int _chosenQuantity; // 0x78
	private bool _craftingInProgress; // 0x7C

	// Properties
	public int ChosenQuantity { get; private set; } // 0x00000001803DAE10-0x00000001803DAE20 0x0000000180E63F30-0x0000000180E64110

	// Constructors
	public UI_LazyListItemDetailPanel_CraftableItem_Shop(); // 0x0000000180E63EC0-0x0000000180E63F30

	// Methods
	public override void Setup(UI_LazyListItem<BaseDef> inDataSrc); // 0x0000000180E638E0-0x0000000180E63B00
	public void LongPressProgress_Craft(float inProgress); // 0x0000000180E63340-0x0000000180E63360
	public void LongPressCancel_Craft(); // 0x0000000180E63300-0x0000000180E63320
	public void LongPressFinish_Craft(); // 0x0000000180E63320-0x0000000180E63340
	public void InputEnded_ChosenQuantity(string inValue); // 0x0000000180E63270-0x0000000180E63300
	public void BtnClicked_IncreaseChosenQuantity(); // 0x0000000180E63250-0x0000000180E63270
	public void BtnClicked_DecreaseChosenQuantity(); // 0x0000000180E63230-0x0000000180E63250
	protected virtual void OnCraftBegin(); // 0x0000000180E63360-0x0000000180E633A0
	protected virtual void OnCraftCancel(); // 0x0000000180E633A0-0x0000000180E633E0
	protected virtual void OnCraftFinish(); // 0x0000000180E633A0-0x0000000180E633E0
	private void Start(); // 0x0000000180E63DF0-0x0000000180E63EC0
	private void OnDestroy(); // 0x0000000180E633E0-0x0000000180E634B0
	private void SpawnRequirementItems(); // 0x0000000180E63B00-0x0000000180E63DF0
	private void OnInventoryUpdated(InventoryListResponse inMessage); // 0x0000000180E63600-0x0000000180E63750
	private void OnInventoryItemsRemoved(InventoryListRemovedResponse inMessage); // 0x0000000180E634B0-0x0000000180E63600
	private void RefreshCraftButton(); // 0x0000000180E63750-0x0000000180E638E0
}

