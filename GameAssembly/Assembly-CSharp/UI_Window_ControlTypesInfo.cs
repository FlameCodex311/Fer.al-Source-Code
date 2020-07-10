/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_ControlTypesInfo : UI_Window // TypeDefIndex: 12430
{
	// Fields
	[EnumList] // 0x00000001801689B0-0x0000000180168A20
	[SerializeField] // 0x00000001801689B0-0x0000000180168A20
	private List<GameObject> _controlTypeGroups; // 0x108

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12431
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_ControlTypesInfo> <>9__0_0; // 0x08
		public static Action<UI_Window> <>9__1_0; // 0x10

		// Constructors
		static <>c(); // 0x0000000180EFFFE0-0x0000000180F00040
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0_0(UI_Window_ControlTypesInfo window); // 0x0000000180EFE720-0x0000000180EFE750
		internal void <QueueWindow>b__1_0(UI_Window inWindow); // 0x0000000180EFEAC0-0x0000000180EFEB70
	}

	// Constructors
	public UI_Window_ControlTypesInfo(); // 0x0000000180F07000-0x0000000180F07070

	// Methods
	public static void OpenWindow(); // 0x0000000180F06D50-0x0000000180F06E50
	public static void QueueWindow(); // 0x0000000180F06E50-0x0000000180F06F50
	public static void CloseWindow(); // 0x0000000180F06BD0-0x0000000180F06C20
	private void Setup(); // 0x0000000180F06F50-0x0000000180F07000
	protected override void OnOpen(); // 0x0000000180F06CC0-0x0000000180F06D50
	protected override void OnClose(bool inAnimate); // 0x0000000180F06C20-0x0000000180F06CC0
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
}

