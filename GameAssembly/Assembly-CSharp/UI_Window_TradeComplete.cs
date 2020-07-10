/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_TradeComplete : UI_Window // TypeDefIndex: 12258
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyItemList_ReadonlyItemList _itemList; // 0x108
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _gotItemsText; // 0x110
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _noItemsText; // 0x118
	private Trade _trade; // 0x120

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12259
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<TradeCompletedMessage> <>9__0_0; // 0x08

		// Constructors
		static <>c(); // 0x0000000180F7B370-0x0000000180F7B3D0
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <Init>b__0_0(TradeCompletedMessage inMessage); // 0x0000000180F79BB0-0x0000000180F79C80
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 12260
	{
		// Fields
		public Trade inTrade; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0(UI_Window_TradeComplete window); // 0x0000000180F7AC20-0x0000000180F7AC50
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass2_0 // TypeDefIndex: 12261
	{
		// Fields
		public Trade inTrade; // 0x10

		// Constructors
		public <>c__DisplayClass2_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x0000000180F7B0E0-0x0000000180F7B1B0
	}

	// Constructors
	public UI_Window_TradeComplete(); // 0x0000000180E9F830-0x0000000180E9F840

	// Methods
	[RuntimeInitializeOnLoadMethod] // 0x00000001800C1340-0x00000001800C1350
	private static void Init(); // 0x0000000180F823B0-0x0000000180F824B0
	public static void OpenWindow(Trade inTrade); // 0x0000000180F824B0-0x0000000180F82570
	public static void QueueWindow(Trade inTrade); // 0x0000000180F82570-0x0000000180F82630
	public static void CloseWindow(); // 0x0000000180F82360-0x0000000180F823B0
	private void Setup(Trade inTrade); // 0x0000000180F82630-0x0000000180F82850
	protected override void OnOpen(); // 0x0000000180E9F6A0-0x0000000180E9F6B0
	protected override void OnClose(bool inAnimate); // 0x0000000180E9F690-0x0000000180E9F6A0
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
}

