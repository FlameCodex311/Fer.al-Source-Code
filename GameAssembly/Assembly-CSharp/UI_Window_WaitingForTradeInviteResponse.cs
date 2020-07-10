/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_WaitingForTradeInviteResponse : UI_Window // TypeDefIndex: 12271
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _messageText; // 0x108
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralAudioInfo _tradeRejectedAudioInfo; // 0x110

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 12272
	{
		// Fields
		public Trade inTrade; // 0x10

		// Constructors
		public <>c__DisplayClass0_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0(UI_Window_WaitingForTradeInviteResponse window); // 0x0000000180F7A240-0x0000000180F7A270
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 12273
	{
		// Fields
		public Trade inTrade; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x0000000180F7AF40-0x0000000180F7B010
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12274
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<TradeRequestSentMessage> <>9__3_0; // 0x08

		// Constructors
		static <>c(); // 0x0000000180F7B3D0-0x0000000180F7B430
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <Init>b__3_0(TradeRequestSentMessage inMessage); // 0x0000000180F79D00-0x0000000180F79DD0
	}

	// Constructors
	public UI_Window_WaitingForTradeInviteResponse(); // 0x0000000180E9F830-0x0000000180E9F840

	// Methods
	public static void OpenWindow(Trade inTrade); // 0x0000000180F860F0-0x0000000180F861B0
	public static void QueueWindow(Trade inTrade); // 0x0000000180F861B0-0x0000000180F86270
	public static void CloseWindow(); // 0x0000000180F85D00-0x0000000180F85D50
	[RuntimeInitializeOnLoadMethod] // 0x00000001800C1340-0x00000001800C1350
	private static void Init(); // 0x0000000180F85D50-0x0000000180F85E50
	private void Setup(Trade inTrade); // 0x0000000180F86270-0x0000000180F86330
	protected override void OnOpen(); // 0x0000000180F85F60-0x0000000180F86070
	protected override void OnClose(bool inAnimate); // 0x0000000180F85E50-0x0000000180F85F60
	private void OnTradeStarted(TradeStartedMessage inMessage); // 0x0000000180EA0020-0x0000000180EA0030
	private void OnTradeRequestEnded(TradeRequestEndedMessage inMessage); // 0x0000000180F86070-0x0000000180F860F0
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
	public void BtnClicked_Cancel(); // 0x0000000180F85CA0-0x0000000180F85D00
}

