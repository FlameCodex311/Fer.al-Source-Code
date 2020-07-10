/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using LitJson;
using Server;
using Services.Chat;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[RoutedMessage] // 0x000000018010A630-0x000000018010A660
public class ChatConversationHistoryResponse : ServiceMessage // TypeDefIndex: 11060
{
	// Fields
	public readonly List<ChatEntry> Messages; // 0x28
	public readonly string nextCursor; // 0x30

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 11061
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Comparison<ChatEntry> <>9__2_0; // 0x08

		// Constructors
		static <>c(); // 0x00000001810345A0-0x0000000181034600
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal int <.ctor>b__2_0(ChatEntry a, ChatEntry b); // 0x00000001810344E0-0x0000000181034530
	}

	// Constructors
	public ChatConversationHistoryResponse(JsonData jsonData); // 0x00000001810284B0-0x0000000181028760
}

