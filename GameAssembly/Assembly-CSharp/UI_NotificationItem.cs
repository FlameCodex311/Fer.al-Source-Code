/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_NotificationItem : MonoBehaviour, ISelectHandler // TypeDefIndex: 12325
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _messageText; // 0x20
	private Notification _notification; // 0x28
	private Action<RectTransform> _onSelectedAction; // 0x30
	private Selectable _selectable; // 0x38

	// Properties
	public string Message { get; private set; } // 0x0000000180E83EF0-0x0000000180E83F20 0x0000000180E83FA0-0x0000000180E83FC0
	public Notification Notification { get; } // 0x0000000180369B60-0x0000000180369B70 
	public Selectable Selectable { get; } // 0x0000000180E83F20-0x0000000180E83FA0 

	// Constructors
	public UI_NotificationItem(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	public void Setup(Notification inNotification, Action<RectTransform> inSelectedAction); // 0x0000000180E83EA0-0x0000000180E83EF0
	public void OnSelect(BaseEventData eventData); // 0x0000000180E83E30-0x0000000180E83EA0
}

