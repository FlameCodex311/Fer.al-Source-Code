/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyListItemDetailPanel_UncraftingShop : UI_LazyListItemDetailPanel<Item> // TypeDefIndex: 12134
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
	private List<CanvasGroup> _quantityControls; // 0x60
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralAudioInfo _craftSound; // 0x68
	private List<UI_ItemCraftRequirement> _requirementItems; // 0x70
	private int _maxQuantity; // 0x78
	private int _chosenQuantity; // 0x7C
	private bool _craftingInProgress; // 0x80

	// Properties
	public int ChosenQuantity { get; private set; } // 0x00000001808CAC70-0x00000001808CAC80 0x0000000180E6DEA0-0x0000000180E6E060
	public TMP_InputField QuantityInputField { get; set; } // 0x0000000180357120-0x0000000180357130 0x0000000180485C70-0x0000000180485C80

	// Constructors
	public UI_LazyListItemDetailPanel_UncraftingShop(); // 0x0000000180E6DE10-0x0000000180E6DEA0

	// Methods
	public override void Setup(UI_LazyListItem<Item> inDataSrc); // 0x0000000180E6D870-0x0000000180E6DA90
	public void LongPressProgress_Craft(float inProgress); // 0x0000000180E6D3C0-0x0000000180E6D3F0
	public void LongPressCancel_Craft(); // 0x0000000180E6D360-0x0000000180E6D390
	public void LongPressFinish_Craft(); // 0x0000000180E6D390-0x0000000180E6D3C0
	public void InputEnded_ChosenQuantity(string inValue); // 0x0000000180E6D2D0-0x0000000180E6D360
	public void BtnClicked_IncreaseChosenQuantity(); // 0x0000000180E6D2B0-0x0000000180E6D2D0
	public void BtnClicked_DecreaseChosenQuantity(); // 0x0000000180E6D290-0x0000000180E6D2B0
	protected virtual void OnCraftBegin(); // 0x0000000180E63360-0x0000000180E633A0
	protected virtual void OnCraftCancel(); // 0x0000000180E633A0-0x0000000180E633E0
	protected virtual void OnCraftFinish(); // 0x0000000180E633A0-0x0000000180E633E0
	private void Start(); // 0x0000000180E6DD80-0x0000000180E6DE10
	private void OnDestroy(); // 0x0000000180E6D3F0-0x0000000180E6D480
	private void SpawnRequirementItems(); // 0x0000000180E6DA90-0x0000000180E6DD80
	private void RefreshMax(); // 0x0000000180E6D530-0x0000000180E6D870
	private void OnItemChanged(InventoryItemChangedEvent inMessage); // 0x0000000180E6D480-0x0000000180E6D530
}

