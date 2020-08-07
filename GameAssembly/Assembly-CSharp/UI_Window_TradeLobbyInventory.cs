/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_TradeLobbyInventory : UI_Window // TypeDefIndex: 14224
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyItemList_TradeLobbyInventory _itemList; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_TabGroup _tabGroup; // 0x110
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _categoryText; // 0x118

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 14225
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_TradeLobbyInventory> <>9__0_0; // 0x08
		public static Action<UI_Window> <>9__1_0; // 0x10

		// Constructors
		static <>c(); // 0x0000000180448560-0x00000001804485C0
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0_0(UI_Window_TradeLobbyInventory window); // 0x00000001803B24A0-0x00000001803B24C0
		internal void <QueueWindow>b__1_0(UI_Window inWindow); // 0x00000001804466A0-0x0000000180446720
	}

	// Constructors
	public UI_Window_TradeLobbyInventory(); // 0x00000001803B50E0-0x00000001803B50F0

	// Methods
	public static void OpenWindow(); // 0x000000018044FC50-0x000000018044FD50
	public static void QueueWindow(); // 0x000000018044FD50-0x000000018044FE50
	public static void CloseWindow(); // 0x000000018044F800-0x000000018044F850
	private void Setup(); // 0x00000001803774A0-0x00000001803774B0
	protected override void OnOpen(); // 0x000000018044FAD0-0x000000018044FC50
	protected override void OnClose(bool inAnimate); // 0x000000018044F9A0-0x000000018044FAD0
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
	private void OnCategorySelected(int inCategoryIndex); // 0x000000018044F850-0x000000018044F9A0
	private void OnTradeEnded(TradeEndedMessage inMessage); // 0x00000001803B58D0-0x00000001803B58E0
	private void OnTradeConfirmationInitiated(TradeConfirmationInitiatedMessage inMessage); // 0x00000001803B58D0-0x00000001803B58E0
}

