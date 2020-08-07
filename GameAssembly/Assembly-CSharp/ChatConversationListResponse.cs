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

[RoutedMessage] // 0x00000001801E7010-0x00000001801E7040
public class ChatConversationListResponse : ServiceMessage // TypeDefIndex: 12584
{
	// Fields
	public readonly ChatConversationData[] Conversations; // 0x28
	public readonly string NextCursor; // 0x30

	// Constructors
	public ChatConversationListResponse(JsonData jsonData); // 0x00000001804A1340-0x00000001804A1510
}

