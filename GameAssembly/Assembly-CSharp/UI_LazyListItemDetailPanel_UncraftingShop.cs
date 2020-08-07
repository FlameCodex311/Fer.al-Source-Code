/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyListItemDetailPanel_UncraftingShop : UI_LazyListItemDetailPanel<Item> // TypeDefIndex: 13679
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
	private List<CanvasGroup> _quantityControls; // 0x60
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralAudioInfo _craftSound; // 0x68
	private List<UI_ItemCraftRequirement> _requirementItems; // 0x70
	private int _maxQuantity; // 0x78
	private int _chosenQuantity; // 0x7C
	private bool _craftingInProgress; // 0x80

	// Properties
	public int ChosenQuantity { get; private set; } // 0x00000001803A1570-0x00000001803A1580 0x00000001803A1590-0x00000001803A1740
	public TMP_InputField QuantityInputField { get; set; } // 0x00000001803A1580-0x00000001803A1590 0x00000001803A1740-0x00000001803A1750

	// Constructors
	public UI_LazyListItemDetailPanel_UncraftingShop(); // 0x00000001803A14E0-0x00000001803A1570

	// Methods
	public override void Setup(UI_LazyListItem<Item> inDataSrc); // 0x00000001803A0F60-0x00000001803A1170
	public void LongPressProgress_Craft(float inProgress); // 0x00000001803A0AD0-0x00000001803A0B00
	public void LongPressCancel_Craft(); // 0x00000001803A0A70-0x00000001803A0AA0
	public void LongPressFinish_Craft(); // 0x00000001803A0AA0-0x00000001803A0AD0
	public void InputEnded_ChosenQuantity(string inValue); // 0x00000001803A09F0-0x00000001803A0A70
	public void BtnClicked_IncreaseChosenQuantity(); // 0x00000001803A09D0-0x00000001803A09F0
	public void BtnClicked_DecreaseChosenQuantity(); // 0x00000001803A09B0-0x00000001803A09D0
	protected virtual void OnCraftBegin(); // 0x0000000180394E60-0x0000000180394E90
	protected virtual void OnCraftCancel(); // 0x0000000180394E90-0x0000000180394EC0
	protected virtual void OnCraftFinish(); // 0x0000000180394E90-0x0000000180394EC0
	private void Start(); // 0x00000001803A1450-0x00000001803A14E0
	private void OnDestroy(); // 0x00000001803A0B00-0x00000001803A0B90
	private void SpawnRequirementItems(); // 0x00000001803A1170-0x00000001803A1450
	private void RefreshMax(); // 0x00000001803A0C30-0x00000001803A0F60
	private void OnItemChanged(InventoryItemChangedEvent inMessage); // 0x00000001803A0B90-0x00000001803A0C30
}

