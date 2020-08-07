/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_GameplayNotifications : UI_Window // TypeDefIndex: 14071
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private int _maxShownNotifications; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _notificationDisplayTime; // 0x10C
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_GameplayNotificationItem _notificationAlertItemPrefab; // 0x110
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private LazyLayoutGroup _layout; // 0x118
	private List<Notification> _notificationQueue; // 0x120
	private List<UI_GameplayNotificationItem> _shownNotifications; // 0x128
	private Dictionary<UI_GameplayNotificationItem, float> _notificationTimers; // 0x130

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass7_0 // TypeDefIndex: 14072
	{
		// Fields
		public NotificationSentMessage inMessage; // 0x10

		// Constructors
		public <>c__DisplayClass7_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <Init>b__2(); // 0x00000001803E2530-0x00000001803E25B0
		internal void <Init>b__3(UI_Window_GameplayNotifications inWindow); // 0x00000001803E25B0-0x00000001803E25F0
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 14073
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<bool> <>9__7_1; // 0x08
		public static Action<NotificationSentMessage> <>9__7_0; // 0x10
		public static Action<UI_Window_GameplayNotifications> <>9__8_0; // 0x18
		public static Action<UI_Window> <>9__9_0; // 0x20

		// Constructors
		static <>c(); // 0x00000001803E2C10-0x00000001803E2C70
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <Init>b__7_0(NotificationSentMessage inMessage); // 0x00000001803E0A90-0x00000001803E0D70
		internal bool <Init>b__7_1(); // 0x00000001803E0D70-0x00000001803E0DF0
		internal void <OpenWindow>b__8_0(UI_Window_GameplayNotifications window); // 0x00000001803B24A0-0x00000001803B24C0
		internal void <QueueWindow>b__9_0(UI_Window inWindow); // 0x00000001803E16A0-0x00000001803E1720
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass12_0 // TypeDefIndex: 14074
	{
		// Fields
		public Notification inNotification; // 0x10

		// Constructors
		public <>c__DisplayClass12_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <AddNotification>b__0(Notification item); // 0x00000001803E18A0-0x00000001803E19A0
		internal bool <AddNotification>b__1(UI_GameplayNotificationItem item); // 0x00000001803E19A0-0x00000001803E1A30
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass15_0 // TypeDefIndex: 14075
	{
		// Fields
		public UI_Window_GameplayNotifications <>4__this; // 0x10
		public UI_GameplayNotificationItem inNotification; // 0x18

		// Constructors
		public <>c__DisplayClass15_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <RemoveNotification>b__0(); // 0x00000001803E1A30-0x00000001803E1B90
	}

	// Constructors
	public UI_Window_GameplayNotifications(); // 0x00000001803E4AD0-0x00000001803E4B90

	// Methods
	[RuntimeInitializeOnLoadMethod] // 0x00000001801CF2D0-0x00000001801CF2E0
	private static void Init(); // 0x00000001803E4320-0x00000001803E4420
	public static void OpenWindow(); // 0x00000001803E4580-0x00000001803E4680
	public static void QueueWindow(); // 0x00000001803E4680-0x00000001803E4780
	public static void CloseWindow(); // 0x00000001803E42D0-0x00000001803E4320
	private void Setup(); // 0x00000001803774A0-0x00000001803774B0
	public void AddNotification(Notification inNotification); // 0x00000001803E4010-0x00000001803E42D0
	private void ShowNotification(Notification inNotification); // 0x00000001803E4920-0x00000001803E4AD0
	private void ShowNextNotification(); // 0x00000001803E4880-0x00000001803E4920
	private void RemoveNotification(UI_GameplayNotificationItem inNotification); // 0x00000001803E4780-0x00000001803E4880
	public override void MUpdate(); // 0x00000001803E4420-0x00000001803E4580
	protected override void OnOpen(); // 0x00000001803B4570-0x00000001803B4580
	protected override void OnClose(bool inAnimate); // 0x00000001803B4560-0x00000001803B4570
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
}

