/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_DyeConfirmation : UI_Window // TypeDefIndex: 12448
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Transform _dyeCostItemParent; // 0x108
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_DyeCostItem _dyeCostItemPrefab; // 0x110
	private Action<bool> _onConfirmationResult; // 0x118

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 12449
	{
		// Fields
		[TupleElementNames] // 0x00000001801753F0-0x0000000180175470
		public List<ValueTuple<Item, int>> inDyeOperations; // 0x10
		public Action<bool> inOnConfirmationResult; // 0x18

		// Constructors
		public <>c__DisplayClass0_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0(UI_Window_DyeConfirmation window); // 0x0000000180EFEDC0-0x0000000180EFEDF0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 12450
	{
		// Fields
		[TupleElementNames] // 0x00000001800B3920-0x00000001800B39A0
		public List<ValueTuple<Item, int>> inDyeOperations; // 0x10
		public Action<bool> inOnConfirmationResult; // 0x18

		// Constructors
		public <>c__DisplayClass1_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x0000000180EFF2F0-0x0000000180EFF3C0
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12451
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		[TupleElementNames] // 0x00000001800B3F20-0x00000001800B3FA0
		public static Func<ValueTuple<Item, int>, Item> <>9__6_0; // 0x08

		// Constructors
		static <>c(); // 0x0000000180EFFD40-0x0000000180EFFDA0
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal Item <Setup>b__6_0([TupleElementNames] /* 0x00000001800B54E0-0x00000001800B5560 */ ValueTuple<Item, int> operation); // 0x0000000180EFEDB0-0x0000000180EFEDC0
	}

	// Constructors
	public UI_Window_DyeConfirmation(); // 0x0000000180E9F830-0x0000000180E9F840

	// Methods
	public static void OpenWindow([TupleElementNames] /* 0x00000001801744E0-0x0000000180174560 */ List<ValueTuple<Item, int>> inDyeOperations, Action<bool> inOnConfirmationResult); // 0x0000000180F10830-0x0000000180F10900
	public static void QueueWindow([TupleElementNames] /* 0x0000000180174980-0x0000000180174A00 */ List<ValueTuple<Item, int>> inDyeOperations, Action<bool> inOnConfirmationResult); // 0x0000000180F10900-0x0000000180F109D0
	public static void CloseWindow(); // 0x0000000180F107E0-0x0000000180F10830
	public void Setup([TupleElementNames] /* 0x0000000180174CC0-0x0000000180174D40 */ List<ValueTuple<Item, int>> inDyeOperations, Action<bool> inOnConfirmationResult); // 0x0000000180F109D0-0x0000000180F10CD0
	public void BtnClicked_Yes(); // 0x0000000180F10780-0x0000000180F107E0
	public void BtnClicked_No(); // 0x0000000180F10720-0x0000000180F10780
	protected override void OnOpen(); // 0x0000000180E9F6A0-0x0000000180E9F6B0
	protected override void OnClose(bool inAnimate); // 0x0000000180E9F690-0x0000000180E9F6A0
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
}

