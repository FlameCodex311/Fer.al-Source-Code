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

public class UI_Window_TradeLobby : UI_Window // TypeDefIndex: 12266
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _otherUserTitleText; // 0x108
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _otherUserReadyText; // 0x110
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _readyToggleMe; // 0x118
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _readyToggleThem; // 0x120
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _waitingGroup; // 0x128
	[Header] // 0x0000000180122120-0x0000000180122170
	[SerializeField] // 0x0000000180122120-0x0000000180122170
	private WWTextMeshProUGUI _chatNameTextMe; // 0x130
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _chatNameTextThem; // 0x138
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private RawImage _playerIconMe; // 0x140
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private RawImage _playerIconThem; // 0x148
	private Trade _trade; // 0x150

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12267
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<TradeStartedMessage> <>9__0_0; // 0x08

		// Constructors
		static <>c(); // 0x0000000180F7B610-0x0000000180F7B670
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <Init>b__0_0(TradeStartedMessage inMessage); // 0x0000000180F79A10-0x0000000180F79AE0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 12268
	{
		// Fields
		public Trade inTrade; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0(UI_Window_TradeLobby window); // 0x0000000180F7AC50-0x0000000180F7AC80
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass2_0 // TypeDefIndex: 12269
	{
		// Fields
		public Trade inTrade; // 0x10

		// Constructors
		public <>c__DisplayClass2_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x0000000180F7B010-0x0000000180F7B0E0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <Setup>d__14 : IAsyncStateMachine // TypeDefIndex: 12270
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public Trade inTrade; // 0x28
		public UI_Window_TradeLobby <>4__this; // 0x30
		private TaskAwaiter<AvatarLookGetResponse> <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F17E0-0x00000001801F17F0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	// Constructors
	public UI_Window_TradeLobby(); // 0x0000000180E9F830-0x0000000180E9F840

	// Methods
	[RuntimeInitializeOnLoadMethod] // 0x00000001800C1340-0x00000001800C1350
	private static void Init(); // 0x0000000180F840C0-0x0000000180F841C0
	public static void OpenWindow(Trade inTrade); // 0x0000000180F849D0-0x0000000180F84A90
	public static void QueueWindow(Trade inTrade); // 0x0000000180F84A90-0x0000000180F84B50
	public static void CloseWindow(); // 0x0000000180F84070-0x0000000180F840C0
	[AsyncStateMachine] // 0x0000000180122920-0x0000000180122970
	private void Setup(Trade inTrade); // 0x0000000180F84B50-0x0000000180F84C10
	protected override void OnOpen(); // 0x0000000180F84590-0x0000000180F84820
	protected override void OnClose(bool inAnimate); // 0x0000000180F841C0-0x0000000180F84450
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
	public void BtnClicked_ExitTrade(); // 0x0000000180F83FC0-0x0000000180F84020
	public void BtnToggled_Ready(bool InValue); // 0x0000000180F84020-0x0000000180F84070
	private void OnTradeEnded(TradeEndedMessage inMessage); // 0x0000000180EA0020-0x0000000180EA0030
	private void OnUserReadyStateChanged(UserReadyStateChangedMessage inMessage); // 0x0000000180F848E0-0x0000000180F849D0
	private void OnTradeConfirmationInitiated(TradeConfirmationInitiatedMessage inMessage); // 0x0000000180ED5170-0x0000000180ED5180
	private void OnTradeConfirmationUpdated(TradeConfirmationUpdatedMessage inMessage); // 0x0000000180F84820-0x0000000180F848E0
	private void OnItemRemovedFromTrade(ItemRemovedFromTradeMessage inMessage); // 0x0000000180F844F0-0x0000000180F84590
	private void OnItemAddedToTrade(ItemAddedToTradeMessage inMessage); // 0x0000000180F84450-0x0000000180F844F0
}

