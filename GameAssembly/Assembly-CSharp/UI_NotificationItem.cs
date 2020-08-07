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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_NotificationItem : MonoBehaviour, ISelectHandler // TypeDefIndex: 13910
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _messageText; // 0x20
	private Notification _notification; // 0x28
	private Action<RectTransform> _onSelectedAction; // 0x30
	private Selectable _selectable; // 0x38

	// Properties
	public string Message { get; private set; } // 0x00000001803CD7F0-0x00000001803CD810 0x00000001803CD890-0x00000001803CD8B0
	public Notification Notification { get; } // 0x00000001803745B0-0x00000001803745C0 
	public Selectable Selectable { get; } // 0x00000001803CD810-0x00000001803CD890 

	// Constructors
	public UI_NotificationItem(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	public void Setup(Notification inNotification, Action<RectTransform> inSelectedAction); // 0x00000001803CD7A0-0x00000001803CD7F0
	public void OnSelect(BaseEventData eventData); // 0x00000001803CD730-0x00000001803CD7A0
}

