/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class NotificationManager : SingletonManagerBase<NotificationManager> // TypeDefIndex: 10749
{
	// Fields
	public List<Notification> loggedNotifications; // 0x60

	// Constructors
	public NotificationManager(); // 0x0000000180E96040-0x0000000180E960B0

	// Methods
	public override void Init(); // 0x0000000180E95EB0-0x0000000180E95ED0
	public override void Deinit(); // 0x0000000180E95D40-0x0000000180E95D60
	public void AddGameplayNotification(Notification inNotification); // 0x0000000180E95C20-0x0000000180E95C50
	public void AddSystemNotification(Notification inNotification); // 0x0000000180E95D10-0x0000000180E95D40
	public void AddCriticalNotification(Notification inNotification); // 0x0000000180E95BF0-0x0000000180E95C20
	public void AddNotification(Notification inNotification); // 0x0000000180E95C50-0x0000000180E95D10
	public int GetUnreadNotificationCount(); // 0x0000000180E95D60-0x0000000180E95EB0
	public void MarkAllAsRead(); // 0x0000000180E95ED0-0x0000000180E96040
}

