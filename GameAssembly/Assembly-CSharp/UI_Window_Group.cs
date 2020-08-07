/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_Group : UI_Window // TypeDefIndex: 14076
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CanvasGroup _canvasGroup; // 0x108

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 14077
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_Group> <>9__0_0; // 0x08
		public static Action<UI_Window> <>9__1_0; // 0x10

		// Constructors
		static <>c(); // 0x00000001803E2790-0x00000001803E27F0
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0_0(UI_Window_Group window); // 0x00000001803B24A0-0x00000001803B24C0
		internal void <QueueWindow>b__1_0(UI_Window inWindow); // 0x00000001803E13D0-0x00000001803E1450
	}

	// Constructors
	public UI_Window_Group(); // 0x00000001803B50E0-0x00000001803B50F0

	// Methods
	public static void OpenWindow(bool inAnimate = true /* Metadata: 0x007BA62B */); // 0x00000001803E4FB0-0x00000001803E50C0
	public static void QueueWindow(); // 0x00000001803E50C0-0x00000001803E51C0
	public static void CloseWindow(); // 0x00000001803E4DA0-0x00000001803E4DF0
	private void Setup(); // 0x00000001803774A0-0x00000001803774B0
	protected override void OnOpen(bool inAnimate); // 0x00000001803E4EB0-0x00000001803E4FB0
	protected override void OnClose(bool inAnimate); // 0x00000001803E4DF0-0x00000001803E4EB0
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
	public void BtnClicked_Quests(); // 0x00000001803E4D00-0x00000001803E4DA0
	public void BtnClicked_Notifications(); // 0x00000001803E4B90-0x00000001803E4D00
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <BtnClicked_Quests>b__8_0(); // 0x00000001803B5F40-0x00000001803B5F50
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <BtnClicked_Notifications>b__9_0(); // 0x00000001803B5F40-0x00000001803B5F50
}

