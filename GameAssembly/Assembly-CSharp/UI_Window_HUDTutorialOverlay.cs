/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_HUDTutorialOverlay : UI_Window // TypeDefIndex: 12486
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _chatTutorialItem; // 0x108

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12487
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_HUDTutorialOverlay> <>9__0_0; // 0x08
		public static Action<UI_Window> <>9__1_0; // 0x10

		// Constructors
		static <>c(); // 0x0000000180ECF3F0-0x0000000180ECF450
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0_0(UI_Window_HUDTutorialOverlay window); // 0x0000000180E9D080-0x0000000180E9D0A0
		internal void <QueueWindow>b__1_0(UI_Window inWindow); // 0x0000000180ECDED0-0x0000000180ECDF50
	}

	// Constructors
	public UI_Window_HUDTutorialOverlay(); // 0x0000000180E9F830-0x0000000180E9F840

	// Methods
	public static void OpenWindow(); // 0x0000000180ED2190-0x0000000180ED2290
	public static void QueueWindow(); // 0x0000000180ED2290-0x0000000180ED2390
	public static void CloseWindow(); // 0x0000000180ED1EC0-0x0000000180ED1F10
	private void Setup(); // 0x00000001803581E0-0x00000001803581F0
	protected override void OnOpen(); // 0x0000000180ED2000-0x0000000180ED2190
	protected override void OnClose(bool inAnimate); // 0x0000000180ED1F10-0x0000000180ED2000
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
}

