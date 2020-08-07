/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_ClothingPicker : UI_Window // TypeDefIndex: 14019
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyItemList_ClothingPicker _itemList; // 0x108
	private Action<ActorClothingDefComponent> _onItemChosenCallback; // 0x110

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 14020
	{
		// Fields
		public Action<ActorClothingDefComponent> inOnItemChosenCallback; // 0x10

		// Constructors
		public <>c__DisplayClass0_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0(UI_Window_ClothingPicker window); // 0x000000018047E730-0x000000018047E750
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 14021
	{
		// Fields
		public Action<ActorClothingDefComponent> inOnItemChosenCallback; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x000000018047EC80-0x000000018047ED40
	}

	// Constructors
	public UI_Window_ClothingPicker(); // 0x00000001803B50E0-0x00000001803B50F0

	// Methods
	public static void OpenWindow(Action<ActorClothingDefComponent> inOnItemChosenCallback); // 0x0000000180484550-0x0000000180484610
	public static void QueueWindow(Action<ActorClothingDefComponent> inOnItemChosenCallback); // 0x0000000180484610-0x00000001804846D0
	public static void CloseWindow(); // 0x0000000180484200-0x0000000180484250
	private void Setup(Action<ActorClothingDefComponent> inOnItemChosenCallback); // 0x00000001804846D0-0x00000001804846E0
	protected override void OnOpen(); // 0x0000000180484420-0x0000000180484550
	protected override void OnClose(bool inAnimate); // 0x0000000180484250-0x0000000180484380
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
	private void OnItemChosen(ActorClothingDefComponent inItem); // 0x0000000180484380-0x0000000180484420
}

