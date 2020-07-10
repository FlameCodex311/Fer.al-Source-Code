/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_TradeConfirmation : UI_Window // TypeDefIndex: 12262
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyItemList_ReadonlyItemList _itemListMine; // 0x108
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyItemList_ReadonlyItemList _itemListTheirs; // 0x110
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _groupInitial; // 0x118
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _groupWaiting; // 0x120
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _waitingText; // 0x128
	private Trade _trade; // 0x130

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12263
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<TradeConfirmationInitiatedMessage> <>9__0_0; // 0x08

		// Constructors
		static <>c(); // 0x0000000180F7B430-0x0000000180F7B490
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <Init>b__0_0(TradeConfirmationInitiatedMessage inMessage); // 0x0000000180F79AE0-0x0000000180F79BB0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 12264
	{
		// Fields
		public Trade inTrade; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0(UI_Window_TradeConfirmation window); // 0x0000000180F7ABF0-0x0000000180F7AC20
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass2_0 // TypeDefIndex: 12265
	{
		// Fields
		public Trade inTrade; // 0x10

		// Constructors
		public <>c__DisplayClass2_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x0000000180F7B1B0-0x0000000180F7B280
	}

	// Constructors
	public UI_Window_TradeConfirmation(); // 0x0000000180E9F830-0x0000000180E9F840

	// Methods
	[RuntimeInitializeOnLoadMethod] // 0x00000001800C1340-0x00000001800C1350
	private static void Init(); // 0x0000000180F82940-0x0000000180F82A40
	public static void OpenWindow(Trade inTrade); // 0x0000000180F82DF0-0x0000000180F82EB0
	public static void QueueWindow(Trade inTrade); // 0x0000000180F82EB0-0x0000000180F82F70
	public static void CloseWindow(); // 0x0000000180F828F0-0x0000000180F82940
	private void Setup(Trade inTrade); // 0x0000000180F82F70-0x0000000180F83190
	protected override void OnOpen(); // 0x0000000180F82B60-0x0000000180F82C80
	protected override void OnClose(bool inAnimate); // 0x0000000180F82A40-0x0000000180F82B60
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
	public void BtnClicked_RejectTrade(); // 0x0000000180F828A0-0x0000000180F828F0
	public void BtnClicked_AcceptTrade(); // 0x0000000180F82850-0x0000000180F828A0
	private void OnTradeConfirmationUpdated(TradeConfirmationUpdatedMessage inMessage); // 0x0000000180F82C80-0x0000000180F82DB0
	private void OnTradeEnded(TradeEndedMessage inMessage); // 0x0000000180F82DB0-0x0000000180F82DF0
	private void OnTradeRequestEnded(TradeRequestEndedMessage inMessage); // 0x0000000180F82DB0-0x0000000180F82DF0
}

