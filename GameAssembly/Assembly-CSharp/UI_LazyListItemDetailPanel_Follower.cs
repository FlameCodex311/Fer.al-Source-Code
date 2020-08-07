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

public class UI_LazyListItemDetailPanel_Follower : UI_LazyListItemDetailPanel<RelationshipManager.Follower> // TypeDefIndex: 13689
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _blockUserToggle; // 0x38
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _followUserToggle; // 0x40
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _tradeBtn; // 0x48

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <Setup>d__3 : IAsyncStateMachine // TypeDefIndex: 13690
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_LazyListItemDetailPanel_Follower <>4__this; // 0x28
		public UI_LazyListItem<RelationshipManager.Follower> inDataSrc; // 0x30
		private FeralButton <>7__wrap1; // 0x38
		private UniTask<bool> <>u__1; // 0x40

		// Methods
		private void MoveNext(); // 0x0000000180002200-0x0000000180002210
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RefreshOnlineStatus>d__15 : IAsyncStateMachine // TypeDefIndex: 13691
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_LazyListItemDetailPanel_Follower <>4__this; // 0x28
		private TaskAwaiter<bool> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001800021B0-0x00000001800021C0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Constructors
	public UI_LazyListItemDetailPanel_Follower(); // 0x000000018039C550-0x000000018039E330

	// Methods
	[AsyncStateMachine] // 0x00000001801D5810-0x00000001801D5860
	public override void Setup(UI_LazyListItem<RelationshipManager.Follower> inDataSrc); // 0x000000018039C280-0x000000018039C340
	private void Start(); // 0x000000018039C340-0x000000018039C490
	private void OnDestroy(); // 0x000000018039BE20-0x000000018039BF70
	private void OnUserBlocked(UserBlockedMessage inMessage); // 0x000000018039BF70-0x000000018039C010
	private void OnUserUnblocked(UserUnblockedMessage inMessage); // 0x000000018039C0B0-0x000000018039C140
	private void OnUserFollowed(UserFollowedMessage inMessage); // 0x000000018039C010-0x000000018039C0B0
	private void OnUserUnfollowed(UserUnfollowedMessage inMessage); // 0x000000018039C140-0x000000018039C1D0
	public void BtnClicked_Sanctuary(); // 0x000000018039BBC0-0x000000018039BC20
	public void BtnClicked_Trade(); // 0x000000018039BDC0-0x000000018039BE20
	public void BtnClicked_OpenPlayerCard(); // 0x000000018039BB60-0x000000018039BBC0
	public void BtnClicked_ToggleFollow(); // 0x000000018039BCF0-0x000000018039BDC0
	public void BtnClicked_ToggleBlock(); // 0x000000018039BC20-0x000000018039BCF0
	[AsyncStateMachine] // 0x00000001801D59E0-0x00000001801D5A30
	private void RefreshOnlineStatus(); // 0x000000018039C1D0-0x000000018039C280
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <Setup>b__3_0(RelationshipManager.Follow follow); // 0x000000018039C490-0x000000018039C500
	[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
	[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
	private void <>n__0(UI_LazyListItem<RelationshipManager.Follower> inDataSrc); // 0x000000018039C500-0x000000018039C550
}

