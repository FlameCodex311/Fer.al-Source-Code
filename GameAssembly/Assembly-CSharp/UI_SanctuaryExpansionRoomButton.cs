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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_SanctuaryExpansionRoomButton : MonoBehaviour // TypeDefIndex: 13764
{
	// Fields
	public int roomIndex; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _button; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _roomName; // 0x30
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CanvasGroup _groupUnderConstruction; // 0x38
	[Header] // 0x00000001801F4860-0x00000001801F48B0
	[SerializeField] // 0x00000001801F4860-0x00000001801F48B0
	private CanvasGroup _groupNotBuilt; // 0x40
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWImage _imageNotBuilt; // 0x48
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Color _colorCanBeBuilt; // 0x50
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Color _colorCannotBeBuilt; // 0x60
	[Header] // 0x00000001801F53D0-0x00000001801F5420
	[SerializeField] // 0x00000001801F53D0-0x00000001801F5420
	private CanvasGroup _groupBuilt; // 0x70
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UIEffect _roomOffEffect; // 0x78
	[Header] // 0x00000001801F5910-0x00000001801F5960
	[SerializeField] // 0x00000001801F5910-0x00000001801F5960
	private CanvasGroup _groupExpanded; // 0x80
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWImage _imageExpansion; // 0x88
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Color _colorExpansionOn; // 0x90
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Color _colorExpansionOff; // 0xA0
	private UI_Window_Shop_SanctuaryExpansions _expansionShopUI; // 0xB0

	// Properties
	public string RoomName { get; } // 0x00000001803DBCB0-0x00000001803DBCD0 
	private UI_Window_Shop_SanctuaryExpansions ExpansionShopUI { get; } // 0x00000001803DB730-0x00000001803DB7E0 
	public bool IsTwiggleAvailable { get; } // 0x00000001803DBC40-0x00000001803DBCB0 
	public bool IsRoomConnected { get; } // 0x00000001803DB960-0x00000001803DBAC0 
	public bool IsRoomOwned { get; } // 0x00000001803DBB80-0x00000001803DBC40 
	public bool IsExpansionOwned { get; } // 0x00000001803DB8A0-0x00000001803DB960 
	public bool IsRoomOn { get; } // 0x00000001803DBAC0-0x00000001803DBB80 
	public bool IsExpansionOn { get; } // 0x00000001803DB7E0-0x00000001803DB8A0 

	// Constructors
	public UI_SanctuaryExpansionRoomButton(); // 0x00000001803DB6C0-0x00000001803DB730

	// Methods
	private void Start(); // 0x00000001803DB2C0-0x00000001803DB400
	private void OnDestroy(); // 0x00000001803DB0A0-0x00000001803DB130
	private void OnEnable(); // 0x00000001803DB1D0-0x00000001803DB270
	private void OnDisable(); // 0x00000001803DB130-0x00000001803DB1D0
	public void UpdateButtonState(bool isHighlighted); // 0x00000001803DB400-0x00000001803DB6C0
	public void SetButtonSelected(bool inSelected); // 0x00000001803DB2B0-0x00000001803DB2C0
	public void BtnClicked_OnRoomSelected(); // 0x00000001803DB010-0x00000001803DB0A0
	private void OnStateChanged(SanctuaryBuildStateChangedMessage inMessage); // 0x00000001803DB270-0x00000001803DB2B0
}

