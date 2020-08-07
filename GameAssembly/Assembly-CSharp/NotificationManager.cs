/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class NotificationManager : SingletonManagerBase<NotificationManager> // TypeDefIndex: 12259
{
	// Fields
	public List<Notification> loggedNotifications; // 0x60

	// Constructors
	public NotificationManager(); // 0x0000000180804090-0x0000000180804100

	// Methods
	public override void Init(); // 0x0000000180803F00-0x0000000180803F20
	public override void Deinit(); // 0x00000001804ADDD0-0x00000001804ADDF0
	public void AddGameplayNotification(Notification inNotification); // 0x0000000180803CA0-0x0000000180803CD0
	public void AddSystemNotification(Notification inNotification); // 0x0000000180803D90-0x0000000180803DC0
	public void AddCriticalNotification(Notification inNotification); // 0x0000000180803C70-0x0000000180803CA0
	public void AddNotification(Notification inNotification); // 0x0000000180803CD0-0x0000000180803D90
	public int GetUnreadNotificationCount(); // 0x0000000180803DC0-0x0000000180803F00
	public void MarkAllAsRead(); // 0x0000000180803F20-0x0000000180804090
}

