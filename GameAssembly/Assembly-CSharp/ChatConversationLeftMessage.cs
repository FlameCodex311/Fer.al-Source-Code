/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using LitJson;
using Server;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[RoutedMessage] // 0x00000001801E9090-0x00000001801E90C0
public class ChatConversationLeftMessage : ServiceMessage, ITaggedMessage // TypeDefIndex: 12592
{
	// Fields
	public readonly string ConversationId; // 0x28
	public readonly string UserUUID; // 0x30

	// Constructors
	public ChatConversationLeftMessage(JsonData jsonData); // 0x00000001804A12B0-0x00000001804A1340

	// Methods
	public string GetTag(); // 0x00000001804A1270-0x00000001804A12B0
}

