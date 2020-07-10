/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.DeInspektor.Attributes;
using TMPro;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_UnreadCount : MonoBehaviour // TypeDefIndex: 12381
{
	// Fields
	[DeComment] // 0x0000000180158F80-0x0000000180158FD0
	[SerializeField] // 0x0000000180158F80-0x0000000180158FD0
	private ItemType _itemType; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _unreadCountText; // 0x28
	private List<Item> _unreadItems; // 0x30

	// Constructors
	public UI_UnreadCount(); // 0x0000000180F9BF70-0x0000000180F9BFD0

	// Methods
	private void Start(); // 0x0000000180F9BD20-0x0000000180F9BF70
	private void OnDestroy(); // 0x0000000180F9BA00-0x0000000180F9BAD0
	private void OnItemUnread(ItemUnreadMessage inMessage); // 0x0000000180F9BB80-0x0000000180F9BC30
	private void OnItemRead(ItemReadMessage inMessage); // 0x0000000180F9BAD0-0x0000000180F9BB80
	private bool ItemMatchesType(Item inItem); // 0x0000000180F9B9B0-0x0000000180F9BA00
	private void RefreshText(); // 0x0000000180F9BC30-0x0000000180F9BD20
}

