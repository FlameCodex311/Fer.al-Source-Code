/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_QuestIncompleteSummary : UI_Window // TypeDefIndex: 12544
{
	// Fields
	private Action<bool> _resultCallback; // 0x108

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 12545
	{
		// Fields
		public Action<bool> inResultCallback; // 0x10

		// Constructors
		public <>c__DisplayClass0_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0(UI_Window_QuestIncompleteSummary window); // 0x0000000180E9D8C0-0x0000000180E9D8F0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 12546
	{
		// Fields
		public Action<bool> inResultCallback; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x0000000180E9E810-0x0000000180E9E8E0
	}

	// Constructors
	public UI_Window_QuestIncompleteSummary(); // 0x0000000180E9F830-0x0000000180E9F840

	// Methods
	public static void OpenWindow(Action<bool> inResultCallback = null); // 0x0000000180E9F6B0-0x0000000180E9F770
	public static void QueueWindow(Action<bool> inResultCallback = null); // 0x0000000180E9F770-0x0000000180E9F830
	public static void CloseWindow(); // 0x0000000180E9F630-0x0000000180E9F680
	private void Setup(Action<bool> inResultCallback = null); // 0x00000001803BE5E0-0x00000001803BE5F0
	public void BtnClicked_Leave(); // 0x0000000180E9F5D0-0x0000000180E9F630
	public void BtnClicked_Cancel(); // 0x0000000180E9F570-0x0000000180E9F5D0
	protected override void OnOpen(); // 0x0000000180E9F6A0-0x0000000180E9F6B0
	protected override void OnClose(bool inAnimate); // 0x0000000180E9F690-0x0000000180E9F6A0
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
}

