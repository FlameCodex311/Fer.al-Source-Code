/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using WW.Debug;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_DesignerNPCSelector : UI_Window // TypeDefIndex: 12442
{
	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12443
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_DesignerNPCSelector> <>9__0_0; // 0x08
		public static Action<UI_Window> <>9__1_0; // 0x10

		// Constructors
		static <>c(); // 0x0000000180F000A0-0x0000000180F00100
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0_0(UI_Window_DesignerNPCSelector window); // 0x0000000180EFE6C0-0x0000000180EFE720
		internal void <QueueWindow>b__1_0(UI_Window inWindow); // 0x0000000180EFEA40-0x0000000180EFEAC0
	}

	// Constructors
	public UI_Window_DesignerNPCSelector(); // 0x0000000180E9F830-0x0000000180E9F840

	// Methods
	[DebugButton] // 0x000000018016EF20-0x000000018016EF80
	public static void OpenWindow(); // 0x0000000180F0B780-0x0000000180F0B880
	public static void QueueWindow(); // 0x0000000180F0B880-0x0000000180F0B980
	public static void CloseWindow(); // 0x0000000180F0B730-0x0000000180F0B780
	private void Setup(); // 0x00000001803581E0-0x00000001803581F0
	protected override void OnOpen(); // 0x0000000180E9F6A0-0x0000000180E9F6B0
	protected override void OnClose(bool inAnimate); // 0x0000000180E9F690-0x0000000180E9F6A0
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
}

