/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Async;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LazyListItemDetailPanel_Follower : UI_LazyListItemDetailPanel<RelationshipManager.Follower> // TypeDefIndex: 12148
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _blockUserToggle; // 0x38
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _followUserToggle; // 0x40
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _tradeBtn; // 0x48

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <Setup>d__3 : IAsyncStateMachine // TypeDefIndex: 12149
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_LazyListItemDetailPanel_Follower <>4__this; // 0x28
		public UI_LazyListItem<RelationshipManager.Follower> inDataSrc; // 0x30
		private FeralButton <>7__wrap1; // 0x38
		private UniTask<bool> <>u__1; // 0x40

		// Methods
		private void MoveNext(); // 0x00000001801F0570-0x00000001801F0680
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RefreshOnlineStatus>d__15 : IAsyncStateMachine // TypeDefIndex: 12150
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_LazyListItemDetailPanel_Follower <>4__this; // 0x28
		private TaskAwaiter<bool> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F0520-0x00000001801F0530
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	// Constructors
	public UI_LazyListItemDetailPanel_Follower(); // 0x0000000180E6AC10-0x0000000180E6AC50

	// Methods
	[AsyncStateMachine] // 0x00000001800FC180-0x00000001800FC1D0
	public override void Setup(UI_LazyListItem<RelationshipManager.Follower> inDataSrc); // 0x0000000180E6A930-0x0000000180E6A9F0
	private void Start(); // 0x0000000180E6A9F0-0x0000000180E6AB40
	private void OnDestroy(); // 0x0000000180E6A4D0-0x0000000180E6A620
	private void OnUserBlocked(UserBlockedMessage inMessage); // 0x0000000180E6A620-0x0000000180E6A6C0
	private void OnUserUnblocked(UserUnblockedMessage inMessage); // 0x0000000180E6A760-0x0000000180E6A7F0
	private void OnUserFollowed(UserFollowedMessage inMessage); // 0x0000000180E6A6C0-0x0000000180E6A760
	private void OnUserUnfollowed(UserUnfollowedMessage inMessage); // 0x0000000180E6A7F0-0x0000000180E6A880
	public void BtnClicked_Sanctuary(); // 0x0000000180E6A270-0x0000000180E6A2D0
	public void BtnClicked_Trade(); // 0x0000000180E6A470-0x0000000180E6A4D0
	public void BtnClicked_OpenPlayerCard(); // 0x0000000180E6A210-0x0000000180E6A270
	public void BtnClicked_ToggleFollow(); // 0x0000000180E6A3A0-0x0000000180E6A470
	public void BtnClicked_ToggleBlock(); // 0x0000000180E6A2D0-0x0000000180E6A3A0
	[AsyncStateMachine] // 0x00000001800FC4B0-0x00000001800FC500
	private void RefreshOnlineStatus(); // 0x0000000180E6A880-0x0000000180E6A930
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <Setup>b__3_0(RelationshipManager.Follow follow); // 0x0000000180E6AB40-0x0000000180E6ABC0
	[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
	[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
	private void <>n__0(UI_LazyListItem<RelationshipManager.Follower> inDataSrc); // 0x0000000180E6ABC0-0x0000000180E6AC10
}

