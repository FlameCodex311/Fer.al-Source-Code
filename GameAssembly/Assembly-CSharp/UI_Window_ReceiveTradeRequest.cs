/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_ReceiveTradeRequest : UI_Window // TypeDefIndex: 12250
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _messageText; // 0x108

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12251
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<TradeRequestReceivedMessage> <>9__0_0; // 0x08

		// Constructors
		static <>c(); // 0x0000000180E9F1B0-0x0000000180E9F210
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <Init>b__0_0(TradeRequestReceivedMessage inMessage); // 0x0000000180E9CFB0-0x0000000180E9D080
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 12252
	{
		// Fields
		public Trade inTrade; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0(UI_Window_ReceiveTradeRequest window); // 0x0000000180E9DFD0-0x0000000180E9E000
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass2_0 // TypeDefIndex: 12253
	{
		// Fields
		public Trade inTrade; // 0x10

		// Constructors
		public <>c__DisplayClass2_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x0000000180E9EEB0-0x0000000180E9EF80
	}

	// Constructors
	public UI_Window_ReceiveTradeRequest(); // 0x0000000180E9F830-0x0000000180E9F840

	// Methods
	[RuntimeInitializeOnLoadMethod] // 0x00000001800C1340-0x00000001800C1350
	private static void Init(); // 0x0000000180EA11B0-0x0000000180EA12B0
	public static void OpenWindow(Trade inTrade); // 0x0000000180EA1610-0x0000000180EA16D0
	public static void QueueWindow(Trade inTrade); // 0x0000000180EA16D0-0x0000000180EA1790
	public static void CloseWindow(); // 0x0000000180EA1160-0x0000000180EA11B0
	private void Setup(Trade inTrade); // 0x0000000180EA1790-0x0000000180EA18A0
	protected override void OnOpen(); // 0x0000000180EA1460-0x0000000180EA1610
	protected override void OnClose(bool inAnimate); // 0x0000000180EA12B0-0x0000000180EA1460
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
	public void BtnClicked_Decline(); // 0x0000000180EA1100-0x0000000180EA1160
	public void BtnClicked_Accept(); // 0x0000000180EA10A0-0x0000000180EA1100
	private void OnTradeReqeustEnded(TradeRequestEndedMessage inMessage); // 0x0000000180EA0020-0x0000000180EA0030
	private void OnTradeStarted(TradeStartedMessage inMessage); // 0x0000000180EA0020-0x0000000180EA0030
	private void OnTradeRequestSent(TradeRequestSentMessage inMessage); // 0x0000000180EA0020-0x0000000180EA0030
}

