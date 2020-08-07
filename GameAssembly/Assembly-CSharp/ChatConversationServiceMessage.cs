/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using LitJson;
using Server;
using Services.Chat;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[RoutedMessage] // 0x00000001801E6720-0x00000001801E6750
public class ChatConversationServiceMessage : ServiceMessage // TypeDefIndex: 12581
{
	// Fields
	public readonly string ConversationId; // 0x28
	public readonly ChatEntry ChatEntry; // 0x30
	public readonly string Error; // 0x38

	// Constructors
	public ChatConversationServiceMessage(JsonData jsonData); // 0x00000001804A15E0-0x00000001804A16F0
}

