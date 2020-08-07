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

public class UI_LazyListItem_Follow : UI_LazyListItem<RelationshipManager.Follow> // TypeDefIndex: 13692
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
	private struct <BtnClicked_PrivateChat>d__13 : IAsyncStateMachine // TypeDefIndex: 13693
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_LazyListItem_Follow <>4__this; // 0x28
		private UniTask.Awaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x0000000180002170-0x0000000180002180
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <SetupAsync>d__15 : IAsyncStateMachine // TypeDefIndex: 13694
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_LazyListItem_Follow <>4__this; // 0x28
		private UniTask<bool> <>u__1; // 0x30
		private UniTask<UserInfo> <>u__2; // 0x40

		// Methods
		private void MoveNext(); // 0x00000001800021E0-0x00000001800021F0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Constructors
	public UI_LazyListItem_Follow(); // 0x00000001803A6F20-0x00000001803A6F60

	// Methods
	public override void Setup(Action<UI_LazyListItem<RelationshipManager.Follow>> inOnClicked, Action<UI_LazyListItem<RelationshipManager.Follow>> inOnSelected, RelationshipManager.Follow inData, UI_LazyItemList<RelationshipManager.Follow> inItemList); // 0x00000001803A6BD0-0x00000001803A6D20
	[AsyncStateMachine] // 0x00000001801D6B60-0x00000001801D6BB0
	public void BtnClicked_PrivateChat(); // 0x00000001803A6350-0x00000001803A6400
	public void BtnClicked_ToggleFavorite(bool inIsOn); // 0x00000001803A6400-0x00000001803A64B0
	[AsyncStateMachine] // 0x00000001801D6E10-0x00000001801D6E60
	private void SetupAsync(); // 0x00000001803A6B20-0x00000001803A6BD0
	protected override void Start(); // 0x00000001803A6D20-0x00000001803A6E80
	private void OnDestroy(); // 0x00000001803A6510-0x00000001803A6660
	private void OnUserBlocked(UserBlockedMessage inMessage); // 0x00000001803A6700-0x00000001803A6790
	private void OnUserUnblocked(UserUnblockedMessage inMessage); // 0x00000001803A6830-0x00000001803A68B0
	private void RefreshBlockedState(bool inInstant = false /* Metadata: 0x007BA4B1 */); // 0x00000001803A6950-0x00000001803A6A90
	private void OnUserFavorited(UserFavoritedMessage inMessage); // 0x00000001803A6790-0x00000001803A6830
	private void OnUserUnfavorited(UserUnfavoritedMessage inMessage); // 0x00000001803A68B0-0x00000001803A6950
	private void RefreshFavoritedState(); // 0x00000001803A6A90-0x00000001803A6AC0
	private void RefreshPrivateChat(); // 0x00000001803A6AC0-0x00000001803A6B20
	private void OnEnable(); // 0x00000001803A6680-0x00000001803A6700
	private void OnDisable(); // 0x00000001803A6660-0x00000001803A6680
	public override void MarkAsSelected(bool inIsSelected); // 0x00000001803A64B0-0x00000001803A6510
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <RefreshBlockedState>b__20_0(); // 0x00000001803A6E80-0x00000001803A6ED0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <RefreshBlockedState>b__20_1(); // 0x00000001803A6ED0-0x00000001803A6F20
}

