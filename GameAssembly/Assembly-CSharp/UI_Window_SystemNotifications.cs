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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_SystemNotifications : UI_Window, IDragHandler // TypeDefIndex: 14217
{
	// Fields
	[Header] // 0x00000001801E5CD0-0x00000001801E5D20
	[SerializeField] // 0x00000001801E5CD0-0x00000001801E5D20
	private float _notificationDisplayTime; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _dismissalDragThreshold; // 0x10C
	[Header] // 0x00000001801E6260-0x00000001801E62B0
	[SerializeField] // 0x00000001801E6260-0x00000001801E62B0
	private RectTransform _panelTransform; // 0x110
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _iconGroup; // 0x118
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWImage _iconImage; // 0x120
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RawImage _iconRawImage; // 0x128
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _messageText; // 0x130
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_OnlineStatus _onlineStatus; // 0x138
	private List<Notification> _notificationQueue; // 0x140
	private Notification _notification; // 0x148
	private float _notificationTimer; // 0x150

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 14218
	{
		// Fields
		public NotificationSentMessage inMessage; // 0x10

		// Constructors
		public <>c__DisplayClass0_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <Init>b__2(); // 0x0000000180446A20-0x0000000180446AA0
		internal void <Init>b__3(UI_Window_SystemNotifications inWindow); // 0x0000000180446AA0-0x0000000180446AE0
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 14219
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<bool> <>9__0_1; // 0x08
		public static Action<NotificationSentMessage> <>9__0_0; // 0x10
		public static Action<UI_Window_SystemNotifications> <>9__1_0; // 0x18
		public static Action<UI_Window> <>9__2_0; // 0x20

		// Constructors
		static <>c(); // 0x00000001804485C0-0x0000000180448620
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <Init>b__0_0(NotificationSentMessage inMessage); // 0x0000000180445F70-0x00000001804462C0
		internal bool <Init>b__0_1(); // 0x0000000180446530-0x00000001804465B0
		internal void <OpenWindow>b__1_0(UI_Window_SystemNotifications window); // 0x00000001803B24A0-0x00000001803B24C0
		internal void <QueueWindow>b__2_0(UI_Window inWindow); // 0x00000001804468D0-0x0000000180446950
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <ShowNextNotification>d__23 : IAsyncStateMachine // TypeDefIndex: 14220
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_SystemNotifications <>4__this; // 0x28
		private UniTask.Awaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x0000000180004730-0x0000000180004A30
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Constructors
	public UI_Window_SystemNotifications(); // 0x000000018044E1B0-0x000000018044E230

	// Methods
	[RuntimeInitializeOnLoadMethod] // 0x00000001801CF2D0-0x00000001801CF2E0
	private static void Init(); // 0x000000018044D470-0x000000018044D570
	public static void OpenWindow(); // 0x000000018044D930-0x000000018044DA30
	public static void QueueWindow(); // 0x000000018044DA30-0x000000018044DB30
	public static void CloseWindow(); // 0x000000018044D420-0x000000018044D470
	private void Setup(); // 0x00000001803774A0-0x00000001803774B0
	public void BtnClicked_OpenNotification(); // 0x000000018044D3A0-0x000000018044D420
	public void OnDrag(PointerEventData eventData); // 0x000000018044D780-0x000000018044D7E0
	private void AddNotification(Notification inNotification); // 0x000000018044D220-0x000000018044D3A0
	private void ShowNotification(Notification inNotification); // 0x000000018044E010-0x000000018044E1B0
	private void SetupImage(); // 0x000000018044DB30-0x000000018044DE50
	private void SetupUserStatus(); // 0x000000018044DEA0-0x000000018044DF60
	private void SetupText(); // 0x000000018044DE50-0x000000018044DEA0
	[AsyncStateMachine] // 0x00000001801E72E0-0x00000001801E7330
	private void ShowNextNotification(); // 0x000000018044DF60-0x000000018044E010
	public override void MUpdate(); // 0x000000018044D570-0x000000018044D630
	protected override void OnOpen(); // 0x000000018044D840-0x000000018044D930
	protected override void OnClose(bool inAnimate); // 0x000000018044D630-0x000000018044D780
	private void OnNotificationWindowOpened(WindowOpenedMessage inMessage); // 0x000000018044D7E0-0x000000018044D840
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
}

