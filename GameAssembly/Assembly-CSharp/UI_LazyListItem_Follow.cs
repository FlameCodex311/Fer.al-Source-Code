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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyListItem_Follow : UI_LazyListItem<RelationshipManager.Follow> // TypeDefIndex: 12139
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CanvasGroup _canvasGroup; // 0x68
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _nameText; // 0x70
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWImage _blockedIconImage; // 0x78
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_OnlineStatus _onlineStatus; // 0x80
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _privateChatBtn; // 0x88
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _privateChatUnreadIndicator; // 0x90
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _favoriteToggle; // 0x98
	private UserInfo _userInfo; // 0xA0
	private bool _isBlocked; // 0xA8
	private bool _isFavorite; // 0xA9
	private bool _hasCompletedSetup; // 0xAA
	private CancellationTokenSource _cancellationTokenSource; // 0xB0

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <BtnClicked_PrivateChat>d__13 : IAsyncStateMachine // TypeDefIndex: 12140
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_LazyListItem_Follow <>4__this; // 0x28
		private UniTask.Awaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F0690-0x00000001801F06A0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <SetupAsync>d__15 : IAsyncStateMachine // TypeDefIndex: 12141
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_LazyListItem_Follow <>4__this; // 0x28
		private UniTask<bool> <>u__1; // 0x30
		private UniTask<UserInfo> <>u__2; // 0x40

		// Methods
		private void MoveNext(); // 0x00000001801F06F0-0x00000001801F0700
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	// Constructors
	public UI_LazyListItem_Follow(); // 0x0000000180E75350-0x0000000180E75390

	// Methods
	public override void Setup(Action<UI_LazyListItem<RelationshipManager.Follow>> inOnClicked, Action<UI_LazyListItem<RelationshipManager.Follow>> inOnSelected, RelationshipManager.Follow inData, UI_LazyItemList<RelationshipManager.Follow> inItemList); // 0x0000000180E75000-0x0000000180E75150
	[AsyncStateMachine] // 0x00000001800F7720-0x00000001800F7770
	public void BtnClicked_PrivateChat(); // 0x0000000180E74770-0x0000000180E74820
	public void BtnClicked_ToggleFavorite(bool inIsOn); // 0x0000000180E74820-0x0000000180E748E0
	[AsyncStateMachine] // 0x00000001800F7A30-0x00000001800F7A80
	private void SetupAsync(); // 0x0000000180E74F50-0x0000000180E75000
	protected override void Start(); // 0x0000000180E75150-0x0000000180E752B0
	private void OnDestroy(); // 0x0000000180E74940-0x0000000180E74A90
	private void OnUserBlocked(UserBlockedMessage inMessage); // 0x0000000180E74B30-0x0000000180E74BC0
	private void OnUserUnblocked(UserUnblockedMessage inMessage); // 0x0000000180E74C60-0x0000000180E74CE0
	private void RefreshBlockedState(bool inInstant = false /* Metadata: 0x00782DA3 */); // 0x0000000180E74D80-0x0000000180E74EC0
	private void OnUserFavorited(UserFavoritedMessage inMessage); // 0x0000000180E74BC0-0x0000000180E74C60
	private void OnUserUnfavorited(UserUnfavoritedMessage inMessage); // 0x0000000180E74CE0-0x0000000180E74D80
	private void RefreshFavoritedState(); // 0x0000000180E74EC0-0x0000000180E74EF0
	private void RefreshPrivateChat(); // 0x0000000180E74EF0-0x0000000180E74F50
	private void OnEnable(); // 0x0000000180E74AB0-0x0000000180E74B30
	private void OnDisable(); // 0x0000000180E74A90-0x0000000180E74AB0
	public override void MarkAsSelected(bool inIsSelected); // 0x0000000180E748E0-0x0000000180E74940
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <RefreshBlockedState>b__20_0(); // 0x0000000180E752B0-0x0000000180E75300
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <RefreshBlockedState>b__20_1(); // 0x0000000180E75300-0x0000000180E75350
}

