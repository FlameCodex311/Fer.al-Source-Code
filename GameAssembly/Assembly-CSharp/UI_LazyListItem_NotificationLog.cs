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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyListItem_NotificationLog : UI_LazyListItem<Notification> // TypeDefIndex: 13644
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Rectangle _bgRectangle; // 0x68
	[Header] // 0x0000000180286E30-0x0000000180286E80
	[SerializeField] // 0x0000000180286E30-0x0000000180286E80
	private WWTextMeshProUGUI _messageText; // 0x70
	[Header] // 0x0000000180286FF0-0x0000000180287040
	[SerializeField] // 0x0000000180286FF0-0x0000000180287040
	private UI_OnlineStatus _onlineStatus; // 0x78
	[Header] // 0x0000000180287240-0x0000000180287290
	[SerializeField] // 0x0000000180287240-0x0000000180287290
	private GameObject _groupImage; // 0x80
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWImage _iconImage; // 0x88
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RawImage _iconRawImage; // 0x90
	[Header] // 0x00000001802889B0-0x0000000180288A00
	[SerializeField] // 0x00000001802889B0-0x0000000180288A00
	private WWTextMeshProUGUI _timeStampText; // 0x98
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Color _readColor; // 0xA0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Color _unreadColor; // 0xB0
	private CancellationTokenSource _cancellationTokenSource; // 0xC0
	private UI_LazyItemList_NotificationLog _list; // 0xC8

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <SetupAsync>d__13 : IAsyncStateMachine // TypeDefIndex: 13645
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_LazyListItem_NotificationLog <>4__this; // 0x28
		private UniTask.Awaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001800021C0-0x00000001800021D0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <SetupUser>d__14 : IAsyncStateMachine // TypeDefIndex: 13646
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncUniTaskMethodBuilder <>t__builder; // 0x08
		public UI_LazyListItem_NotificationLog <>4__this; // 0x18

		// Methods
		private void MoveNext(); // 0x0000000180002210-0x0000000180002340
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002020-0x0000000180002030
	}

	// Constructors
	public UI_LazyListItem_NotificationLog(); // 0x00000001803A9C30-0x00000001803A9CA0

	// Methods
	public override void Setup(Action<UI_LazyListItem<Notification>> inOnClicked, Action<UI_LazyListItem<Notification>> inOnSelected, Notification inData, UI_LazyItemList<Notification> inItemList); // 0x00000001803A9AC0-0x00000001803A9C30
	public override void Refresh(); // 0x00000001803A9400-0x00000001803A9510
	[AsyncStateMachine] // 0x0000000180288CE0-0x0000000180288D30
	private void SetupAsync(); // 0x00000001803A9510-0x00000001803A95C0
	[AsyncStateMachine] // 0x0000000180288EF0-0x0000000180288F40
	private UniTask SetupUser(CancellationTokenSource inCancellationTokenSource); // 0x00000001803A9A30-0x00000001803A9AC0
	private void SetupImage(); // 0x00000001803A95C0-0x00000001803A98C0
	private void SetupText(); // 0x00000001803A98C0-0x00000001803A9930
	private void SetupTimeStamp(); // 0x00000001803A9930-0x00000001803A9A30
	private void OnDisable(); // 0x00000001803A9370-0x00000001803A9400
}

