/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_DemoWelcome : UI_Window // TypeDefIndex: 12440
{
	// Fields
	private static bool _firstLoad; // 0x00

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12441
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_DemoWelcome> <>9__3_0; // 0x08
		public static Action<UI_Window> <>9__4_0; // 0x10

		// Constructors
		static <>c(); // 0x0000000180F00040-0x0000000180F000A0
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__3_0(UI_Window_DemoWelcome window); // 0x0000000180E9D080-0x0000000180E9D0A0
		internal void <QueueWindow>b__4_0(UI_Window inWindow); // 0x0000000180EFEC70-0x0000000180EFECF0
	}

	// Constructors
	public UI_Window_DemoWelcome(); // 0x0000000180E9F830-0x0000000180E9F840
	static UI_Window_DemoWelcome(); // 0x0000000180F0B6F0-0x0000000180F0B730

	// Methods
	[RuntimeInitializeOnLoadMethod] // 0x00000001800C1340-0x00000001800C1350
	private static void StaticInit(); // 0x00000001803581E0-0x00000001803581F0
	private static void OnLevelLoaded(Message inMessage); // 0x0000000180F0B420-0x0000000180F0B4F0
	public static void OpenWindow(); // 0x0000000180F0B4F0-0x0000000180F0B5F0
	public static void QueueWindow(); // 0x0000000180F0B5F0-0x0000000180F0B6F0
	public static void CloseWindow(); // 0x0000000180F0B3D0-0x0000000180F0B420
	private void Setup(); // 0x00000001803581E0-0x00000001803581F0
	protected override void OnOpen(); // 0x0000000180E9F6A0-0x0000000180E9F6B0
	protected override void OnClose(bool inAnimate); // 0x0000000180E9F690-0x0000000180E9F6A0
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
}

