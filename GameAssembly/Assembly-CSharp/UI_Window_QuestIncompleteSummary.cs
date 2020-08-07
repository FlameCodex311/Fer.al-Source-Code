/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_QuestIncompleteSummary : UI_Window // TypeDefIndex: 14146
{
	// Fields
	private Action<bool> _resultCallback; // 0x108

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 14147
	{
		// Fields
		public Action<bool> inResultCallback; // 0x10

		// Constructors
		public <>c__DisplayClass0_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0(UI_Window_QuestIncompleteSummary window); // 0x00000001803B2CD0-0x00000001803B2CF0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 14148
	{
		// Fields
		public Action<bool> inResultCallback; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x00000001803B3950-0x00000001803B3A10
	}

	// Constructors
	public UI_Window_QuestIncompleteSummary(); // 0x00000001803B50E0-0x00000001803B50F0

	// Methods
	public static void OpenWindow(Action<bool> inResultCallback = null); // 0x00000001803B4F50-0x00000001803B5010
	public static void QueueWindow(Action<bool> inResultCallback = null); // 0x00000001803B5010-0x00000001803B50D0
	public static void CloseWindow(); // 0x00000001803B4F00-0x00000001803B4F50
	private void Setup(Action<bool> inResultCallback = null); // 0x00000001803B50D0-0x00000001803B50E0
	public void BtnClicked_Leave(); // 0x00000001803B4EA0-0x00000001803B4F00
	public void BtnClicked_Cancel(); // 0x00000001803B4E40-0x00000001803B4EA0
	protected override void OnOpen(); // 0x00000001803B4570-0x00000001803B4580
	protected override void OnClose(bool inAnimate); // 0x00000001803B4560-0x00000001803B4570
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
}

