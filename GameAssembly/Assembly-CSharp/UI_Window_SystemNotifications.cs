/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UniRx.Async;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_SystemNotifications : UI_Window, IDragHandler // TypeDefIndex: 12615
{
	// Fields
	[Header] // 0x00000001800F40E0-0x00000001800F4130
	[SerializeField] // 0x00000001800F40E0-0x00000001800F4130
	private float _notificationDisplayTime; // 0x108
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _dismissalDragThreshold; // 0x10C
	[Header] // 0x00000001800C54D0-0x00000001800C5520
	[SerializeField] // 0x00000001800C54D0-0x00000001800C5520
	private RectTransform _panelTransform; // 0x110
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _iconGroup; // 0x118
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWImage _iconImage; // 0x120
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private RawImage _iconRawImage; // 0x128
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _messageText; // 0x130
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_OnlineStatus _onlineStatus; // 0x138
	private List<Notification> _notificationQueue; // 0x140
	private Notification _notification; // 0x148
	private float _notificationTimer; // 0x150

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 12616
	{
		// Fields
		public NotificationSentMessage inMessage; // 0x10

		// Constructors
		public <>c__DisplayClass0_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <Init>b__2(); // 0x0000000180F7A180-0x0000000180F7A200
		internal void <Init>b__3(UI_Window_SystemNotifications inWindow); // 0x0000000180F7A200-0x0000000180F7A240
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12617
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<bool> <>9__0_1; // 0x08
		public static Action<NotificationSentMessage> <>9__0_0; // 0x10
		public static Action<UI_Window_SystemNotifications> <>9__1_0; // 0x18
		public static Action<UI_Window> <>9__2_0; // 0x20

		// Constructors
		static <>c(); // 0x0000000180F7B550-0x0000000180F7B5B0
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <Init>b__0_0(NotificationSentMessage inMessage); // 0x0000000180F796C0-0x0000000180F79A10
		internal bool <Init>b__0_1(); // 0x0000000180F79C80-0x0000000180F79D00
		internal void <OpenWindow>b__1_0(UI_Window_SystemNotifications window); // 0x0000000180E9D080-0x0000000180E9D0A0
		internal void <QueueWindow>b__2_0(UI_Window inWindow); // 0x0000000180F7A030-0x0000000180F7A0B0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <ShowNextNotification>d__23 : IAsyncStateMachine // TypeDefIndex: 12618
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_SystemNotifications <>4__this; // 0x28
		private UniTask.Awaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F17F0-0x00000001801F1800
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	// Constructors
	public UI_Window_SystemNotifications(); // 0x0000000180F822E0-0x0000000180F82360

	// Methods
	[RuntimeInitializeOnLoadMethod] // 0x00000001800C1340-0x00000001800C1350
	private static void Init(); // 0x0000000180F81580-0x0000000180F81680
	public static void OpenWindow(); // 0x0000000180F81A40-0x0000000180F81B40
	public static void QueueWindow(); // 0x0000000180F81B40-0x0000000180F81C40
	public static void CloseWindow(); // 0x0000000180F81530-0x0000000180F81580
	private void Setup(); // 0x00000001803581E0-0x00000001803581F0
	public void BtnClicked_OpenNotification(); // 0x0000000180F814B0-0x0000000180F81530
	public void OnDrag(PointerEventData eventData); // 0x0000000180F81890-0x0000000180F818F0
	private void AddNotification(Notification inNotification); // 0x0000000180F81330-0x0000000180F814B0
	private void ShowNotification(Notification inNotification); // 0x0000000180F82130-0x0000000180F822E0
	private void SetupImage(); // 0x0000000180F81C40-0x0000000180F81F70
	private void SetupUserStatus(); // 0x0000000180F81FC0-0x0000000180F82080
	private void SetupText(); // 0x0000000180F81F70-0x0000000180F81FC0
	[AsyncStateMachine] // 0x00000001800F4CE0-0x00000001800F4D30
	private void ShowNextNotification(); // 0x0000000180F82080-0x0000000180F82130
	public override void MUpdate(); // 0x0000000180F81680-0x0000000180F81740
	protected override void OnOpen(); // 0x0000000180F81950-0x0000000180F81A40
	protected override void OnClose(bool inAnimate); // 0x0000000180F81740-0x0000000180F81890
	private void OnNotificationWindowOpened(WindowOpenedMessage inMessage); // 0x0000000180F818F0-0x0000000180F81950
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
}

