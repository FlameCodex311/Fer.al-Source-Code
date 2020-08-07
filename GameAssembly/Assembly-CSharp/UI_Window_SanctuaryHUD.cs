/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_SanctuaryHUD : UI_Window // TypeDefIndex: 14174
{
	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 14175
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_SanctuaryHUD> <>9__3_0; // 0x08
		public static Action<UI_Window> <>9__4_0; // 0x10
		public static Action <>9__11_0; // 0x18

		// Constructors
		static <>c(); // 0x00000001803B3FE0-0x00000001803B4040
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__3_0(UI_Window_SanctuaryHUD window); // 0x00000001803B24A0-0x00000001803B24C0
		internal void <QueueWindow>b__4_0(UI_Window inWindow); // 0x00000001803B2A30-0x00000001803B2AB0
		internal void <BtnClicked_Edit>b__11_0(); // 0x00000001803B2250-0x00000001803B2300
	}

	// Constructors
	public UI_Window_SanctuaryHUD(); // 0x00000001803B50E0-0x00000001803B50F0

	// Methods
	[RuntimeInitializeOnLoadMethod] // 0x00000001801CF2D0-0x00000001801CF2E0
	private static void StaticInit(); // 0x00000001803BBC90-0x00000001803BBD50
	private static void OnSanctuaryEntered(SanctuaryEnterMessage inMessage); // 0x00000001803BB970-0x00000001803BBA90
	private static void OnSanctuaryExited(SanctuaryExitMessage inMessage); // 0x00000001803BB920-0x00000001803BB970
	public static void OpenWindow(); // 0x00000001803BBA90-0x00000001803BBB90
	public static void QueueWindow(); // 0x00000001803BBB90-0x00000001803BBC90
	public static void CloseWindow(); // 0x00000001803BB920-0x00000001803BB970
	private void Setup(); // 0x00000001803774A0-0x00000001803774B0
	protected override void OnOpen(); // 0x00000001803B4570-0x00000001803B4580
	protected override void OnClose(bool inAnimate); // 0x00000001803B4560-0x00000001803B4570
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
	public void BtnClicked_Decorate(); // 0x00000001803BA5B0-0x00000001803BA6B0
	public void BtnClicked_Edit(); // 0x00000001803BB750-0x00000001803BB910
	public void BtnClicked_Switch(); // 0x00000001803BB910-0x00000001803BB920
}

