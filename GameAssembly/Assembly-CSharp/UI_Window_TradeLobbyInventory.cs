/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_TradeLobbyInventory : UI_Window // TypeDefIndex: 12622
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyItemList_TradeLobbyInventory _itemList; // 0x108
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_TabGroup _tabGroup; // 0x110
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _categoryText; // 0x118

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12623
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_TradeLobbyInventory> <>9__0_0; // 0x08
		public static Action<UI_Window> <>9__1_0; // 0x10

		// Constructors
		static <>c(); // 0x0000000180F7B4F0-0x0000000180F7B550
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0_0(UI_Window_TradeLobbyInventory window); // 0x0000000180E9D080-0x0000000180E9D0A0
		internal void <QueueWindow>b__1_0(UI_Window inWindow); // 0x0000000180F79E00-0x0000000180F79E80
	}

	// Constructors
	public UI_Window_TradeLobbyInventory(); // 0x0000000180E9F830-0x0000000180E9F840

	// Methods
	public static void OpenWindow(); // 0x0000000180F83DC0-0x0000000180F83EC0
	public static void QueueWindow(); // 0x0000000180F83EC0-0x0000000180F83FC0
	public static void CloseWindow(); // 0x0000000180F83960-0x0000000180F839B0
	private void Setup(); // 0x00000001803581E0-0x00000001803581F0
	protected override void OnOpen(); // 0x0000000180F83C30-0x0000000180F83DC0
	protected override void OnClose(bool inAnimate); // 0x0000000180F83B00-0x0000000180F83C30
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
	private void OnCategorySelected(int inCategoryIndex); // 0x0000000180F839B0-0x0000000180F83B00
	private void OnTradeEnded(TradeEndedMessage inMessage); // 0x0000000180EA0020-0x0000000180EA0030
	private void OnTradeConfirmationInitiated(TradeConfirmationInitiatedMessage inMessage); // 0x0000000180EA0020-0x0000000180EA0030
}

