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

[RoutedMessage] // 0x0000000180108CE0-0x0000000180108D10
public class ChatConversationServiceMessage : ServiceMessage // TypeDefIndex: 11056
{
	// Fields
	public readonly string ConversationId; // 0x28
	public readonly ChatEntry ChatEntry; // 0x30
	public readonly string Error; // 0x38

	// Constructors
	public ChatConversationServiceMessage(JsonData jsonData); // 0x0000000181028D00-0x0000000181028E10
}

