/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_ReceiveTradeRequest : UI_Window // TypeDefIndex: 13800
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _messageText; // 0x108

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 13801
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<TradeRequestReceivedMessage> <>9__0_0; // 0x08

		// Constructors
		static <>c(); // 0x00000001803B40A0-0x00000001803B4100
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <Init>b__0_0(TradeRequestReceivedMessage inMessage); // 0x00000001803B23D0-0x00000001803B24A0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 13802
	{
		// Fields
		public Trade inTrade; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0(UI_Window_ReceiveTradeRequest window); // 0x00000001803B3030-0x00000001803B3060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass2_0 // TypeDefIndex: 13803
	{
		// Fields
		public Trade inTrade; // 0x10

		// Constructors
		public <>c__DisplayClass2_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x00000001803B3DA0-0x00000001803B3E70
	}

	// Constructors
	public UI_Window_ReceiveTradeRequest(); // 0x00000001803B50E0-0x00000001803B50F0

	// Methods
	[RuntimeInitializeOnLoadMethod] // 0x00000001801CF2D0-0x00000001801CF2E0
	private static void Init(); // 0x00000001803B6A70-0x00000001803B6B70
	public static void OpenWindow(Trade inTrade); // 0x00000001803B6ED0-0x00000001803B6F90
	public static void QueueWindow(Trade inTrade); // 0x00000001803B6F90-0x00000001803B7050
	public static void CloseWindow(); // 0x00000001803B6A20-0x00000001803B6A70
	private void Setup(Trade inTrade); // 0x00000001803B7050-0x00000001803B7150
	protected override void OnOpen(); // 0x00000001803B6D20-0x00000001803B6ED0
	protected override void OnClose(bool inAnimate); // 0x00000001803B6B70-0x00000001803B6D20
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
	public void BtnClicked_Decline(); // 0x00000001803B69C0-0x00000001803B6A20
	public void BtnClicked_Accept(); // 0x00000001803B6960-0x00000001803B69C0
	private void OnTradeReqeustEnded(TradeRequestEndedMessage inMessage); // 0x00000001803B58D0-0x00000001803B58E0
	private void OnTradeStarted(TradeStartedMessage inMessage); // 0x00000001803B58D0-0x00000001803B58E0
	private void OnTradeRequestSent(TradeRequestSentMessage inMessage); // 0x00000001803B58D0-0x00000001803B58E0
}

