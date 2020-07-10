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

[RoutedMessage] // 0x00000001801091E0-0x0000000180109210
public class ChatConversationGetResponse : ServiceMessage // TypeDefIndex: 11058
{
	// Fields
	public readonly ChatConversationData Conversation; // 0x28
	public readonly string Error; // 0x30

	// Constructors
	public ChatConversationGetResponse(JsonData jsonData); // 0x0000000181028340-0x0000000181028430
}

