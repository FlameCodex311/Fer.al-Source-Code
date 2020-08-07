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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_PlayerCard : UI_Window // TypeDefIndex: 14135
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _nameText; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RawImage _avatarIconImage; // 0x110
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _followToggle; // 0x118
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _blockToggle; // 0x120
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _favoriteToggle; // 0x128
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_OnlineStatus _onlineStatus; // 0x130
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_XPIndicator _xpIndicator; // 0x138
	private UserInfo _userInfo; // 0x140

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 14136
	{
		// Fields
		public string inUUID; // 0x10

		// Constructors
		public <>c__DisplayClass0_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0(UI_Window_PlayerCard window); // 0x00000001803B2EB0-0x00000001803B2EE0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 14137
	{
		// Fields
		public string inUUID; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x00000001803B30C0-0x00000001803B3190
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <Setup>d__11 : IAsyncStateMachine // TypeDefIndex: 14138
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_PlayerCard <>4__this; // 0x28
		public string inUUID; // 0x30
		private UniTask<UserInfo> <>u__1; // 0x38
		private TaskAwaiter<AvatarLookGetResponse> <>u__2; // 0x48

		// Methods
		private void MoveNext(); // 0x00000001800023E0-0x00000001800023F0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RefreshBlocked>d__16 : IAsyncStateMachine // TypeDefIndex: 14139
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_PlayerCard <>4__this; // 0x28
		private FeralButton <>7__wrap1; // 0x30
		private UniTask<bool> <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001800023A0-0x00000001800023B0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <BtnClicked_PrivateChat>d__20 : IAsyncStateMachine // TypeDefIndex: 14140
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_PlayerCard <>4__this; // 0x28
		private UniTask.Awaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x0000000180002340-0x0000000180002350
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Constructors
	public UI_Window_PlayerCard(); // 0x00000001803B50E0-0x00000001803B50F0

	// Methods
	public static void OpenWindow(string inUUID); // 0x00000001803F2360-0x00000001803F2420
	public static void QueueWindow(string inUUID); // 0x00000001803F2420-0x00000001803F24E0
	public static void CloseWindow(); // 0x00000001803F1C80-0x00000001803F1CD0
	[AsyncStateMachine] // 0x0000000180294B00-0x0000000180294B50
	private void Setup(string inUUID); // 0x00000001803F26B0-0x00000001803F2770
	protected override void OnOpen(); // 0x00000001803F1F70-0x00000001803F2200
	protected override void OnClose(bool inAnimate); // 0x00000001803F1CD0-0x00000001803F1F70
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
	private void RefreshFollowedAndFavorited(); // 0x00000001803F2590-0x00000001803F26B0
	[AsyncStateMachine] // 0x0000000180295010-0x0000000180295060
	private void RefreshBlocked(); // 0x00000001803F24E0-0x00000001803F2590
	public void ToggleBtnClicked_Favorite(bool inIsOn); // 0x00000001803F2770-0x00000001803F2800
	public void BtnClicked_ToggleFollow(); // 0x00000001803F1BA0-0x00000001803F1C60
	public void BtnClicked_ToggleBlock(); // 0x00000001803F1AE0-0x00000001803F1BA0
	[AsyncStateMachine] // 0x0000000180295210-0x0000000180295260
	public void BtnClicked_PrivateChat(); // 0x00000001803F19D0-0x00000001803F1A80
	public void BtnClicked_Sanctuary(); // 0x00000001803F1A90-0x00000001803F1AE0
	public void BtnClicked_Trade(); // 0x00000001803F1C60-0x00000001803F1C80
	public void BtnClicked_GoToPlayer(); // 0x00000001803F1950-0x00000001803F19D0
	public void BtnClicked_Report(); // 0x00000001803F1A80-0x00000001803F1A90
	private void OnUserFollowed(UserFollowedMessage inMessage); // 0x00000001803F2260-0x00000001803F22C0
	private void OnUserUnFollowed(UserUnfollowedMessage inMessage); // 0x00000001803F22C0-0x00000001803F2310
	private void OnUserFavorited(UserFavoritedMessage inMessage); // 0x00000001803F2260-0x00000001803F22C0
	private void OnUserUnfavorited(UserUnfavoritedMessage inMessage); // 0x00000001803F2260-0x00000001803F22C0
	private void OnUserBlocked(UserBlockedMessage inMessage); // 0x00000001803F2200-0x00000001803F2260
	private void OnUserUnblocked(UserUnblockedMessage inMessage); // 0x00000001803F2310-0x00000001803F2360
	private void CloseFromMessage(Message inMessage); // 0x00000001803B58D0-0x00000001803B58E0
}

