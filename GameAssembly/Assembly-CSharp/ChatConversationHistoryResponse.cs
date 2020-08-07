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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[RoutedMessage] // 0x00000001801E7330-0x00000001801E7360
public class ChatConversationHistoryResponse : ServiceMessage // TypeDefIndex: 12585
{
	// Fields
	public readonly List<ChatEntry> Messages; // 0x28
	public readonly string nextCursor; // 0x30

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 12586
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Comparison<ChatEntry> <>9__2_0; // 0x08

		// Constructors
		static <>c(); // 0x00000001804A9310-0x00000001804A9370
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal int <.ctor>b__2_0(ChatEntry a, ChatEntry b); // 0x00000001804A91F0-0x00000001804A9240
	}

	// Constructors
	public ChatConversationHistoryResponse(JsonData jsonData); // 0x00000001804A0E00-0x00000001804A10A0
}

