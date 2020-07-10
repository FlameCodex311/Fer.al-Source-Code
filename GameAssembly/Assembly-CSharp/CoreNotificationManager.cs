/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class CoreNotificationManager : CoreManagerBase<CoreNotificationManager> // TypeDefIndex: 13482
{
	// Fields
	private static Color32 notificationColor; // 0x00
	private int START_HOUR; // 0x60
	private int END_HOUR; // 0x64

	// Nested types
	public enum NotificationExecuteMode // TypeDefIndex: 13483
	{
		Inexact = 0,
		Exact = 1,
		ExactAndAllowWhileIdle = 2
	}

	protected struct AJNotification // TypeDefIndex: 13484
	{
		// Fields
		public NotificationDefComponent notificationDef; // 0x00
		public DateTime fireDate; // 0x08

		// Constructors
		public AJNotification(NotificationDefComponent notificationDef, DateTime fireDate); // 0x0000000180005D30-0x0000000180005EC0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <WaitForDeviceToken>d__13 : IEnumerator<object> // TypeDefIndex: 13485
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <WaitForDeviceToken>d__13(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180EE0630-0x0000000180EE0640
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x000000018132A3F0-0x000000018132A440
	}

	// Constructors
	public CoreNotificationManager(); // 0x0000000181318D30-0x0000000181318D70
	static CoreNotificationManager(); // 0x0000000181318CD0-0x0000000181318D30

	// Methods
	public static void SendNotification(int id, DateTime fireDate, string title, string message, bool sound = true /* Metadata: 0x00783D75 */, bool vibrate = true /* Metadata: 0x00783D76 */, bool lights = true /* Metadata: 0x00783D77 */, string bigIcon = "" /* Metadata: 0x00783D78 */, NotificationExecuteMode executeMode = NotificationExecuteMode.Inexact /* Metadata: 0x00783D7C */); // 0x00000001803581E0-0x00000001803581F0
	public static void SendRepeatingNotification(int id, DateTime fireDate, long timeout, string title, string message, bool sound = true /* Metadata: 0x00783D80 */, bool vibrate = true /* Metadata: 0x00783D81 */, bool lights = true /* Metadata: 0x00783D82 */, string bigIcon = "" /* Metadata: 0x00783D83 */); // 0x00000001803581E0-0x00000001803581F0
	public static void CancelNotification(object identifier); // 0x00000001803581E0-0x00000001803581F0
	public static void CancelAllNotifications(); // 0x00000001803581E0-0x00000001803581F0
	public override void Init(); // 0x0000000181318640-0x0000000181318830
	public override void MUpdate(); // 0x000000018036B6C0-0x000000018036B6D0
	private void OnApplicationPause(bool pause); // 0x0000000181318850-0x0000000181318870
	private void OnApplicationFocus(bool focus); // 0x0000000181318830-0x0000000181318850
	public static void RegisterForNotifications(); // 0x00000001803581E0-0x00000001803581F0
	[IteratorStateMachine] // 0x000000018016B160-0x000000018016B1B0
	private static IEnumerator WaitForDeviceToken(); // 0x0000000181318C80-0x0000000181318CD0
	protected void ScheduleAllLocalNotifications(List<AJNotification> notificationsToSchedule); // 0x0000000181318870-0x0000000181318C80
	private DateTime DelayNotification(DateTime inFireDate); // 0x0000000181318520-0x00000001813185D0
	public virtual void ClearAndScheduleAllLocalNotifications(); // 0x0000000181318280-0x0000000181318520
	protected DateTime? GetFireDate(NotificationDefComponent notificationDef, DateTime nowUtc, long currTimeTicks); // 0x00000001813185D0-0x0000000181318640
	protected void ClearAllLocalNotifications(); // 0x00000001803581E0-0x00000001803581F0
}

