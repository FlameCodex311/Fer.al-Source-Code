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

public class UI_Window_TradeLobby : UI_Window // TypeDefIndex: 13816
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _otherUserTitleText; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _otherUserReadyText; // 0x110
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _readyToggleMe; // 0x118
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _readyToggleThem; // 0x120
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _waitingGroup; // 0x128
	[Header] // 0x0000000180209C80-0x0000000180209CD0
	[SerializeField] // 0x0000000180209C80-0x0000000180209CD0
	private WWTextMeshProUGUI _chatNameTextMe; // 0x130
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _chatNameTextThem; // 0x138
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RawImage _playerIconMe; // 0x140
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RawImage _playerIconThem; // 0x148
	private Trade _trade; // 0x150

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 13817
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<TradeStartedMessage> <>9__0_0; // 0x08

		// Constructors
		static <>c(); // 0x0000000180448680-0x00000001804486E0
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <Init>b__0_0(TradeStartedMessage inMessage); // 0x00000001804462C0-0x0000000180446390
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 13818
	{
		// Fields
		public Trade inTrade; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0(UI_Window_TradeLobby window); // 0x0000000180447860-0x0000000180447890
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass2_0 // TypeDefIndex: 13819
	{
		// Fields
		public Trade inTrade; // 0x10

		// Constructors
		public <>c__DisplayClass2_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x0000000180447E90-0x0000000180447F60
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <Setup>d__14 : IAsyncStateMachine // TypeDefIndex: 13820
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public Trade inTrade; // 0x28
		public UI_Window_TradeLobby <>4__this; // 0x30
		private TaskAwaiter<AvatarLookGetResponse> <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x0000000180004720-0x0000000180004730
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Constructors
	public UI_Window_TradeLobby(); // 0x00000001803B50E0-0x00000001803B50F0

	// Methods
	[RuntimeInitializeOnLoadMethod] // 0x00000001801CF2D0-0x00000001801CF2E0
	private static void Init(); // 0x000000018044FF50-0x0000000180450050
	public static void OpenWindow(Trade inTrade); // 0x0000000180450860-0x0000000180450920
	public static void QueueWindow(Trade inTrade); // 0x0000000180450920-0x00000001804509E0
	public static void CloseWindow(); // 0x000000018044FF00-0x000000018044FF50
	[AsyncStateMachine] // 0x000000018020A470-0x000000018020A4C0
	private void Setup(Trade inTrade); // 0x00000001804509E0-0x0000000180450AA0
	protected override void OnOpen(); // 0x0000000180450420-0x00000001804506B0
	protected override void OnClose(bool inAnimate); // 0x0000000180450050-0x00000001804502E0
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
	public void BtnClicked_ExitTrade(); // 0x000000018044FE50-0x000000018044FEB0
	public void BtnToggled_Ready(bool InValue); // 0x000000018044FEB0-0x000000018044FF00
	private void OnTradeEnded(TradeEndedMessage inMessage); // 0x00000001803B58D0-0x00000001803B58E0
	private void OnUserReadyStateChanged(UserReadyStateChangedMessage inMessage); // 0x0000000180450770-0x0000000180450860
	private void OnTradeConfirmationInitiated(TradeConfirmationInitiatedMessage inMessage); // 0x00000001803E83B0-0x00000001803E83C0
	private void OnTradeConfirmationUpdated(TradeConfirmationUpdatedMessage inMessage); // 0x00000001804506B0-0x0000000180450770
	private void OnItemRemovedFromTrade(ItemRemovedFromTradeMessage inMessage); // 0x0000000180450380-0x0000000180450420
	private void OnItemAddedToTrade(ItemAddedToTradeMessage inMessage); // 0x00000001804502E0-0x0000000180450380
}

