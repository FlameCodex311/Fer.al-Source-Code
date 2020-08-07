/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_HUDTutorialOverlay : UI_Window // TypeDefIndex: 14081
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _chatTutorialItem; // 0x108

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 14082
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_HUDTutorialOverlay> <>9__0_0; // 0x08
		public static Action<UI_Window> <>9__1_0; // 0x10

		// Constructors
		static <>c(); // 0x00000001803E26D0-0x00000001803E2730
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0_0(UI_Window_HUDTutorialOverlay window); // 0x00000001803B24A0-0x00000001803B24C0
		internal void <QueueWindow>b__1_0(UI_Window inWindow); // 0x00000001803E14D0-0x00000001803E1550
	}

	// Constructors
	public UI_Window_HUDTutorialOverlay(); // 0x00000001803B50E0-0x00000001803B50F0

	// Methods
	public static void OpenWindow(); // 0x00000001803E5480-0x00000001803E5580
	public static void QueueWindow(); // 0x00000001803E5580-0x00000001803E5680
	public static void CloseWindow(); // 0x00000001803E51C0-0x00000001803E5210
	private void Setup(); // 0x00000001803774A0-0x00000001803774B0
	protected override void OnOpen(); // 0x00000001803E52F0-0x00000001803E5480
	protected override void OnClose(bool inAnimate); // 0x00000001803E5210-0x00000001803E52F0
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
}

