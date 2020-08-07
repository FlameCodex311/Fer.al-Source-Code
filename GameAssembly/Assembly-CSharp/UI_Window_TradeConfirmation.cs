/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_TradeConfirmation : UI_Window // TypeDefIndex: 13812
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyItemList_ReadonlyItemList _itemListMine; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyItemList_ReadonlyItemList _itemListTheirs; // 0x110
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _groupInitial; // 0x118
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _groupWaiting; // 0x120
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _waitingText; // 0x128
	private Trade _trade; // 0x130

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 13813
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<TradeConfirmationInitiatedMessage> <>9__0_0; // 0x08

		// Constructors
		static <>c(); // 0x00000001804484A0-0x0000000180448500
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <Init>b__0_0(TradeConfirmationInitiatedMessage inMessage); // 0x0000000180446390-0x0000000180446460
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 13814
	{
		// Fields
		public Trade inTrade; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0(UI_Window_TradeConfirmation window); // 0x0000000180447800-0x0000000180447830
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass2_0 // TypeDefIndex: 13815
	{
		// Fields
		public Trade inTrade; // 0x10

		// Constructors
		public <>c__DisplayClass2_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x0000000180448100-0x00000001804481D0
	}

	// Constructors
	public UI_Window_TradeConfirmation(); // 0x00000001803B50E0-0x00000001803B50F0

	// Methods
	[RuntimeInitializeOnLoadMethod] // 0x00000001801CF2D0-0x00000001801CF2E0
	private static void Init(); // 0x000000018044E800-0x000000018044E900
	public static void OpenWindow(Trade inTrade); // 0x000000018044ECB0-0x000000018044ED70
	public static void QueueWindow(Trade inTrade); // 0x000000018044ED70-0x000000018044EE30
	public static void CloseWindow(); // 0x000000018044E7B0-0x000000018044E800
	private void Setup(Trade inTrade); // 0x000000018044EE30-0x000000018044F040
	protected override void OnOpen(); // 0x000000018044EA20-0x000000018044EB40
	protected override void OnClose(bool inAnimate); // 0x000000018044E900-0x000000018044EA20
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
	public void BtnClicked_RejectTrade(); // 0x000000018044E760-0x000000018044E7B0
	public void BtnClicked_AcceptTrade(); // 0x000000018044E710-0x000000018044E760
	private void OnTradeConfirmationUpdated(TradeConfirmationUpdatedMessage inMessage); // 0x000000018044EB40-0x000000018044EC70
	private void OnTradeEnded(TradeEndedMessage inMessage); // 0x000000018044EC70-0x000000018044ECB0
	private void OnTradeRequestEnded(TradeRequestEndedMessage inMessage); // 0x000000018044EC70-0x000000018044ECB0
}

