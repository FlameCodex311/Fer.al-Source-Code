/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using WW.Debug;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_DesignerNPCSelector : UI_Window // TypeDefIndex: 14041
{
	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 14042
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_DesignerNPCSelector> <>9__0_0; // 0x08
		public static Action<UI_Window> <>9__1_0; // 0x10

		// Constructors
		static <>c(); // 0x000000018047F770-0x000000018047F7D0
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0_0(UI_Window_DesignerNPCSelector window); // 0x000000018047E100-0x000000018047E160
		internal void <QueueWindow>b__1_0(UI_Window inWindow); // 0x000000018047E380-0x000000018047E400
	}

	// Constructors
	public UI_Window_DesignerNPCSelector(); // 0x00000001803B50E0-0x00000001803B50F0

	// Methods
	[DebugButton] // 0x00000001802672E0-0x0000000180267340
	public static void OpenWindow(); // 0x0000000180489960-0x0000000180489A60
	public static void QueueWindow(); // 0x0000000180489A60-0x0000000180489B60
	public static void CloseWindow(); // 0x0000000180489910-0x0000000180489960
	private void Setup(); // 0x00000001803774A0-0x00000001803774B0
	protected override void OnOpen(); // 0x00000001803B4570-0x00000001803B4580
	protected override void OnClose(bool inAnimate); // 0x00000001803B4560-0x00000001803B4570
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
}

