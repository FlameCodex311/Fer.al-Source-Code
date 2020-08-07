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

[RoutedMessage] // 0x00000001801E6C70-0x00000001801E6CA0
public class ChatConversationGetResponse : ServiceMessage // TypeDefIndex: 12583
{
	// Fields
	public readonly ChatConversationData Conversation; // 0x28
	public readonly string Error; // 0x30

	// Constructors
	public ChatConversationGetResponse(JsonData jsonData); // 0x00000001804A0D10-0x00000001804A0E00
}

