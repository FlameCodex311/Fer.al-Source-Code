/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_CreateChatConversation : UI_Window // TypeDefIndex: 12432
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private TMP_InputField _nameInput; // 0x108
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private TMP_InputField _membersInput; // 0x110

	// Properties
	private string NameInput { get; } // 0x0000000180EA1FD0-0x0000000180EA2000 
	private string[] MemberNames { get; } // 0x0000000180F07FC0-0x0000000180F08140 

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12433
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_CreateChatConversation> <>9__6_0; // 0x08
		public static Action<UI_Window> <>9__7_0; // 0x10

		// Constructors
		static <>c(); // 0x0000000180EFFE60-0x0000000180EFFEC0
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__6_0(UI_Window_CreateChatConversation window); // 0x00000001803581E0-0x00000001803581F0
		internal void <QueueWindow>b__7_0(UI_Window inWindow); // 0x00000001803581E0-0x00000001803581F0
	}

	// Constructors
	public UI_Window_CreateChatConversation(); // 0x0000000180E9F830-0x0000000180E9F840

	// Methods
	public static void OpenWindow(); // 0x0000000180F07DC0-0x0000000180F07EC0
	public static void QueueWindow(); // 0x0000000180F07EC0-0x0000000180F07FC0
	public static void CloseWindow(); // 0x0000000180F07C50-0x0000000180F07CA0
	[RuntimeInitializeOnLoadMethod] // 0x00000001800C1340-0x00000001800C1350
	private static void StaticInit(); // 0x00000001803581E0-0x00000001803581F0
	protected override void OnOpen(); // 0x0000000180F07D30-0x0000000180F07DC0
	protected override void OnClose(bool inAnimate); // 0x0000000180F07CA0-0x0000000180F07D30
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
	public void BtnClicked_CreateConversation(); // 0x00000001803581E0-0x00000001803581F0
}

