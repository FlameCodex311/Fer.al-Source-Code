/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using LitJson;
using Server;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[RoutedMessage] // 0x000000018010AEC0-0x000000018010AEF0
public class ChatConversationLeftMessage : ServiceMessage, ITaggedMessage // TypeDefIndex: 11067
{
	// Fields
	public readonly string ConversationId; // 0x28
	public readonly string UserUUID; // 0x30

	// Constructors
	public ChatConversationLeftMessage(JsonData jsonData); // 0x0000000181028960-0x0000000181028A00

	// Methods
	public string GetTag(); // 0x0000000181028920-0x0000000181028960
}

