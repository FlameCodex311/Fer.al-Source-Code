/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_ItemCraftRequirement : MonoBehaviour // TypeDefIndex: 13907
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _uncraftingMode; // 0x20
	[Header] // 0x0000000180232A00-0x0000000180232A50
	[SerializeField] // 0x0000000180232A00-0x0000000180232A50
	private WWTextMeshProUGUI _nameText; // 0x28
	[RootSelector] // 0x0000000180232B60-0x0000000180232BE0
	[SerializeField] // 0x0000000180232B60-0x0000000180232BE0
	private string _commonColorDefId; // 0x30
	[RootSelector] // 0x0000000180232D70-0x0000000180232DF0
	[SerializeField] // 0x0000000180232D70-0x0000000180232DF0
	private string _uncommonColorDefId; // 0x38
	[RootSelector] // 0x0000000180233080-0x0000000180233100
	[SerializeField] // 0x0000000180233080-0x0000000180233100
	private string _rareColorDefId; // 0x40
	[RootSelector] // 0x0000000180233400-0x0000000180233480
	[SerializeField] // 0x0000000180233400-0x0000000180233480
	private string _epicColorDefId; // 0x48
	[Header] // 0x0000000180233850-0x00000001802338A0
	[SerializeField] // 0x0000000180233850-0x00000001802338A0
	private WWTextMeshProUGUI _amountText; // 0x50
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _currencyImageGroup; // 0x58
	[RootSelector] // 0x00000001801DDD10-0x00000001801DDD90
	[SerializeField] // 0x00000001801DDD10-0x00000001801DDD90
	private string _notEnoughColorDefId; // 0x60
	private bool _hasRequirement; // 0x68
	private BaseDef _itemDef; // 0x70
	private PurchaseableDefComponent.CostEntry _requirement; // 0x78
	private int _quantity; // 0x80

	// Properties
	public bool HasRequirement { get; } // 0x000000018037D390-0x000000018037D3A0 

	// Constructors
	public UI_ItemCraftRequirement(); // 0x000000018037D310-0x000000018037D390

	// Methods
	public void Setup(PurchaseableDefComponent.CostEntry inItemRequirement, int inQuantity); // 0x000000018037D220-0x000000018037D310
	public void Refresh(int inQuantity); // 0x000000018037CB40-0x000000018037D220
}

