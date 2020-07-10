/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_AvatarActionWheel : UI_Window // TypeDefIndex: 12410
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private List<UI_AvatarActionWheelItem> _avatarActionWheelItems; // 0x108
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Vector2 _windowScale; // 0x110

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12411
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_AvatarActionWheel> <>9__0_0; // 0x08
		public static Action<UI_Window> <>9__1_0; // 0x10
		public static Comparison<Item> <>9__6_0; // 0x18

		// Constructors
		static <>c(); // 0x0000000180EFFCE0-0x0000000180EFFD40
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0_0(UI_Window_AvatarActionWheel window); // 0x0000000180EFE750-0x0000000180EFE780
		internal void <QueueWindow>b__1_0(UI_Window inWindow); // 0x0000000180EFE7E0-0x0000000180EFE890
		internal int <OnOpen>b__6_0(Item a, Item b); // 0x0000000180EFE650-0x0000000180EFE6C0
	}

	// Constructors
	public UI_Window_AvatarActionWheel(); // 0x0000000180F01F00-0x0000000180F01FB0

	// Methods
	public static void OpenWindow(); // 0x0000000180F01C70-0x0000000180F01D70
	public static void QueueWindow(); // 0x0000000180F01D70-0x0000000180F01E70
	public static void CloseWindow(); // 0x0000000180F018B0-0x0000000180F01900
	private void Setup(); // 0x0000000180F01E70-0x0000000180F01F00
	protected override void OnOpen(); // 0x0000000180F01A10-0x0000000180F01C70
	protected override void OnClose(bool inAnimate); // 0x0000000180F01900-0x0000000180F019A0
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
	private void OnHideHUDCommand(HideHUDCommand inCommand); // 0x0000000180F019A0-0x0000000180F01A10
}

