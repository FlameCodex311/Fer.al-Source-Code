/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Async;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LazyListItemDetailPanel_Follow : UI_LazyListItemDetailPanel<RelationshipManager.Follow> // TypeDefIndex: 13686
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _blockUserToggle; // 0x38
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _tradeBtn; // 0x40

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <Setup>d__2 : IAsyncStateMachine // TypeDefIndex: 13687
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_LazyListItemDetailPanel_Follow <>4__this; // 0x28
		public UI_LazyListItem<RelationshipManager.Follow> inDataSrc; // 0x30
		private FeralButton <>7__wrap1; // 0x38
		private UniTask<bool> <>u__1; // 0x40

		// Methods
		private void MoveNext(); // 0x0000000180002060-0x0000000180002170
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RefreshOnlineStatus>d__8 : IAsyncStateMachine // TypeDefIndex: 13688
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_LazyListItemDetailPanel_Follow <>4__this; // 0x28
		private TaskAwaiter<bool> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x0000000180002040-0x0000000180002050
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Constructors
	public UI_LazyListItemDetailPanel_Follow(); // 0x000000018039BB20-0x000000018039BB60

	// Methods
	[AsyncStateMachine] // 0x00000001801D41E0-0x00000001801D4230
	public override void Setup(UI_LazyListItem<RelationshipManager.Follow> inDataSrc); // 0x000000018039B900-0x000000018039B9C0
	private void Start(); // 0x000000018039B9C0-0x000000018039BAD0
	private void OnDestroy(); // 0x000000018039B600-0x000000018039B710
	private void OnUserBlocked(UserBlockedMessage inMessage); // 0x000000018039B720-0x000000018039B7C0
	private void OnUserUnblocked(UserUnblockedMessage inMessage); // 0x000000018039B7C0-0x000000018039B850
	private void OnOnlineStatusChanged(UserOnlineStatusMessage inMessage); // 0x000000018039B710-0x000000018039B720
	[AsyncStateMachine] // 0x00000001801D45B0-0x00000001801D4600
	private void RefreshOnlineStatus(); // 0x000000018039B850-0x000000018039B900
	public void BtnClicked_Unfollow(); // 0x000000018039B590-0x000000018039B600
	public void BtnClicked_Sanctuary(); // 0x000000018039B400-0x000000018039B460
	public void BtnClicked_Trade(); // 0x000000018039B530-0x000000018039B590
	public void BtnClicked_OpenPlayerCard(); // 0x000000018039B3A0-0x000000018039B400
	public void BtnClicked_ToggleBlock(); // 0x000000018039B460-0x000000018039B530
	[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
	[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
	private void <>n__0(UI_LazyListItem<RelationshipManager.Follow> inDataSrc); // 0x000000018039BAD0-0x000000018039BB20
}

