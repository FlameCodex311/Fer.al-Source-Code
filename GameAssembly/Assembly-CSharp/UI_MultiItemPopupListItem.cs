/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_MultiItemPopupListItem : MonoBehaviour // TypeDefIndex: 12324
{
	// Fields
	[Header] // 0x00000001801380C0-0x0000000180138110
	[SerializeField] // 0x00000001801380C0-0x0000000180138110
	private WWTextMeshProUGUI _nameText; // 0x20
	[RootSelector] // 0x0000000180138340-0x00000001801383C0
	[SerializeField] // 0x0000000180138340-0x00000001801383C0
	private string _commonColorDefId; // 0x28
	[RootSelector] // 0x0000000180138500-0x0000000180138580
	[SerializeField] // 0x0000000180138500-0x0000000180138580
	private string _uncommonColorDefId; // 0x30
	[RootSelector] // 0x0000000180139910-0x0000000180139990
	[SerializeField] // 0x0000000180139910-0x0000000180139990
	private string _rareColorDefId; // 0x38
	[RootSelector] // 0x0000000180139BA0-0x0000000180139C20
	[SerializeField] // 0x0000000180139BA0-0x0000000180139C20
	private string _epicColorDefId; // 0x40
	[Header] // 0x0000000180139D50-0x0000000180139DA0
	[SerializeField] // 0x0000000180139D50-0x0000000180139DA0
	private WWTextMeshProUGUI _amountText; // 0x48
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _currencyImageGroup; // 0x50
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_ItemImage _currencyItemImage; // 0x58

	// Constructors
	public UI_MultiItemPopupListItem(); // 0x0000000180E83CC0-0x0000000180E83D20

	// Methods
	public void Setup(BaseDef inItemDef, int inQuantity); // 0x0000000180E838B0-0x0000000180E83CC0
}

