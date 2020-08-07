/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_WaitingForTradeInviteResponse : UI_Window // TypeDefIndex: 13821
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _messageText; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralAudioInfo _tradeRejectedAudioInfo; // 0x110
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralAudioInfo _tradeAcceptedAudioInfo; // 0x118

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 13822
	{
		// Fields
		public Trade inTrade; // 0x10

		// Constructors
		public <>c__DisplayClass0_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0(UI_Window_WaitingForTradeInviteResponse window); // 0x0000000180446AE0-0x0000000180446B10
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 13823
	{
		// Fields
		public Trade inTrade; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x0000000180447C20-0x0000000180447CF0
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 13824
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<TradeRequestSentMessage> <>9__3_0; // 0x08

		// Constructors
		static <>c(); // 0x0000000180448440-0x00000001804484A0
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <Init>b__3_0(TradeRequestSentMessage inMessage); // 0x00000001804465B0-0x0000000180446680
	}

	// Constructors
	public UI_Window_WaitingForTradeInviteResponse(); // 0x00000001803B50E0-0x00000001803B50F0

	// Methods
	public static void OpenWindow(Trade inTrade); // 0x0000000180451F80-0x0000000180452040
	public static void QueueWindow(Trade inTrade); // 0x0000000180452040-0x0000000180452100
	public static void CloseWindow(); // 0x0000000180451B40-0x0000000180451B90
	[RuntimeInitializeOnLoadMethod] // 0x00000001801CF2D0-0x00000001801CF2E0
	private static void Init(); // 0x0000000180451B90-0x0000000180451C90
	private void Setup(Trade inTrade); // 0x0000000180452100-0x00000001804521C0
	protected override void OnOpen(); // 0x0000000180451DA0-0x0000000180451EB0
	protected override void OnClose(bool inAnimate); // 0x0000000180451C90-0x0000000180451DA0
	private void OnTradeStarted(TradeStartedMessage inMessage); // 0x0000000180451F30-0x0000000180451F80
	private void OnTradeRequestEnded(TradeRequestEndedMessage inMessage); // 0x0000000180451EB0-0x0000000180451F30
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
	public void BtnClicked_Cancel(); // 0x0000000180451AE0-0x0000000180451B40
}

