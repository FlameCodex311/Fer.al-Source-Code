/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_UnreadNotificationCount : MonoBehaviour // TypeDefIndex: 13967
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _unreadCountText; // 0x20
	private int _unreadCount; // 0x28

	// Constructors
	public UI_UnreadNotificationCount(); // 0x000000018063CC90-0x000000018063CCA0

	// Methods
	private void Start(); // 0x000000018063CBB0-0x000000018063CC90
	private void OnNotificationsRead(NotificationsReadMessage inMessage); // 0x000000018063C990-0x000000018063C9A0
	private void OnNotificationSent(NotificationSentMessage inMessage); // 0x000000018063C990-0x000000018063C9A0
	private void OnDestroy(); // 0x000000018063C8C0-0x000000018063C990
	private void RefreshCount(); // 0x000000018063C9A0-0x000000018063CAD0
	private void RefreshText(); // 0x000000018063CAD0-0x000000018063CBB0
}

