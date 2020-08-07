/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_ActorClassPicker : UI_Window // TypeDefIndex: 13977
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyItemList_ActorClassPicker _itemList; // 0x108
	private Action<ActorClassDefComponent> _onItemChosenCallback; // 0x110

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 13978
	{
		// Fields
		public Action<ActorClassDefComponent> inOnItemChosenCallback; // 0x10

		// Constructors
		public <>c__DisplayClass0_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0(UI_Window_ActorClassPicker window); // 0x000000018047E730-0x000000018047E750
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 13979
	{
		// Fields
		public Action<ActorClassDefComponent> inOnItemChosenCallback; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x0000000180634FA0-0x0000000180635060
	}

	// Constructors
	public UI_Window_ActorClassPicker(); // 0x00000001803B50E0-0x00000001803B50F0

	// Methods
	public static void OpenWindow(Action<ActorClassDefComponent> inOnItemChosenCallback); // 0x000000018063FCC0-0x000000018063FD80
	public static void QueueWindow(Action<ActorClassDefComponent> inOnItemChosenCallback); // 0x000000018063FD80-0x000000018063FE40
	public static void CloseWindow(); // 0x000000018063F970-0x000000018063F9C0
	private void Setup(Action<ActorClassDefComponent> inOnItemChosenCallback); // 0x00000001804846D0-0x00000001804846E0
	protected override void OnOpen(); // 0x000000018063FB90-0x000000018063FCC0
	protected override void OnClose(bool inAnimate); // 0x000000018063F9C0-0x000000018063FAF0
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
	private void OnItemChosen(ActorClassDefComponent inItem); // 0x000000018063FAF0-0x000000018063FB90
}

