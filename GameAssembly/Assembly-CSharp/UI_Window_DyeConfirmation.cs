/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_DyeConfirmation : UI_Window // TypeDefIndex: 14047
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Transform _dyeCostItemParent; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_DyeCostItem _dyeCostItemPrefab; // 0x110
	private Action<bool> _onConfirmationResult; // 0x118

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 14048
	{
		// Fields
		[TupleElementNames] // 0x000000018026ABE0-0x000000018026AC60
		public List<ValueTuple<Item, int>> inDyeOperations; // 0x10
		public Action<bool> inOnConfirmationResult; // 0x18

		// Constructors
		public <>c__DisplayClass0_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0(UI_Window_DyeConfirmation window); // 0x000000018047E700-0x000000018047E730
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 14049
	{
		// Fields
		[TupleElementNames] // 0x000000018026B020-0x000000018026B0A0
		public List<ValueTuple<Item, int>> inDyeOperations; // 0x10
		public Action<bool> inOnConfirmationResult; // 0x18

		// Constructors
		public <>c__DisplayClass1_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x000000018047ED40-0x000000018047EE10
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 14050
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		[TupleElementNames] // 0x000000018026B5D0-0x000000018026B650
		public static Func<ValueTuple<Item, int>, Item> <>9__6_0; // 0x08

		// Constructors
		static <>c(); // 0x000000018047F470-0x000000018047F4D0
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal Item <Setup>b__6_0([TupleElementNames] /* 0x000000018026B9D0-0x000000018026BA50 */ ValueTuple<Item, int> operation); // 0x000000018047E6F0-0x000000018047E700
	}

	// Constructors
	public UI_Window_DyeConfirmation(); // 0x00000001803B50E0-0x00000001803B50F0

	// Methods
	public static void OpenWindow([TupleElementNames] /* 0x0000000180269D00-0x0000000180269D80 */ List<ValueTuple<Item, int>> inDyeOperations, Action<bool> inOnConfirmationResult); // 0x000000018048E900-0x000000018048E9D0
	public static void QueueWindow([TupleElementNames] /* 0x000000018026A2A0-0x000000018026A320 */ List<ValueTuple<Item, int>> inDyeOperations, Action<bool> inOnConfirmationResult); // 0x000000018048E9D0-0x000000018048EAA0
	public static void CloseWindow(); // 0x000000018048E8B0-0x000000018048E900
	public void Setup([TupleElementNames] /* 0x000000018026A610-0x000000018026A690 */ List<ValueTuple<Item, int>> inDyeOperations, Action<bool> inOnConfirmationResult); // 0x000000018048EAA0-0x000000018048EDA0
	public void BtnClicked_Yes(); // 0x000000018048E850-0x000000018048E8B0
	public void BtnClicked_No(); // 0x000000018048E7F0-0x000000018048E850
	protected override void OnOpen(); // 0x00000001803B4570-0x00000001803B4580
	protected override void OnClose(bool inAnimate); // 0x00000001803B4560-0x00000001803B4570
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
}

