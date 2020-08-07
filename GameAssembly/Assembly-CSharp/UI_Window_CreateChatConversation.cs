/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_CreateChatConversation : UI_Window // TypeDefIndex: 14031
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private TMP_InputField _nameInput; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private TMP_InputField _membersInput; // 0x110

	// Properties
	private string NameInput { get; } // 0x00000001803B7870-0x00000001803B78A0 
	private string[] MemberNames { get; } // 0x0000000180486290-0x0000000180486400 

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 14032
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_CreateChatConversation> <>9__6_0; // 0x08
		public static Action<UI_Window> <>9__7_0; // 0x10

		// Constructors
		static <>c(); // 0x000000018047F590-0x000000018047F5F0
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__6_0(UI_Window_CreateChatConversation window); // 0x00000001803774A0-0x00000001803774B0
		internal void <QueueWindow>b__7_0(UI_Window inWindow); // 0x00000001803774A0-0x00000001803774B0
	}

	// Constructors
	public UI_Window_CreateChatConversation(); // 0x00000001803B50E0-0x00000001803B50F0

	// Methods
	public static void OpenWindow(); // 0x0000000180486090-0x0000000180486190
	public static void QueueWindow(); // 0x0000000180486190-0x0000000180486290
	public static void CloseWindow(); // 0x0000000180485F20-0x0000000180485F70
	[RuntimeInitializeOnLoadMethod] // 0x00000001801CF2D0-0x00000001801CF2E0
	private static void StaticInit(); // 0x00000001803774A0-0x00000001803774B0
	protected override void OnOpen(); // 0x0000000180486000-0x0000000180486090
	protected override void OnClose(bool inAnimate); // 0x0000000180485F70-0x0000000180486000
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
	public void BtnClicked_CreateConversation(); // 0x00000001803774A0-0x00000001803774B0
}

