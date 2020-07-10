/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_ItemCraftRequirement : MonoBehaviour // TypeDefIndex: 12323
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _uncraftingMode; // 0x20
	[Header] // 0x00000001801380C0-0x0000000180138110
	[SerializeField] // 0x00000001801380C0-0x0000000180138110
	private WWTextMeshProUGUI _nameText; // 0x28
	[RootSelector] // 0x0000000180138340-0x00000001801383C0
	[SerializeField] // 0x0000000180138340-0x00000001801383C0
	private string _commonColorDefId; // 0x30
	[RootSelector] // 0x0000000180138500-0x0000000180138580
	[SerializeField] // 0x0000000180138500-0x0000000180138580
	private string _uncommonColorDefId; // 0x38
	[RootSelector] // 0x0000000180139910-0x0000000180139990
	[SerializeField] // 0x0000000180139910-0x0000000180139990
	private string _rareColorDefId; // 0x40
	[RootSelector] // 0x0000000180139BA0-0x0000000180139C20
	[SerializeField] // 0x0000000180139BA0-0x0000000180139C20
	private string _epicColorDefId; // 0x48
	[Header] // 0x0000000180139D50-0x0000000180139DA0
	[SerializeField] // 0x0000000180139D50-0x0000000180139DA0
	private WWTextMeshProUGUI _amountText; // 0x50
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _currencyImageGroup; // 0x58
	[RootSelector] // 0x000000018013A020-0x000000018013A0A0
	[SerializeField] // 0x000000018013A020-0x000000018013A0A0
	private string _notEnoughColorDefId; // 0x60
	private bool _hasRequirement; // 0x68
	private BaseDef _itemDef; // 0x70
	private PurchaseableDefComponent.CostEntry _requirement; // 0x78
	private int _quantity; // 0x80

	// Properties
	public bool HasRequirement { get; } // 0x0000000180622650-0x0000000180622660 

	// Constructors
	public UI_ItemCraftRequirement(); // 0x0000000180E45850-0x0000000180E458D0

	// Methods
	public void Setup(PurchaseableDefComponent.CostEntry inItemRequirement, int inQuantity); // 0x0000000180E45760-0x0000000180E45850
	public void Refresh(int inQuantity); // 0x0000000180E45060-0x0000000180E45760
}

