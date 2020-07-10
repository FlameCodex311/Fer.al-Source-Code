/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_Settings : UI_Window // TypeDefIndex: 12208
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private List<GameObject> _loggedInOnlyGroups; // 0x108
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_TabGroup _tabGroup; // 0x110
	private int? _lastSelectedTab; // 0x118

	// Properties
	private int LastSelectedTab { get; set; } // 0x0000000180EADCE0-0x0000000180EADE40 0x0000000180EADB70-0x0000000180EADC70

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12209
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_Settings> <>9__0_0; // 0x08
		public static Action<UI_Window> <>9__1_0; // 0x10
		public static Action<bool> <>9__15_0; // 0x18

		// Constructors
		static <>c(); // 0x0000000180E9F150-0x0000000180E9F1B0
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0_0(UI_Window_Settings window); // 0x0000000180E9D080-0x0000000180E9D0A0
		internal void <QueueWindow>b__1_0(UI_Window inWindow); // 0x0000000180E9D390-0x0000000180E9D410
		internal void <BtnClicked_Quit>b__15_0(bool inResult); // 0x0000000180E9CEE0-0x0000000180E9CEF0
	}

	// Constructors
	public UI_Window_Settings(); // 0x0000000180EADC70-0x0000000180EADCE0

	// Methods
	public static void OpenWindow(); // 0x0000000180EAD8B0-0x0000000180EAD9B0
	public static void QueueWindow(); // 0x0000000180EAD9B0-0x0000000180EADAB0
	public static void CloseWindow(); // 0x0000000180EAD240-0x0000000180EAD290
	private void Setup(); // 0x00000001803581E0-0x00000001803581F0
	protected override void OnOpen(); // 0x0000000180EAD480-0x0000000180EAD810
	protected override void OnClose(bool inAnimate); // 0x0000000180EAD290-0x0000000180EAD3E0
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
	public void BtnClicked_GiveFeedback(); // 0x0000000180EAD000-0x0000000180EAD010
	public void BtnClicked_Logout(); // 0x0000000180EAD010-0x0000000180EAD100
	public void BtnClicked_Quit(); // 0x0000000180EAD100-0x0000000180EAD240
	public override void OnReceiveFocus(); // 0x0000000180EAD810-0x0000000180EAD8B0
	public override void OnLoseFocus(); // 0x0000000180EAD3E0-0x0000000180EAD480
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <OnOpen>b__10_0(int tabIndex); // 0x0000000180EADB70-0x0000000180EADC70
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <BtnClicked_Logout>b__14_0(bool result); // 0x0000000180EADAB0-0x0000000180EADB70
}

