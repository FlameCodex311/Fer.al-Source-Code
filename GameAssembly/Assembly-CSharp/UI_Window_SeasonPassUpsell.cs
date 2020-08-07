/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_SeasonPassUpsell : UI_Window // TypeDefIndex: 14194
{
	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 14195
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_SeasonPassUpsell> <>9__0_0; // 0x08
		public static Action<UI_Window> <>9__1_0; // 0x10

		// Constructors
		static <>c(); // 0x00000001803B42E0-0x00000001803B4340
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0_0(UI_Window_SeasonPassUpsell window); // 0x00000001803B24A0-0x00000001803B24C0
		internal void <QueueWindow>b__1_0(UI_Window inWindow); // 0x00000001803B2830-0x00000001803B28B0
	}

	// Constructors
	public UI_Window_SeasonPassUpsell(); // 0x00000001803B50E0-0x00000001803B50F0

	// Methods
	public static void OpenWindow(); // 0x00000001803BF2F0-0x00000001803BF3F0
	public static void QueueWindow(); // 0x00000001803BF3F0-0x00000001803BF4F0
	public static void CloseWindow(); // 0x00000001803BF160-0x00000001803BF1B0
	private void Setup(); // 0x00000001803774A0-0x00000001803774B0
	protected override void OnOpen(); // 0x00000001803BF250-0x00000001803BF2F0
	protected override void OnClose(bool inAnimate); // 0x00000001803BF1B0-0x00000001803BF250
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
	public void BtnClicked_Ok(); // 0x00000001803B58D0-0x00000001803B58E0
	public void BtnClicked_GetThePass(); // 0x00000001803BF0E0-0x00000001803BF160
}

