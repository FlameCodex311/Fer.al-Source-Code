/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_UnreadNotificationCount : MonoBehaviour // TypeDefIndex: 12382
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _unreadCountText; // 0x20
	private int _unreadCount; // 0x28

	// Constructors
	public UI_UnreadNotificationCount(); // 0x0000000180F9C3C0-0x0000000180F9C3D0

	// Methods
	private void Start(); // 0x0000000180F9C2E0-0x0000000180F9C3C0
	private void OnNotificationsRead(NotificationsReadMessage inMessage); // 0x0000000180F9C0A0-0x0000000180F9C0B0
	private void OnNotificationSent(NotificationSentMessage inMessage); // 0x0000000180F9C0A0-0x0000000180F9C0B0
	private void OnDestroy(); // 0x0000000180F9BFD0-0x0000000180F9C0A0
	private void RefreshCount(); // 0x0000000180F9C0B0-0x0000000180F9C1F0
	private void RefreshText(); // 0x0000000180F9C1F0-0x0000000180F9C2E0
}

