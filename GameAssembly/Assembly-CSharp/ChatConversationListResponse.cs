/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using LitJson;
using Server;
using Services.Chat;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[RoutedMessage] // 0x000000018010A490-0x000000018010A4C0
public class ChatConversationListResponse : ServiceMessage // TypeDefIndex: 11059
{
	// Fields
	public readonly ChatConversationData[] Conversations; // 0x28
	public readonly string NextCursor; // 0x30

	// Constructors
	public ChatConversationListResponse(JsonData jsonData); // 0x0000000181028A00-0x0000000181028BE0
}

