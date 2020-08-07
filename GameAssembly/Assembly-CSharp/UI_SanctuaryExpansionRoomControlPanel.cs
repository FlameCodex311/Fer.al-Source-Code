/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_SanctuaryExpansionRoomControlPanel : MonoBehaviour // TypeDefIndex: 13765
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CanvasGroup _canvasGroup; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _groupNotUnderConstruction; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _groupUnderConstruction; // 0x30
	[Header] // 0x00000001801E0F70-0x00000001801E0FC0
	[SerializeField] // 0x00000001801E0F70-0x00000001801E0FC0
	private WWTextMeshProUGUI _editHeaderText; // 0x38
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _groupEdit; // 0x40
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _groupRoom; // 0x48
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _groupExpansion; // 0x50
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _roomToggle; // 0x58
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _roomValueText; // 0x60
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _expansionToggle; // 0x68
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _expansionValueText; // 0x70
	[Header] // 0x00000001801F9850-0x00000001801F98A0
	[SerializeField] // 0x00000001801F9850-0x00000001801F98A0
	private GameObject _groupBuild; // 0x78
	public WWTextMeshProUGUI upgradeDetailsText; // 0x80
	[RootSelectorCompact] // 0x00000001801F9B50-0x00000001801F9BB0
	public string timeCostDefId; // 0x88
	[RootSelectorCompact] // 0x00000001801F9B50-0x00000001801F9BB0
	public string twiggleCostDefId; // 0x90
	[RootSelectorCompact] // 0x00000001801FA000-0x00000001801FA080
	[SerializeField] // 0x00000001801FA000-0x00000001801FA080
	private string _notEnoughColorDefId; // 0x98
	public WWTextMeshProUGUI timeRequirmentCostLabel; // 0xA0
	public WWTextMeshProUGUI timeRequirmentCostText; // 0xA8
	public WWTextMeshProUGUI twiggleRequirmentCostText; // 0xB0
	public WWTextMeshProUGUI twiggleRequirmentCostLabel; // 0xB8
	[Header] // 0x00000001801FA3E0-0x00000001801FA410
	public WWTextMeshProUGUI generalRequirementCostLabel1; // 0xC0
	public WWTextMeshProUGUI generalRequirementCostText1; // 0xC8
	[Header] // 0x00000001801FA740-0x00000001801FA770
	public WWTextMeshProUGUI generalRequirementCostLabel2; // 0xD0
	public WWTextMeshProUGUI generalRequirementCostText2; // 0xD8
	[Header] // 0x00000001801FA850-0x00000001801FA880
	public WWTextMeshProUGUI generalRequirementCostLabel3; // 0xE0
	public WWTextMeshProUGUI generalRequirementCostText3; // 0xE8
	public FeralButton addRoomButton; // 0xF0
	public FeralButton expandRoomButton; // 0xF8
	private UI_SanctuaryExpansionRoomButton _roomButton; // 0x100
	private int _roomIndex; // 0x108
	private PurchaseableDefComponent _currentRoomUpgradeCost; // 0x110

	// Properties
	public PurchaseableDefComponent CurrentRoomUpgradeCost { get; } // 0x0000000180385320-0x0000000180385330 

	// Constructors
	public UI_SanctuaryExpansionRoomControlPanel(); // 0x00000001803DDC90-0x00000001803DDCE0

	// Methods
	public void Setup(int inRoomIndex, UI_SanctuaryExpansionRoomButton inRoomButton); // 0x00000001803DD2F0-0x00000001803DDC90
	public void BtnClicked_RoomToggle(bool inIsOn); // 0x00000001803DC150-0x00000001803DC390
	public void BtnClicked_ExpansionToggle(bool inIsOn); // 0x00000001803DBCD0-0x00000001803DBE60
	public void BtnClicked_PurchaseRoomToggle(bool inIsOn); // 0x00000001803DBFF0-0x00000001803DC150
	public void BtnClicked_PurchaseExpansionToggle(bool inIsOn); // 0x00000001803DBE60-0x00000001803DBFF0
	private bool SetRoomCosts(PurchaseableDefComponent inUpgradeCost); // 0x00000001803DC5B0-0x00000001803DD2F0
	private string GetTimeUnitString(int value, string valueName, bool leadingWhitespace); // 0x00000001803DC390-0x00000001803DC5B0
}

