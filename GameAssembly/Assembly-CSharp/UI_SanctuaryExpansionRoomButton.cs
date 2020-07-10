/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coffee.UIExtensions;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_SanctuaryExpansionRoomButton : MonoBehaviour // TypeDefIndex: 12214
{
	// Fields
	public int roomIndex; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _button; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _roomName; // 0x30
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CanvasGroup _groupUnderConstruction; // 0x38
	[Header] // 0x0000000180110010-0x0000000180110060
	[SerializeField] // 0x0000000180110010-0x0000000180110060
	private CanvasGroup _groupNotBuilt; // 0x40
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWImage _imageNotBuilt; // 0x48
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color _colorCanBeBuilt; // 0x50
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color _colorCannotBeBuilt; // 0x60
	[Header] // 0x0000000180110810-0x0000000180110860
	[SerializeField] // 0x0000000180110810-0x0000000180110860
	private CanvasGroup _groupBuilt; // 0x70
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UIEffect _roomOffEffect; // 0x78
	[Header] // 0x0000000180110D80-0x0000000180110DD0
	[SerializeField] // 0x0000000180110D80-0x0000000180110DD0
	private CanvasGroup _groupExpanded; // 0x80
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWImage _imageExpansion; // 0x88
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color _colorExpansionOn; // 0x90
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color _colorExpansionOff; // 0xA0
	private UI_Window_Shop_SanctuaryExpansions _expansionShopUI; // 0xB0

	// Properties
	public string RoomName { get; } // 0x0000000180EECA60-0x0000000180EECA90 
	private UI_Window_Shop_SanctuaryExpansions ExpansionShopUI { get; } // 0x0000000180EEC4E0-0x0000000180EEC590 
	public bool IsTwiggleAvailable { get; } // 0x0000000180EEC9F0-0x0000000180EECA60 
	public bool IsRoomConnected { get; } // 0x0000000180EEC710-0x0000000180EEC870 
	public bool IsRoomOwned { get; } // 0x0000000180EEC930-0x0000000180EEC9F0 
	public bool IsExpansionOwned { get; } // 0x0000000180EEC650-0x0000000180EEC710 
	public bool IsRoomOn { get; } // 0x0000000180EEC870-0x0000000180EEC930 
	public bool IsExpansionOn { get; } // 0x0000000180EEC590-0x0000000180EEC650 

	// Constructors
	public UI_SanctuaryExpansionRoomButton(); // 0x0000000180EEC470-0x0000000180EEC4E0

	// Methods
	private void Start(); // 0x0000000180EEC060-0x0000000180EEC1A0
	private void OnDestroy(); // 0x0000000180EEBE40-0x0000000180EEBED0
	private void OnEnable(); // 0x0000000180EEBF70-0x0000000180EEC010
	private void OnDisable(); // 0x0000000180EEBED0-0x0000000180EEBF70
	public void UpdateButtonState(bool isHighlighted); // 0x0000000180EEC1A0-0x0000000180EEC470
	public void SetButtonSelected(bool inSelected); // 0x0000000180EEC050-0x0000000180EEC060
	public void BtnClicked_OnRoomSelected(); // 0x0000000180EEBDA0-0x0000000180EEBE40
	private void OnStateChanged(SanctuaryBuildStateChangedMessage inMessage); // 0x0000000180EEC010-0x0000000180EEC050
}

