/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_Social : UI_Window // TypeDefIndex: 14215
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyItemList_Follower _followerList; // 0x108

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 14216
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_Social> <>9__0_0; // 0x08
		public static Action<UI_Window> <>9__1_0; // 0x10

		// Constructors
		static <>c(); // 0x0000000180448500-0x0000000180448560
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0_0(UI_Window_Social window); // 0x00000001803B24A0-0x00000001803B24C0
		internal void <QueueWindow>b__1_0(UI_Window inWindow); // 0x0000000180446720-0x00000001804467A0
	}

	// Constructors
	public UI_Window_Social(); // 0x00000001803B50E0-0x00000001803B50F0

	// Methods
	public static void OpenWindow(); // 0x000000018044D020-0x000000018044D120
	public static void QueueWindow(); // 0x000000018044D120-0x000000018044D220
	public static void CloseWindow(); // 0x000000018044CEA0-0x000000018044CEF0
	private void Setup(); // 0x00000001803774A0-0x00000001803774B0
	protected override void OnOpen(); // 0x000000018044CFA0-0x000000018044D020
	protected override void DoDelayedOpenAnimation(); // 0x000000018044CEF0-0x000000018044CF00
	protected override void OnClose(bool inAnimate); // 0x000000018044CF00-0x000000018044CFA0
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
}

