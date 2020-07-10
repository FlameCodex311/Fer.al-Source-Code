/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using ThisOtherThing.UI.Shapes;
using TMPro;
using UniRx.Async;
using UniRx.Async.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyListItem_NotificationLog : UI_LazyListItem<Notification> // TypeDefIndex: 12094
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Rectangle _bgRectangle; // 0x68
	[Header] // 0x00000001800E2170-0x00000001800E21C0
	[SerializeField] // 0x00000001800E2170-0x00000001800E21C0
	private WWTextMeshProUGUI _messageText; // 0x70
	[Header] // 0x00000001800E2410-0x00000001800E2460
	[SerializeField] // 0x00000001800E2410-0x00000001800E2460
	private UI_OnlineStatus _onlineStatus; // 0x78
	[Header] // 0x00000001800E2670-0x00000001800E26C0
	[SerializeField] // 0x00000001800E2670-0x00000001800E26C0
	private GameObject _groupImage; // 0x80
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWImage _iconImage; // 0x88
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private RawImage _iconRawImage; // 0x90
	[Header] // 0x00000001800E2B60-0x00000001800E2BB0
	[SerializeField] // 0x00000001800E2B60-0x00000001800E2BB0
	private WWTextMeshProUGUI _timeStampText; // 0x98
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color _readColor; // 0xA0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color _unreadColor; // 0xB0
	private CancellationTokenSource _cancellationTokenSource; // 0xC0
	private UI_LazyItemList_NotificationLog _list; // 0xC8

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <SetupAsync>d__13 : IAsyncStateMachine // TypeDefIndex: 12095
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_LazyListItem_NotificationLog <>4__this; // 0x28
		private UniTask.Awaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F06D0-0x00000001801F06E0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <SetupUser>d__14 : IAsyncStateMachine // TypeDefIndex: 12096
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncUniTaskMethodBuilder <>t__builder; // 0x08
		public UI_LazyListItem_NotificationLog <>4__this; // 0x18

		// Methods
		private void MoveNext(); // 0x00000001801F0710-0x00000001801F0720
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0500-0x00000001801F0510
	}

	// Constructors
	public UI_LazyListItem_NotificationLog(); // 0x0000000180E78110-0x0000000180E78180

	// Methods
	public override void Setup(Action<UI_LazyListItem<Notification>> inOnClicked, Action<UI_LazyListItem<Notification>> inOnSelected, Notification inData, UI_LazyItemList<Notification> inItemList); // 0x0000000180E77FA0-0x0000000180E78110
	public override void Refresh(); // 0x0000000180E778D0-0x0000000180E779F0
	[AsyncStateMachine] // 0x00000001800E2ED0-0x00000001800E2F20
	private void SetupAsync(); // 0x0000000180E779F0-0x0000000180E77AA0
	[AsyncStateMachine] // 0x00000001800E30A0-0x00000001800E30F0
	private UniTask SetupUser(CancellationTokenSource inCancellationTokenSource); // 0x0000000180E77F10-0x0000000180E77FA0
	private void SetupImage(); // 0x0000000180E77AA0-0x0000000180E77DA0
	private void SetupText(); // 0x0000000180E77DA0-0x0000000180E77E10
	private void SetupTimeStamp(); // 0x0000000180E77E10-0x0000000180E77F10
	private void OnDisable(); // 0x0000000180E77840-0x0000000180E778D0
}

