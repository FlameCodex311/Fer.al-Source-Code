/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_MultiItemPopupListItem : MonoBehaviour // TypeDefIndex: 13908
{
	// Fields
	[Header] // 0x0000000180232A00-0x0000000180232A50
	[SerializeField] // 0x0000000180232A00-0x0000000180232A50
	private WWTextMeshProUGUI _nameText; // 0x20
	[RootSelector] // 0x0000000180232B60-0x0000000180232BE0
	[SerializeField] // 0x0000000180232B60-0x0000000180232BE0
	private string _commonColorDefId; // 0x28
	[RootSelector] // 0x0000000180232D70-0x0000000180232DF0
	[SerializeField] // 0x0000000180232D70-0x0000000180232DF0
	private string _uncommonColorDefId; // 0x30
	[RootSelector] // 0x0000000180233080-0x0000000180233100
	[SerializeField] // 0x0000000180233080-0x0000000180233100
	private string _rareColorDefId; // 0x38
	[RootSelector] // 0x0000000180233400-0x0000000180233480
	[SerializeField] // 0x0000000180233400-0x0000000180233480
	private string _epicColorDefId; // 0x40
	[Header] // 0x0000000180233850-0x00000001802338A0
	[SerializeField] // 0x0000000180233850-0x00000001802338A0
	private WWTextMeshProUGUI _amountText; // 0x48
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _currencyImageGroup; // 0x50
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_ItemImage _currencyItemImage; // 0x58

	// Constructors
	public UI_MultiItemPopupListItem(); // 0x00000001803CD5C0-0x00000001803CD620

	// Methods
	public void Setup(BaseDef inItemDef, int inQuantity); // 0x00000001803CD1D0-0x00000001803CD5C0
}

