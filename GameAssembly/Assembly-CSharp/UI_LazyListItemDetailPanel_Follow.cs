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

public class UI_LazyListItemDetailPanel_Follow : UI_LazyListItemDetailPanel<RelationshipManager.Follow> // TypeDefIndex: 12145
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _blockUserToggle; // 0x38
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _tradeBtn; // 0x40

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <Setup>d__2 : IAsyncStateMachine // TypeDefIndex: 12146
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_LazyListItemDetailPanel_Follow <>4__this; // 0x28
		public UI_LazyListItem<RelationshipManager.Follow> inDataSrc; // 0x30
		private FeralButton <>7__wrap1; // 0x38
		private UniTask<bool> <>u__1; // 0x40

		// Methods
		private void MoveNext(); // 0x00000001801F0560-0x00000001801F0570
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RefreshOnlineStatus>d__8 : IAsyncStateMachine // TypeDefIndex: 12147
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_LazyListItemDetailPanel_Follow <>4__this; // 0x28
		private TaskAwaiter<bool> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F0540-0x00000001801F0550
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	// Constructors
	public UI_LazyListItemDetailPanel_Follow(); // 0x0000000180E6A1D0-0x0000000180E6A210

	// Methods
	[AsyncStateMachine] // 0x00000001800F9E40-0x00000001800F9E90
	public override void Setup(UI_LazyListItem<RelationshipManager.Follow> inDataSrc); // 0x0000000180E69FB0-0x0000000180E6A070
	private void Start(); // 0x0000000180E6A070-0x0000000180E6A180
	private void OnDestroy(); // 0x0000000180E69CB0-0x0000000180E69DC0
	private void OnUserBlocked(UserBlockedMessage inMessage); // 0x0000000180E69DD0-0x0000000180E69E70
	private void OnUserUnblocked(UserUnblockedMessage inMessage); // 0x0000000180E69E70-0x0000000180E69F00
	private void OnOnlineStatusChanged(UserOnlineStatusMessage inMessage); // 0x0000000180E69DC0-0x0000000180E69DD0
	[AsyncStateMachine] // 0x00000001800FA0D0-0x00000001800FA120
	private void RefreshOnlineStatus(); // 0x0000000180E69F00-0x0000000180E69FB0
	public void BtnClicked_Unfollow(); // 0x0000000180E69C30-0x0000000180E69CB0
	public void BtnClicked_Sanctuary(); // 0x0000000180E69AA0-0x0000000180E69B00
	public void BtnClicked_Trade(); // 0x0000000180E69BD0-0x0000000180E69C30
	public void BtnClicked_OpenPlayerCard(); // 0x0000000180E69A40-0x0000000180E69AA0
	public void BtnClicked_ToggleBlock(); // 0x0000000180E69B00-0x0000000180E69BD0
	[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
	[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
	private void <>n__0(UI_LazyListItem<RelationshipManager.Follow> inDataSrc); // 0x0000000180E6A180-0x0000000180E6A1D0
}

