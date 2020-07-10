/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_SanctuaryExpansionRoomControlPanel : MonoBehaviour // TypeDefIndex: 12215
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CanvasGroup _canvasGroup; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _groupNotUnderConstruction; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _groupUnderConstruction; // 0x30
	[Header] // 0x00000001801060A0-0x00000001801060F0
	[SerializeField] // 0x00000001801060A0-0x00000001801060F0
	private WWTextMeshProUGUI _editHeaderText; // 0x38
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _groupEdit; // 0x40
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _groupRoom; // 0x48
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _groupExpansion; // 0x50
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _roomToggle; // 0x58
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _roomValueText; // 0x60
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _expansionToggle; // 0x68
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _expansionValueText; // 0x70
	[Header] // 0x0000000180112380-0x00000001801123D0
	[SerializeField] // 0x0000000180112380-0x00000001801123D0
	private GameObject _groupBuild; // 0x78
	public WWTextMeshProUGUI upgradeDetailsText; // 0x80
	[RootSelectorCompact] // 0x00000001801125C0-0x0000000180112620
	public string timeCostDefId; // 0x88
	[RootSelectorCompact] // 0x00000001801125C0-0x0000000180112620
	public string twiggleCostDefId; // 0x90
	[RootSelectorCompact] // 0x0000000180112940-0x00000001801129C0
	[SerializeField] // 0x0000000180112940-0x00000001801129C0
	private string _notEnoughColorDefId; // 0x98
	public WWTextMeshProUGUI timeRequirmentCostLabel; // 0xA0
	public WWTextMeshProUGUI timeRequirmentCostText; // 0xA8
	public WWTextMeshProUGUI twiggleRequirmentCostText; // 0xB0
	public WWTextMeshProUGUI twiggleRequirmentCostLabel; // 0xB8
	[Header] // 0x0000000180112AF0-0x0000000180112B20
	public WWTextMeshProUGUI generalRequirementCostLabel1; // 0xC0
	public WWTextMeshProUGUI generalRequirementCostText1; // 0xC8
	[Header] // 0x0000000180112C80-0x0000000180112CB0
	public WWTextMeshProUGUI generalRequirementCostLabel2; // 0xD0
	public WWTextMeshProUGUI generalRequirementCostText2; // 0xD8
	[Header] // 0x0000000180112D70-0x0000000180112DA0
	public WWTextMeshProUGUI generalRequirementCostLabel3; // 0xE0
	public WWTextMeshProUGUI generalRequirementCostText3; // 0xE8
	public FeralButton addRoomButton; // 0xF0
	public FeralButton expandRoomButton; // 0xF8
	private UI_SanctuaryExpansionRoomButton _roomButton; // 0x100
	private int _roomIndex; // 0x108
	private PurchaseableDefComponent _currentRoomUpgradeCost; // 0x110

	// Properties
	public PurchaseableDefComponent CurrentRoomUpgradeCost { get; } // 0x00000001803BD380-0x00000001803BD390 

	// Constructors
	public UI_SanctuaryExpansionRoomControlPanel(); // 0x0000000180EEEB00-0x0000000180EEEB50

	// Methods
	public void Setup(int inRoomIndex, UI_SanctuaryExpansionRoomButton inRoomButton); // 0x0000000180EEE110-0x0000000180EEEB00
	public void BtnClicked_RoomToggle(bool inIsOn); // 0x0000000180EECF10-0x0000000180EED150
	public void BtnClicked_ExpansionToggle(bool inIsOn); // 0x0000000180EECA90-0x0000000180EECC20
	public void BtnClicked_PurchaseRoomToggle(bool inIsOn); // 0x0000000180EECDB0-0x0000000180EECF10
	public void BtnClicked_PurchaseExpansionToggle(bool inIsOn); // 0x0000000180EECC20-0x0000000180EECDB0
	private bool SetRoomCosts(PurchaseableDefComponent inUpgradeCost); // 0x0000000180EED390-0x0000000180EEE110
	private string GetTimeUnitString(int value, string valueName, bool leadingWhitespace); // 0x0000000180EED150-0x0000000180EED390
}

