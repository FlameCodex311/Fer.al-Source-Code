/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_SimpleItemList : UI_Window // TypeDefIndex: 12610
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _headerText; // 0x108
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyItemList_ReadonlyItemList _itemList; // 0x110

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 12611
	{
		// Fields
		public string inHeaderText; // 0x10
		public List<Item> inItemList; // 0x18

		// Constructors
		public <>c__DisplayClass0_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0(UI_Window_SimpleItemList window); // 0x0000000180F7A270-0x0000000180F7A300
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 12612
	{
		// Fields
		public string inHeaderText; // 0x10
		public List<Item> inItemList; // 0x18

		// Constructors
		public <>c__DisplayClass1_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x0000000180F7AC80-0x0000000180F7ADA0
	}

	// Constructors
	public UI_Window_SimpleItemList(); // 0x0000000180E9F830-0x0000000180E9F840

	// Methods
	public static void OpenWindow(string inHeaderText, List<Item> inItemList); // 0x0000000180F80D90-0x0000000180F80E60
	public static void QueueWindow(string inHeaderText, List<Item> inItemList); // 0x0000000180F80E60-0x0000000180F80F30
	public static void CloseWindow(); // 0x0000000180F80D40-0x0000000180F80D90
	private void Setup(string inHeaderText, List<Item> inItemList); // 0x0000000180F80F30-0x0000000180F80FB0
	protected override void OnOpen(); // 0x0000000180E9F6A0-0x0000000180E9F6B0
	protected override void OnClose(bool inAnimate); // 0x0000000180E9F690-0x0000000180E9F6A0
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
}

