/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_FindPlayer : UI_Window // TypeDefIndex: 14066
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private TMP_InputField _searchInputField; // 0x108
	[Header] // 0x0000000180276360-0x00000001802763B0
	[SerializeField] // 0x0000000180276360-0x00000001802763B0
	private CanvasGroup _groupInitial; // 0x110
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CanvasGroup _groupPlayerFound; // 0x118
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CanvasGroup _groupPlayerNotFound; // 0x120
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _waitingGroup; // 0x128
	[Header] // 0x0000000180276A70-0x0000000180276AC0
	[SerializeField] // 0x0000000180276A70-0x0000000180276AC0
	private WWImage _blockedIconImage; // 0x130
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _privateChatBtn; // 0x138
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _privateChatUnreadIndicator; // 0x140
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _favoriteToggle; // 0x148
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _blockedToggle; // 0x150
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _followToggle; // 0x158
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _goToPlayerBtn; // 0x160
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _tradeBtn; // 0x168
	private UserInfo _userInfo; // 0x170
	private bool _isBlocked; // 0x178
	private bool _isFavorite; // 0x179
	private string _previousSearch; // 0x180

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 14067
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_FindPlayer> <>9__0_0; // 0x08
		public static Action<UI_Window> <>9__1_0; // 0x10

		// Constructors
		static <>c(); // 0x00000001803E2730-0x00000001803E2790
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0_0(UI_Window_FindPlayer window); // 0x00000001803B24A0-0x00000001803B24C0
		internal void <QueueWindow>b__1_0(UI_Window inWindow); // 0x00000001803E0FF0-0x00000001803E1070
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <OnSearchSubmit>d__21 : IAsyncStateMachine // TypeDefIndex: 14068
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_FindPlayer <>4__this; // 0x28
		public string inSearch; // 0x30
		private float <time>5__2; // 0x38
		private string <result>5__3; // 0x40
		private TaskAwaiter<string> <>u__1; // 0x48
		private TaskAwaiter <>u__2; // 0x50

		// Methods
		private void MoveNext(); // 0x0000000180002690-0x00000001800026A0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass30_0 // TypeDefIndex: 14069
	{
		// Fields
		public string inUUID; // 0x10

		// Constructors
		public <>c__DisplayClass30_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <RefreshFollowStatus>b__0(RelationshipManager.Follow f); // 0x00000001803E2140-0x00000001803E2170
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RefreshOnlineStatus>d__33 : IAsyncStateMachine // TypeDefIndex: 14070
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_FindPlayer <>4__this; // 0x28
		private TaskAwaiter<bool> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001800026A0-0x00000001800026B0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Constructors
	public UI_Window_FindPlayer(); // 0x00000001803E3FC0-0x00000001803E4010

	// Methods
	public static void OpenWindow(); // 0x00000001803E3630-0x00000001803E3730
	public static void QueueWindow(); // 0x00000001803E3730-0x00000001803E3830
	public static void CloseWindow(); // 0x00000001803E2D80-0x00000001803E2DD0
	private void Setup(); // 0x00000001803774A0-0x00000001803774B0
	[AsyncStateMachine] // 0x0000000180277BA0-0x0000000180277BF0
	public void OnSearchSubmit(string inSearch); // 0x00000001803E3420-0x00000001803E34F0
	public void ToggleBtnClicked_Favorite(bool inIsOn); // 0x00000001803E3D40-0x00000001803E3DD0
	public void ToggleBtnClicked_Follow(bool inIsOn); // 0x00000001803E3DD0-0x00000001803E3E60
	public void ToggleBtnClicked_Block(bool inIsOn); // 0x00000001803E3CB0-0x00000001803E3D40
	public void BtnClicked_PrivateChat(); // 0x00000001803774A0-0x00000001803774B0
	public void BtnClicked_Sanctuary(); // 0x00000001803E2D40-0x00000001803E2D60
	public void BtnClicked_Trade(); // 0x00000001803E2D60-0x00000001803E2D80
	public void BtnClicked_GoToPlayer(); // 0x00000001803E2CD0-0x00000001803E2D40
	private void OnSearchResult(string inUUID); // 0x00000001803E31C0-0x00000001803E3420
	private void RefreshFollowStatus(string inUUID); // 0x00000001803E3940-0x00000001803E3BA0
	private void RefreshPrivateChat(); // 0x00000001803E3C50-0x00000001803E3CB0
	private void RefreshBlockedState(bool inInstant = false /* Metadata: 0x007BA62A */); // 0x00000001803E3830-0x00000001803E3940
	[AsyncStateMachine] // 0x0000000180277F10-0x0000000180277F60
	private void RefreshOnlineStatus(); // 0x00000001803E3BA0-0x00000001803E3C50
	private void OnUserBlocked(UserBlockedMessage inMessage); // 0x00000001803E34F0-0x00000001803E3560
	private void OnUserUnblocked(UserUnblockedMessage inMessage); // 0x00000001803E35D0-0x00000001803E3630
	private void OnUserFollowed(UserFollowedMessage inMessage); // 0x00000001803E3560-0x00000001803E35D0
	private void OnOnlineStatusChanged(UserOnlineStatusMessage inMessage); // 0x00000001803E2F60-0x00000001803E3040
	protected override void OnOpen(); // 0x00000001803E3040-0x00000001803E31C0
	protected override void OnClose(bool inAnimate); // 0x00000001803E2DD0-0x00000001803E2F60
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <OnSearchSubmit>b__21_0(); // 0x00000001803E3E60-0x00000001803E3EA0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <OnSearchSubmit>b__21_1(); // 0x00000001803E3EA0-0x00000001803E3EE0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <OnSearchSubmit>b__21_2(); // 0x00000001803E3EE0-0x00000001803E3F20
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <OnSearchResult>b__29_0(); // 0x00000001803E3E60-0x00000001803E3EA0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <OnSearchResult>b__29_1(); // 0x00000001803E3EA0-0x00000001803E3EE0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <RefreshBlockedState>b__32_0(); // 0x00000001803E3F20-0x00000001803E3F70
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <RefreshBlockedState>b__32_1(); // 0x00000001803E3F70-0x00000001803E3FC0
}

