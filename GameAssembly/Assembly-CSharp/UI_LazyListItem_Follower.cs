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

public class UI_LazyListItem_Follower : UI_LazyListItem<RelationshipManager.Follower> // TypeDefIndex: 12142
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
	private struct <SetupAsync>d__13 : IAsyncStateMachine // TypeDefIndex: 12143
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_LazyListItem_Follower <>4__this; // 0x28
		private UniTask<bool> <>u__1; // 0x30
		private UniTask<UserInfo> <>u__2; // 0x40

		// Methods
		private void MoveNext(); // 0x00000001801F06E0-0x00000001801F06F0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <BtnClicked_PrivateChat>d__14 : IAsyncStateMachine // TypeDefIndex: 12144
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_LazyListItem_Follower <>4__this; // 0x28
		private UniTask.Awaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F06A0-0x00000001801F06B0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	// Constructors
	public UI_LazyListItem_Follower(); // 0x0000000180E75B80-0x0000000180E75BC0

	// Methods
	public override void Setup(Action<UI_LazyListItem<RelationshipManager.Follower>> inOnClicked, Action<UI_LazyListItem<RelationshipManager.Follower>> inOnSelected, RelationshipManager.Follower inData, UI_LazyItemList<RelationshipManager.Follower> inItemList); // 0x0000000180E75950-0x0000000180E75AA0
	[AsyncStateMachine] // 0x00000001800F8DE0-0x00000001800F8E30
	private void SetupAsync(); // 0x0000000180E758A0-0x0000000180E75950
	[AsyncStateMachine] // 0x00000001800F9130-0x00000001800F9180
	public void BtnClicked_PrivateChat(); // 0x0000000180E75390-0x0000000180E75440
	public void BtnClicked_ToggleFavorite(bool inIsOn); // 0x0000000180E75440-0x0000000180E75500
	protected override void Start(); // 0x0000000180E75AA0-0x0000000180E75B80
	private void OnDestroy(); // 0x0000000180E75560-0x0000000180E75630
	private void OnUserBlocked(UserBlockedMessage inMessage); // 0x0000000180E756B0-0x0000000180E75740
	private void OnUserUnblocked(UserUnblockedMessage inMessage); // 0x0000000180E75740-0x0000000180E757C0
	private void RefreshBlockedState(bool inInstant = false /* Metadata: 0x00782DA4 */); // 0x0000000180E757C0-0x0000000180E758A0
	private void RefreshPrivateChat(); // 0x0000000180E74EF0-0x0000000180E74F50
	private void OnEnable(); // 0x0000000180E75630-0x0000000180E756B0
	private void OnDisable(); // 0x0000000180E74A90-0x0000000180E74AB0
	public override void MarkAsSelected(bool inIsSelected); // 0x0000000180E75500-0x0000000180E75560
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <RefreshBlockedState>b__20_0(); // 0x0000000180E752B0-0x0000000180E75300
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <RefreshBlockedState>b__20_1(); // 0x0000000180E75300-0x0000000180E75350
}

