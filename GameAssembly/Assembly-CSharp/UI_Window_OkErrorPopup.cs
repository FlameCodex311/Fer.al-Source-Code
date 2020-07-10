/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_OkErrorPopup : UI_Window_OkPopup // TypeDefIndex: 12527
{
	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 12528
	{
		// Fields
		public string inTitle; // 0x10
		public string inMessage; // 0x18
		public string inOkBtnText; // 0x20
		public Action inOkCallback; // 0x28

		// Constructors
		public <>c__DisplayClass0_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0(UI_Window_OkErrorPopup window); // 0x0000000180ECE2A0-0x0000000180ECE2E0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 12529
	{
		// Fields
		public string inTitle; // 0x10
		public string inMessage; // 0x18
		public string inOkBtnText; // 0x20
		public Action inOkCallback; // 0x28

		// Constructors
		public <>c__DisplayClass1_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x0000000180ECE920-0x0000000180ECEA00
	}

	// Constructors
	public UI_Window_OkErrorPopup(); // 0x0000000180EDD320-0x0000000180EDD390

	// Methods
	public static new void OpenWindow(string inTitle = "" /* Metadata: 0x00782F57 */, string inMessage = "" /* Metadata: 0x00782F5B */, string inOkBtnText = "" /* Metadata: 0x00782F5F */, Action inOkCallback = null); // 0x0000000180EDD140-0x0000000180EDD230
	public static new void QueueWindow(string inTitle = "" /* Metadata: 0x00782F63 */, string inMessage = "" /* Metadata: 0x00782F67 */, string inOkBtnText = "" /* Metadata: 0x00782F6B */, Action inOkCallback = null); // 0x0000000180EDD230-0x0000000180EDD320
	public static new void CloseWindow(); // 0x0000000180EDCFE0-0x0000000180EDD030
	private void Setup(); // 0x00000001803581E0-0x00000001803581F0
	protected override void OnOpen(); // 0x0000000180EDD0C0-0x0000000180EDD140
	protected override void OnClose(bool inAnimate); // 0x0000000180EDD030-0x0000000180EDD0C0
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
}

