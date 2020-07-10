/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_GameplayNotifications : UI_Window // TypeDefIndex: 12472
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private int _maxShownNotifications; // 0x108
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _notificationDisplayTime; // 0x10C
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_GameplayNotificationItem _notificationAlertItemPrefab; // 0x110
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private LazyLayoutGroup _layout; // 0x118
	private List<Notification> _notificationQueue; // 0x120
	private List<UI_GameplayNotificationItem> _shownNotifications; // 0x128
	private Dictionary<UI_GameplayNotificationItem, float> _notificationTimers; // 0x130

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass7_0 // TypeDefIndex: 12473
	{
		// Fields
		public NotificationSentMessage inMessage; // 0x10

		// Constructors
		public <>c__DisplayClass7_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <Init>b__2(); // 0x0000000180ECF250-0x0000000180ECF2D0
		internal void <Init>b__3(UI_Window_GameplayNotifications inWindow); // 0x0000000180ECF2D0-0x0000000180ECF310
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12474
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<bool> <>9__7_1; // 0x08
		public static Action<NotificationSentMessage> <>9__7_0; // 0x10
		public static Action<UI_Window_GameplayNotifications> <>9__8_0; // 0x18
		public static Action<UI_Window> <>9__9_0; // 0x20

		// Constructors
		static <>c(); // 0x0000000180ECF8D0-0x0000000180ECF930
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <Init>b__7_0(NotificationSentMessage inMessage); // 0x0000000180ECD550-0x0000000180ECD830
		internal bool <Init>b__7_1(); // 0x0000000180ECD830-0x0000000180ECD8B0
		internal void <OpenWindow>b__8_0(UI_Window_GameplayNotifications window); // 0x0000000180E9D080-0x0000000180E9D0A0
		internal void <QueueWindow>b__9_0(UI_Window inWindow); // 0x0000000180ECE0A0-0x0000000180ECE120
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass12_0 // TypeDefIndex: 12475
	{
		// Fields
		public Notification inNotification; // 0x10

		// Constructors
		public <>c__DisplayClass12_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <AddNotification>b__0(Notification item); // 0x0000000180ECE310-0x0000000180ECE410
		internal bool <AddNotification>b__1(UI_GameplayNotificationItem item); // 0x0000000180ECE410-0x0000000180ECE4B0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass15_0 // TypeDefIndex: 12476
	{
		// Fields
		public UI_Window_GameplayNotifications <>4__this; // 0x10
		public UI_GameplayNotificationItem inNotification; // 0x18

		// Constructors
		public <>c__DisplayClass15_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <RemoveNotification>b__0(); // 0x0000000180ECE4B0-0x0000000180ECE620
	}

	// Constructors
	public UI_Window_GameplayNotifications(); // 0x0000000180ED17D0-0x0000000180ED1890

	// Methods
	[RuntimeInitializeOnLoadMethod] // 0x00000001800C1340-0x00000001800C1350
	private static void Init(); // 0x0000000180ED1010-0x0000000180ED1110
	public static void OpenWindow(); // 0x0000000180ED1280-0x0000000180ED1380
	public static void QueueWindow(); // 0x0000000180ED1380-0x0000000180ED1480
	public static void CloseWindow(); // 0x0000000180ED0FC0-0x0000000180ED1010
	private void Setup(); // 0x00000001803581E0-0x00000001803581F0
	public void AddNotification(Notification inNotification); // 0x0000000180ED0CF0-0x0000000180ED0FC0
	private void ShowNotification(Notification inNotification); // 0x0000000180ED1620-0x0000000180ED17D0
	private void ShowNextNotification(); // 0x0000000180ED1580-0x0000000180ED1620
	private void RemoveNotification(UI_GameplayNotificationItem inNotification); // 0x0000000180ED1480-0x0000000180ED1580
	public override void MUpdate(); // 0x0000000180ED1110-0x0000000180ED1280
	protected override void OnOpen(); // 0x0000000180E9F6A0-0x0000000180E9F6B0
	protected override void OnClose(bool inAnimate); // 0x0000000180E9F690-0x0000000180E9F6A0
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
}

