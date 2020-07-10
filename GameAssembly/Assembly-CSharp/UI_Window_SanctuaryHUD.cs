/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_SanctuaryHUD : UI_Window // TypeDefIndex: 12572
{
	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12573
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_SanctuaryHUD> <>9__3_0; // 0x08
		public static Action<UI_Window> <>9__4_0; // 0x10
		public static Action <>9__11_0; // 0x18

		// Constructors
		static <>c(); // 0x0000000180E9F0F0-0x0000000180E9F150
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__3_0(UI_Window_SanctuaryHUD window); // 0x0000000180E9D080-0x0000000180E9D0A0
		internal void <QueueWindow>b__4_0(UI_Window inWindow); // 0x0000000180E9D610-0x0000000180E9D690
		internal void <BtnClicked_Edit>b__11_0(); // 0x0000000180E9CDC0-0x0000000180E9CE70
	}

	// Constructors
	public UI_Window_SanctuaryHUD(); // 0x0000000180E9F830-0x0000000180E9F840

	// Methods
	[RuntimeInitializeOnLoadMethod] // 0x00000001800C1340-0x00000001800C1350
	private static void StaticInit(); // 0x0000000180EA6580-0x0000000180EA6640
	private static void OnSanctuaryEntered(SanctuaryEnterMessage inMessage); // 0x0000000180EA6260-0x0000000180EA6380
	private static void OnSanctuaryExited(SanctuaryExitMessage inMessage); // 0x0000000180EA6210-0x0000000180EA6260
	public static void OpenWindow(); // 0x0000000180EA6380-0x0000000180EA6480
	public static void QueueWindow(); // 0x0000000180EA6480-0x0000000180EA6580
	public static void CloseWindow(); // 0x0000000180EA6210-0x0000000180EA6260
	private void Setup(); // 0x00000001803581E0-0x00000001803581F0
	protected override void OnOpen(); // 0x0000000180E9F6A0-0x0000000180E9F6B0
	protected override void OnClose(bool inAnimate); // 0x0000000180E9F690-0x0000000180E9F6A0
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
	public void BtnClicked_Decorate(); // 0x0000000180EA4DA0-0x0000000180EA4EA0
	public void BtnClicked_Edit(); // 0x0000000180EA5F60-0x0000000180EA6200
	public void BtnClicked_Switch(); // 0x0000000180EA6200-0x0000000180EA6210
}

