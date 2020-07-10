/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_FindPlayer : UI_Window // TypeDefIndex: 12467
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private TMP_InputField _searchInputField; // 0x108
	[Header] // 0x00000001800BD0B0-0x00000001800BD100
	[SerializeField] // 0x00000001800BD0B0-0x00000001800BD100
	private CanvasGroup _groupInitial; // 0x110
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CanvasGroup _groupPlayerFound; // 0x118
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CanvasGroup _groupPlayerNotFound; // 0x120
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _waitingGroup; // 0x128
	[Header] // 0x00000001800BD6C0-0x00000001800BD710
	[SerializeField] // 0x00000001800BD6C0-0x00000001800BD710
	private WWImage _blockedIconImage; // 0x130
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _privateChatBtn; // 0x138
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _privateChatUnreadIndicator; // 0x140
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _favoriteToggle; // 0x148
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _blockedToggle; // 0x150
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _followToggle; // 0x158
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _goToPlayerBtn; // 0x160
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _tradeBtn; // 0x168
	private UserInfo _userInfo; // 0x170
	private bool _isBlocked; // 0x178
	private bool _isFavorite; // 0x179
	private string _previousSearch; // 0x180

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12468
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_FindPlayer> <>9__0_0; // 0x08
		public static Action<UI_Window> <>9__1_0; // 0x10

		// Constructors
		static <>c(); // 0x0000000180ECF450-0x0000000180ECF4B0
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0_0(UI_Window_FindPlayer window); // 0x0000000180E9D080-0x0000000180E9D0A0
		internal void <QueueWindow>b__1_0(UI_Window inWindow); // 0x0000000180ECDAA0-0x0000000180ECDB20
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <OnSearchSubmit>d__21 : IAsyncStateMachine // TypeDefIndex: 12469
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
		private void MoveNext(); // 0x00000001801F0FF0-0x00000001801F1000
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass30_0 // TypeDefIndex: 12470
	{
		// Fields
		public string inUUID; // 0x10

		// Constructors
		public <>c__DisplayClass30_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <RefreshFollowStatus>b__0(RelationshipManager.Follow f); // 0x0000000180EB3C90-0x0000000180EB3CC0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RefreshOnlineStatus>d__33 : IAsyncStateMachine // TypeDefIndex: 12471
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_Window_FindPlayer <>4__this; // 0x28
		private TaskAwaiter<bool> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F1010-0x00000001801F1020
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	// Constructors
	public UI_Window_FindPlayer(); // 0x0000000180ED0CA0-0x0000000180ED0CF0

	// Methods
	public static void OpenWindow(); // 0x0000000180ED0300-0x0000000180ED0400
	public static void QueueWindow(); // 0x0000000180ED0400-0x0000000180ED0500
	public static void CloseWindow(); // 0x0000000180ECFA40-0x0000000180ECFA90
	private void Setup(); // 0x00000001803581E0-0x00000001803581F0
	[AsyncStateMachine] // 0x00000001800BF720-0x00000001800BF770
	public void OnSearchSubmit(string inSearch); // 0x0000000180ED00E0-0x0000000180ED01B0
	public void ToggleBtnClicked_Favorite(bool inIsOn); // 0x0000000180ED0A20-0x0000000180ED0AB0
	public void ToggleBtnClicked_Follow(bool inIsOn); // 0x0000000180ED0AB0-0x0000000180ED0B40
	public void ToggleBtnClicked_Block(bool inIsOn); // 0x0000000180ED0990-0x0000000180ED0A20
	public void BtnClicked_PrivateChat(); // 0x00000001803581E0-0x00000001803581F0
	public void BtnClicked_Sanctuary(); // 0x0000000180ECFA00-0x0000000180ECFA20
	public void BtnClicked_Trade(); // 0x0000000180ECFA20-0x0000000180ECFA40
	public void BtnClicked_GoToPlayer(); // 0x0000000180ECF990-0x0000000180ECFA00
	private void OnSearchResult(string inUUID); // 0x0000000180ECFE80-0x0000000180ED00E0
	private void RefreshFollowStatus(string inUUID); // 0x0000000180ED0610-0x0000000180ED0880
	private void RefreshPrivateChat(); // 0x0000000180ED0930-0x0000000180ED0990
	private void RefreshBlockedState(bool inInstant = false /* Metadata: 0x00782F12 */); // 0x0000000180ED0500-0x0000000180ED0610
	[AsyncStateMachine] // 0x00000001800BF990-0x00000001800BF9E0
	private void RefreshOnlineStatus(); // 0x0000000180ED0880-0x0000000180ED0930
	private void OnUserBlocked(UserBlockedMessage inMessage); // 0x0000000180ED01B0-0x0000000180ED0220
	private void OnUserUnblocked(UserUnblockedMessage inMessage); // 0x0000000180ED02A0-0x0000000180ED0300
	private void OnUserFollowed(UserFollowedMessage inMessage); // 0x0000000180ED0220-0x0000000180ED02A0
	private void OnOnlineStatusChanged(UserOnlineStatusMessage inMessage); // 0x0000000180ECFC20-0x0000000180ECFD00
	protected override void OnOpen(); // 0x0000000180ECFD00-0x0000000180ECFE80
	protected override void OnClose(bool inAnimate); // 0x0000000180ECFA90-0x0000000180ECFC20
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <OnSearchSubmit>b__21_0(); // 0x0000000180ED0B40-0x0000000180ED0B80
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <OnSearchSubmit>b__21_1(); // 0x0000000180ED0B80-0x0000000180ED0BC0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <OnSearchSubmit>b__21_2(); // 0x0000000180ED0BC0-0x0000000180ED0C00
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <OnSearchResult>b__29_0(); // 0x0000000180ED0B40-0x0000000180ED0B80
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <OnSearchResult>b__29_1(); // 0x0000000180ED0B80-0x0000000180ED0BC0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <RefreshBlockedState>b__32_0(); // 0x0000000180ED0C00-0x0000000180ED0C50
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <RefreshBlockedState>b__32_1(); // 0x0000000180ED0C50-0x0000000180ED0CA0
}

