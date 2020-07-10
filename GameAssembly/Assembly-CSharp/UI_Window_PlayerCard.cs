/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UniRx.Async;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_PlayerCard : UI_Window // TypeDefIndex: 12533
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _nameText; // 0x108
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private RawImage _avatarIconImage; // 0x110
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _followToggle; // 0x118
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _blockToggle; // 0x120
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _favoriteToggle; // 0x128
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_OnlineStatus _onlineStatus; // 0x130
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_XPIndicator _xpIndicator; // 0x138
	private UserInfo _userInfo; // 0x140

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 12534
	{
		// Fields
		public string inUUID; // 0x10

		// Constructors
		public <>c__DisplayClass0_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0(UI_Window_PlayerCard window); // 0x0000000180ECE2E0-0x0000000180ECE310
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 12535
	{
		// Fields
		public string inUUID; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x0000000180ECE660-0x0000000180ECE730
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <Setup>d__11 : IAsyncStateMachine // TypeDefIndex: 12536
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public string inUUID; // 0x28
		public UI_Window_PlayerCard <>4__this; // 0x30
		private UniTask<UserInfo> <>u__1; // 0x38
		private TaskAwaiter<AvatarLookGetResponse> <>u__2; // 0x48

		// Methods
		private void MoveNext(); // 0x00000001801F1030-0x00000001801F1040
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RefreshBlocked>d__16 : IAsyncStateMachine // TypeDefIndex: 12537
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_PlayerCard <>4__this; // 0x28
		private FeralButton <>7__wrap1; // 0x30
		private UniTask<bool> <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F1000-0x00000001801F1010
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <BtnClicked_PrivateChat>d__20 : IAsyncStateMachine // TypeDefIndex: 12538
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_PlayerCard <>4__this; // 0x28
		private UniTask.Awaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F0FA0-0x00000001801F0FB0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	// Constructors
	public UI_Window_PlayerCard(); // 0x0000000180E9F830-0x0000000180E9F840

	// Methods
	public static void OpenWindow(string inUUID); // 0x0000000180EDEBC0-0x0000000180EDEC80
	public static void QueueWindow(string inUUID); // 0x0000000180EDEC80-0x0000000180EDED40
	public static void CloseWindow(); // 0x0000000180EDE4E0-0x0000000180EDE530
	[AsyncStateMachine] // 0x00000001800DC6E0-0x00000001800DC730
	private void Setup(string inUUID); // 0x0000000180EDEF10-0x0000000180EDEFD0
	protected override void OnOpen(); // 0x0000000180EDE7D0-0x0000000180EDEA60
	protected override void OnClose(bool inAnimate); // 0x0000000180EDE530-0x0000000180EDE7D0
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
	private void RefreshFollowedAndFavorited(); // 0x0000000180EDEDF0-0x0000000180EDEF10
	[AsyncStateMachine] // 0x00000001800DC8A0-0x00000001800DC8F0
	private void RefreshBlocked(); // 0x0000000180EDED40-0x0000000180EDEDF0
	public void ToggleBtnClicked_Favorite(bool inIsOn); // 0x0000000180EDEFD0-0x0000000180EDF060
	public void BtnClicked_ToggleFollow(); // 0x0000000180EDE3F0-0x0000000180EDE4C0
	public void BtnClicked_ToggleBlock(); // 0x0000000180EDE320-0x0000000180EDE3F0
	[AsyncStateMachine] // 0x00000001800DCB60-0x00000001800DCBB0
	public void BtnClicked_PrivateChat(); // 0x0000000180EDE210-0x0000000180EDE2C0
	public void BtnClicked_Sanctuary(); // 0x0000000180EDE2D0-0x0000000180EDE320
	public void BtnClicked_Trade(); // 0x0000000180EDE4C0-0x0000000180EDE4E0
	public void BtnClicked_GoToPlayer(); // 0x0000000180EDE190-0x0000000180EDE210
	public void BtnClicked_Report(); // 0x0000000180EDE2C0-0x0000000180EDE2D0
	private void OnUserFollowed(UserFollowedMessage inMessage); // 0x0000000180EDEAC0-0x0000000180EDEB20
	private void OnUserUnFollowed(UserUnfollowedMessage inMessage); // 0x0000000180EDEB20-0x0000000180EDEB70
	private void OnUserFavorited(UserFavoritedMessage inMessage); // 0x0000000180EDEAC0-0x0000000180EDEB20
	private void OnUserUnfavorited(UserUnfavoritedMessage inMessage); // 0x0000000180EDEAC0-0x0000000180EDEB20
	private void OnUserBlocked(UserBlockedMessage inMessage); // 0x0000000180EDEA60-0x0000000180EDEAC0
	private void OnUserUnblocked(UserUnblockedMessage inMessage); // 0x0000000180EDEB70-0x0000000180EDEBC0
	private void CloseFromMessage(Message inMessage); // 0x0000000180EA0020-0x0000000180EA0030
}

