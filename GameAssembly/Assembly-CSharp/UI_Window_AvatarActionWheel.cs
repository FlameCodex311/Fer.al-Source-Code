/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_AvatarActionWheel : UI_Window // TypeDefIndex: 14002
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<UI_AvatarActionWheelItem> _avatarActionWheelItems; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Vector2 _windowScale; // 0x110

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 14003
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_AvatarActionWheel> <>9__0_0; // 0x08
		public static Action<UI_Window> <>9__1_0; // 0x10
		public static Comparison<Item> <>9__6_0; // 0x18

		// Constructors
		static <>c(); // 0x000000018047F410-0x000000018047F470
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0_0(UI_Window_AvatarActionWheel window); // 0x000000018047E180-0x000000018047E1A0
		internal void <QueueWindow>b__1_0(UI_Window inWindow); // 0x000000018047E1D0-0x000000018047E280
		internal int <OnOpen>b__6_0(Item a, Item b); // 0x000000018047E090-0x000000018047E100
	}

	// Constructors
	public UI_Window_AvatarActionWheel(); // 0x00000001806458D0-0x0000000180645980

	// Methods
	public static void OpenWindow(); // 0x0000000180645640-0x0000000180645740
	public static void QueueWindow(); // 0x0000000180645740-0x0000000180645840
	public static void CloseWindow(); // 0x0000000180645290-0x00000001806452E0
	private void Setup(); // 0x0000000180645840-0x00000001806458D0
	protected override void OnOpen(); // 0x00000001806453F0-0x0000000180645640
	protected override void OnClose(bool inAnimate); // 0x00000001806452E0-0x0000000180645380
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
	private void OnHideHUDCommand(HideHUDCommand inCommand); // 0x0000000180645380-0x00000001806453F0
}

