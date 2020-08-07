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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_UnreadCount : MonoBehaviour // TypeDefIndex: 13966
{
	// Fields
	[DeComment] // 0x000000018024E6E0-0x000000018024E730
	[SerializeField] // 0x000000018024E6E0-0x000000018024E730
	private ItemType _itemType; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _unreadCountText; // 0x28
	private List<Item> _unreadItems; // 0x30

	// Constructors
	public UI_UnreadCount(); // 0x000000018063C860-0x000000018063C8C0

	// Methods
	private void Start(); // 0x000000018063C620-0x000000018063C860
	private void OnDestroy(); // 0x000000018063C310-0x000000018063C3E0
	private void OnItemUnread(ItemUnreadMessage inMessage); // 0x000000018063C490-0x000000018063C540
	private void OnItemRead(ItemReadMessage inMessage); // 0x000000018063C3E0-0x000000018063C490
	private bool ItemMatchesType(Item inItem); // 0x000000018063C2C0-0x000000018063C310
	private void RefreshText(); // 0x000000018063C540-0x000000018063C620
}

