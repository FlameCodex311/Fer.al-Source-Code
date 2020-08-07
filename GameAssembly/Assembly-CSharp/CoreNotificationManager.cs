/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class CoreNotificationManager : CoreManagerBase<CoreNotificationManager> // TypeDefIndex: 11153
{
	// Fields
	private static Color32 notificationColor; // 0x00
	private int START_HOUR; // 0x60
	private int END_HOUR; // 0x64

	// Nested types
	public enum NotificationExecuteMode // TypeDefIndex: 11154
	{
		Inexact = 0,
		Exact = 1,
		ExactAndAllowWhileIdle = 2
	}

	protected struct AJNotification // TypeDefIndex: 11155
	{
		// Fields
		public NotificationDefComponent notificationDef; // 0x00
		public DateTime fireDate; // 0x08

		// Constructors
		public AJNotification(NotificationDefComponent notificationDef, DateTime fireDate); // 0x0000000180006CF0-0x0000000180006D00
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <WaitForDeviceToken>d__13 : IEnumerator<object> // TypeDefIndex: 11156
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <WaitForDeviceToken>d__13(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001803C5AF0-0x00000001803C5B00
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180AB0180-0x0000000180AB01D0
	}

	// Constructors
	public CoreNotificationManager(); // 0x0000000180A97300-0x0000000180A97340
	static CoreNotificationManager(); // 0x0000000180A972A0-0x0000000180A97300

	// Methods
	public static void SendNotification(int id, DateTime fireDate, string title, string message, bool sound = true /* Metadata: 0x0077C834 */, bool vibrate = true /* Metadata: 0x0077C835 */, bool lights = true /* Metadata: 0x0077C836 */, string bigIcon = "" /* Metadata: 0x0077C837 */, NotificationExecuteMode executeMode = NotificationExecuteMode.Inexact /* Metadata: 0x0077C83B */); // 0x00000001803774A0-0x00000001803774B0
	public static void SendRepeatingNotification(int id, DateTime fireDate, long timeout, string title, string message, bool sound = true /* Metadata: 0x0077C83F */, bool vibrate = true /* Metadata: 0x0077C840 */, bool lights = true /* Metadata: 0x0077C841 */, string bigIcon = "" /* Metadata: 0x0077C842 */); // 0x00000001803774A0-0x00000001803774B0
	public static void CancelNotification(object identifier); // 0x00000001803774A0-0x00000001803774B0
	public static void CancelAllNotifications(); // 0x00000001803774A0-0x00000001803774B0
	public override void Init(); // 0x0000000180A96C50-0x0000000180A96E20
	public override void MUpdate(); // 0x0000000180373240-0x0000000180373250
	private void OnApplicationPause(bool pause); // 0x0000000180A96E40-0x0000000180A96E60
	private void OnApplicationFocus(bool focus); // 0x0000000180A96E20-0x0000000180A96E40
	public static void RegisterForNotifications(); // 0x00000001803774A0-0x00000001803774B0
	[IteratorStateMachine] // 0x00000001802490A0-0x00000001802490F0
	private static IEnumerator WaitForDeviceToken(); // 0x0000000180A97250-0x0000000180A972A0
	protected void ScheduleAllLocalNotifications(List<AJNotification> notificationsToSchedule); // 0x0000000180A96E60-0x0000000180A97250
	private DateTime DelayNotification(DateTime inFireDate); // 0x0000000180A96B30-0x0000000180A96BE0
	public virtual void ClearAndScheduleAllLocalNotifications(); // 0x0000000180A96900-0x0000000180A96B30
	protected DateTime? GetFireDate(NotificationDefComponent notificationDef, DateTime nowUtc, long currTimeTicks); // 0x0000000180A96BE0-0x0000000180A96C50
	protected void ClearAllLocalNotifications(); // 0x00000001803774A0-0x00000001803774B0
}

