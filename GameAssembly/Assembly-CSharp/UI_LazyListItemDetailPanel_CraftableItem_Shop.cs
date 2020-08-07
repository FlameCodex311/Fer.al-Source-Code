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

public class UI_LazyListItemDetailPanel_CraftableItem_Shop : UI_LazyListItemDetailPanel<BaseDef> // TypeDefIndex: 13678
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _nameText; // 0x38
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Transform _arrow; // 0x40
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_ItemCraftRequirement _requirementPrefab; // 0x48
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Transform _requirementParent; // 0x50
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private TMP_InputField _quantityInputField; // 0x58
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWButton _craftBtn; // 0x60
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralAudioInfo _craftSound; // 0x68
	private List<UI_ItemCraftRequirement> _requirementItems; // 0x70
	private int _chosenQuantity; // 0x78
	private bool _craftingInProgress; // 0x7C

	// Properties
	public int ChosenQuantity { get; private set; } // 0x00000001803959E0-0x00000001803959F0 0x00000001803959F0-0x0000000180395BD0

	// Constructors
	public UI_LazyListItemDetailPanel_CraftableItem_Shop(); // 0x0000000180395970-0x00000001803959E0

	// Methods
	public override void Setup(UI_LazyListItem<BaseDef> inDataSrc); // 0x00000001803953B0-0x00000001803955C0
	public void LongPressProgress_Craft(float inProgress); // 0x0000000180394E40-0x0000000180394E60
	public void LongPressCancel_Craft(); // 0x0000000180394E00-0x0000000180394E20
	public void LongPressFinish_Craft(); // 0x0000000180394E20-0x0000000180394E40
	public void InputEnded_ChosenQuantity(string inValue); // 0x0000000180394D80-0x0000000180394E00
	public void BtnClicked_IncreaseChosenQuantity(); // 0x0000000180394D60-0x0000000180394D80
	public void BtnClicked_DecreaseChosenQuantity(); // 0x0000000180394D40-0x0000000180394D60
	protected virtual void OnCraftBegin(); // 0x0000000180394E60-0x0000000180394E90
	protected virtual void OnCraftCancel(); // 0x0000000180394E90-0x0000000180394EC0
	protected virtual void OnCraftFinish(); // 0x0000000180394E90-0x0000000180394EC0
	private void Start(); // 0x00000001803958A0-0x0000000180395970
	private void OnDestroy(); // 0x0000000180394EC0-0x0000000180394F90
	private void SpawnRequirementItems(); // 0x00000001803955C0-0x00000001803958A0
	private void OnInventoryUpdated(InventoryListResponse inMessage); // 0x00000001803950E0-0x0000000180395230
	private void OnInventoryItemsRemoved(InventoryListRemovedResponse inMessage); // 0x0000000180394F90-0x00000001803950E0
	private void RefreshCraftButton(); // 0x0000000180395230-0x00000001803953B0
}

