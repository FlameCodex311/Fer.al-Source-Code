/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_ControlTypesInfo : UI_Window // TypeDefIndex: 14025
{
	// Fields
	[EnumList] // 0x000000018025EFF0-0x000000018025F060
	[SerializeField] // 0x000000018025EFF0-0x000000018025F060
	private List<GameObject> _controlTypeGroups; // 0x108

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 14026
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_ControlTypesInfo> <>9__0_0; // 0x08
		public static Action<UI_Window> <>9__1_0; // 0x10

		// Constructors
		static <>c(); // 0x000000018047F6B0-0x000000018047F710
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0_0(UI_Window_ControlTypesInfo window); // 0x000000018047E160-0x000000018047E180
		internal void <QueueWindow>b__1_0(UI_Window inWindow); // 0x000000018047E400-0x000000018047E4B0
	}

	// Constructors
	public UI_Window_ControlTypesInfo(); // 0x00000001804852E0-0x0000000180485350

	// Methods
	public static void OpenWindow(); // 0x0000000180485030-0x0000000180485130
	public static void QueueWindow(); // 0x0000000180485130-0x0000000180485230
	public static void CloseWindow(); // 0x0000000180484EB0-0x0000000180484F00
	private void Setup(); // 0x0000000180485230-0x00000001804852E0
	protected override void OnOpen(); // 0x0000000180484FA0-0x0000000180485030
	protected override void OnClose(bool inAnimate); // 0x0000000180484F00-0x0000000180484FA0
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
}

