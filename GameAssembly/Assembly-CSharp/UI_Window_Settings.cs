/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_Settings : UI_Window // TypeDefIndex: 13758
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<GameObject> _loggedInOnlyGroups; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_TabGroup _tabGroup; // 0x110
	private int? _lastSelectedTab; // 0x118

	// Properties
	private int LastSelectedTab { get; set; } // 0x00000001803C4090-0x00000001803C41F0 0x00000001803C3F20-0x00000001803C4020

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 13759
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_Settings> <>9__0_0; // 0x08
		public static Action<UI_Window> <>9__1_0; // 0x10
		public static Action<bool> <>9__15_0; // 0x18

		// Constructors
		static <>c(); // 0x00000001803B4040-0x00000001803B40A0
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0_0(UI_Window_Settings window); // 0x00000001803B24A0-0x00000001803B24C0
		internal void <QueueWindow>b__1_0(UI_Window inWindow); // 0x00000001803B27B0-0x00000001803B2830
		internal void <BtnClicked_Quit>b__15_0(bool inResult); // 0x00000001803B2300-0x00000001803B2310
	}

	// Constructors
	public UI_Window_Settings(); // 0x00000001803C4020-0x00000001803C4090

	// Methods
	public static void OpenWindow(); // 0x00000001803C3C60-0x00000001803C3D60
	public static void QueueWindow(); // 0x00000001803C3D60-0x00000001803C3E60
	public static void CloseWindow(); // 0x00000001803C3600-0x00000001803C3650
	private void Setup(); // 0x00000001803774A0-0x00000001803774B0
	protected override void OnOpen(); // 0x00000001803C3840-0x00000001803C3BC0
	protected override void OnClose(bool inAnimate); // 0x00000001803C3650-0x00000001803C37A0
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
	public void BtnClicked_GiveFeedback(); // 0x00000001803C33C0-0x00000001803C33D0
	public void BtnClicked_Logout(); // 0x00000001803C33D0-0x00000001803C34C0
	public void BtnClicked_Quit(); // 0x00000001803C34C0-0x00000001803C3600
	public override void OnReceiveFocus(); // 0x00000001803C3BC0-0x00000001803C3C60
	public override void OnLoseFocus(); // 0x00000001803C37A0-0x00000001803C3840
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <OnOpen>b__10_0(int tabIndex); // 0x00000001803C3F20-0x00000001803C4020
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <BtnClicked_Logout>b__14_0(bool result); // 0x00000001803C3E60-0x00000001803C3F20
}

