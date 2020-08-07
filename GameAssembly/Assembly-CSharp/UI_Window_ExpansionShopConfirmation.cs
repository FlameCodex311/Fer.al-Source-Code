/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_ExpansionShopConfirmation : UI_Window // TypeDefIndex: 14059
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _itemRemovalWarning; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Transform _costItemParent; // 0x110
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_SanctuaryExpansionCostItem _costItemPrefab; // 0x118
	private Action<bool> _onConfirmationResult; // 0x120

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 14060
	{
		// Fields
		[TupleElementNames] // 0x0000000180273D10-0x0000000180273D90
		public List<ValueTuple<BaseDef, int>> inCost; // 0x10
		public Action<bool> inOnConfirmationResult; // 0x18

		// Constructors
		public <>c__DisplayClass0_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0(UI_Window_ExpansionShopConfirmation window); // 0x000000018047E820-0x000000018047E850
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 14061
	{
		// Fields
		[TupleElementNames] // 0x00000001802742D0-0x0000000180274350
		public List<ValueTuple<BaseDef, int>> inCost; // 0x10
		public Action<bool> inOnConfirmationResult; // 0x18

		// Constructors
		public <>c__DisplayClass1_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x000000018047EBB0-0x000000018047EC80
	}

	// Constructors
	public UI_Window_ExpansionShopConfirmation(); // 0x00000001803B50E0-0x00000001803B50F0

	// Methods
	public static void OpenWindow([TupleElementNames] /* 0x0000000180271B00-0x0000000180271B80 */ List<ValueTuple<BaseDef, int>> inCost, Action<bool> inOnConfirmationResult); // 0x0000000180490A40-0x0000000180490B10
	public static void QueueWindow([TupleElementNames] /* 0x0000000180272020-0x00000001802720A0 */ List<ValueTuple<BaseDef, int>> inCost, Action<bool> inOnConfirmationResult); // 0x0000000180490B10-0x0000000180490BE0
	public static void CloseWindow(); // 0x00000001804909F0-0x0000000180490A40
	public void Setup([TupleElementNames] /* 0x0000000180272580-0x0000000180272600 */ List<ValueTuple<BaseDef, int>> inCost, Action<bool> inOnConfirmationResult); // 0x0000000180490BE0-0x0000000180490EB0
	public void BtnClicked_Yes(); // 0x0000000180490990-0x00000001804909F0
	public void BtnClicked_No(); // 0x0000000180490930-0x0000000180490990
}

