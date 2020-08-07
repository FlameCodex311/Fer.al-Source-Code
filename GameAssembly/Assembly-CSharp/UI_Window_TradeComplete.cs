/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_TradeComplete : UI_Window // TypeDefIndex: 13808
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyItemList_ReadonlyItemList _itemList; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _gotItemsText; // 0x110
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _noItemsText; // 0x118
	private Trade _trade; // 0x120

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 13809
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<TradeCompletedMessage> <>9__0_0; // 0x08

		// Constructors
		static <>c(); // 0x00000001804483E0-0x0000000180448440
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <Init>b__0_0(TradeCompletedMessage inMessage); // 0x0000000180446460-0x0000000180446530
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 13810
	{
		// Fields
		public Trade inTrade; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0(UI_Window_TradeComplete window); // 0x0000000180447830-0x0000000180447860
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass2_0 // TypeDefIndex: 13811
	{
		// Fields
		public Trade inTrade; // 0x10

		// Constructors
		public <>c__DisplayClass2_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x0000000180447F60-0x0000000180448030
	}

	// Constructors
	public UI_Window_TradeComplete(); // 0x00000001803B50E0-0x00000001803B50F0

	// Methods
	[RuntimeInitializeOnLoadMethod] // 0x00000001801CF2D0-0x00000001801CF2E0
	private static void Init(); // 0x000000018044E280-0x000000018044E380
	public static void OpenWindow(Trade inTrade); // 0x000000018044E380-0x000000018044E440
	public static void QueueWindow(Trade inTrade); // 0x000000018044E440-0x000000018044E500
	public static void CloseWindow(); // 0x000000018044E230-0x000000018044E280
	private void Setup(Trade inTrade); // 0x000000018044E500-0x000000018044E710
	protected override void OnOpen(); // 0x00000001803B4570-0x00000001803B4580
	protected override void OnClose(bool inAnimate); // 0x00000001803B4560-0x00000001803B4570
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
}

