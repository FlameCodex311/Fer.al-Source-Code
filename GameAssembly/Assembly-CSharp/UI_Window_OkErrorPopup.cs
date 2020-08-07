/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_OkErrorPopup : UI_Window_OkPopup // TypeDefIndex: 14129
{
	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 14130
	{
		// Fields
		public string inTitle; // 0x10
		public string inMessage; // 0x18
		public string inOkBtnText; // 0x20
		public Action inOkCallback; // 0x28

		// Constructors
		public <>c__DisplayClass0_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0(UI_Window_OkErrorPopup window); // 0x00000001803E1860-0x00000001803E18A0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 14131
	{
		// Fields
		public string inTitle; // 0x10
		public string inMessage; // 0x18
		public string inOkBtnText; // 0x20
		public Action inOkCallback; // 0x28

		// Constructors
		public <>c__DisplayClass1_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x00000001803E1DC0-0x00000001803E1EA0
	}

	// Constructors
	public UI_Window_OkErrorPopup(); // 0x00000001803F0B00-0x00000001803F0B70

	// Methods
	public static new void OpenWindow(string inTitle = "" /* Metadata: 0x007BA66F */, string inMessage = "" /* Metadata: 0x007BA673 */, string inOkBtnText = "" /* Metadata: 0x007BA677 */, Action inOkCallback = null); // 0x00000001803F0920-0x00000001803F0A10
	public static new void QueueWindow(string inTitle = "" /* Metadata: 0x007BA67B */, string inMessage = "" /* Metadata: 0x007BA67F */, string inOkBtnText = "" /* Metadata: 0x007BA683 */, Action inOkCallback = null); // 0x00000001803F0A10-0x00000001803F0B00
	public static new void CloseWindow(); // 0x00000001803F07C0-0x00000001803F0810
	private void Setup(); // 0x00000001803774A0-0x00000001803774B0
	protected override void OnOpen(); // 0x00000001803F08A0-0x00000001803F0920
	protected override void OnClose(bool inAnimate); // 0x00000001803F0810-0x00000001803F08A0
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
}

