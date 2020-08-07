/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using TMPro;
using UniRx.Async;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyListItem_Follower : UI_LazyListItem<RelationshipManager.Follower> // TypeDefIndex: 13695
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CanvasGroup _canvasGroup; // 0x68
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _nameText; // 0x70
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWImage _blockedIconImage; // 0x78
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_OnlineStatus _onlineStatus; // 0x80
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _privateChatBtn; // 0x88
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _privateChatUnreadIndicator; // 0x90
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _favoriteToggle; // 0x98
	private UserInfo _userInfo; // 0xA0
	private bool _isBlocked; // 0xA8
	private bool _isFavorite; // 0xA9
	private bool _hasCompletedSetup; // 0xAA
	private CancellationTokenSource _cancellationTokenSource; // 0xB0

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <SetupAsync>d__13 : IAsyncStateMachine // TypeDefIndex: 13696
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_LazyListItem_Follower <>4__this; // 0x28
		private UniTask<bool> <>u__1; // 0x30
		private UniTask<UserInfo> <>u__2; // 0x40

		// Methods
		private void MoveNext(); // 0x00000001800021D0-0x00000001800021E0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <BtnClicked_PrivateChat>d__14 : IAsyncStateMachine // TypeDefIndex: 13697
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_LazyListItem_Follower <>4__this; // 0x28
		private UniTask.Awaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x0000000180002180-0x0000000180002190
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Constructors
	public UI_LazyListItem_Follower(); // 0x00000001803A7740-0x00000001803A7780

	// Methods
	public override void Setup(Action<UI_LazyListItem<RelationshipManager.Follower>> inOnClicked, Action<UI_LazyListItem<RelationshipManager.Follower>> inOnSelected, RelationshipManager.Follower inData, UI_LazyItemList<RelationshipManager.Follower> inItemList); // 0x00000001803A7510-0x00000001803A7660
	[AsyncStateMachine] // 0x00000001801D88C0-0x00000001801D8910
	private void SetupAsync(); // 0x00000001803A7460-0x00000001803A7510
	[AsyncStateMachine] // 0x00000001801D8AD0-0x00000001801D8B20
	public void BtnClicked_PrivateChat(); // 0x00000001803A6F60-0x00000001803A7010
	public void BtnClicked_ToggleFavorite(bool inIsOn); // 0x00000001803A7010-0x00000001803A70C0
	protected override void Start(); // 0x00000001803A7660-0x00000001803A7740
	private void OnDestroy(); // 0x00000001803A7120-0x00000001803A71F0
	private void OnUserBlocked(UserBlockedMessage inMessage); // 0x00000001803A7270-0x00000001803A7300
	private void OnUserUnblocked(UserUnblockedMessage inMessage); // 0x00000001803A7300-0x00000001803A7380
	private void RefreshBlockedState(bool inInstant = false /* Metadata: 0x007BA4B2 */); // 0x00000001803A7380-0x00000001803A7460
	private void RefreshPrivateChat(); // 0x00000001803A6AC0-0x00000001803A6B20
	private void OnEnable(); // 0x00000001803A71F0-0x00000001803A7270
	private void OnDisable(); // 0x00000001803A6660-0x00000001803A6680
	public override void MarkAsSelected(bool inIsSelected); // 0x00000001803A70C0-0x00000001803A7120
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <RefreshBlockedState>b__20_0(); // 0x00000001803A6E80-0x00000001803A6ED0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <RefreshBlockedState>b__20_1(); // 0x00000001803A6ED0-0x00000001803A6F20
}

