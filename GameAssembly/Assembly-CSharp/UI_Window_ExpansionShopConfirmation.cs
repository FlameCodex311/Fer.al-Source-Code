/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_ExpansionShopConfirmation : UI_Window // TypeDefIndex: 12460
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _itemRemovalWarning; // 0x108
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Transform _costItemParent; // 0x110
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_SanctuaryExpansionCostItem _costItemPrefab; // 0x118
	private Action<bool> _onConfirmationResult; // 0x120

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 12461
	{
		// Fields
		[TupleElementNames] // 0x00000001800BAF80-0x00000001800BB000
		public List<ValueTuple<BaseDef, int>> inCost; // 0x10
		public Action<bool> inOnConfirmationResult; // 0x18

		// Constructors
		public <>c__DisplayClass0_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0(UI_Window_ExpansionShopConfirmation window); // 0x0000000180EFEF20-0x0000000180EFEF50
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 12462
	{
		// Fields
		[TupleElementNames] // 0x00000001800BB420-0x00000001800BB4A0
		public List<ValueTuple<BaseDef, int>> inCost; // 0x10
		public Action<bool> inOnConfirmationResult; // 0x18

		// Constructors
		public <>c__DisplayClass1_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x0000000180EFF220-0x0000000180EFF2F0
	}

	// Constructors
	public UI_Window_ExpansionShopConfirmation(); // 0x0000000180E9F830-0x0000000180E9F840

	// Methods
	public static void OpenWindow([TupleElementNames] /* 0x00000001800BA3D0-0x00000001800BA450 */ List<ValueTuple<BaseDef, int>> inCost, Action<bool> inOnConfirmationResult); // 0x0000000180F129C0-0x0000000180F12A90
	public static void QueueWindow([TupleElementNames] /* 0x00000001800BA650-0x00000001800BA6D0 */ List<ValueTuple<BaseDef, int>> inCost, Action<bool> inOnConfirmationResult); // 0x0000000180F12A90-0x0000000180F12B60
	public static void CloseWindow(); // 0x0000000180F12970-0x0000000180F129C0
	public void Setup([TupleElementNames] /* 0x00000001800BAAA0-0x00000001800BAB20 */ List<ValueTuple<BaseDef, int>> inCost, Action<bool> inOnConfirmationResult); // 0x0000000180F12B60-0x0000000180F12E40
	public void BtnClicked_Yes(); // 0x0000000180F12910-0x0000000180F12970
	public void BtnClicked_No(); // 0x0000000180F128B0-0x0000000180F12910
}

