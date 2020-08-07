/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_SimpleItemList : UI_Window // TypeDefIndex: 14212
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _headerText; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyItemList_ReadonlyItemList _itemList; // 0x110

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 14213
	{
		// Fields
		public string inHeaderText; // 0x10
		public List<Item> inItemList; // 0x18

		// Constructors
		public <>c__DisplayClass0_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0(UI_Window_SimpleItemList window); // 0x0000000180446B10-0x0000000180446BA0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 14214
	{
		// Fields
		public string inHeaderText; // 0x10
		public List<Item> inItemList; // 0x18

		// Constructors
		public <>c__DisplayClass1_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x0000000180447890-0x00000001804479B0
	}

	// Constructors
	public UI_Window_SimpleItemList(); // 0x00000001803B50E0-0x00000001803B50F0

	// Methods
	public static void OpenWindow(string inHeaderText, List<Item> inItemList); // 0x000000018044CC80-0x000000018044CD50
	public static void QueueWindow(string inHeaderText, List<Item> inItemList); // 0x000000018044CD50-0x000000018044CE20
	public static void CloseWindow(); // 0x000000018044CC30-0x000000018044CC80
	private void Setup(string inHeaderText, List<Item> inItemList); // 0x000000018044CE20-0x000000018044CEA0
	protected override void OnOpen(); // 0x00000001803B4570-0x00000001803B4580
	protected override void OnClose(bool inAnimate); // 0x00000001803B4560-0x00000001803B4570
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
}

